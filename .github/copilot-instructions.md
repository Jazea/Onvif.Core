# Onvif.Core - AI Coding Instructions

## Project Overview
Onvif.Core is a **stable, production-grade** .NET Standard library for ONVIF camera discovery and control. It provides both network discovery of IP cameras and full client functionality for PTZ (Pan-Tilt-Zoom), media, imaging, and device management via SOAP web services.

### Stability & API Compatibility
**This is a stable library.** Backward compatibility and API stability are paramount:
- **Never break existing APIs** - no public method/property removals, renamings, or signature changes
- **Only extend, never contract** - add new methods/overloads, do not modify existing ones
- **Make minimal changes** - apply only the smallest necessary changes to fix bugs or add features
- **Deprecate cautiously** - use `[Obsolete]` attributes with clear migration paths when API changes are unavoidable
- **Document all changes** - explain the purpose and impact of every modification in code comments and commit messages

## Architecture & Key Components

### Core Architecture Pattern
- **Factory-based client creation**: Use `OnvifClientFactory` for all SOAP clients (Device, PTZ, Media, Imaging)
- **Singleton camera management**: `Camera.Create()` maintains a static dictionary of cameras keyed by `Account`
- **Lazy client initialization**: Camera properties (`Ptz`, `Media`, `Imaging`) create clients on first access
- **SOAP security**: All clients use WS-Security with digest authentication via `SoapSecurityHeader`

### Main Components
1. **Discovery** (`Discovery/`): UDP multicast WS-Discovery for finding cameras on network
2. **Client** (`Client/`): SOAP client wrappers for ONVIF services
3. **Security** (`Client/Security/`): WS-Security implementation with time-shifted nonce generation
4. **Data Types**: Auto-generated from WSDL files in `wsdl/` directory

### Key Classes & Usage Patterns

#### Camera Creation & Management
```csharp
// Always use factory method - never 'new Camera()'
var account = new Account("192.168.1.100", "admin", "password");
var camera = await Camera.CreateAsync(account, ex => Console.WriteLine(ex));
```

#### Client Access Pattern
```csharp
// Clients are lazy-loaded properties, not constructor injected
await camera.Ptz.AbsoluteMoveAsync(profileToken, position, speed);
await camera.Media.GetProfilesAsync();
```

## Development Guidelines

### API Stability & Backward Compatibility (Critical)
Before making ANY changes to public APIs:
1. **Check for existing usage** - search the entire codebase for references to the API being modified
2. **Preserve signatures** - existing method/property signatures must remain unchanged
3. **Only add, never remove** - new overloads and members are acceptable; removals/renames are not
4. **Use [Obsolete] for migrations** - if a public method must change, mark the old one as `[Obsolete("Use NewMethod instead.", error: false)]`
5. **Document breaking change** - add XML comments explaining the migration path and why the change was necessary
6. **Version bump** - breaking changes require major version increments (follows semver)

**Example of acceptable change:**
```csharp
// OLD: Keep existing method
public async Task<Profile> GetProfileAsync(string profileToken)
{
    return await GetProfileAsync(profileToken, CancellationToken.None);
}

// NEW: Add new overload, don't modify existing
public async Task<Profile> GetProfileAsync(string profileToken, CancellationToken cancellationToken)
{
    // Implementation
}
```

**Example of unacceptable change:**
```csharp
// WRONG: Don't remove or change existing method signature
// public async Task<Profile> GetProfileAsync(string profileToken) // REMOVED - breaks consumers!
```

### SOAP Client Development
- WSDL files in `wsdl/` are source of truth for service contracts
- All clients inherit from generated ServiceModel proxies
- Custom binding always uses SOAP 1.2 with HTTP transport (`OnvifClientFactory.CreateBinding()`)
- Time synchronization is critical - get device time first via `GetDeviceTimeShift()`

### Security Implementation
- Username token with digest authentication is required for all ONVIF calls
- Nonce generation uses cryptographically secure random bytes
- Created timestamp must account for camera/server time difference
- Security headers are injected via `SoapSecurityHeaderBehavior`

### Discovery Service
- Uses UDP multicast to 239.255.255.250:3702
- Sends WS-Discovery Probe messages
- Parses device responses for service URLs and scopes
- Can bind to specific network interfaces via `UdpClientWrapper`

### Error Handling Patterns
- Camera creation includes exception callback: `Camera.Create(account, ex => { })`
- Client calls should wrap in try-catch as SOAP faults are common
- Network timeouts and unreachable devices are expected scenarios

## Build & Development

