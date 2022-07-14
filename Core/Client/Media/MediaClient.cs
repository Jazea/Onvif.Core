using Onvif.Core.Client.Common;

namespace Onvif.Core.Client.Media
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", ConfigurationName="Onvif.Core.Client.Media.Media")]
    public interface Media
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetServiceCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Capabilities")]
        System.Threading.Tasks.Task<Capabilities> GetServiceCapabilitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetVideoSources/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourcesResponse> GetVideoSourcesAsync(Onvif.Core.Client.Media.GetVideoSourcesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioSources", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioSourcesResponse> GetAudioSourcesAsync(Onvif.Core.Client.Media.GetAudioSourcesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioOutputsResponse> GetAudioOutputsAsync(Onvif.Core.Client.Media.GetAudioOutputsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/CreateProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Profile")]
        System.Threading.Tasks.Task<Profile> CreateProfileAsync(string Name, string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetProfile/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Profile")]
        System.Threading.Tasks.Task<Profile> GetProfileAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetProfiles", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<GetProfilesResponse> GetProfilesAsync(GetProfilesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveVideoEncoderConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveVideoSourceConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioEncoderConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioSourceConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddPTZConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemovePTZConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemovePTZConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveMetadataConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioOutputConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/AddAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/RemoveAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemoveAudioDecoderConfigurationAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/DeleteProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task DeleteProfileAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoSourceConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync(Onvif.Core.Client.Media.GetVideoSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetVideoEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetAudioSourceConfigurations/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync(Onvif.Core.Client.Media.GetAudioSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetAudioEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoAnalyticsConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync(Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetMetadataConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync(Onvif.Core.Client.Media.GetMetadataConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync(Onvif.Core.Client.Media.GetAudioOutputConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync(Onvif.Core.Client.Media.GetAudioDecoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Configuration")]
        System.Threading.Tasks.Task<AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoSourceConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioEncoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioSourceConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoAnalyticsConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleMetadataConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioOutputConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioDecoderConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetVideoSourceConfigurationAsync(VideoSourceConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetVideoEncoderConfigurationAsync(VideoEncoderConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioSourceConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioSourceConfigurationAsync(AudioSourceConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioEncoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioEncoderConfigurationAsync(AudioEncoderConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoAnalyticsConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetVideoAnalyticsConfigurationAsync(VideoAnalyticsConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetMetadataConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetMetadataConfigurationAsync(MetadataConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioOutputConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioOutputConfigurationAsync(AudioOutputConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetAudioDecoderConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetAudioDecoderConfigurationAsync(AudioDecoderConfiguration Configuration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdlGetVideoSourceConfigurationOptions/", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioSourceConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetMetadataConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetGuaranteedNumberOfVideoEncoderInstances", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(Onvif.Core.Client.Media.GetGuaranteedNumberOfVideoEncoderInstancesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetStreamUri", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MediaUri")]
        System.Threading.Tasks.Task<MediaUri> GetStreamUriAsync(StreamSetup StreamSetup, string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/StartMulticastStreaming", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task StartMulticastStreamingAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/StopMulticastStreaming", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task StopMulticastStreamingAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetSynchronizationPoint", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetSynchronizationPointAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetSnapshotUri", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MediaUri")]
        System.Threading.Tasks.Task<MediaUri> GetSnapshotUriAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetVideoSourceModes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourceModesResponse> GetVideoSourceModesAsync(Onvif.Core.Client.Media.GetVideoSourceModesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetVideoSourceMode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Reboot")]
        System.Threading.Tasks.Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetOSDs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDsResponse> GetOSDsAsync(Onvif.Core.Client.Media.GetOSDsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDResponse> GetOSDAsync(Onvif.Core.Client.Media.GetOSDRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/GetOSDOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDOptionsResponse> GetOSDOptionsAsync(Onvif.Core.Client.Media.GetOSDOptionsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/SetOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.SetOSDResponse> SetOSDAsync(Onvif.Core.Client.Media.SetOSDRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/CreateOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.CreateOSDResponse> CreateOSDAsync(Onvif.Core.Client.Media.CreateOSDRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver10/media/wsdl/DeleteOSD", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.DeleteOSDResponse> DeleteOSDAsync(Onvif.Core.Client.Media.DeleteOSDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSources", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourcesRequest
    {
        
        public GetVideoSourcesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourcesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourcesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("VideoSources")]
        public VideoSource[] VideoSources;
        
        public GetVideoSourcesResponse()
        {
        }
        
        public GetVideoSourcesResponse(VideoSource[] VideoSources)
        {
            this.VideoSources = VideoSources;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSources", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourcesRequest
    {
        
        public GetAudioSourcesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSourcesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourcesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AudioSources")]
        public AudioSource[] AudioSources;
        
        public GetAudioSourcesResponse()
        {
        }
        
        public GetAudioSourcesResponse(AudioSource[] AudioSources)
        {
            this.AudioSources = AudioSources;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputs", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputsRequest
    {
        
        public GetAudioOutputsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AudioOutputs")]
        public AudioOutput[] AudioOutputs;
        
        public GetAudioOutputsResponse()
        {
        }
        
        public GetAudioOutputsResponse(AudioOutput[] AudioOutputs)
        {
            this.AudioOutputs = AudioOutputs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProfiles", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetProfilesRequest
    {
        
        public GetProfilesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProfilesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetProfilesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Profiles")]
        public Profile[] Profiles;
        
        public GetProfilesResponse()
        {
        }
        
        public GetProfilesResponse(Profile[] Profiles)
        {
            this.Profiles = Profiles;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceConfigurationsRequest
    {
        
        public GetVideoSourceConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public VideoSourceConfiguration[] Configurations;
        
        public GetVideoSourceConfigurationsResponse()
        {
        }
        
        public GetVideoSourceConfigurationsResponse(VideoSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoEncoderConfigurationsRequest
    {
        
        public GetVideoEncoderConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public VideoEncoderConfiguration[] Configurations;
        
        public GetVideoEncoderConfigurationsResponse()
        {
        }
        
        public GetVideoEncoderConfigurationsResponse(VideoEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourceConfigurationsRequest
    {
        
        public GetAudioSourceConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioSourceConfiguration[] Configurations;
        
        public GetAudioSourceConfigurationsResponse()
        {
        }
        
        public GetAudioSourceConfigurationsResponse(AudioSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioEncoderConfigurationsRequest
    {
        
        public GetAudioEncoderConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioEncoderConfiguration[] Configurations;
        
        public GetAudioEncoderConfigurationsResponse()
        {
        }
        
        public GetAudioEncoderConfigurationsResponse(AudioEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoAnalyticsConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoAnalyticsConfigurationsRequest
    {
        
        public GetVideoAnalyticsConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoAnalyticsConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoAnalyticsConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public VideoAnalyticsConfiguration[] Configurations;
        
        public GetVideoAnalyticsConfigurationsResponse()
        {
        }
        
        public GetVideoAnalyticsConfigurationsResponse(VideoAnalyticsConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetadataConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetMetadataConfigurationsRequest
    {
        
        public GetMetadataConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetadataConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetMetadataConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public MetadataConfiguration[] Configurations;
        
        public GetMetadataConfigurationsResponse()
        {
        }
        
        public GetMetadataConfigurationsResponse(MetadataConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputConfigurationsRequest
    {
        
        public GetAudioOutputConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioOutputConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioOutputConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioOutputConfiguration[] Configurations;
        
        public GetAudioOutputConfigurationsResponse()
        {
        }
        
        public GetAudioOutputConfigurationsResponse(AudioOutputConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioDecoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioDecoderConfigurationsRequest
    {
        
        public GetAudioDecoderConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAudioDecoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetAudioDecoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioDecoderConfiguration[] Configurations;
        
        public GetAudioDecoderConfigurationsResponse()
        {
        }
        
        public GetAudioDecoderConfigurationsResponse(AudioDecoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoEncoderConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleVideoEncoderConfigurationsRequest()
        {
        }
        
        public GetCompatibleVideoEncoderConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public VideoEncoderConfiguration[] Configurations;
        
        public GetCompatibleVideoEncoderConfigurationsResponse()
        {
        }
        
        public GetCompatibleVideoEncoderConfigurationsResponse(VideoEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoSourceConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleVideoSourceConfigurationsRequest()
        {
        }
        
        public GetCompatibleVideoSourceConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public VideoSourceConfiguration[] Configurations;
        
        public GetCompatibleVideoSourceConfigurationsResponse()
        {
        }
        
        public GetCompatibleVideoSourceConfigurationsResponse(VideoSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioEncoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioEncoderConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioEncoderConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioEncoderConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioEncoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioEncoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioEncoderConfiguration[] Configurations;
        
        public GetCompatibleAudioEncoderConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioEncoderConfigurationsResponse(AudioEncoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioSourceConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioSourceConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioSourceConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioSourceConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioSourceConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioSourceConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioSourceConfiguration[] Configurations;
        
        public GetCompatibleAudioSourceConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioSourceConfigurationsResponse(AudioSourceConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoAnalyticsConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoAnalyticsConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleVideoAnalyticsConfigurationsRequest()
        {
        }
        
        public GetCompatibleVideoAnalyticsConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleVideoAnalyticsConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleVideoAnalyticsConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public VideoAnalyticsConfiguration[] Configurations;
        
        public GetCompatibleVideoAnalyticsConfigurationsResponse()
        {
        }
        
        public GetCompatibleVideoAnalyticsConfigurationsResponse(VideoAnalyticsConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleMetadataConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleMetadataConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleMetadataConfigurationsRequest()
        {
        }
        
        public GetCompatibleMetadataConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleMetadataConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleMetadataConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public MetadataConfiguration[] Configurations;
        
        public GetCompatibleMetadataConfigurationsResponse()
        {
        }
        
        public GetCompatibleMetadataConfigurationsResponse(MetadataConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioOutputConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioOutputConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioOutputConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioOutputConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioOutputConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioOutputConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioOutputConfiguration[] Configurations;
        
        public GetCompatibleAudioOutputConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioOutputConfigurationsResponse(AudioOutputConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioDecoderConfigurations", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioDecoderConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleAudioDecoderConfigurationsRequest()
        {
        }
        
        public GetCompatibleAudioDecoderConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleAudioDecoderConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetCompatibleAudioDecoderConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Configurations")]
        public AudioDecoderConfiguration[] Configurations;
        
        public GetCompatibleAudioDecoderConfigurationsResponse()
        {
        }
        
        public GetCompatibleAudioDecoderConfigurationsResponse(AudioDecoderConfiguration[] Configurations)
        {
            this.Configurations = Configurations;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGuaranteedNumberOfVideoEncoderInstances", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetGuaranteedNumberOfVideoEncoderInstancesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ConfigurationToken;
        
        public GetGuaranteedNumberOfVideoEncoderInstancesRequest()
        {
        }
        
        public GetGuaranteedNumberOfVideoEncoderInstancesRequest(string ConfigurationToken)
        {
            this.ConfigurationToken = ConfigurationToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGuaranteedNumberOfVideoEncoderInstancesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetGuaranteedNumberOfVideoEncoderInstancesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public int TotalNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=1)]
        public int JPEG;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=2)]
        public int H264;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=3)]
        public int MPEG4;
        
        public GetGuaranteedNumberOfVideoEncoderInstancesResponse()
        {
        }
        
        public GetGuaranteedNumberOfVideoEncoderInstancesResponse(int TotalNumber, int JPEG, int H264, int MPEG4)
        {
            this.TotalNumber = TotalNumber;
            this.JPEG = JPEG;
            this.H264 = H264;
            this.MPEG4 = MPEG4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceModes", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceModesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string VideoSourceToken;
        
        public GetVideoSourceModesRequest()
        {
        }
        
        public GetVideoSourceModesRequest(string VideoSourceToken)
        {
            this.VideoSourceToken = VideoSourceToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetVideoSourceModesResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetVideoSourceModesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("VideoSourceModes")]
        public VideoSourceMode[] VideoSourceModes;
        
        public GetVideoSourceModesResponse()
        {
        }
        
        public GetVideoSourceModesResponse(VideoSourceMode[] VideoSourceModes)
        {
            this.VideoSourceModes = VideoSourceModes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDs", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ConfigurationToken;
        
        public GetOSDsRequest()
        {
        }
        
        public GetOSDsRequest(string ConfigurationToken)
        {
            this.ConfigurationToken = ConfigurationToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("OSDs")]
        public OSDConfiguration[] OSDs;
        
        public GetOSDsResponse()
        {
        }
        
        public GetOSDsResponse(OSDConfiguration[] OSDs)
        {
            this.OSDs = OSDs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string OSDToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDRequest()
        {
        }
        
        public GetOSDRequest(string OSDToken, System.Xml.Linq.XElement[] Any)
        {
            this.OSDToken = OSDToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public OSDConfiguration OSD;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDResponse()
        {
        }
        
        public GetOSDResponse(OSDConfiguration OSD, System.Xml.Linq.XElement[] Any)
        {
            this.OSD = OSD;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDOptions", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDOptionsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string ConfigurationToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDOptionsRequest()
        {
        }
        
        public GetOSDOptionsRequest(string ConfigurationToken, System.Xml.Linq.XElement[] Any)
        {
            this.ConfigurationToken = ConfigurationToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetOSDOptionsResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class GetOSDOptionsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public OSDConfigurationOptions OSDOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public GetOSDOptionsResponse()
        {
        }
        
        public GetOSDOptionsResponse(OSDConfigurationOptions OSDOptions, System.Xml.Linq.XElement[] Any)
        {
            this.OSDOptions = OSDOptions;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class SetOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public OSDConfiguration OSD;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public SetOSDRequest()
        {
        }
        
        public SetOSDRequest(OSDConfiguration OSD, System.Xml.Linq.XElement[] Any)
        {
            this.OSD = OSD;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class SetOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public SetOSDResponse()
        {
        }
        
        public SetOSDResponse(System.Xml.Linq.XElement[] Any)
        {
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class CreateOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public OSDConfiguration OSD;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public CreateOSDRequest()
        {
        }
        
        public CreateOSDRequest(OSDConfiguration OSD, System.Xml.Linq.XElement[] Any)
        {
            this.OSD = OSD;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class CreateOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string OSDToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public CreateOSDResponse()
        {
        }
        
        public CreateOSDResponse(string OSDToken, System.Xml.Linq.XElement[] Any)
        {
            this.OSDToken = OSDToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteOSD", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class DeleteOSDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver10/media/wsdl", Order=0)]
        public string OSDToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public DeleteOSDRequest()
        {
        }
        
        public DeleteOSDRequest(string OSDToken, System.Xml.Linq.XElement[] Any)
        {
            this.OSDToken = OSDToken;
            this.Any = Any;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteOSDResponse", WrapperNamespace="http://www.onvif.org/ver10/media/wsdl", IsWrapped=true)]
    public partial class DeleteOSDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any;
        
        public DeleteOSDResponse()
        {
        }
        
        public DeleteOSDResponse(System.Xml.Linq.XElement[] Any)
        {
            this.Any = Any;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public interface MediaChannel : Onvif.Core.Client.Media.Media, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public partial class MediaClient : System.ServiceModel.ClientBase<Onvif.Core.Client.Media.Media>, Onvif.Core.Client.Media.Media
    {
        
        internal MediaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Capabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourcesResponse> Onvif.Core.Client.Media.Media.GetVideoSourcesAsync(Onvif.Core.Client.Media.GetVideoSourcesRequest request)
        {
            return base.Channel.GetVideoSourcesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourcesResponse> GetVideoSourcesAsync()
        {
            Onvif.Core.Client.Media.GetVideoSourcesRequest inValue = new Onvif.Core.Client.Media.GetVideoSourcesRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetVideoSourcesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioSourcesResponse> Onvif.Core.Client.Media.Media.GetAudioSourcesAsync(Onvif.Core.Client.Media.GetAudioSourcesRequest request)
        {
            return base.Channel.GetAudioSourcesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioSourcesResponse> GetAudioSourcesAsync()
        {
            Onvif.Core.Client.Media.GetAudioSourcesRequest inValue = new Onvif.Core.Client.Media.GetAudioSourcesRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetAudioSourcesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioOutputsResponse> Onvif.Core.Client.Media.Media.GetAudioOutputsAsync(Onvif.Core.Client.Media.GetAudioOutputsRequest request)
        {
            return base.Channel.GetAudioOutputsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioOutputsResponse> GetAudioOutputsAsync()
        {
            Onvif.Core.Client.Media.GetAudioOutputsRequest inValue = new Onvif.Core.Client.Media.GetAudioOutputsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetAudioOutputsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Profile> CreateProfileAsync(string Name, string Token)
        {
            return base.Channel.CreateProfileAsync(Name, Token);
        }
        
        public System.Threading.Tasks.Task<Profile> GetProfileAsync(string ProfileToken)
        {
            return base.Channel.GetProfileAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetProfilesResponse> Onvif.Core.Client.Media.Media.GetProfilesAsync(GetProfilesRequest request)
        {
            return Channel.GetProfilesAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetProfilesResponse> GetProfilesAsync()
        {
            GetProfilesRequest inValue = new GetProfilesRequest();
            return ((Media)(this)).GetProfilesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddVideoEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveVideoEncoderConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveVideoEncoderConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddVideoSourceConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveVideoSourceConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveVideoSourceConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioEncoderConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioEncoderConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioSourceConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioSourceConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioSourceConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddPTZConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemovePTZConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemovePTZConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddVideoAnalyticsConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveVideoAnalyticsConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddMetadataConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveMetadataConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveMetadataConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioOutputConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioOutputConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioOutputConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
        {
            return base.Channel.AddAudioDecoderConfigurationAsync(ProfileToken, ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task RemoveAudioDecoderConfigurationAsync(string ProfileToken)
        {
            return base.Channel.RemoveAudioDecoderConfigurationAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task DeleteProfileAsync(string ProfileToken)
        {
            return base.Channel.DeleteProfileAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourceConfigurationsResponse> Onvif.Core.Client.Media.Media.GetVideoSourceConfigurationsAsync(Onvif.Core.Client.Media.GetVideoSourceConfigurationsRequest request)
        {
            return base.Channel.GetVideoSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetVideoSourceConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetVideoSourceConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetVideoSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoEncoderConfigurationsResponse> Onvif.Core.Client.Media.Media.GetVideoEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetVideoEncoderConfigurationsRequest request)
        {
            return base.Channel.GetVideoEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetVideoEncoderConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetVideoEncoderConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetVideoEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioSourceConfigurationsResponse> Onvif.Core.Client.Media.Media.GetAudioSourceConfigurationsAsync(Onvif.Core.Client.Media.GetAudioSourceConfigurationsRequest request)
        {
            return base.Channel.GetAudioSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetAudioSourceConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetAudioSourceConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetAudioSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioEncoderConfigurationsResponse> Onvif.Core.Client.Media.Media.GetAudioEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetAudioEncoderConfigurationsRequest request)
        {
            return base.Channel.GetAudioEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetAudioEncoderConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetAudioEncoderConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetAudioEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsResponse> Onvif.Core.Client.Media.Media.GetVideoAnalyticsConfigurationsAsync(Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsRequest request)
        {
            return base.Channel.GetVideoAnalyticsConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetVideoAnalyticsConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetVideoAnalyticsConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetMetadataConfigurationsResponse> Onvif.Core.Client.Media.Media.GetMetadataConfigurationsAsync(Onvif.Core.Client.Media.GetMetadataConfigurationsRequest request)
        {
            return base.Channel.GetMetadataConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetMetadataConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetMetadataConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetMetadataConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioOutputConfigurationsResponse> Onvif.Core.Client.Media.Media.GetAudioOutputConfigurationsAsync(Onvif.Core.Client.Media.GetAudioOutputConfigurationsRequest request)
        {
            return base.Channel.GetAudioOutputConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetAudioOutputConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetAudioOutputConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetAudioOutputConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioDecoderConfigurationsResponse> Onvif.Core.Client.Media.Media.GetAudioDecoderConfigurationsAsync(Onvif.Core.Client.Media.GetAudioDecoderConfigurationsRequest request)
        {
            return base.Channel.GetAudioDecoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync()
        {
            Onvif.Core.Client.Media.GetAudioDecoderConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetAudioDecoderConfigurationsRequest();
            return ((Onvif.Core.Client.Media.Media)(this)).GetAudioDecoderConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetVideoSourceConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetVideoEncoderConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioSourceConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioEncoderConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetVideoAnalyticsConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetMetadataConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioOutputConfigurationAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken)
        {
            return base.Channel.GetAudioDecoderConfigurationAsync(ConfigurationToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleVideoEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleVideoEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleVideoEncoderConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleVideoEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleVideoSourceConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleVideoSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleVideoSourceConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleVideoSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleAudioEncoderConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioEncoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleAudioEncoderConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleAudioEncoderConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleAudioSourceConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioSourceConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleAudioSourceConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleAudioSourceConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleVideoAnalyticsConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleVideoAnalyticsConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleVideoAnalyticsConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleVideoAnalyticsConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleMetadataConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleMetadataConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleMetadataConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleMetadataConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleAudioOutputConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioOutputConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleAudioOutputConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleAudioOutputConfigurationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsResponse> Onvif.Core.Client.Media.Media.GetCompatibleAudioDecoderConfigurationsAsync(Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleAudioDecoderConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsRequest inValue = new Onvif.Core.Client.Media.GetCompatibleAudioDecoderConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetCompatibleAudioDecoderConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task SetVideoSourceConfigurationAsync(VideoSourceConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetVideoSourceConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetVideoEncoderConfigurationAsync(VideoEncoderConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetVideoEncoderConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioSourceConfigurationAsync(AudioSourceConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioSourceConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioEncoderConfigurationAsync(AudioEncoderConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioEncoderConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetVideoAnalyticsConfigurationAsync(VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetVideoAnalyticsConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetMetadataConfigurationAsync(MetadataConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetMetadataConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioOutputConfigurationAsync(AudioOutputConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioOutputConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task SetAudioDecoderConfigurationAsync(AudioDecoderConfiguration Configuration, bool ForcePersistence)
        {
            return base.Channel.SetAudioDecoderConfigurationAsync(Configuration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task<VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetVideoSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetVideoEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetMetadataConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioOutputConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
        {
            return base.Channel.GetAudioDecoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(Onvif.Core.Client.Media.GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
        {
            return base.Channel.GetGuaranteedNumberOfVideoEncoderInstancesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MediaUri> GetStreamUriAsync(StreamSetup StreamSetup, string ProfileToken)
        {
            return base.Channel.GetStreamUriAsync(StreamSetup, ProfileToken);
        }
        
        public System.Threading.Tasks.Task StartMulticastStreamingAsync(string ProfileToken)
        {
            return base.Channel.StartMulticastStreamingAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task StopMulticastStreamingAsync(string ProfileToken)
        {
            return base.Channel.StopMulticastStreamingAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task SetSynchronizationPointAsync(string ProfileToken)
        {
            return base.Channel.SetSynchronizationPointAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task<MediaUri> GetSnapshotUriAsync(string ProfileToken)
        {
            return base.Channel.GetSnapshotUriAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourceModesResponse> Onvif.Core.Client.Media.Media.GetVideoSourceModesAsync(Onvif.Core.Client.Media.GetVideoSourceModesRequest request)
        {
            return base.Channel.GetVideoSourceModesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetVideoSourceModesResponse> GetVideoSourceModesAsync(string VideoSourceToken)
        {
            Onvif.Core.Client.Media.GetVideoSourceModesRequest inValue = new Onvif.Core.Client.Media.GetVideoSourceModesRequest();
            inValue.VideoSourceToken = VideoSourceToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetVideoSourceModesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken)
        {
            return base.Channel.SetVideoSourceModeAsync(VideoSourceToken, VideoSourceModeToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDsResponse> Onvif.Core.Client.Media.Media.GetOSDsAsync(Onvif.Core.Client.Media.GetOSDsRequest request)
        {
            return base.Channel.GetOSDsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDsResponse> GetOSDsAsync(string ConfigurationToken)
        {
            Onvif.Core.Client.Media.GetOSDsRequest inValue = new Onvif.Core.Client.Media.GetOSDsRequest();
            inValue.ConfigurationToken = ConfigurationToken;
            return ((Onvif.Core.Client.Media.Media)(this)).GetOSDsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDResponse> GetOSDAsync(Onvif.Core.Client.Media.GetOSDRequest request)
        {
            return base.Channel.GetOSDAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.GetOSDOptionsResponse> GetOSDOptionsAsync(Onvif.Core.Client.Media.GetOSDOptionsRequest request)
        {
            return base.Channel.GetOSDOptionsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.SetOSDResponse> SetOSDAsync(Onvif.Core.Client.Media.SetOSDRequest request)
        {
            return base.Channel.SetOSDAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.CreateOSDResponse> CreateOSDAsync(Onvif.Core.Client.Media.CreateOSDRequest request)
        {
            return base.Channel.CreateOSDAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Media.DeleteOSDResponse> DeleteOSDAsync(Onvif.Core.Client.Media.DeleteOSDRequest request)
        {
            return base.Channel.DeleteOSDAsync(request);
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
