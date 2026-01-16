#nullable enable

using System;

namespace Onvif.Core.Client;

/// <summary>
/// Configuration settings for WCF binding timeouts used in ONVIF client creation.
/// Null values indicate that WCF defaults should be used (no override).
/// Set a value to override the corresponding WCF binding timeout.
/// </summary>
public sealed class OnvifBindingTimeoutConfiguration
{
	/// <summary>
	/// Gets or sets the timeout for opening a connection to the ONVIF service.
	/// When null, uses WCF default (1 minute).
	/// </summary>
	public TimeSpan? OpenTimeout { get; set; }

	/// <summary>
	/// Gets or sets the timeout for sending data to the ONVIF service.
	/// When null, uses WCF default (1 minute).
	/// </summary>
	public TimeSpan? SendTimeout { get; set; }

	/// <summary>
	/// Gets or sets the timeout for receiving data from the ONVIF service.
	/// When null, uses WCF default (10 minutes).
	/// </summary>
	public TimeSpan? ReceiveTimeout { get; set; }

	/// <summary>
	/// Gets or sets the timeout for closing a connection to the ONVIF service.
	/// When null, uses WCF default (1 minute).
	/// </summary>
	public TimeSpan? CloseTimeout { get; set; }
}