### Project Structure
- **Target Frameworks**: .NET Standard 2.0 and 2.1
- **Dependencies**: System.ServiceModel.* packages for SOAP, security packages for WS-Security
- **Output**: NuGet package with embedded WSDL files and README

### Key Commands
```powershell
# Build package
dotnet pack

# Build specific framework
dotnet build -f netstandard2.1

# Test with specific camera (no unit tests - requires hardware)
# Use examples in README.md for manual testing
```

### Performance Considerations
- Camera instances are cached by Account to avoid repeated authentication
- Clients use object pooling for UDP sockets in discovery
- Custom FNV-1a hash implementation for efficient Account equality
- SOAP clients should be reused, not recreated per call

## Common Patterns & Conventions

### Async/Await Usage
- All public APIs are async with `ConfigureAwait(false)`
- Synchronous wrappers use `.Result` (Camera.Create vs CreateAsync)
- CancellationToken support in discovery operations

### ONVIF-Specific Patterns
- Profile tokens identify camera configurations
- PTZ operations require both position AND speed vectors
- Media profiles contain stream URIs and codec information
- Device time synchronization prevents authentication failures

### Code Generation
- DataTypes classes are generated from XSD schemas
- Use `[XmlType]` attributes with proper ONVIF namespaces
- Maintain compatibility with ONVIF specification versions (v10, v20)

## Nullable Reference Types

### Project Configuration
- **Note**: The Onvif.Core project does **not** have `<Nullable>enable</Nullable>` globally enabled to preserve backward compatibility with existing and WCF-generated code.
- Nullable reference type checking is **opt-in only** for new code that requires null-safety.

### Using Nullable Reference Types for New Code
When creating **new classes** that require null-safety, enable nullable reference types using the `#nullable enable` pragma at the top of the file:

```csharp
#nullable enable

using System;

namespace Onvif.Core.Client;

/// <summary>
/// Configuration for WCF binding timeouts.
/// Null values indicate that WCF defaults should be used (no override).
/// </summary>
public sealed class OnvifBindingTimeoutConfiguration
{
    public TimeSpan? OpenTimeout { get; set; }  // Nullable value type: null = use WCF default
    public TimeSpan? SendTimeout { get; set; }
    public TimeSpan? ReceiveTimeout { get; set; }
    public TimeSpan? CloseTimeout { get; set; }
}
```

### Guidelines for Nullable Reference Types
1. **Use `#nullable enable` only for new, safety-critical code** - Do not add it retroactively to existing code
2. **Do not modify generated code** - WCF-generated DataTypes.cs and WSDL-derived classes should remain untouched
3. **Distinguish between nullable types**:
   - `TimeSpan?` = nullable **value type** (means "value or nothing")
   - `string?` = nullable **reference type** (means "reference or null")
   - Use explicit nullable annotations to document API contracts
4. **Document null semantics** - Always explain in XML comments what null means for your property/parameter
5. **Preserve stability** - New nullable code must not break existing consumers

## Code Documentation & Comments

### XML Documentation Requirements
All public APIs must have complete XML documentation (`///` comments):

```csharp
/// <summary>
/// Creates a new camera instance for the specified account.
/// </summary>
/// <param name="account">The camera account with connection credentials.</param>
/// <param name="exceptionHandler">Callback invoked when connection errors occur (optional).</param>
/// <returns>A new Camera instance, or null if creation failed.</returns>
/// <remarks>
/// Camera instances are cached by Account to prevent duplicate authentication.
/// The same account will return the existing cached instance.
/// </remarks>
public static async Task<Camera> CreateAsync(Account account, Action<Exception> exceptionHandler)
{
    // Implementation
}
```

### Implementation Comments
For complex logic, especially in security, discovery, and SOAP binding code:
- Explain the **why**, not just the **what**
- Reference ONVIF specifications when relevant
- Note any deviations from standard patterns with justification

```csharp
// Time shift is required because ONVIF cameras may have different system clocks than the client.
// We query device time first, then adjust all nonce timestamps to prevent authentication failures.
var timeShift = await GetDeviceTimeShift();
```

### Change Documentation
When modifying existing code:
- Add a comment explaining **why** the change was made
- Reference related issues or requirements if applicable
- Note any API additions clearly

```csharp
// CHANGE: Added CancellationToken support to allow graceful shutdown during discovery
// This prevents orphaned socket connections when the application terminates.
public async Task<IEnumerable<OnvifCamera>> DiscoverAsync(CancellationToken cancellationToken)
{
    // Implementation
}
```