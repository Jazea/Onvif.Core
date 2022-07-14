using Onvif.Core.Client.Common;
using DateTime = Onvif.Core.Client.Common.DateTime;
using TimeZone = Onvif.Core.Client.Common.TimeZone;

namespace Onvif.Core.Client.Device
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", ConfigurationName="Onvif.Core.Client.Device.Device")]
    public interface Device
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetServices", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetServicesResponse> GetServicesAsync(Onvif.Core.Client.Device.GetServicesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetServiceCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Capabilities")]
        System.Threading.Tasks.Task<DeviceServiceCapabilities> GetServiceCapabilitiesAsync();
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDeviceInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDeviceInformationResponse> GetDeviceInformationAsync(Onvif.Core.Client.Device.GetDeviceInformationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetSystemDateAndTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSystemDateAndTimeAsync(SetDateTimeType DateTimeType, bool DaylightSavings, TimeZone TimeZone, DateTime UTCDateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemDateAndTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SystemDateAndTime")]
        System.Threading.Tasks.Task<SystemDateTime> GetSystemDateAndTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetSystemFactoryDefault", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSystemFactoryDefaultAsync(FactoryDefaultType FactoryDefault);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/UpgradeSystemFirmware", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Message")]
        System.Threading.Tasks.Task<string> UpgradeSystemFirmwareAsync(AttachmentData Firmware);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SystemReboot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Message")]
        System.Threading.Tasks.Task<string> SystemRebootAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/RestoreSystem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.RestoreSystemResponse> RestoreSystemAsync(Onvif.Core.Client.Device.RestoreSystemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemBackup", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetSystemBackupResponse> GetSystemBackupAsync(Onvif.Core.Client.Device.GetSystemBackupRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SystemLog")]
        System.Threading.Tasks.Task<SystemLog> GetSystemLogAsync(SystemLogType LogType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemSupportInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SupportInformation")]
        System.Threading.Tasks.Task<SupportInformation> GetSystemSupportInformationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetScopesResponse> GetScopesAsync(Onvif.Core.Client.Device.GetScopesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetScopesResponse> SetScopesAsync(Onvif.Core.Client.Device.SetScopesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/AddScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.AddScopesResponse> AddScopesAsync(Onvif.Core.Client.Device.AddScopesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/RemoveScopes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.RemoveScopesResponse> RemoveScopesAsync(Onvif.Core.Client.Device.RemoveScopesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DiscoveryMode")]
        System.Threading.Tasks.Task<DiscoveryMode> GetDiscoveryModeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetDiscoveryModeAsync(DiscoveryMode DiscoveryMode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetRemoteDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RemoteDiscoveryMode")]
        System.Threading.Tasks.Task<DiscoveryMode> GetRemoteDiscoveryModeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRemoteDiscoveryMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRemoteDiscoveryModeAsync(DiscoveryMode RemoteDiscoveryMode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDPAddresses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDPAddressesResponse> GetDPAddressesAsync(Onvif.Core.Client.Device.GetDPAddressesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDPAddresses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDPAddressesResponse> SetDPAddressesAsync(Onvif.Core.Client.Device.SetDPAddressesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetEndpointReference", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetEndpointReferenceResponse> GetEndpointReferenceAsync(Onvif.Core.Client.Device.GetEndpointReferenceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetRemoteUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RemoteUser")]
        System.Threading.Tasks.Task<RemoteUser> GetRemoteUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRemoteUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRemoteUserAsync(RemoteUser RemoteUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetUsersResponse> GetUsersAsync(Onvif.Core.Client.Device.GetUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.CreateUsersResponse> CreateUsersAsync(Onvif.Core.Client.Device.CreateUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteUsersResponse> DeleteUsersAsync(Onvif.Core.Client.Device.DeleteUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetUserResponse> SetUserAsync(Onvif.Core.Client.Device.SetUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetWsdlUrl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetWsdlUrlResponse> GetWsdlUrlAsync(Onvif.Core.Client.Device.GetWsdlUrlRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCapabilitiesResponse> GetCapabilitiesAsync(Onvif.Core.Client.Device.GetCapabilitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetHostname", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="HostnameInformation")]
        System.Threading.Tasks.Task<HostnameInformation> GetHostnameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetHostname", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetHostnameResponse> SetHostnameAsync(Onvif.Core.Client.Device.SetHostnameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetHostnameFromDHCP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RebootNeeded")]
        System.Threading.Tasks.Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DNSInformation")]
        System.Threading.Tasks.Task<DNSInformation> GetDNSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDNSResponse> SetDNSAsync(Onvif.Core.Client.Device.SetDNSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNTP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="NTPInformation")]
        System.Threading.Tasks.Task<NTPInformation> GetNTPAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNTP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNTPResponse> SetNTPAsync(Onvif.Core.Client.Device.SetNTPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDynamicDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="DynamicDNSInformation")]
        System.Threading.Tasks.Task<DynamicDNSInformation> GetDynamicDNSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDynamicDNS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDynamicDNSResponse> SetDynamicDNSAsync(Onvif.Core.Client.Device.SetDynamicDNSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNetworkInterfaces", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetNetworkInterfacesResponse> GetNetworkInterfacesAsync(Onvif.Core.Client.Device.GetNetworkInterfacesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNetworkInterfaces", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RebootNeeded")]
        System.Threading.Tasks.Task<bool> SetNetworkInterfacesAsync(string InterfaceToken, NetworkInterfaceSetConfiguration NetworkInterface);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNetworkProtocols", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetNetworkProtocolsResponse> GetNetworkProtocolsAsync(Onvif.Core.Client.Device.GetNetworkProtocolsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNetworkProtocols", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(Onvif.Core.Client.Device.SetNetworkProtocolsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetNetworkDefaultGateway", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="NetworkGateway")]
        System.Threading.Tasks.Task<NetworkGateway> GetNetworkDefaultGatewayAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetNetworkDefaultGateway", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNetworkDefaultGatewayResponse> SetNetworkDefaultGatewayAsync(Onvif.Core.Client.Device.SetNetworkDefaultGatewayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetZeroConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ZeroConfiguration")]
        System.Threading.Tasks.Task<NetworkZeroConfiguration> GetZeroConfigurationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetZeroConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="IPAddressFilter")]
        System.Threading.Tasks.Task<IPAddressFilter> GetIPAddressFilterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetIPAddressFilterAsync(IPAddressFilter IPAddressFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/AddIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddIPAddressFilterAsync(IPAddressFilter IPAddressFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/RemoveIPAddressFilter", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveIPAddressFilterAsync(IPAddressFilter IPAddressFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetAccessPolicy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PolicyFile")]
        System.Threading.Tasks.Task<BinaryData> GetAccessPolicyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetAccessPolicy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAccessPolicyAsync(BinaryData PolicyFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateCertificate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.CreateCertificateResponse> CreateCertificateAsync(Onvif.Core.Client.Device.CreateCertificateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificatesResponse> GetCertificatesAsync(Onvif.Core.Client.Device.GetCertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCertificatesStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificatesStatusResponse> GetCertificatesStatusAsync(Onvif.Core.Client.Device.GetCertificatesStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetCertificatesStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetCertificatesStatusResponse> SetCertificatesStatusAsync(Onvif.Core.Client.Device.SetCertificatesStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteCertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteCertificatesResponse> DeleteCertificatesAsync(Onvif.Core.Client.Device.DeleteCertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetPkcs10Request", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetPkcs10RequestResponse> GetPkcs10RequestAsync(Onvif.Core.Client.Device.GetPkcs10RequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/LoadCertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCertificatesResponse> LoadCertificatesAsync(Onvif.Core.Client.Device.LoadCertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetClientCertificateMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Enabled")]
        System.Threading.Tasks.Task<bool> GetClientCertificateModeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetClientCertificateMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetClientCertificateModeAsync(bool Enabled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetRelayOutputs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetRelayOutputsResponse> GetRelayOutputsAsync(Onvif.Core.Client.Device.GetRelayOutputsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRelayOutputSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRelayOutputSettingsAsync(string RelayOutputToken, RelayOutputSettings Properties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetRelayOutputState", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetRelayOutputStateAsync(string RelayOutputToken, RelayLogicalState LogicalState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SendAuxiliaryCommand", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="AuxiliaryCommandResponse")]
        System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCACertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCACertificatesResponse> GetCACertificatesAsync(Onvif.Core.Client.Device.GetCACertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/LoadCertificateWithPrivateKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKeyAsync(Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetCertificateInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificateInformationResponse> GetCertificateInformationAsync(Onvif.Core.Client.Device.GetCertificateInformationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/LoadCACertificates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCACertificatesResponse> LoadCACertificatesAsync(Onvif.Core.Client.Device.LoadCACertificatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task CreateDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Dot1XConfiguration")]
        System.Threading.Tasks.Task<Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot1XConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDot1XConfigurationsResponse> GetDot1XConfigurationsAsync(Onvif.Core.Client.Device.GetDot1XConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteDot1XConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteDot1XConfigurationResponse> DeleteDot1XConfigurationAsync(Onvif.Core.Client.Device.DeleteDot1XConfigurationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot11Capabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDot11CapabilitiesResponse> GetDot11CapabilitiesAsync(Onvif.Core.Client.Device.GetDot11CapabilitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetDot11Status", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Status")]
        System.Threading.Tasks.Task<Dot11Status> GetDot11StatusAsync(string InterfaceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/ScanAvailableDot11Networks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.ScanAvailableDot11NetworksResponse> ScanAvailableDot11NetworksAsync(Onvif.Core.Client.Device.ScanAvailableDot11NetworksRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetSystemUris", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetSystemUrisResponse> GetSystemUrisAsync(Onvif.Core.Client.Device.GetSystemUrisRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/StartFirmwareUpgrade", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.StartFirmwareUpgradeResponse> StartFirmwareUpgradeAsync(Onvif.Core.Client.Device.StartFirmwareUpgradeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/StartSystemRestore", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.StartSystemRestoreResponse> StartSystemRestoreAsync(Onvif.Core.Client.Device.StartSystemRestoreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetStorageConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetStorageConfigurationsResponse> GetStorageConfigurationsAsync(Onvif.Core.Client.Device.GetStorageConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/CreateStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Token")]
        System.Threading.Tasks.Task<string> CreateStorageConfigurationAsync(StorageConfigurationData StorageConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="StorageConfiguration")]
        System.Threading.Tasks.Task<StorageConfiguration> GetStorageConfigurationAsync(string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetStorageConfigurationAsync(StorageConfiguration StorageConfiguration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteStorageConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task DeleteStorageConfigurationAsync(string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/GetGeoLocation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetGeoLocationResponse> GetGeoLocationAsync(Onvif.Core.Client.Device.GetGeoLocationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/SetGeoLocation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetGeoLocationResponse> SetGeoLocationAsync(Onvif.Core.Client.Device.SetGeoLocationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/device/wsdl/DeleteGeoLocation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteGeoLocationResponse> DeleteGeoLocationAsync(Onvif.Core.Client.Device.DeleteGeoLocationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServices", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetServicesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public bool IncludeCapability;
        
        public GetServicesRequest()
        {
        }
        
        public GetServicesRequest(bool IncludeCapability)
        {
            this.IncludeCapability = IncludeCapability;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetServicesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetServicesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDeviceInformation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDeviceInformationRequest
    {
        
        public GetDeviceInformationRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDeviceInformationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDeviceInformationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public string Manufacturer;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        public string Model;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        public string FirmwareVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=3)]
        public string SerialNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=4)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RestoreSystem", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RestoreSystemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RestoreSystemResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RestoreSystemResponse
    {
        
        public RestoreSystemResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemBackup", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemBackupRequest
    {
        
        public GetSystemBackupRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemBackupResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemBackupResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetScopesRequest
    {
        
        public GetScopesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetScopesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetScopesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Scopes", DataType="anyURI")]
        public string[] Scopes;
        
        public SetScopesRequest()
        {
        }
        
        public SetScopesRequest(string[] Scopes)
        {
            this.Scopes = Scopes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetScopesResponse
    {
        
        public SetScopesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class AddScopesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType="anyURI")]
        public string[] ScopeItem;
        
        public AddScopesRequest()
        {
        }
        
        public AddScopesRequest(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class AddScopesResponse
    {
        
        public AddScopesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveScopes", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RemoveScopesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType="anyURI")]
        public string[] ScopeItem;
        
        public RemoveScopesRequest()
        {
        }
        
        public RemoveScopesRequest(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveScopesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class RemoveScopesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ScopeItem", DataType="anyURI")]
        public string[] ScopeItem;
        
        public RemoveScopesResponse()
        {
        }
        
        public RemoveScopesResponse(string[] ScopeItem)
        {
            this.ScopeItem = ScopeItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDPAddresses", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDPAddressesRequest
    {
        
        public GetDPAddressesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDPAddressesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDPAddressesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDPAddresses", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDPAddressesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDPAddressesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDPAddressesResponse
    {
        
        public SetDPAddressesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEndpointReference", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetEndpointReferenceRequest
    {
        
        public GetEndpointReferenceRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEndpointReferenceResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetEndpointReferenceResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public string GUID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsers", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetUsersRequest
    {
        
        public GetUsersRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsersResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetUsersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUsers", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateUsersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateUsersResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateUsersResponse
    {
        
        public CreateUsersResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteUsers", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteUsersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteUsersResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteUsersResponse
    {
        
        public DeleteUsersResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetUser", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetUserResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetUserResponse
    {
        
        public SetUserResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWsdlUrl", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetWsdlUrlRequest
    {
        
        public GetWsdlUrlRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetWsdlUrlResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetWsdlUrlResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string WsdlUrl;
        
        public GetWsdlUrlResponse()
        {
        }
        
        public GetWsdlUrlResponse(string WsdlUrl)
        {
            this.WsdlUrl = WsdlUrl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCapabilities", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCapabilitiesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCapabilitiesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCapabilitiesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public Capabilities Capabilities;
        
        public GetCapabilitiesResponse()
        {
        }
        
        public GetCapabilitiesResponse(Capabilities Capabilities)
        {
            this.Capabilities = Capabilities;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetHostname", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetHostnameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string Name;
        
        public SetHostnameRequest()
        {
        }
        
        public SetHostnameRequest(string Name)
        {
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetHostnameResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetHostnameResponse
    {
        
        public SetHostnameResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDNS", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDNSRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public bool FromDHCP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("SearchDomain", DataType="token")]
        public string[] SearchDomain;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDNSResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDNSResponse
    {
        
        public SetDNSResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNTP", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNTPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public bool FromDHCP;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNTPResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNTPResponse
    {
        
        public SetNTPResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDynamicDNS", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDynamicDNSRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public DynamicDNSType Type;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string TTL;
        
        public SetDynamicDNSRequest()
        {
        }
        
        public SetDynamicDNSRequest(DynamicDNSType Type, string Name, string TTL)
        {
            this.Type = Type;
            this.Name = Name;
            this.TTL = TTL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetDynamicDNSResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetDynamicDNSResponse
    {
        
        public SetDynamicDNSResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkInterfaces", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkInterfacesRequest
    {
        
        public GetNetworkInterfacesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkInterfacesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkInterfacesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkProtocols", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkProtocolsRequest
    {
        
        public GetNetworkProtocolsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNetworkProtocolsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetNetworkProtocolsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkProtocols", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkProtocolsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkProtocolsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkProtocolsResponse
    {
        
        public SetNetworkProtocolsResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkDefaultGateway", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkDefaultGatewayRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("IPv4Address", DataType="token")]
        public string[] IPv4Address;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("IPv6Address", DataType="token")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetNetworkDefaultGatewayResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetNetworkDefaultGatewayResponse
    {
        
        public SetNetworkDefaultGatewayResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCertificate", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateCertificateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string CertificateID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        public string Subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        public System.DateTime ValidNotBefore;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=3)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateCertificateResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class CreateCertificateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public Certificate NvtCertificate;
        
        public CreateCertificateResponse()
        {
        }
        
        public CreateCertificateResponse(Certificate NvtCertificate)
        {
            this.NvtCertificate = NvtCertificate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesRequest
    {
        
        public GetCertificatesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificatesStatus", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesStatusRequest
    {
        
        public GetCertificatesStatusRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificatesStatusResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificatesStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCertificatesStatus", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetCertificatesStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetCertificatesStatusResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetCertificatesStatusResponse
    {
        
        public SetCertificatesStatusResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteCertificatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("CertificateID", DataType="token")]
        public string[] CertificateID;
        
        public DeleteCertificatesRequest()
        {
        }
        
        public DeleteCertificatesRequest(string[] CertificateID)
        {
            this.CertificateID = CertificateID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteCertificatesResponse
    {
        
        public DeleteCertificatesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPkcs10Request", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetPkcs10RequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string CertificateID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        public string Subject;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPkcs10RequestResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetPkcs10RequestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public BinaryData Pkcs10Request;
        
        public GetPkcs10RequestResponse()
        {
        }
        
        public GetPkcs10RequestResponse(BinaryData Pkcs10Request)
        {
            this.Pkcs10Request = Pkcs10Request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificatesResponse
    {
        
        public LoadCertificatesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRelayOutputs", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetRelayOutputsRequest
    {
        
        public GetRelayOutputsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRelayOutputsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetRelayOutputsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCACertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCACertificatesRequest
    {
        
        public GetCACertificatesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCACertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCACertificatesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificateWithPrivateKey", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificateWithPrivateKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCertificateWithPrivateKeyResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCertificateWithPrivateKeyResponse
    {
        
        public LoadCertificateWithPrivateKeyResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificateInformation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificateInformationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="token")]
        public string CertificateID;
        
        public GetCertificateInformationRequest()
        {
        }
        
        public GetCertificateInformationRequest(string CertificateID)
        {
            this.CertificateID = CertificateID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCertificateInformationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetCertificateInformationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public CertificateInformation CertificateInformation;
        
        public GetCertificateInformationResponse()
        {
        }
        
        public GetCertificateInformationResponse(CertificateInformation CertificateInformation)
        {
            this.CertificateInformation = CertificateInformation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCACertificates", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCACertificatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoadCACertificatesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class LoadCACertificatesResponse
    {
        
        public LoadCACertificatesResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot1XConfigurations", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot1XConfigurationsRequest
    {
        
        public GetDot1XConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot1XConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot1XConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteDot1XConfiguration", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteDot1XConfigurationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteDot1XConfigurationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteDot1XConfigurationResponse
    {
        
        public DeleteDot1XConfigurationResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot11Capabilities", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot11CapabilitiesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDot11CapabilitiesResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetDot11CapabilitiesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public Dot11Capabilities Capabilities;
        
        public GetDot11CapabilitiesResponse()
        {
        }
        
        public GetDot11CapabilitiesResponse(Dot11Capabilities Capabilities)
        {
            this.Capabilities = Capabilities;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ScanAvailableDot11Networks", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class ScanAvailableDot11NetworksRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        public string InterfaceToken;
        
        public ScanAvailableDot11NetworksRequest()
        {
        }
        
        public ScanAvailableDot11NetworksRequest(string InterfaceToken)
        {
            this.InterfaceToken = InterfaceToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ScanAvailableDot11NetworksResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class ScanAvailableDot11NetworksResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemUris", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemUrisRequest
    {
        
        public GetSystemUrisRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemUrisResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetSystemUrisResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SystemLog", Namespace="http://www.onvif.org/ver10/schema", IsNullable=false)]
        public SystemLogUri[] SystemLogUris;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string SupportInfoUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string SystemBackupUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=3)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartFirmwareUpgrade", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartFirmwareUpgradeRequest
    {
        
        public StartFirmwareUpgradeRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartFirmwareUpgradeResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartFirmwareUpgradeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string UploadUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string UploadDelay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string ExpectedDownTime;
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartSystemRestore", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartSystemRestoreRequest
    {
        
        public StartSystemRestoreRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartSystemRestoreResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class StartSystemRestoreResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string UploadUri;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string ExpectedDownTime;
        
        public StartSystemRestoreResponse()
        {
        }
        
        public StartSystemRestoreResponse(string UploadUri, string ExpectedDownTime)
        {
            this.UploadUri = UploadUri;
            this.ExpectedDownTime = ExpectedDownTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetStorageConfigurations", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetStorageConfigurationsRequest
    {
        
        public GetStorageConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetStorageConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetStorageConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGeoLocation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetGeoLocationRequest
    {
        
        public GetGeoLocationRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGeoLocationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class GetGeoLocationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetGeoLocation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetGeoLocationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetGeoLocationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class SetGeoLocationResponse
    {
        
        public SetGeoLocationResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteGeoLocation", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteGeoLocationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/device/wsdl", Order=0)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteGeoLocationResponse", WrapperNamespace="http://www.onvif.org/ver10/device/wsdl", IsWrapped=true)]
    public partial class DeleteGeoLocationResponse
    {
        
        public DeleteGeoLocationResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public interface DeviceChannel : Onvif.Core.Client.Device.Device, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public partial class DeviceClient : System.ServiceModel.ClientBase<Onvif.Core.Client.Device.Device>, Onvif.Core.Client.Device.Device
    {
        
        internal DeviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetServicesResponse> Onvif.Core.Client.Device.Device.GetServicesAsync(Onvif.Core.Client.Device.GetServicesRequest request)
        {
            return base.Channel.GetServicesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetServicesResponse> GetServicesAsync(bool IncludeCapability)
        {
            Onvif.Core.Client.Device.GetServicesRequest inValue = new Onvif.Core.Client.Device.GetServicesRequest();
            inValue.IncludeCapability = IncludeCapability;
            return ((Onvif.Core.Client.Device.Device)(this)).GetServicesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<DeviceServiceCapabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDeviceInformationResponse> GetDeviceInformationAsync(Onvif.Core.Client.Device.GetDeviceInformationRequest request)
        {
            return base.Channel.GetDeviceInformationAsync(request);
        }
        
        public System.Threading.Tasks.Task SetSystemDateAndTimeAsync(SetDateTimeType DateTimeType, bool DaylightSavings, TimeZone TimeZone, DateTime UTCDateTime)
        {
            return base.Channel.SetSystemDateAndTimeAsync(DateTimeType, DaylightSavings, TimeZone, UTCDateTime);
        }
        
        public System.Threading.Tasks.Task<SystemDateTime> GetSystemDateAndTimeAsync()
        {
            return base.Channel.GetSystemDateAndTimeAsync();
        }
        
        public System.Threading.Tasks.Task SetSystemFactoryDefaultAsync(FactoryDefaultType FactoryDefault)
        {
            return base.Channel.SetSystemFactoryDefaultAsync(FactoryDefault);
        }
        
        public System.Threading.Tasks.Task<string> UpgradeSystemFirmwareAsync(AttachmentData Firmware)
        {
            return base.Channel.UpgradeSystemFirmwareAsync(Firmware);
        }
        
        public System.Threading.Tasks.Task<string> SystemRebootAsync()
        {
            return base.Channel.SystemRebootAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.RestoreSystemResponse> Onvif.Core.Client.Device.Device.RestoreSystemAsync(Onvif.Core.Client.Device.RestoreSystemRequest request)
        {
            return base.Channel.RestoreSystemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.RestoreSystemResponse> RestoreSystemAsync(BackupFile[] BackupFiles)
        {
            Onvif.Core.Client.Device.RestoreSystemRequest inValue = new Onvif.Core.Client.Device.RestoreSystemRequest();
            inValue.BackupFiles = BackupFiles;
            return ((Onvif.Core.Client.Device.Device)(this)).RestoreSystemAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetSystemBackupResponse> Onvif.Core.Client.Device.Device.GetSystemBackupAsync(Onvif.Core.Client.Device.GetSystemBackupRequest request)
        {
            return base.Channel.GetSystemBackupAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetSystemBackupResponse> GetSystemBackupAsync()
        {
            Onvif.Core.Client.Device.GetSystemBackupRequest inValue = new Onvif.Core.Client.Device.GetSystemBackupRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetSystemBackupAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<SystemLog> GetSystemLogAsync(SystemLogType LogType)
        {
            return base.Channel.GetSystemLogAsync(LogType);
        }
        
        public System.Threading.Tasks.Task<SupportInformation> GetSystemSupportInformationAsync()
        {
            return base.Channel.GetSystemSupportInformationAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetScopesResponse> Onvif.Core.Client.Device.Device.GetScopesAsync(Onvif.Core.Client.Device.GetScopesRequest request)
        {
            return base.Channel.GetScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetScopesResponse> GetScopesAsync()
        {
            Onvif.Core.Client.Device.GetScopesRequest inValue = new Onvif.Core.Client.Device.GetScopesRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetScopesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetScopesResponse> Onvif.Core.Client.Device.Device.SetScopesAsync(Onvif.Core.Client.Device.SetScopesRequest request)
        {
            return base.Channel.SetScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetScopesResponse> SetScopesAsync(string[] Scopes)
        {
            Onvif.Core.Client.Device.SetScopesRequest inValue = new Onvif.Core.Client.Device.SetScopesRequest();
            inValue.Scopes = Scopes;
            return ((Onvif.Core.Client.Device.Device)(this)).SetScopesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.AddScopesResponse> Onvif.Core.Client.Device.Device.AddScopesAsync(Onvif.Core.Client.Device.AddScopesRequest request)
        {
            return base.Channel.AddScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.AddScopesResponse> AddScopesAsync(string[] ScopeItem)
        {
            Onvif.Core.Client.Device.AddScopesRequest inValue = new Onvif.Core.Client.Device.AddScopesRequest();
            inValue.ScopeItem = ScopeItem;
            return ((Onvif.Core.Client.Device.Device)(this)).AddScopesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.RemoveScopesResponse> RemoveScopesAsync(Onvif.Core.Client.Device.RemoveScopesRequest request)
        {
            return base.Channel.RemoveScopesAsync(request);
        }
        
        public System.Threading.Tasks.Task<DiscoveryMode> GetDiscoveryModeAsync()
        {
            return base.Channel.GetDiscoveryModeAsync();
        }
        
        public System.Threading.Tasks.Task SetDiscoveryModeAsync(DiscoveryMode DiscoveryMode)
        {
            return base.Channel.SetDiscoveryModeAsync(DiscoveryMode);
        }
        
        public System.Threading.Tasks.Task<DiscoveryMode> GetRemoteDiscoveryModeAsync()
        {
            return base.Channel.GetRemoteDiscoveryModeAsync();
        }
        
        public System.Threading.Tasks.Task SetRemoteDiscoveryModeAsync(DiscoveryMode RemoteDiscoveryMode)
        {
            return base.Channel.SetRemoteDiscoveryModeAsync(RemoteDiscoveryMode);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDPAddressesResponse> Onvif.Core.Client.Device.Device.GetDPAddressesAsync(Onvif.Core.Client.Device.GetDPAddressesRequest request)
        {
            return base.Channel.GetDPAddressesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDPAddressesResponse> GetDPAddressesAsync()
        {
            Onvif.Core.Client.Device.GetDPAddressesRequest inValue = new Onvif.Core.Client.Device.GetDPAddressesRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetDPAddressesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDPAddressesResponse> Onvif.Core.Client.Device.Device.SetDPAddressesAsync(Onvif.Core.Client.Device.SetDPAddressesRequest request)
        {
            return base.Channel.SetDPAddressesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDPAddressesResponse> SetDPAddressesAsync(NetworkHost[] DPAddress)
        {
            Onvif.Core.Client.Device.SetDPAddressesRequest inValue = new Onvif.Core.Client.Device.SetDPAddressesRequest();
            inValue.DPAddress = DPAddress;
            return ((Onvif.Core.Client.Device.Device)(this)).SetDPAddressesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetEndpointReferenceResponse> GetEndpointReferenceAsync(Onvif.Core.Client.Device.GetEndpointReferenceRequest request)
        {
            return base.Channel.GetEndpointReferenceAsync(request);
        }
        
        public System.Threading.Tasks.Task<RemoteUser> GetRemoteUserAsync()
        {
            return base.Channel.GetRemoteUserAsync();
        }
        
        public System.Threading.Tasks.Task SetRemoteUserAsync(RemoteUser RemoteUser)
        {
            return base.Channel.SetRemoteUserAsync(RemoteUser);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetUsersResponse> Onvif.Core.Client.Device.Device.GetUsersAsync(Onvif.Core.Client.Device.GetUsersRequest request)
        {
            return base.Channel.GetUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetUsersResponse> GetUsersAsync()
        {
            Onvif.Core.Client.Device.GetUsersRequest inValue = new Onvif.Core.Client.Device.GetUsersRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.CreateUsersResponse> Onvif.Core.Client.Device.Device.CreateUsersAsync(Onvif.Core.Client.Device.CreateUsersRequest request)
        {
            return base.Channel.CreateUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.CreateUsersResponse> CreateUsersAsync(User[] User)
        {
            Onvif.Core.Client.Device.CreateUsersRequest inValue = new Onvif.Core.Client.Device.CreateUsersRequest();
            inValue.User = User;
            return ((Onvif.Core.Client.Device.Device)(this)).CreateUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteUsersResponse> Onvif.Core.Client.Device.Device.DeleteUsersAsync(Onvif.Core.Client.Device.DeleteUsersRequest request)
        {
            return base.Channel.DeleteUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteUsersResponse> DeleteUsersAsync(string[] Username)
        {
            Onvif.Core.Client.Device.DeleteUsersRequest inValue = new Onvif.Core.Client.Device.DeleteUsersRequest();
            inValue.Username = Username;
            return ((Onvif.Core.Client.Device.Device)(this)).DeleteUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetUserResponse> Onvif.Core.Client.Device.Device.SetUserAsync(Onvif.Core.Client.Device.SetUserRequest request)
        {
            return base.Channel.SetUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetUserResponse> SetUserAsync(User[] User)
        {
            Onvif.Core.Client.Device.SetUserRequest inValue = new Onvif.Core.Client.Device.SetUserRequest();
            inValue.User = User;
            return ((Onvif.Core.Client.Device.Device)(this)).SetUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetWsdlUrlResponse> Onvif.Core.Client.Device.Device.GetWsdlUrlAsync(Onvif.Core.Client.Device.GetWsdlUrlRequest request)
        {
            return base.Channel.GetWsdlUrlAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetWsdlUrlResponse> GetWsdlUrlAsync()
        {
            Onvif.Core.Client.Device.GetWsdlUrlRequest inValue = new Onvif.Core.Client.Device.GetWsdlUrlRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetWsdlUrlAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCapabilitiesResponse> Onvif.Core.Client.Device.Device.GetCapabilitiesAsync(Onvif.Core.Client.Device.GetCapabilitiesRequest request)
        {
            return base.Channel.GetCapabilitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCapabilitiesResponse> GetCapabilitiesAsync(CapabilityCategory[] Category)
        {
            Onvif.Core.Client.Device.GetCapabilitiesRequest inValue = new Onvif.Core.Client.Device.GetCapabilitiesRequest();
            inValue.Category = Category;
            return ((Onvif.Core.Client.Device.Device)(this)).GetCapabilitiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<HostnameInformation> GetHostnameAsync()
        {
            return base.Channel.GetHostnameAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetHostnameResponse> Onvif.Core.Client.Device.Device.SetHostnameAsync(Onvif.Core.Client.Device.SetHostnameRequest request)
        {
            return base.Channel.SetHostnameAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetHostnameResponse> SetHostnameAsync(string Name)
        {
            Onvif.Core.Client.Device.SetHostnameRequest inValue = new Onvif.Core.Client.Device.SetHostnameRequest();
            inValue.Name = Name;
            return ((Onvif.Core.Client.Device.Device)(this)).SetHostnameAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> SetHostnameFromDHCPAsync(bool FromDHCP)
        {
            return base.Channel.SetHostnameFromDHCPAsync(FromDHCP);
        }
        
        public System.Threading.Tasks.Task<DNSInformation> GetDNSAsync()
        {
            return base.Channel.GetDNSAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDNSResponse> Onvif.Core.Client.Device.Device.SetDNSAsync(Onvif.Core.Client.Device.SetDNSRequest request)
        {
            return base.Channel.SetDNSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDNSResponse> SetDNSAsync(bool FromDHCP, string[] SearchDomain, IPAddress[] DNSManual)
        {
            Onvif.Core.Client.Device.SetDNSRequest inValue = new Onvif.Core.Client.Device.SetDNSRequest();
            inValue.FromDHCP = FromDHCP;
            inValue.SearchDomain = SearchDomain;
            inValue.DNSManual = DNSManual;
            return ((Onvif.Core.Client.Device.Device)(this)).SetDNSAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<NTPInformation> GetNTPAsync()
        {
            return base.Channel.GetNTPAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNTPResponse> Onvif.Core.Client.Device.Device.SetNTPAsync(Onvif.Core.Client.Device.SetNTPRequest request)
        {
            return base.Channel.SetNTPAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNTPResponse> SetNTPAsync(bool FromDHCP, NetworkHost[] NTPManual)
        {
            Onvif.Core.Client.Device.SetNTPRequest inValue = new Onvif.Core.Client.Device.SetNTPRequest();
            inValue.FromDHCP = FromDHCP;
            inValue.NTPManual = NTPManual;
            return ((Onvif.Core.Client.Device.Device)(this)).SetNTPAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<DynamicDNSInformation> GetDynamicDNSAsync()
        {
            return base.Channel.GetDynamicDNSAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDynamicDNSResponse> Onvif.Core.Client.Device.Device.SetDynamicDNSAsync(Onvif.Core.Client.Device.SetDynamicDNSRequest request)
        {
            return base.Channel.SetDynamicDNSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetDynamicDNSResponse> SetDynamicDNSAsync(DynamicDNSType Type, string Name, string TTL)
        {
            Onvif.Core.Client.Device.SetDynamicDNSRequest inValue = new Onvif.Core.Client.Device.SetDynamicDNSRequest();
            inValue.Type = Type;
            inValue.Name = Name;
            inValue.TTL = TTL;
            return ((Onvif.Core.Client.Device.Device)(this)).SetDynamicDNSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetNetworkInterfacesResponse> Onvif.Core.Client.Device.Device.GetNetworkInterfacesAsync(Onvif.Core.Client.Device.GetNetworkInterfacesRequest request)
        {
            return base.Channel.GetNetworkInterfacesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetNetworkInterfacesResponse> GetNetworkInterfacesAsync()
        {
            Onvif.Core.Client.Device.GetNetworkInterfacesRequest inValue = new Onvif.Core.Client.Device.GetNetworkInterfacesRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetNetworkInterfacesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> SetNetworkInterfacesAsync(string InterfaceToken, NetworkInterfaceSetConfiguration NetworkInterface)
        {
            return base.Channel.SetNetworkInterfacesAsync(InterfaceToken, NetworkInterface);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetNetworkProtocolsResponse> Onvif.Core.Client.Device.Device.GetNetworkProtocolsAsync(Onvif.Core.Client.Device.GetNetworkProtocolsRequest request)
        {
            return base.Channel.GetNetworkProtocolsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetNetworkProtocolsResponse> GetNetworkProtocolsAsync()
        {
            Onvif.Core.Client.Device.GetNetworkProtocolsRequest inValue = new Onvif.Core.Client.Device.GetNetworkProtocolsRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetNetworkProtocolsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNetworkProtocolsResponse> Onvif.Core.Client.Device.Device.SetNetworkProtocolsAsync(Onvif.Core.Client.Device.SetNetworkProtocolsRequest request)
        {
            return base.Channel.SetNetworkProtocolsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNetworkProtocolsResponse> SetNetworkProtocolsAsync(NetworkProtocol[] NetworkProtocols)
        {
            Onvif.Core.Client.Device.SetNetworkProtocolsRequest inValue = new Onvif.Core.Client.Device.SetNetworkProtocolsRequest();
            inValue.NetworkProtocols = NetworkProtocols;
            return ((Onvif.Core.Client.Device.Device)(this)).SetNetworkProtocolsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<NetworkGateway> GetNetworkDefaultGatewayAsync()
        {
            return base.Channel.GetNetworkDefaultGatewayAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNetworkDefaultGatewayResponse> Onvif.Core.Client.Device.Device.SetNetworkDefaultGatewayAsync(Onvif.Core.Client.Device.SetNetworkDefaultGatewayRequest request)
        {
            return base.Channel.SetNetworkDefaultGatewayAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetNetworkDefaultGatewayResponse> SetNetworkDefaultGatewayAsync(string[] IPv4Address, string[] IPv6Address)
        {
            Onvif.Core.Client.Device.SetNetworkDefaultGatewayRequest inValue = new Onvif.Core.Client.Device.SetNetworkDefaultGatewayRequest();
            inValue.IPv4Address = IPv4Address;
            inValue.IPv6Address = IPv6Address;
            return ((Onvif.Core.Client.Device.Device)(this)).SetNetworkDefaultGatewayAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<NetworkZeroConfiguration> GetZeroConfigurationAsync()
        {
            return base.Channel.GetZeroConfigurationAsync();
        }
        
        public System.Threading.Tasks.Task SetZeroConfigurationAsync(string InterfaceToken, bool Enabled)
        {
            return base.Channel.SetZeroConfigurationAsync(InterfaceToken, Enabled);
        }
        
        public System.Threading.Tasks.Task<IPAddressFilter> GetIPAddressFilterAsync()
        {
            return base.Channel.GetIPAddressFilterAsync();
        }
        
        public System.Threading.Tasks.Task SetIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
        {
            return base.Channel.SetIPAddressFilterAsync(IPAddressFilter);
        }
        
        public System.Threading.Tasks.Task AddIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
        {
            return base.Channel.AddIPAddressFilterAsync(IPAddressFilter);
        }
        
        public System.Threading.Tasks.Task RemoveIPAddressFilterAsync(IPAddressFilter IPAddressFilter)
        {
            return base.Channel.RemoveIPAddressFilterAsync(IPAddressFilter);
        }
        
        public System.Threading.Tasks.Task<BinaryData> GetAccessPolicyAsync()
        {
            return base.Channel.GetAccessPolicyAsync();
        }
        
        public System.Threading.Tasks.Task SetAccessPolicyAsync(BinaryData PolicyFile)
        {
            return base.Channel.SetAccessPolicyAsync(PolicyFile);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.CreateCertificateResponse> Onvif.Core.Client.Device.Device.CreateCertificateAsync(Onvif.Core.Client.Device.CreateCertificateRequest request)
        {
            return base.Channel.CreateCertificateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.CreateCertificateResponse> CreateCertificateAsync(string CertificateID, string Subject, System.DateTime ValidNotBefore, System.DateTime ValidNotAfter)
        {
            Onvif.Core.Client.Device.CreateCertificateRequest inValue = new Onvif.Core.Client.Device.CreateCertificateRequest();
            inValue.CertificateID = CertificateID;
            inValue.Subject = Subject;
            inValue.ValidNotBefore = ValidNotBefore;
            inValue.ValidNotAfter = ValidNotAfter;
            return ((Onvif.Core.Client.Device.Device)(this)).CreateCertificateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificatesResponse> Onvif.Core.Client.Device.Device.GetCertificatesAsync(Onvif.Core.Client.Device.GetCertificatesRequest request)
        {
            return base.Channel.GetCertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificatesResponse> GetCertificatesAsync()
        {
            Onvif.Core.Client.Device.GetCertificatesRequest inValue = new Onvif.Core.Client.Device.GetCertificatesRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetCertificatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificatesStatusResponse> Onvif.Core.Client.Device.Device.GetCertificatesStatusAsync(Onvif.Core.Client.Device.GetCertificatesStatusRequest request)
        {
            return base.Channel.GetCertificatesStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificatesStatusResponse> GetCertificatesStatusAsync()
        {
            Onvif.Core.Client.Device.GetCertificatesStatusRequest inValue = new Onvif.Core.Client.Device.GetCertificatesStatusRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetCertificatesStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetCertificatesStatusResponse> Onvif.Core.Client.Device.Device.SetCertificatesStatusAsync(Onvif.Core.Client.Device.SetCertificatesStatusRequest request)
        {
            return base.Channel.SetCertificatesStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetCertificatesStatusResponse> SetCertificatesStatusAsync(CertificateStatus[] CertificateStatus)
        {
            Onvif.Core.Client.Device.SetCertificatesStatusRequest inValue = new Onvif.Core.Client.Device.SetCertificatesStatusRequest();
            inValue.CertificateStatus = CertificateStatus;
            return ((Onvif.Core.Client.Device.Device)(this)).SetCertificatesStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteCertificatesResponse> Onvif.Core.Client.Device.Device.DeleteCertificatesAsync(Onvif.Core.Client.Device.DeleteCertificatesRequest request)
        {
            return base.Channel.DeleteCertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteCertificatesResponse> DeleteCertificatesAsync(string[] CertificateID)
        {
            Onvif.Core.Client.Device.DeleteCertificatesRequest inValue = new Onvif.Core.Client.Device.DeleteCertificatesRequest();
            inValue.CertificateID = CertificateID;
            return ((Onvif.Core.Client.Device.Device)(this)).DeleteCertificatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetPkcs10RequestResponse> Onvif.Core.Client.Device.Device.GetPkcs10RequestAsync(Onvif.Core.Client.Device.GetPkcs10RequestRequest request)
        {
            return base.Channel.GetPkcs10RequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetPkcs10RequestResponse> GetPkcs10RequestAsync(string CertificateID, string Subject, BinaryData Attributes)
        {
            Onvif.Core.Client.Device.GetPkcs10RequestRequest inValue = new Onvif.Core.Client.Device.GetPkcs10RequestRequest();
            inValue.CertificateID = CertificateID;
            inValue.Subject = Subject;
            inValue.Attributes = Attributes;
            return ((Onvif.Core.Client.Device.Device)(this)).GetPkcs10RequestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCertificatesResponse> Onvif.Core.Client.Device.Device.LoadCertificatesAsync(Onvif.Core.Client.Device.LoadCertificatesRequest request)
        {
            return base.Channel.LoadCertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCertificatesResponse> LoadCertificatesAsync(Certificate[] NVTCertificate)
        {
            Onvif.Core.Client.Device.LoadCertificatesRequest inValue = new Onvif.Core.Client.Device.LoadCertificatesRequest();
            inValue.NVTCertificate = NVTCertificate;
            return ((Onvif.Core.Client.Device.Device)(this)).LoadCertificatesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> GetClientCertificateModeAsync()
        {
            return base.Channel.GetClientCertificateModeAsync();
        }
        
        public System.Threading.Tasks.Task SetClientCertificateModeAsync(bool Enabled)
        {
            return base.Channel.SetClientCertificateModeAsync(Enabled);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetRelayOutputsResponse> Onvif.Core.Client.Device.Device.GetRelayOutputsAsync(Onvif.Core.Client.Device.GetRelayOutputsRequest request)
        {
            return base.Channel.GetRelayOutputsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetRelayOutputsResponse> GetRelayOutputsAsync()
        {
            Onvif.Core.Client.Device.GetRelayOutputsRequest inValue = new Onvif.Core.Client.Device.GetRelayOutputsRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetRelayOutputsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task SetRelayOutputSettingsAsync(string RelayOutputToken, RelayOutputSettings Properties)
        {
            return base.Channel.SetRelayOutputSettingsAsync(RelayOutputToken, Properties);
        }
        
        public System.Threading.Tasks.Task SetRelayOutputStateAsync(string RelayOutputToken, RelayLogicalState LogicalState)
        {
            return base.Channel.SetRelayOutputStateAsync(RelayOutputToken, LogicalState);
        }
        
        public System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string AuxiliaryCommand)
        {
            return base.Channel.SendAuxiliaryCommandAsync(AuxiliaryCommand);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCACertificatesResponse> Onvif.Core.Client.Device.Device.GetCACertificatesAsync(Onvif.Core.Client.Device.GetCACertificatesRequest request)
        {
            return base.Channel.GetCACertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCACertificatesResponse> GetCACertificatesAsync()
        {
            Onvif.Core.Client.Device.GetCACertificatesRequest inValue = new Onvif.Core.Client.Device.GetCACertificatesRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetCACertificatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyResponse> Onvif.Core.Client.Device.Device.LoadCertificateWithPrivateKeyAsync(Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyRequest request)
        {
            return base.Channel.LoadCertificateWithPrivateKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKeyAsync(CertificateWithPrivateKey[] CertificateWithPrivateKey)
        {
            Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyRequest inValue = new Onvif.Core.Client.Device.LoadCertificateWithPrivateKeyRequest();
            inValue.CertificateWithPrivateKey = CertificateWithPrivateKey;
            return ((Onvif.Core.Client.Device.Device)(this)).LoadCertificateWithPrivateKeyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificateInformationResponse> Onvif.Core.Client.Device.Device.GetCertificateInformationAsync(Onvif.Core.Client.Device.GetCertificateInformationRequest request)
        {
            return base.Channel.GetCertificateInformationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetCertificateInformationResponse> GetCertificateInformationAsync(string CertificateID)
        {
            Onvif.Core.Client.Device.GetCertificateInformationRequest inValue = new Onvif.Core.Client.Device.GetCertificateInformationRequest();
            inValue.CertificateID = CertificateID;
            return ((Onvif.Core.Client.Device.Device)(this)).GetCertificateInformationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCACertificatesResponse> Onvif.Core.Client.Device.Device.LoadCACertificatesAsync(Onvif.Core.Client.Device.LoadCACertificatesRequest request)
        {
            return base.Channel.LoadCACertificatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.LoadCACertificatesResponse> LoadCACertificatesAsync(Certificate[] CACertificate)
        {
            Onvif.Core.Client.Device.LoadCACertificatesRequest inValue = new Onvif.Core.Client.Device.LoadCACertificatesRequest();
            inValue.CACertificate = CACertificate;
            return ((Onvif.Core.Client.Device.Device)(this)).LoadCACertificatesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task CreateDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration)
        {
            return base.Channel.CreateDot1XConfigurationAsync(Dot1XConfiguration);
        }
        
        public System.Threading.Tasks.Task SetDot1XConfigurationAsync(Dot1XConfiguration Dot1XConfiguration)
        {
            return base.Channel.SetDot1XConfigurationAsync(Dot1XConfiguration);
        }
        
        public System.Threading.Tasks.Task<Dot1XConfiguration> GetDot1XConfigurationAsync(string Dot1XConfigurationToken)
        {
            return base.Channel.GetDot1XConfigurationAsync(Dot1XConfigurationToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDot1XConfigurationsResponse> Onvif.Core.Client.Device.Device.GetDot1XConfigurationsAsync(Onvif.Core.Client.Device.GetDot1XConfigurationsRequest request)
        {
            return base.Channel.GetDot1XConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDot1XConfigurationsResponse> GetDot1XConfigurationsAsync()
        {
            Onvif.Core.Client.Device.GetDot1XConfigurationsRequest inValue = new Onvif.Core.Client.Device.GetDot1XConfigurationsRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetDot1XConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteDot1XConfigurationResponse> Onvif.Core.Client.Device.Device.DeleteDot1XConfigurationAsync(Onvif.Core.Client.Device.DeleteDot1XConfigurationRequest request)
        {
            return base.Channel.DeleteDot1XConfigurationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteDot1XConfigurationResponse> DeleteDot1XConfigurationAsync(string[] Dot1XConfigurationToken)
        {
            Onvif.Core.Client.Device.DeleteDot1XConfigurationRequest inValue = new Onvif.Core.Client.Device.DeleteDot1XConfigurationRequest();
            inValue.Dot1XConfigurationToken = Dot1XConfigurationToken;
            return ((Onvif.Core.Client.Device.Device)(this)).DeleteDot1XConfigurationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDot11CapabilitiesResponse> Onvif.Core.Client.Device.Device.GetDot11CapabilitiesAsync(Onvif.Core.Client.Device.GetDot11CapabilitiesRequest request)
        {
            return base.Channel.GetDot11CapabilitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetDot11CapabilitiesResponse> GetDot11CapabilitiesAsync(System.Xml.Linq.XElement[] Any)
        {
            Onvif.Core.Client.Device.GetDot11CapabilitiesRequest inValue = new Onvif.Core.Client.Device.GetDot11CapabilitiesRequest();
            inValue.Any = Any;
            return ((Onvif.Core.Client.Device.Device)(this)).GetDot11CapabilitiesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Dot11Status> GetDot11StatusAsync(string InterfaceToken)
        {
            return base.Channel.GetDot11StatusAsync(InterfaceToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.ScanAvailableDot11NetworksResponse> Onvif.Core.Client.Device.Device.ScanAvailableDot11NetworksAsync(Onvif.Core.Client.Device.ScanAvailableDot11NetworksRequest request)
        {
            return base.Channel.ScanAvailableDot11NetworksAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.ScanAvailableDot11NetworksResponse> ScanAvailableDot11NetworksAsync(string InterfaceToken)
        {
            Onvif.Core.Client.Device.ScanAvailableDot11NetworksRequest inValue = new Onvif.Core.Client.Device.ScanAvailableDot11NetworksRequest();
            inValue.InterfaceToken = InterfaceToken;
            return ((Onvif.Core.Client.Device.Device)(this)).ScanAvailableDot11NetworksAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetSystemUrisResponse> GetSystemUrisAsync(Onvif.Core.Client.Device.GetSystemUrisRequest request)
        {
            return base.Channel.GetSystemUrisAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.StartFirmwareUpgradeResponse> StartFirmwareUpgradeAsync(Onvif.Core.Client.Device.StartFirmwareUpgradeRequest request)
        {
            return base.Channel.StartFirmwareUpgradeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.StartSystemRestoreResponse> StartSystemRestoreAsync(Onvif.Core.Client.Device.StartSystemRestoreRequest request)
        {
            return base.Channel.StartSystemRestoreAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetStorageConfigurationsResponse> Onvif.Core.Client.Device.Device.GetStorageConfigurationsAsync(Onvif.Core.Client.Device.GetStorageConfigurationsRequest request)
        {
            return base.Channel.GetStorageConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetStorageConfigurationsResponse> GetStorageConfigurationsAsync()
        {
            Onvif.Core.Client.Device.GetStorageConfigurationsRequest inValue = new Onvif.Core.Client.Device.GetStorageConfigurationsRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetStorageConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<string> CreateStorageConfigurationAsync(StorageConfigurationData StorageConfiguration)
        {
            return base.Channel.CreateStorageConfigurationAsync(StorageConfiguration);
        }
        
        public System.Threading.Tasks.Task<StorageConfiguration> GetStorageConfigurationAsync(string Token)
        {
            return base.Channel.GetStorageConfigurationAsync(Token);
        }
        
        public System.Threading.Tasks.Task SetStorageConfigurationAsync(StorageConfiguration StorageConfiguration)
        {
            return base.Channel.SetStorageConfigurationAsync(StorageConfiguration);
        }
        
        public System.Threading.Tasks.Task DeleteStorageConfigurationAsync(string Token)
        {
            return base.Channel.DeleteStorageConfigurationAsync(Token);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetGeoLocationResponse> Onvif.Core.Client.Device.Device.GetGeoLocationAsync(Onvif.Core.Client.Device.GetGeoLocationRequest request)
        {
            return base.Channel.GetGeoLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.GetGeoLocationResponse> GetGeoLocationAsync()
        {
            Onvif.Core.Client.Device.GetGeoLocationRequest inValue = new Onvif.Core.Client.Device.GetGeoLocationRequest();
            return ((Onvif.Core.Client.Device.Device)(this)).GetGeoLocationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetGeoLocationResponse> Onvif.Core.Client.Device.Device.SetGeoLocationAsync(Onvif.Core.Client.Device.SetGeoLocationRequest request)
        {
            return base.Channel.SetGeoLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.SetGeoLocationResponse> SetGeoLocationAsync(LocationEntity[] Location)
        {
            Onvif.Core.Client.Device.SetGeoLocationRequest inValue = new Onvif.Core.Client.Device.SetGeoLocationRequest();
            inValue.Location = Location;
            return ((Onvif.Core.Client.Device.Device)(this)).SetGeoLocationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteGeoLocationResponse> Onvif.Core.Client.Device.Device.DeleteGeoLocationAsync(Onvif.Core.Client.Device.DeleteGeoLocationRequest request)
        {
            return base.Channel.DeleteGeoLocationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Device.DeleteGeoLocationResponse> DeleteGeoLocationAsync(LocationEntity[] Location)
        {
            Onvif.Core.Client.Device.DeleteGeoLocationRequest inValue = new Onvif.Core.Client.Device.DeleteGeoLocationRequest();
            inValue.Location = Location;
            return ((Onvif.Core.Client.Device.Device)(this)).DeleteGeoLocationAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
