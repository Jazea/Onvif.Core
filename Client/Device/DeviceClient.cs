using Onvif.Core.Client.Common;
using Onvif.Core.Internals;

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Onvif.Core.Client.Device;

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[ServiceContractAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", ConfigurationName = "Device")]
public interface Device
{

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetServices", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetServicesResponse> GetServicesAsync(GetServicesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetServiceCapabilities", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Capabilities")]
	Task<DeviceServiceCapabilities> GetServiceCapabilitiesAsync();

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDeviceInformation", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetDeviceInformationResponse> GetDeviceInformationAsync(GetDeviceInformationRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetSystemDateAndTime", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetSystemDateAndTimeAsync(SetDateTimeType DateTimeType, bool DaylightSavings, Common.TimeZone TimeZone, Common.DateTime UTCDateTime);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemDateAndTime", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "SystemDateAndTime")]
	Task<SystemDateTime> GetSystemDateAndTimeAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetSystemFactoryDefault", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetSystemFactoryDefaultAsync(FactoryDefaultType FactoryDefault);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/UpgradeSystemFirmware", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Message")]
	Task<string> UpgradeSystemFirmwareAsync(AttachmentData Firmware);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SystemReboot", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Message")]
	Task<string> SystemRebootAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/RestoreSystem", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<RestoreSystemResponse> RestoreSystemAsync(RestoreSystemRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemBackup", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetSystemBackupResponse> GetSystemBackupAsync(GetSystemBackupRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemLog", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "SystemLog")]
	Task<SystemLog> GetSystemLogAsync(SystemLogType LogType);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemSupportInformation", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "SupportInformation")]
	Task<SupportInformation> GetSystemSupportInformationAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetScopes", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetScopesResponse> GetScopesAsync(GetScopesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetScopes", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetScopesResponse> SetScopesAsync(SetScopesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/AddScopes", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<AddScopesResponse> AddScopesAsync(AddScopesRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/RemoveScopes", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<RemoveScopesResponse> RemoveScopesAsync(RemoveScopesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDiscoveryMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "DiscoveryMode")]
	Task<DiscoveryMode> GetDiscoveryModeAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDiscoveryMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetDiscoveryModeAsync(DiscoveryMode DiscoveryMode);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetRemoteDiscoveryMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "RemoteDiscoveryMode")]
	Task<DiscoveryMode> GetRemoteDiscoveryModeAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetRemoteDiscoveryMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetRemoteDiscoveryModeAsync(DiscoveryMode RemoteDiscoveryMode);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDPAddresses", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetDPAddressesResponse> GetDPAddressesAsync(GetDPAddressesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDPAddresses", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetDPAddressesResponse> SetDPAddressesAsync(SetDPAddressesRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetEndpointReference", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetEndpointReferenceResponse> GetEndpointReferenceAsync(GetEndpointReferenceRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetRemoteUser", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "RemoteUser")]
	Task<RemoteUser> GetRemoteUserAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetRemoteUser", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetRemoteUserAsync(RemoteUser RemoteUser);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetUsers", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetUsersResponse> GetUsersAsync(GetUsersRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/CreateUsers", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/DeleteUsers", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<DeleteUsersResponse> DeleteUsersAsync(DeleteUsersRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetUser", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetUserResponse> SetUserAsync(SetUserRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetWsdlUrl", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetWsdlUrlResponse> GetWsdlUrlAsync(GetWsdlUrlRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetCapabilities", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCapabilitiesResponse> GetCapabilitiesAsync(GetCapabilitiesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetHostname", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "HostnameInformation")]
	Task<HostnameInformation> GetHostnameAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetHostname", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetHostnameResponse> SetHostnameAsync(SetHostnameRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetHostnameFromDHCP", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "RebootNeeded")]
	Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDNS", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "DNSInformation")]
	Task<DNSInformation> GetDNSAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDNS", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetDNSResponse> SetDNSAsync(SetDNSRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetNTP", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "NTPInformation")]
	Task<NTPInformation> GetNTPAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetNTP", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetNTPResponse> SetNTPAsync(SetNTPRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDynamicDNS", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "DynamicDNSInformation")]
	Task<DynamicDNSInformation> GetDynamicDNSAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDynamicDNS", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetDynamicDNSResponse> SetDynamicDNSAsync(SetDynamicDNSRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetNetworkInterfaces", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetNetworkInterfacesResponse> GetNetworkInterfacesAsync(GetNetworkInterfacesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetNetworkInterfaces", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "RebootNeeded")]
	Task<bool> SetNetworkInterfacesAsync(string InterfaceToken, NetworkInterfaceSetConfiguration NetworkInterface);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetNetworkProtocols", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetNetworkProtocolsResponse> GetNetworkProtocolsAsync(GetNetworkProtocolsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetNetworkProtocols", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(SetNetworkProtocolsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetNetworkDefaultGateway", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "NetworkGateway")]
	Task<NetworkGateway> GetNetworkDefaultGatewayAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetNetworkDefaultGateway", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetNetworkDefaultGatewayResponse> SetNetworkDefaultGatewayAsync(SetNetworkDefaultGatewayRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetZeroConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "ZeroConfiguration")]
	Task<NetworkZeroConfiguration> GetZeroConfigurationAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetZeroConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetIPAddressFilter", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "IPAddressFilter")]
	Task<IPAddressFilter> GetIPAddressFilterAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetIPAddressFilter", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetIPAddressFilterAsync(IPAddressFilter IPAddressFilter);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/AddIPAddressFilter", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddIPAddressFilterAsync(IPAddressFilter IPAddressFilter);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/RemoveIPAddressFilter", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveIPAddressFilterAsync(IPAddressFilter IPAddressFilter);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetAccessPolicy", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PolicyFile")]
	Task<BinaryData> GetAccessPolicyAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetAccessPolicy", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetAccessPolicyAsync(BinaryData PolicyFile);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/CreateCertificate", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetCertificates", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCertificatesResponse> GetCertificatesAsync(GetCertificatesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetCertificatesStatus", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCertificatesStatusResponse> GetCertificatesStatusAsync(GetCertificatesStatusRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetCertificatesStatus", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetCertificatesStatusResponse> SetCertificatesStatusAsync(SetCertificatesStatusRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/DeleteCertificates", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<DeleteCertificatesResponse> DeleteCertificatesAsync(DeleteCertificatesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetPkcs10Request", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetPkcs10RequestResponse> GetPkcs10RequestAsync(GetPkcs10RequestRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/LoadCertificates", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<LoadCertificatesResponse> LoadCertificatesAsync(LoadCertificatesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetClientCertificateMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Enabled")]
	Task<bool> GetClientCertificateModeAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetClientCertificateMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetClientCertificateModeAsync(bool Enabled);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetRelayOutputs", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetRelayOutputsResponse> GetRelayOutputsAsync(GetRelayOutputsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetRelayOutputSettings", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetRelayOutputSettingsAsync(string RelayOutputToken, RelayOutputSettings Properties);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetRelayOutputState", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetRelayOutputStateAsync(string RelayOutputToken, RelayLogicalState LogicalState);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SendAuxiliaryCommand", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "AuxiliaryCommandResponse")]
	Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetCACertificates", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCACertificatesResponse> GetCACertificatesAsync(GetCACertificatesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/LoadCertificateWithPrivateKey", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKeyAsync(LoadCertificateWithPrivateKeyRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetCertificateInformation", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCertificateInformationResponse> GetCertificateInformationAsync(GetCertificateInformationRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/LoadCACertificates", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<LoadCACertificatesResponse> LoadCACertificatesAsync(LoadCACertificatesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/CreateDot1XConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task CreateDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetDot1XConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDot1XConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Dot1XConfiguration")]
	Task<Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDot1XConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetDot1XConfigurationsResponse> GetDot1XConfigurationsAsync(GetDot1XConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/DeleteDot1XConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<DeleteDot1XConfigurationResponse> DeleteDot1XConfigurationAsync(DeleteDot1XConfigurationRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDot11Capabilities", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetDot11CapabilitiesResponse> GetDot11CapabilitiesAsync(GetDot11CapabilitiesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetDot11Status", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Status")]
	Task<Dot11Status> GetDot11StatusAsync(string InterfaceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/ScanAvailableDot11Networks", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<ScanAvailableDot11NetworksResponse> ScanAvailableDot11NetworksAsync(ScanAvailableDot11NetworksRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetSystemUris", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetSystemUrisResponse> GetSystemUrisAsync(GetSystemUrisRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/StartFirmwareUpgrade", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<StartFirmwareUpgradeResponse> StartFirmwareUpgradeAsync(StartFirmwareUpgradeRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/StartSystemRestore", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<StartSystemRestoreResponse> StartSystemRestoreAsync(StartSystemRestoreRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetStorageConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetStorageConfigurationsResponse> GetStorageConfigurationsAsync(GetStorageConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/CreateStorageConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Token")]
	Task<string> CreateStorageConfigurationAsync(StorageConfigurationData StorageConfiguration);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetStorageConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "StorageConfiguration")]
	Task<StorageConfiguration> GetStorageConfigurationAsync(string Token);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetStorageConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetStorageConfigurationAsync(StorageConfiguration StorageConfiguration);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/DeleteStorageConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task DeleteStorageConfigurationAsync(string Token);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/GetGeoLocation", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/SetGeoLocation", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetGeoLocationResponse> SetGeoLocationAsync(SetGeoLocationRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/device/wsdl/DeleteGeoLocation", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<DeleteGeoLocationResponse> DeleteGeoLocationAsync(DeleteGeoLocationRequest request);
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetServices", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetServicesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public bool IncludeCapability;

	public GetServicesRequest()
	{
	}

	public GetServicesRequest(bool IncludeCapability)
	{
		this.IncludeCapability = IncludeCapability;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetServicesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetServicesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Service")]
	public Service[] Service;

	public GetServicesResponse()
	{
	}

	public GetServicesResponse(Service[] Service)
	{
		this.Service = Service;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetDeviceInformation", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDeviceInformationRequest
{

	public GetDeviceInformationRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetDeviceInformationResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDeviceInformationResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public string Manufacturer;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	public string Model;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	public string FirmwareVersion;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 3)]
	public string SerialNumber;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 4)]
	public string HardwareId;

	public GetDeviceInformationResponse()
	{
	}

	public GetDeviceInformationResponse(string Manufacturer, string Model, string FirmwareVersion, string SerialNumber, string HardwareId)
	{
		this.Manufacturer = Manufacturer;
		this.Model = Model;
		this.FirmwareVersion = FirmwareVersion;
		this.SerialNumber = SerialNumber;
		this.HardwareId = HardwareId;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "RestoreSystem", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class RestoreSystemRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("BackupFiles")]
	public BackupFile[] BackupFiles;

	public RestoreSystemRequest()
	{
	}

	public RestoreSystemRequest(BackupFile[] BackupFiles)
	{
		this.BackupFiles = BackupFiles;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "RestoreSystemResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class RestoreSystemResponse
{

	public RestoreSystemResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetSystemBackup", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetSystemBackupRequest
{

	public GetSystemBackupRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetSystemBackupResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetSystemBackupResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("BackupFiles")]
	public BackupFile[] BackupFiles;

	public GetSystemBackupResponse()
	{
	}

	public GetSystemBackupResponse(BackupFile[] BackupFiles)
	{
		this.BackupFiles = BackupFiles;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetScopes", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetScopesRequest
{

	public GetScopesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetScopesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetScopesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Scopes")]
	public Scope[] Scopes;

	public GetScopesResponse()
	{
	}

	public GetScopesResponse(Scope[] Scopes)
	{
		this.Scopes = Scopes;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetScopes", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetScopesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Scopes", DataType = "anyURI")]
	public string[] Scopes;

	public SetScopesRequest()
	{
	}

	public SetScopesRequest(string[] Scopes)
	{
		this.Scopes = Scopes;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetScopesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetScopesResponse
{

	public SetScopesResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "AddScopes", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class AddScopesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType = "anyURI")]
	public string[] ScopeItem;

	public AddScopesRequest()
	{
	}

	public AddScopesRequest(string[] ScopeItem)
	{
		this.ScopeItem = ScopeItem;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "AddScopesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class AddScopesResponse
{

	public AddScopesResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "RemoveScopes", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class RemoveScopesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType = "anyURI")]
	public string[] ScopeItem;

	public RemoveScopesRequest()
	{
	}

	public RemoveScopesRequest(string[] ScopeItem)
	{
		this.ScopeItem = ScopeItem;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "RemoveScopesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class RemoveScopesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType = "anyURI")]
	public string[] ScopeItem;

	public RemoveScopesResponse()
	{
	}

	public RemoveScopesResponse(string[] ScopeItem)
	{
		this.ScopeItem = ScopeItem;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetDPAddresses", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDPAddressesRequest
{

	public GetDPAddressesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetDPAddressesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDPAddressesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("DPAddress")]
	public NetworkHost[] DPAddress;

	public GetDPAddressesResponse()
	{
	}

	public GetDPAddressesResponse(NetworkHost[] DPAddress)
	{
		this.DPAddress = DPAddress;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetDPAddresses", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetDPAddressesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("DPAddress")]
	public NetworkHost[] DPAddress;

	public SetDPAddressesRequest()
	{
	}

	public SetDPAddressesRequest(NetworkHost[] DPAddress)
	{
		this.DPAddress = DPAddress;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetDPAddressesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetDPAddressesResponse
{

	public SetDPAddressesResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetEndpointReference", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetEndpointReferenceRequest
{

	public GetEndpointReferenceRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetEndpointReferenceResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetEndpointReferenceResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public string GUID;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[System.Xml.Serialization.XmlAnyElementAttribute()]
	public System.Xml.Linq.XElement[] Any;

	public GetEndpointReferenceResponse()
	{
	}

	public GetEndpointReferenceResponse(string GUID, System.Xml.Linq.XElement[] Any)
	{
		this.GUID = GUID;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetUsers", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetUsersRequest
{

	public GetUsersRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetUsersResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetUsersResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("User")]
	public User[] User;

	public GetUsersResponse()
	{
	}

	public GetUsersResponse(User[] User)
	{
		this.User = User;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "CreateUsers", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class CreateUsersRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("User")]
	public User[] User;

	public CreateUsersRequest()
	{
	}

	public CreateUsersRequest(User[] User)
	{
		this.User = User;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "CreateUsersResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class CreateUsersResponse
{

	public CreateUsersResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteUsers", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteUsersRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Username")]
	public string[] Username;

	public DeleteUsersRequest()
	{
	}

	public DeleteUsersRequest(string[] Username)
	{
		this.Username = Username;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteUsersResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteUsersResponse
{

	public DeleteUsersResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetUser", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetUserRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("User")]
	public User[] User;

	public SetUserRequest()
	{
	}

	public SetUserRequest(User[] User)
	{
		this.User = User;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetUserResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetUserResponse
{

	public SetUserResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetWsdlUrl", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetWsdlUrlRequest
{

	public GetWsdlUrlRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetWsdlUrlResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetWsdlUrlResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
	public string WsdlUrl;

	public GetWsdlUrlResponse()
	{
	}

	public GetWsdlUrlResponse(string WsdlUrl)
	{
		this.WsdlUrl = WsdlUrl;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCapabilities", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCapabilitiesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Category")]
	public CapabilityCategory[] Category;

	public GetCapabilitiesRequest()
	{
	}

	public GetCapabilitiesRequest(CapabilityCategory[] Category)
	{
		this.Category = Category;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCapabilitiesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCapabilitiesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public Capabilities Capabilities;

	public GetCapabilitiesResponse()
	{
	}

	public GetCapabilitiesResponse(Capabilities Capabilities)
	{
		this.Capabilities = Capabilities;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetHostname", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetHostnameRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
	public string Name;

	public SetHostnameRequest()
	{
	}

	public SetHostnameRequest(string Name)
	{
		this.Name = Name;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetHostnameResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetHostnameResponse
{

	public SetHostnameResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetDNS", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetDNSRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public bool FromDHCP;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute("SearchDomain", DataType = "token")]
	public string[] SearchDomain;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	[System.Xml.Serialization.XmlElementAttribute("DNSManual")]
	public IPAddress[] DNSManual;

	public SetDNSRequest()
	{
	}

	public SetDNSRequest(bool FromDHCP, string[] SearchDomain, IPAddress[] DNSManual)
	{
		this.FromDHCP = FromDHCP;
		this.SearchDomain = SearchDomain;
		this.DNSManual = DNSManual;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetDNSResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetDNSResponse
{

	public SetDNSResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetNTP", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetNTPRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public bool FromDHCP;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute("NTPManual")]
	public NetworkHost[] NTPManual;

	public SetNTPRequest()
	{
	}

	public SetNTPRequest(bool FromDHCP, NetworkHost[] NTPManual)
	{
		this.FromDHCP = FromDHCP;
		this.NTPManual = NTPManual;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetNTPResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetNTPResponse
{

	public SetNTPResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetDynamicDNS", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetDynamicDNSRequest
{
	[XmlIgnore]
	public TimeSpan? TTLField;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public DynamicDNSType Type;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
	public string Name;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
	public string TTL
	{
		get => TTLField.ToXmlString();
		set => NullableTimeSpanExtensions.GetTimeSpanFromString(value);
	}

	public SetDynamicDNSRequest()
	{
	}

	public SetDynamicDNSRequest(DynamicDNSType Type, string Name, TimeSpan? TTL)
	{
		this.Type = Type;
		this.Name = Name;
		TTLField = TTL;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetDynamicDNSResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetDynamicDNSResponse
{

	public SetDynamicDNSResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetNetworkInterfaces", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetNetworkInterfacesRequest
{

	public GetNetworkInterfacesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetNetworkInterfacesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetNetworkInterfacesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("NetworkInterfaces")]
	public NetworkInterface[] NetworkInterfaces;

	public GetNetworkInterfacesResponse()
	{
	}

	public GetNetworkInterfacesResponse(NetworkInterface[] NetworkInterfaces)
	{
		this.NetworkInterfaces = NetworkInterfaces;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetNetworkProtocols", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetNetworkProtocolsRequest
{

	public GetNetworkProtocolsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetNetworkProtocolsResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetNetworkProtocolsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("NetworkProtocols")]
	public NetworkProtocol[] NetworkProtocols;

	public GetNetworkProtocolsResponse()
	{
	}

	public GetNetworkProtocolsResponse(NetworkProtocol[] NetworkProtocols)
	{
		this.NetworkProtocols = NetworkProtocols;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetNetworkProtocols", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetNetworkProtocolsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("NetworkProtocols")]
	public NetworkProtocol[] NetworkProtocols;

	public SetNetworkProtocolsRequest()
	{
	}

	public SetNetworkProtocolsRequest(NetworkProtocol[] NetworkProtocols)
	{
		this.NetworkProtocols = NetworkProtocols;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetNetworkProtocolsResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetNetworkProtocolsResponse
{

	public SetNetworkProtocolsResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetNetworkDefaultGateway", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetNetworkDefaultGatewayRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("IPv4Address", DataType = "token")]
	public string[] IPv4Address;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute("IPv6Address", DataType = "token")]
	public string[] IPv6Address;

	public SetNetworkDefaultGatewayRequest()
	{
	}

	public SetNetworkDefaultGatewayRequest(string[] IPv4Address, string[] IPv6Address)
	{
		this.IPv4Address = IPv4Address;
		this.IPv6Address = IPv6Address;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetNetworkDefaultGatewayResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetNetworkDefaultGatewayResponse
{

	public SetNetworkDefaultGatewayResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "CreateCertificate", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class CreateCertificateRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
	public string CertificateID;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	public string Subject;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	public System.DateTime ValidNotBefore;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 3)]
	public System.DateTime ValidNotAfter;

	public CreateCertificateRequest()
	{
	}

	public CreateCertificateRequest(string CertificateID, string Subject, System.DateTime ValidNotBefore, System.DateTime ValidNotAfter)
	{
		this.CertificateID = CertificateID;
		this.Subject = Subject;
		this.ValidNotBefore = ValidNotBefore;
		this.ValidNotAfter = ValidNotAfter;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "CreateCertificateResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class CreateCertificateResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public Certificate NvtCertificate;

	public CreateCertificateResponse()
	{
	}

	public CreateCertificateResponse(Certificate NvtCertificate)
	{
		this.NvtCertificate = NvtCertificate;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCertificates", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCertificatesRequest
{

	public GetCertificatesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCertificatesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCertificatesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("NvtCertificate")]
	public Certificate[] NvtCertificate;

	public GetCertificatesResponse()
	{
	}

	public GetCertificatesResponse(Certificate[] NvtCertificate)
	{
		this.NvtCertificate = NvtCertificate;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCertificatesStatus", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCertificatesStatusRequest
{

	public GetCertificatesStatusRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCertificatesStatusResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCertificatesStatusResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("CertificateStatus")]
	public CertificateStatus[] CertificateStatus;

	public GetCertificatesStatusResponse()
	{
	}

	public GetCertificatesStatusResponse(CertificateStatus[] CertificateStatus)
	{
		this.CertificateStatus = CertificateStatus;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetCertificatesStatus", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetCertificatesStatusRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("CertificateStatus")]
	public CertificateStatus[] CertificateStatus;

	public SetCertificatesStatusRequest()
	{
	}

	public SetCertificatesStatusRequest(CertificateStatus[] CertificateStatus)
	{
		this.CertificateStatus = CertificateStatus;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetCertificatesStatusResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetCertificatesStatusResponse
{

	public SetCertificatesStatusResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteCertificates", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteCertificatesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("CertificateID", DataType = "token")]
	public string[] CertificateID;

	public DeleteCertificatesRequest()
	{
	}

	public DeleteCertificatesRequest(string[] CertificateID)
	{
		this.CertificateID = CertificateID;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteCertificatesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteCertificatesResponse
{

	public DeleteCertificatesResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPkcs10Request", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetPkcs10RequestRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
	public string CertificateID;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	public string Subject;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	public BinaryData Attributes;

	public GetPkcs10RequestRequest()
	{
	}

	public GetPkcs10RequestRequest(string CertificateID, string Subject, BinaryData Attributes)
	{
		this.CertificateID = CertificateID;
		this.Subject = Subject;
		this.Attributes = Attributes;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPkcs10RequestResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetPkcs10RequestResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public BinaryData Pkcs10Request;

	public GetPkcs10RequestResponse()
	{
	}

	public GetPkcs10RequestResponse(BinaryData Pkcs10Request)
	{
		this.Pkcs10Request = Pkcs10Request;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "LoadCertificates", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class LoadCertificatesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("NVTCertificate")]
	public Certificate[] NVTCertificate;

	public LoadCertificatesRequest()
	{
	}

	public LoadCertificatesRequest(Certificate[] NVTCertificate)
	{
		this.NVTCertificate = NVTCertificate;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "LoadCertificatesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class LoadCertificatesResponse
{

	public LoadCertificatesResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetRelayOutputs", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetRelayOutputsRequest
{

	public GetRelayOutputsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetRelayOutputsResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetRelayOutputsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("RelayOutputs")]
	public RelayOutput[] RelayOutputs;

	public GetRelayOutputsResponse()
	{
	}

	public GetRelayOutputsResponse(RelayOutput[] RelayOutputs)
	{
		this.RelayOutputs = RelayOutputs;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCACertificates", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCACertificatesRequest
{

	public GetCACertificatesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCACertificatesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCACertificatesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("CACertificate")]
	public Certificate[] CACertificate;

	public GetCACertificatesResponse()
	{
	}

	public GetCACertificatesResponse(Certificate[] CACertificate)
	{
		this.CACertificate = CACertificate;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "LoadCertificateWithPrivateKey", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class LoadCertificateWithPrivateKeyRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("CertificateWithPrivateKey")]
	public CertificateWithPrivateKey[] CertificateWithPrivateKey;

	public LoadCertificateWithPrivateKeyRequest()
	{
	}

	public LoadCertificateWithPrivateKeyRequest(CertificateWithPrivateKey[] CertificateWithPrivateKey)
	{
		this.CertificateWithPrivateKey = CertificateWithPrivateKey;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "LoadCertificateWithPrivateKeyResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class LoadCertificateWithPrivateKeyResponse
{

	public LoadCertificateWithPrivateKeyResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCertificateInformation", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCertificateInformationRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
	public string CertificateID;

	public GetCertificateInformationRequest()
	{
	}

	public GetCertificateInformationRequest(string CertificateID)
	{
		this.CertificateID = CertificateID;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCertificateInformationResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetCertificateInformationResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public CertificateInformation CertificateInformation;

	public GetCertificateInformationResponse()
	{
	}

	public GetCertificateInformationResponse(CertificateInformation CertificateInformation)
	{
		this.CertificateInformation = CertificateInformation;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "LoadCACertificates", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class LoadCACertificatesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("CACertificate")]
	public Certificate[] CACertificate;

	public LoadCACertificatesRequest()
	{
	}

	public LoadCACertificatesRequest(Certificate[] CACertificate)
	{
		this.CACertificate = CACertificate;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "LoadCACertificatesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class LoadCACertificatesResponse
{

	public LoadCACertificatesResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetDot1XConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDot1XConfigurationsRequest
{

	public GetDot1XConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetDot1XConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDot1XConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Dot1XConfiguration")]
	public Dot1XConfiguration[] Dot1XConfiguration;

	public GetDot1XConfigurationsResponse()
	{
	}

	public GetDot1XConfigurationsResponse(Dot1XConfiguration[] Dot1XConfiguration)
	{
		this.Dot1XConfiguration = Dot1XConfiguration;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteDot1XConfiguration", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteDot1XConfigurationRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Dot1XConfigurationToken")]
	public string[] Dot1XConfigurationToken;

	public DeleteDot1XConfigurationRequest()
	{
	}

	public DeleteDot1XConfigurationRequest(string[] Dot1XConfigurationToken)
	{
		this.Dot1XConfigurationToken = Dot1XConfigurationToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteDot1XConfigurationResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteDot1XConfigurationResponse
{

	public DeleteDot1XConfigurationResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetDot11Capabilities", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDot11CapabilitiesRequest
{

	[MessageBodyMemberAttribute(Namespace = "", Order = 0)]
	[System.Xml.Serialization.XmlAnyElementAttribute()]
	public System.Xml.Linq.XElement[] Any;

	public GetDot11CapabilitiesRequest()
	{
	}

	public GetDot11CapabilitiesRequest(System.Xml.Linq.XElement[] Any)
	{
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetDot11CapabilitiesResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetDot11CapabilitiesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public Dot11Capabilities Capabilities;

	public GetDot11CapabilitiesResponse()
	{
	}

	public GetDot11CapabilitiesResponse(Dot11Capabilities Capabilities)
	{
		this.Capabilities = Capabilities;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "ScanAvailableDot11Networks", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class ScanAvailableDot11NetworksRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	public string InterfaceToken;

	public ScanAvailableDot11NetworksRequest()
	{
	}

	public ScanAvailableDot11NetworksRequest(string InterfaceToken)
	{
		this.InterfaceToken = InterfaceToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "ScanAvailableDot11NetworksResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class ScanAvailableDot11NetworksResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Networks")]
	public Dot11AvailableNetworks[] Networks;

	public ScanAvailableDot11NetworksResponse()
	{
	}

	public ScanAvailableDot11NetworksResponse(Dot11AvailableNetworks[] Networks)
	{
		this.Networks = Networks;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetSystemUris", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetSystemUrisRequest
{

	public GetSystemUrisRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetSystemUrisResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetSystemUrisResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlArrayItemAttribute("SystemLog", Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
	public SystemLogUri[] SystemLogUris;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
	public string SupportInfoUri;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
	public string SystemBackupUri;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 3)]
	public GetSystemUrisResponseExtension Extension;

	public GetSystemUrisResponse()
	{
	}

	public GetSystemUrisResponse(SystemLogUri[] SystemLogUris, string SupportInfoUri, string SystemBackupUri, GetSystemUrisResponseExtension Extension)
	{
		this.SystemLogUris = SystemLogUris;
		this.SupportInfoUri = SupportInfoUri;
		this.SystemBackupUri = SystemBackupUri;
		this.Extension = Extension;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "StartFirmwareUpgrade", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class StartFirmwareUpgradeRequest
{

	public StartFirmwareUpgradeRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "StartFirmwareUpgradeResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class StartFirmwareUpgradeResponse
{
	[XmlIgnore]
	public TimeSpan UploadDelayField;
	[XmlIgnore]
	public TimeSpan ExpectedDownTimeField;
	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
	public string UploadUri;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
	public string UploadDelay
	{
		get => XmlConvert.ToString(UploadDelayField);
		set => UploadDelayField = XmlConvert.ToTimeSpan(value);
	}
	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 2)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
	public string ExpectedDownTime
	{
		get => XmlConvert.ToString(ExpectedDownTimeField);
		set => ExpectedDownTimeField = XmlConvert.ToTimeSpan(value);
	}

	public StartFirmwareUpgradeResponse()
	{
	}

	public StartFirmwareUpgradeResponse(string UploadUri, string UploadDelay, string ExpectedDownTime)
	{
		this.UploadUri = UploadUri;
		this.UploadDelay = UploadDelay;
		this.ExpectedDownTime = ExpectedDownTime;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "StartSystemRestore", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class StartSystemRestoreRequest
{

	public StartSystemRestoreRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "StartSystemRestoreResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class StartSystemRestoreResponse
{
	[XmlIgnore]
	public TimeSpan ExpectedDownTimeField;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
	public string UploadUri;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 1)]
	[System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
	public string ExpectedDownTime
	{
		get => XmlConvert.ToString(ExpectedDownTimeField);
		set => ExpectedDownTimeField = XmlConvert.ToTimeSpan(value);
	}

	public StartSystemRestoreResponse()
	{
	}

	public StartSystemRestoreResponse(string UploadUri, string ExpectedDownTime)
	{
		this.UploadUri = UploadUri;
		this.ExpectedDownTime = ExpectedDownTime;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetStorageConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetStorageConfigurationsRequest
{

	public GetStorageConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetStorageConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetStorageConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("StorageConfigurations")]
	public StorageConfiguration[] StorageConfigurations;

	public GetStorageConfigurationsResponse()
	{
	}

	public GetStorageConfigurationsResponse(StorageConfiguration[] StorageConfigurations)
	{
		this.StorageConfigurations = StorageConfigurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetGeoLocation", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetGeoLocationRequest
{

	public GetGeoLocationRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetGeoLocationResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class GetGeoLocationResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Location")]
	public LocationEntity[] Location;

	public GetGeoLocationResponse()
	{
	}

	public GetGeoLocationResponse(LocationEntity[] Location)
	{
		this.Location = Location;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetGeoLocation", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetGeoLocationRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Location")]
	public LocationEntity[] Location;

	public SetGeoLocationRequest()
	{
	}

	public SetGeoLocationRequest(LocationEntity[] Location)
	{
		this.Location = Location;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "SetGeoLocationResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class SetGeoLocationResponse
{

	public SetGeoLocationResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteGeoLocation", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteGeoLocationRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", Order = 0)]
	[System.Xml.Serialization.XmlElementAttribute("Location")]
	public LocationEntity[] Location;

	public DeleteGeoLocationRequest()
	{
	}

	public DeleteGeoLocationRequest(LocationEntity[] Location)
	{
		this.Location = Location;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "DeleteGeoLocationResponse", WrapperNamespace = "http://www.onvif.org/ver10/device/wsdl", IsWrapped = true)]
public partial class DeleteGeoLocationResponse
{

	public DeleteGeoLocationResponse()
	{
	}
}

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public interface DeviceChannel : Device, IClientChannel
{
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public partial class DeviceClient : ClientBase<Device>, Device
{

	internal DeviceClient(Binding binding, EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
	{
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetServicesResponse> Device.GetServicesAsync(GetServicesRequest request)
	{
		return base.Channel.GetServicesAsync(request);
	}

	public Task<GetServicesResponse> GetServicesAsync(bool IncludeCapability)
	{
		GetServicesRequest inValue = new GetServicesRequest();
		inValue.IncludeCapability = IncludeCapability;
		return ((Device)(this)).GetServicesAsync(inValue);
	}

	public Task<DeviceServiceCapabilities> GetServiceCapabilitiesAsync()
	{
		return base.Channel.GetServiceCapabilitiesAsync();
	}

	public Task<GetDeviceInformationResponse> GetDeviceInformationAsync(GetDeviceInformationRequest request)
	{
		return base.Channel.GetDeviceInformationAsync(request);
	}

	public Task SetSystemDateAndTimeAsync(SetDateTimeType DateTimeType, bool DaylightSavings, Common.TimeZone TimeZone, Common.DateTime UTCDateTime)
	{
		return base.Channel.SetSystemDateAndTimeAsync(DateTimeType, DaylightSavings, TimeZone, UTCDateTime);
	}

	public Task<SystemDateTime> GetSystemDateAndTimeAsync()
	{
		return base.Channel.GetSystemDateAndTimeAsync();
	}

	public Task SetSystemFactoryDefaultAsync(FactoryDefaultType FactoryDefault)
	{
		return base.Channel.SetSystemFactoryDefaultAsync(FactoryDefault);
	}

	public Task<string> UpgradeSystemFirmwareAsync(AttachmentData Firmware)
	{
		return base.Channel.UpgradeSystemFirmwareAsync(Firmware);
	}

	public Task<string> SystemRebootAsync()
	{
		return base.Channel.SystemRebootAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<RestoreSystemResponse> Device.RestoreSystemAsync(RestoreSystemRequest request)
	{
		return base.Channel.RestoreSystemAsync(request);
	}

	public Task<RestoreSystemResponse> RestoreSystemAsync(BackupFile[] BackupFiles)
	{
		RestoreSystemRequest inValue = new RestoreSystemRequest();
		inValue.BackupFiles = BackupFiles;
		return ((Device)(this)).RestoreSystemAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetSystemBackupResponse> Device.GetSystemBackupAsync(GetSystemBackupRequest request)
	{
		return base.Channel.GetSystemBackupAsync(request);
	}

	public Task<GetSystemBackupResponse> GetSystemBackupAsync()
	{
		GetSystemBackupRequest inValue = new GetSystemBackupRequest();
		return ((Device)(this)).GetSystemBackupAsync(inValue);
	}

	public Task<SystemLog> GetSystemLogAsync(SystemLogType LogType)
	{
		return base.Channel.GetSystemLogAsync(LogType);
	}

	public Task<SupportInformation> GetSystemSupportInformationAsync()
	{
		return base.Channel.GetSystemSupportInformationAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetScopesResponse> Device.GetScopesAsync(GetScopesRequest request)
	{
		return base.Channel.GetScopesAsync(request);
	}

	public Task<GetScopesResponse> GetScopesAsync()
	{
		GetScopesRequest inValue = new GetScopesRequest();
		return ((Device)(this)).GetScopesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetScopesResponse> Device.SetScopesAsync(SetScopesRequest request)
	{
		return base.Channel.SetScopesAsync(request);
	}

	public Task<SetScopesResponse> SetScopesAsync(string[] Scopes)
	{
		SetScopesRequest inValue = new SetScopesRequest();
		inValue.Scopes = Scopes;
		return ((Device)(this)).SetScopesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<AddScopesResponse> Device.AddScopesAsync(AddScopesRequest request)
	{
		return base.Channel.AddScopesAsync(request);
	}

	public Task<AddScopesResponse> AddScopesAsync(string[] ScopeItem)
	{
		AddScopesRequest inValue = new AddScopesRequest();
		inValue.ScopeItem = ScopeItem;
		return ((Device)(this)).AddScopesAsync(inValue);
	}

	public Task<RemoveScopesResponse> RemoveScopesAsync(RemoveScopesRequest request)
	{
		return base.Channel.RemoveScopesAsync(request);
	}

	public Task<DiscoveryMode> GetDiscoveryModeAsync()
	{
		return base.Channel.GetDiscoveryModeAsync();
	}

	public Task SetDiscoveryModeAsync(DiscoveryMode DiscoveryMode)
	{
		return base.Channel.SetDiscoveryModeAsync(DiscoveryMode);
	}

	public Task<DiscoveryMode> GetRemoteDiscoveryModeAsync()
	{
		return base.Channel.GetRemoteDiscoveryModeAsync();
	}

	public Task SetRemoteDiscoveryModeAsync(DiscoveryMode RemoteDiscoveryMode)
	{
		return base.Channel.SetRemoteDiscoveryModeAsync(RemoteDiscoveryMode);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetDPAddressesResponse> Device.GetDPAddressesAsync(GetDPAddressesRequest request)
	{
		return base.Channel.GetDPAddressesAsync(request);
	}

	public Task<GetDPAddressesResponse> GetDPAddressesAsync()
	{
		GetDPAddressesRequest inValue = new GetDPAddressesRequest();
		return ((Device)(this)).GetDPAddressesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetDPAddressesResponse> Device.SetDPAddressesAsync(SetDPAddressesRequest request)
	{
		return base.Channel.SetDPAddressesAsync(request);
	}

	public Task<SetDPAddressesResponse> SetDPAddressesAsync(NetworkHost[] DPAddress)
	{
		SetDPAddressesRequest inValue = new SetDPAddressesRequest();
		inValue.DPAddress = DPAddress;
		return ((Device)(this)).SetDPAddressesAsync(inValue);
	}

	public Task<GetEndpointReferenceResponse> GetEndpointReferenceAsync(GetEndpointReferenceRequest request)
	{
		return base.Channel.GetEndpointReferenceAsync(request);
	}

	public Task<RemoteUser> GetRemoteUserAsync()
	{
		return base.Channel.GetRemoteUserAsync();
	}

	public Task SetRemoteUserAsync(RemoteUser RemoteUser)
	{
		return base.Channel.SetRemoteUserAsync(RemoteUser);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetUsersResponse> Device.GetUsersAsync(GetUsersRequest request)
	{
		return base.Channel.GetUsersAsync(request);
	}

	public Task<GetUsersResponse> GetUsersAsync()
	{
		GetUsersRequest inValue = new GetUsersRequest();
		return ((Device)(this)).GetUsersAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<CreateUsersResponse> Device.CreateUsersAsync(CreateUsersRequest request)
	{
		return base.Channel.CreateUsersAsync(request);
	}

	public Task<CreateUsersResponse> CreateUsersAsync(User[] User)
	{
		CreateUsersRequest inValue = new CreateUsersRequest();
		inValue.User = User;
		return ((Device)(this)).CreateUsersAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<DeleteUsersResponse> Device.DeleteUsersAsync(DeleteUsersRequest request)
	{
		return base.Channel.DeleteUsersAsync(request);
	}

	public Task<DeleteUsersResponse> DeleteUsersAsync(string[] Username)
	{
		DeleteUsersRequest inValue = new DeleteUsersRequest();
		inValue.Username = Username;
		return ((Device)(this)).DeleteUsersAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetUserResponse> Device.SetUserAsync(SetUserRequest request)
	{
		return base.Channel.SetUserAsync(request);
	}

	public Task<SetUserResponse> SetUserAsync(User[] User)
	{
		SetUserRequest inValue = new SetUserRequest();
		inValue.User = User;
		return ((Device)(this)).SetUserAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetWsdlUrlResponse> Device.GetWsdlUrlAsync(GetWsdlUrlRequest request)
	{
		return base.Channel.GetWsdlUrlAsync(request);
	}

	public Task<GetWsdlUrlResponse> GetWsdlUrlAsync()
	{
		GetWsdlUrlRequest inValue = new GetWsdlUrlRequest();
		return ((Device)(this)).GetWsdlUrlAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCapabilitiesResponse> Device.GetCapabilitiesAsync(GetCapabilitiesRequest request)
	{
		return base.Channel.GetCapabilitiesAsync(request);
	}

	public Task<GetCapabilitiesResponse> GetCapabilitiesAsync(CapabilityCategory[] Category)
	{
		GetCapabilitiesRequest inValue = new GetCapabilitiesRequest();
		inValue.Category = Category;
		return ((Device)(this)).GetCapabilitiesAsync(inValue);
	}

	public Task<HostnameInformation> GetHostnameAsync()
	{
		return base.Channel.GetHostnameAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetHostnameResponse> Device.SetHostnameAsync(SetHostnameRequest request)
	{
		return base.Channel.SetHostnameAsync(request);
	}

	public Task<SetHostnameResponse> SetHostnameAsync(string Name)
	{
		SetHostnameRequest inValue = new SetHostnameRequest();
		inValue.Name = Name;
		return ((Device)(this)).SetHostnameAsync(inValue);
	}

	public Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP)
	{
		return base.Channel.SetHostnameFromDHCPAsync(FromDHCP);
	}

	public Task<DNSInformation> GetDNSAsync()
	{
		return base.Channel.GetDNSAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetDNSResponse> Device.SetDNSAsync(SetDNSRequest request)
	{
		return base.Channel.SetDNSAsync(request);
	}

	public Task<SetDNSResponse> SetDNSAsync(bool FromDHCP, string[] SearchDomain, IPAddress[] DNSManual)
	{
		SetDNSRequest inValue = new SetDNSRequest();
		inValue.FromDHCP = FromDHCP;
		inValue.SearchDomain = SearchDomain;
		inValue.DNSManual = DNSManual;
		return ((Device)(this)).SetDNSAsync(inValue);
	}

	public Task<NTPInformation> GetNTPAsync()
	{
		return base.Channel.GetNTPAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetNTPResponse> Device.SetNTPAsync(SetNTPRequest request)
	{
		return base.Channel.SetNTPAsync(request);
	}

	public Task<SetNTPResponse> SetNTPAsync(bool FromDHCP, NetworkHost[] NTPManual)
	{
		SetNTPRequest inValue = new SetNTPRequest();
		inValue.FromDHCP = FromDHCP;
		inValue.NTPManual = NTPManual;
		return ((Device)(this)).SetNTPAsync(inValue);
	}

	public Task<DynamicDNSInformation> GetDynamicDNSAsync()
	{
		return base.Channel.GetDynamicDNSAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetDynamicDNSResponse> Device.SetDynamicDNSAsync(SetDynamicDNSRequest request)
	{
		return base.Channel.SetDynamicDNSAsync(request);
	}

	public Task<SetDynamicDNSResponse> SetDynamicDNSAsync(DynamicDNSType Type, string Name, TimeSpan? TTL = null)
	{
		SetDynamicDNSRequest inValue = new SetDynamicDNSRequest();
		inValue.Type = Type;
		inValue.Name = Name;
		inValue.TTLField = TTL;
		return ((Device)(this)).SetDynamicDNSAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetNetworkInterfacesResponse> Device.GetNetworkInterfacesAsync(GetNetworkInterfacesRequest request)
	{
		return base.Channel.GetNetworkInterfacesAsync(request);
	}

	public Task<GetNetworkInterfacesResponse> GetNetworkInterfacesAsync()
	{
		GetNetworkInterfacesRequest inValue = new GetNetworkInterfacesRequest();
		return ((Device)(this)).GetNetworkInterfacesAsync(inValue);
	}

	public Task<bool> SetNetworkInterfacesAsync(string InterfaceToken, NetworkInterfaceSetConfiguration NetworkInterface)
	{
		return base.Channel.SetNetworkInterfacesAsync(InterfaceToken, NetworkInterface);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetNetworkProtocolsResponse> Device.GetNetworkProtocolsAsync(GetNetworkProtocolsRequest request)
	{
		return base.Channel.GetNetworkProtocolsAsync(request);
	}

	public Task<GetNetworkProtocolsResponse> GetNetworkProtocolsAsync()
	{
		GetNetworkProtocolsRequest inValue = new GetNetworkProtocolsRequest();
		return ((Device)(this)).GetNetworkProtocolsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetNetworkProtocolsResponse> Device.SetNetworkProtocolsAsync(SetNetworkProtocolsRequest request)
	{
		return base.Channel.SetNetworkProtocolsAsync(request);
	}

	public Task<SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(NetworkProtocol[] NetworkProtocols)
	{
		SetNetworkProtocolsRequest inValue = new SetNetworkProtocolsRequest();
		inValue.NetworkProtocols = NetworkProtocols;
		return ((Device)(this)).SetNetworkProtocolsAsync(inValue);
	}

	public Task<NetworkGateway> GetNetworkDefaultGatewayAsync()
	{
		return base.Channel.GetNetworkDefaultGatewayAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetNetworkDefaultGatewayResponse> Device.SetNetworkDefaultGatewayAsync(SetNetworkDefaultGatewayRequest request)
	{
		return base.Channel.SetNetworkDefaultGatewayAsync(request);
	}

	public Task<SetNetworkDefaultGatewayResponse> SetNetworkDefaultGatewayAsync(string[] IPv4Address, string[] IPv6Address)
	{
		SetNetworkDefaultGatewayRequest inValue = new SetNetworkDefaultGatewayRequest();
		inValue.IPv4Address = IPv4Address;
		inValue.IPv6Address = IPv6Address;
		return ((Device)(this)).SetNetworkDefaultGatewayAsync(inValue);
	}

	public Task<NetworkZeroConfiguration> GetZeroConfigurationAsync()
	{
		return base.Channel.GetZeroConfigurationAsync();
	}

	public Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled)
	{
		return base.Channel.SetZeroConfigurationAsync(InterfaceToken, Enabled);
	}

	public Task<IPAddressFilter> GetIPAddressFilterAsync()
	{
		return base.Channel.GetIPAddressFilterAsync();
	}

	public Task SetIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
	{
		return base.Channel.SetIPAddressFilterAsync(IPAddressFilter);
	}

	public Task AddIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
	{
		return base.Channel.AddIPAddressFilterAsync(IPAddressFilter);
	}

	public Task RemoveIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
	{
		return base.Channel.RemoveIPAddressFilterAsync(IPAddressFilter);
	}

	public Task<BinaryData> GetAccessPolicyAsync()
	{
		return base.Channel.GetAccessPolicyAsync();
	}

	public Task SetAccessPolicyAsync(BinaryData PolicyFile)
	{
		return base.Channel.SetAccessPolicyAsync(PolicyFile);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<CreateCertificateResponse> Device.CreateCertificateAsync(CreateCertificateRequest request)
	{
		return base.Channel.CreateCertificateAsync(request);
	}

	public Task<CreateCertificateResponse> CreateCertificateAsync(string CertificateID, string Subject, System.DateTime ValidNotBefore, System.DateTime ValidNotAfter)
	{
		CreateCertificateRequest inValue = new CreateCertificateRequest();
		inValue.CertificateID = CertificateID;
		inValue.Subject = Subject;
		inValue.ValidNotBefore = ValidNotBefore;
		inValue.ValidNotAfter = ValidNotAfter;
		return ((Device)(this)).CreateCertificateAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCertificatesResponse> Device.GetCertificatesAsync(GetCertificatesRequest request)
	{
		return base.Channel.GetCertificatesAsync(request);
	}

	public Task<GetCertificatesResponse> GetCertificatesAsync()
	{
		GetCertificatesRequest inValue = new GetCertificatesRequest();
		return ((Device)(this)).GetCertificatesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCertificatesStatusResponse> Device.GetCertificatesStatusAsync(GetCertificatesStatusRequest request)
	{
		return base.Channel.GetCertificatesStatusAsync(request);
	}

	public Task<GetCertificatesStatusResponse> GetCertificatesStatusAsync()
	{
		GetCertificatesStatusRequest inValue = new GetCertificatesStatusRequest();
		return ((Device)(this)).GetCertificatesStatusAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetCertificatesStatusResponse> Device.SetCertificatesStatusAsync(SetCertificatesStatusRequest request)
	{
		return base.Channel.SetCertificatesStatusAsync(request);
	}

	public Task<SetCertificatesStatusResponse> SetCertificatesStatusAsync(CertificateStatus[] CertificateStatus)
	{
		SetCertificatesStatusRequest inValue = new SetCertificatesStatusRequest();
		inValue.CertificateStatus = CertificateStatus;
		return ((Device)(this)).SetCertificatesStatusAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<DeleteCertificatesResponse> Device.DeleteCertificatesAsync(DeleteCertificatesRequest request)
	{
		return base.Channel.DeleteCertificatesAsync(request);
	}

	public Task<DeleteCertificatesResponse> DeleteCertificatesAsync(string[] CertificateID)
	{
		DeleteCertificatesRequest inValue = new DeleteCertificatesRequest();
		inValue.CertificateID = CertificateID;
		return ((Device)(this)).DeleteCertificatesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetPkcs10RequestResponse> Device.GetPkcs10RequestAsync(GetPkcs10RequestRequest request)
	{
		return base.Channel.GetPkcs10RequestAsync(request);
	}

	public Task<GetPkcs10RequestResponse> GetPkcs10RequestAsync(string CertificateID, string Subject, BinaryData Attributes)
	{
		GetPkcs10RequestRequest inValue = new GetPkcs10RequestRequest();
		inValue.CertificateID = CertificateID;
		inValue.Subject = Subject;
		inValue.Attributes = Attributes;
		return ((Device)(this)).GetPkcs10RequestAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<LoadCertificatesResponse> Device.LoadCertificatesAsync(LoadCertificatesRequest request)
	{
		return base.Channel.LoadCertificatesAsync(request);
	}

	public Task<LoadCertificatesResponse> LoadCertificatesAsync(Certificate[] NVTCertificate)
	{
		LoadCertificatesRequest inValue = new LoadCertificatesRequest();
		inValue.NVTCertificate = NVTCertificate;
		return ((Device)(this)).LoadCertificatesAsync(inValue);
	}

	public Task<bool> GetClientCertificateModeAsync()
	{
		return base.Channel.GetClientCertificateModeAsync();
	}

	public Task SetClientCertificateModeAsync(bool Enabled)
	{
		return base.Channel.SetClientCertificateModeAsync(Enabled);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetRelayOutputsResponse> Device.GetRelayOutputsAsync(GetRelayOutputsRequest request)
	{
		return base.Channel.GetRelayOutputsAsync(request);
	}

	public Task<GetRelayOutputsResponse> GetRelayOutputsAsync()
	{
		GetRelayOutputsRequest inValue = new GetRelayOutputsRequest();
		return ((Device)(this)).GetRelayOutputsAsync(inValue);
	}

	public Task SetRelayOutputSettingsAsync(string RelayOutputToken, RelayOutputSettings Properties)
	{
		return base.Channel.SetRelayOutputSettingsAsync(RelayOutputToken, Properties);
	}

	public Task SetRelayOutputStateAsync(string RelayOutputToken, RelayLogicalState LogicalState)
	{
		return base.Channel.SetRelayOutputStateAsync(RelayOutputToken, LogicalState);
	}

	public Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand)
	{
		return base.Channel.SendAuxiliaryCommandAsync(AuxiliaryCommand);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCACertificatesResponse> Device.GetCACertificatesAsync(GetCACertificatesRequest request)
	{
		return base.Channel.GetCACertificatesAsync(request);
	}

	public Task<GetCACertificatesResponse> GetCACertificatesAsync()
	{
		GetCACertificatesRequest inValue = new GetCACertificatesRequest();
		return ((Device)(this)).GetCACertificatesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<LoadCertificateWithPrivateKeyResponse> Device.LoadCertificateWithPrivateKeyAsync(LoadCertificateWithPrivateKeyRequest request)
	{
		return base.Channel.LoadCertificateWithPrivateKeyAsync(request);
	}

	public Task<LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKeyAsync(CertificateWithPrivateKey[] CertificateWithPrivateKey)
	{
		LoadCertificateWithPrivateKeyRequest inValue = new LoadCertificateWithPrivateKeyRequest();
		inValue.CertificateWithPrivateKey = CertificateWithPrivateKey;
		return ((Device)(this)).LoadCertificateWithPrivateKeyAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCertificateInformationResponse> Device.GetCertificateInformationAsync(GetCertificateInformationRequest request)
	{
		return base.Channel.GetCertificateInformationAsync(request);
	}

	public Task<GetCertificateInformationResponse> GetCertificateInformationAsync(string CertificateID)
	{
		GetCertificateInformationRequest inValue = new GetCertificateInformationRequest();
		inValue.CertificateID = CertificateID;
		return ((Device)(this)).GetCertificateInformationAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<LoadCACertificatesResponse> Device.LoadCACertificatesAsync(LoadCACertificatesRequest request)
	{
		return base.Channel.LoadCACertificatesAsync(request);
	}

	public Task<LoadCACertificatesResponse> LoadCACertificatesAsync(Certificate[] CACertificate)
	{
		LoadCACertificatesRequest inValue = new LoadCACertificatesRequest();
		inValue.CACertificate = CACertificate;
		return ((Device)(this)).LoadCACertificatesAsync(inValue);
	}

	public Task CreateDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration)
	{
		return base.Channel.CreateDot1XConfigurationAsync(Dot1XConfiguration);
	}

	public Task SetDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration)
	{
		return base.Channel.SetDot1XConfigurationAsync(Dot1XConfiguration);
	}

	public Task<Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken)
	{
		return base.Channel.GetDot1XConfigurationAsync(Dot1XConfigurationToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetDot1XConfigurationsResponse> Device.GetDot1XConfigurationsAsync(GetDot1XConfigurationsRequest request)
	{
		return base.Channel.GetDot1XConfigurationsAsync(request);
	}

	public Task<GetDot1XConfigurationsResponse> GetDot1XConfigurationsAsync()
	{
		GetDot1XConfigurationsRequest inValue = new GetDot1XConfigurationsRequest();
		return ((Device)(this)).GetDot1XConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<DeleteDot1XConfigurationResponse> Device.DeleteDot1XConfigurationAsync(DeleteDot1XConfigurationRequest request)
	{
		return base.Channel.DeleteDot1XConfigurationAsync(request);
	}

	public Task<DeleteDot1XConfigurationResponse> DeleteDot1XConfigurationAsync(string[] Dot1XConfigurationToken)
	{
		DeleteDot1XConfigurationRequest inValue = new DeleteDot1XConfigurationRequest();
		inValue.Dot1XConfigurationToken = Dot1XConfigurationToken;
		return ((Device)(this)).DeleteDot1XConfigurationAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetDot11CapabilitiesResponse> Device.GetDot11CapabilitiesAsync(GetDot11CapabilitiesRequest request)
	{
		return base.Channel.GetDot11CapabilitiesAsync(request);
	}

	public Task<GetDot11CapabilitiesResponse> GetDot11CapabilitiesAsync(System.Xml.Linq.XElement[] Any)
	{
		GetDot11CapabilitiesRequest inValue = new GetDot11CapabilitiesRequest();
		inValue.Any = Any;
		return ((Device)(this)).GetDot11CapabilitiesAsync(inValue);
	}

	public Task<Dot11Status> GetDot11StatusAsync(string InterfaceToken)
	{
		return base.Channel.GetDot11StatusAsync(InterfaceToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<ScanAvailableDot11NetworksResponse> Device.ScanAvailableDot11NetworksAsync(ScanAvailableDot11NetworksRequest request)
	{
		return base.Channel.ScanAvailableDot11NetworksAsync(request);
	}

	public Task<ScanAvailableDot11NetworksResponse> ScanAvailableDot11NetworksAsync(string InterfaceToken)
	{
		ScanAvailableDot11NetworksRequest inValue = new ScanAvailableDot11NetworksRequest();
		inValue.InterfaceToken = InterfaceToken;
		return ((Device)(this)).ScanAvailableDot11NetworksAsync(inValue);
	}

	public Task<GetSystemUrisResponse> GetSystemUrisAsync(GetSystemUrisRequest request)
	{
		return base.Channel.GetSystemUrisAsync(request);
	}

	public Task<StartFirmwareUpgradeResponse> StartFirmwareUpgradeAsync(StartFirmwareUpgradeRequest request)
	{
		return base.Channel.StartFirmwareUpgradeAsync(request);
	}

	public Task<StartSystemRestoreResponse> StartSystemRestoreAsync(StartSystemRestoreRequest request)
	{
		return base.Channel.StartSystemRestoreAsync(request);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetStorageConfigurationsResponse> Device.GetStorageConfigurationsAsync(GetStorageConfigurationsRequest request)
	{
		return base.Channel.GetStorageConfigurationsAsync(request);
	}

	public Task<GetStorageConfigurationsResponse> GetStorageConfigurationsAsync()
	{
		GetStorageConfigurationsRequest inValue = new GetStorageConfigurationsRequest();
		return ((Device)(this)).GetStorageConfigurationsAsync(inValue);
	}

	public Task<string> CreateStorageConfigurationAsync(StorageConfigurationData StorageConfiguration)
	{
		return base.Channel.CreateStorageConfigurationAsync(StorageConfiguration);
	}

	public Task<StorageConfiguration> GetStorageConfigurationAsync(string Token)
	{
		return base.Channel.GetStorageConfigurationAsync(Token);
	}

	public Task SetStorageConfigurationAsync(StorageConfiguration StorageConfiguration)
	{
		return base.Channel.SetStorageConfigurationAsync(StorageConfiguration);
	}

	public Task DeleteStorageConfigurationAsync(string Token)
	{
		return base.Channel.DeleteStorageConfigurationAsync(Token);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetGeoLocationResponse> Device.GetGeoLocationAsync(GetGeoLocationRequest request)
	{
		return base.Channel.GetGeoLocationAsync(request);
	}

	public Task<GetGeoLocationResponse> GetGeoLocationAsync()
	{
		GetGeoLocationRequest inValue = new GetGeoLocationRequest();
		return ((Device)(this)).GetGeoLocationAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<SetGeoLocationResponse> Device.SetGeoLocationAsync(SetGeoLocationRequest request)
	{
		return base.Channel.SetGeoLocationAsync(request);
	}

	public Task<SetGeoLocationResponse> SetGeoLocationAsync(LocationEntity[] Location)
	{
		SetGeoLocationRequest inValue = new SetGeoLocationRequest();
		inValue.Location = Location;
		return ((Device)(this)).SetGeoLocationAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<DeleteGeoLocationResponse> Device.DeleteGeoLocationAsync(DeleteGeoLocationRequest request)
	{
		return base.Channel.DeleteGeoLocationAsync(request);
	}

	public Task<DeleteGeoLocationResponse> DeleteGeoLocationAsync(LocationEntity[] Location)
	{
		DeleteGeoLocationRequest inValue = new DeleteGeoLocationRequest();
		inValue.Location = Location;
		return ((Device)(this)).DeleteGeoLocationAsync(inValue);
	}

	public virtual Task OpenAsync()
	{
		return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((ICommunicationObject)(this)).EndOpen));
	}

	public virtual Task CloseAsync()
	{
		return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((ICommunicationObject)(this)).EndClose));
	}
}
