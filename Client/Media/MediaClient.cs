using Onvif.Core.Client.Common;

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Onvif.Core.Client.Media;

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[ServiceContractAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", ConfigurationName = "Media")]
public interface Media
{

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetServiceCapabilities", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Capabilities")]
	Task<Capabilities> GetServiceCapabilitiesAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdlGetVideoSources/", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetVideoSourcesResponse> GetVideoSourcesAsync(GetVideoSourcesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioSources", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetAudioSourcesResponse> GetAudioSourcesAsync(GetAudioSourcesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioOutputs", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetAudioOutputsResponse> GetAudioOutputsAsync(GetAudioOutputsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/CreateProfile", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Profile")]
	Task<Profile> CreateProfileAsync(string Name, string Token);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdlGetProfile/", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Profile")]
	Task<Profile> GetProfileAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetProfiles", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetProfilesResponse> GetProfilesAsync(GetProfilesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddVideoEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveVideoEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveVideoEncoderConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddVideoSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveVideoSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveVideoSourceConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddAudioEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveAudioEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveAudioEncoderConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddAudioSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveAudioSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveAudioSourceConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddPTZConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemovePTZConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemovePTZConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddVideoAnalyticsConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveVideoAnalyticsConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddMetadataConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveMetadataConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveMetadataConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddAudioOutputConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveAudioOutputConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveAudioOutputConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/AddAudioDecoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/RemoveAudioDecoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemoveAudioDecoderConfigurationAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/DeleteProfile", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task DeleteProfileAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoSourceConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync(GetVideoSourceConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync(GetVideoEncoderConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdlGetAudioSourceConfigurations/", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync(GetAudioSourceConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync(GetAudioEncoderConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoAnalyticsConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync(GetVideoAnalyticsConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetMetadataConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync(GetMetadataConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync(GetAudioOutputConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync(GetAudioDecoderConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoAnalyticsConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetMetadataConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Configuration")]
	Task<AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoEncoderConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(GetCompatibleVideoEncoderConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoSourceConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(GetCompatibleVideoSourceConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioEncoderConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(GetCompatibleAudioEncoderConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioSourceConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(GetCompatibleAudioSourceConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleVideoAnalyticsConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(GetCompatibleVideoAnalyticsConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleMetadataConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(GetCompatibleMetadataConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioOutputConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(GetCompatibleAudioOutputConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetCompatibleAudioDecoderConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(GetCompatibleAudioDecoderConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetVideoSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetVideoSourceConfigurationAsync(VideoSourceConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetVideoEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetVideoEncoderConfigurationAsync(VideoEncoderConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetAudioSourceConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetAudioSourceConfigurationAsync(AudioSourceConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetAudioEncoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetAudioEncoderConfigurationAsync(AudioEncoderConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetVideoAnalyticsConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetVideoAnalyticsConfigurationAsync(VideoAnalyticsConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetMetadataConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetMetadataConfigurationAsync(MetadataConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetAudioOutputConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetAudioOutputConfigurationAsync(AudioOutputConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetAudioDecoderConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetAudioDecoderConfigurationAsync(AudioDecoderConfiguration Configuration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdlGetVideoSourceConfigurationOptions/", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoEncoderConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioSourceConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioEncoderConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetMetadataConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioOutputConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetAudioDecoderConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetGuaranteedNumberOfVideoEncoderInstances", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(GetGuaranteedNumberOfVideoEncoderInstancesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetStreamUri", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "MediaUri")]
	Task<MediaUri> GetStreamUriAsync(StreamSetup StreamSetup, string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/StartMulticastStreaming", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task StartMulticastStreamingAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/StopMulticastStreaming", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task StopMulticastStreamingAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetSynchronizationPoint", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetSynchronizationPointAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetSnapshotUri", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "MediaUri")]
	Task<MediaUri> GetSnapshotUriAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetVideoSourceModes", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetVideoSourceModesResponse> GetVideoSourceModesAsync(GetVideoSourceModesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetVideoSourceMode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Reboot")]
	Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetOSDs", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetOSDsResponse> GetOSDsAsync(GetOSDsRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetOSD", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetOSDResponse> GetOSDAsync(GetOSDRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/GetOSDOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetOSDOptionsResponse> GetOSDOptionsAsync(GetOSDOptionsRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/SetOSD", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetOSDResponse> SetOSDAsync(SetOSDRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/CreateOSD", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<CreateOSDResponse> CreateOSDAsync(CreateOSDRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver10/media/wsdl/DeleteOSD", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<DeleteOSDResponse> DeleteOSDAsync(DeleteOSDRequest request);
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoSources", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoSourcesRequest
{

	public GetVideoSourcesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoSourcesResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoSourcesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("VideoSources")]
	public VideoSource[] VideoSources;

	public GetVideoSourcesResponse()
	{
	}

	public GetVideoSourcesResponse(VideoSource[] VideoSources)
	{
		this.VideoSources = VideoSources;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioSources", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioSourcesRequest
{

	public GetAudioSourcesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioSourcesResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioSourcesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("AudioSources")]
	public AudioSource[] AudioSources;

	public GetAudioSourcesResponse()
	{
	}

	public GetAudioSourcesResponse(AudioSource[] AudioSources)
	{
		this.AudioSources = AudioSources;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioOutputs", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioOutputsRequest
{

	public GetAudioOutputsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioOutputsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioOutputsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("AudioOutputs")]
	public AudioOutput[] AudioOutputs;

	public GetAudioOutputsResponse()
	{
	}

	public GetAudioOutputsResponse(AudioOutput[] AudioOutputs)
	{
		this.AudioOutputs = AudioOutputs;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetProfiles", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetProfilesRequest
{

	public GetProfilesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetProfilesResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetProfilesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Profiles")]
	public Profile[] Profiles;

	public GetProfilesResponse()
	{
	}

	public GetProfilesResponse(Profile[] Profiles)
	{
		this.Profiles = Profiles;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoSourceConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoSourceConfigurationsRequest
{

	public GetVideoSourceConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoSourceConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoSourceConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public VideoSourceConfiguration[] Configurations;

	public GetVideoSourceConfigurationsResponse()
	{
	}

	public GetVideoSourceConfigurationsResponse(VideoSourceConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoEncoderConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoEncoderConfigurationsRequest
{

	public GetVideoEncoderConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoEncoderConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoEncoderConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public VideoEncoderConfiguration[] Configurations;

	public GetVideoEncoderConfigurationsResponse()
	{
	}

	public GetVideoEncoderConfigurationsResponse(VideoEncoderConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioSourceConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioSourceConfigurationsRequest
{

	public GetAudioSourceConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioSourceConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioSourceConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioSourceConfiguration[] Configurations;

	public GetAudioSourceConfigurationsResponse()
	{
	}

	public GetAudioSourceConfigurationsResponse(AudioSourceConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioEncoderConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioEncoderConfigurationsRequest
{

	public GetAudioEncoderConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioEncoderConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioEncoderConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioEncoderConfiguration[] Configurations;

	public GetAudioEncoderConfigurationsResponse()
	{
	}

	public GetAudioEncoderConfigurationsResponse(AudioEncoderConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoAnalyticsConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoAnalyticsConfigurationsRequest
{

	public GetVideoAnalyticsConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoAnalyticsConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoAnalyticsConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public VideoAnalyticsConfiguration[] Configurations;

	public GetVideoAnalyticsConfigurationsResponse()
	{
	}

	public GetVideoAnalyticsConfigurationsResponse(VideoAnalyticsConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetMetadataConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetMetadataConfigurationsRequest
{

	public GetMetadataConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetMetadataConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetMetadataConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public MetadataConfiguration[] Configurations;

	public GetMetadataConfigurationsResponse()
	{
	}

	public GetMetadataConfigurationsResponse(MetadataConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioOutputConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioOutputConfigurationsRequest
{

	public GetAudioOutputConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioOutputConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioOutputConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioOutputConfiguration[] Configurations;

	public GetAudioOutputConfigurationsResponse()
	{
	}

	public GetAudioOutputConfigurationsResponse(AudioOutputConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioDecoderConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioDecoderConfigurationsRequest
{

	public GetAudioDecoderConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetAudioDecoderConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetAudioDecoderConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioDecoderConfiguration[] Configurations;

	public GetAudioDecoderConfigurationsResponse()
	{
	}

	public GetAudioDecoderConfigurationsResponse(AudioDecoderConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleVideoEncoderConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleVideoEncoderConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleVideoEncoderConfigurationsRequest()
	{
	}

	public GetCompatibleVideoEncoderConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleVideoEncoderConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleVideoEncoderConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public VideoEncoderConfiguration[] Configurations;

	public GetCompatibleVideoEncoderConfigurationsResponse()
	{
	}

	public GetCompatibleVideoEncoderConfigurationsResponse(VideoEncoderConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleVideoSourceConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleVideoSourceConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleVideoSourceConfigurationsRequest()
	{
	}

	public GetCompatibleVideoSourceConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleVideoSourceConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleVideoSourceConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public VideoSourceConfiguration[] Configurations;

	public GetCompatibleVideoSourceConfigurationsResponse()
	{
	}

	public GetCompatibleVideoSourceConfigurationsResponse(VideoSourceConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioEncoderConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioEncoderConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleAudioEncoderConfigurationsRequest()
	{
	}

	public GetCompatibleAudioEncoderConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioEncoderConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioEncoderConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioEncoderConfiguration[] Configurations;

	public GetCompatibleAudioEncoderConfigurationsResponse()
	{
	}

	public GetCompatibleAudioEncoderConfigurationsResponse(AudioEncoderConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioSourceConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioSourceConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleAudioSourceConfigurationsRequest()
	{
	}

	public GetCompatibleAudioSourceConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioSourceConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioSourceConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioSourceConfiguration[] Configurations;

	public GetCompatibleAudioSourceConfigurationsResponse()
	{
	}

	public GetCompatibleAudioSourceConfigurationsResponse(AudioSourceConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleVideoAnalyticsConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleVideoAnalyticsConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleVideoAnalyticsConfigurationsRequest()
	{
	}

	public GetCompatibleVideoAnalyticsConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleVideoAnalyticsConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleVideoAnalyticsConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public VideoAnalyticsConfiguration[] Configurations;

	public GetCompatibleVideoAnalyticsConfigurationsResponse()
	{
	}

	public GetCompatibleVideoAnalyticsConfigurationsResponse(VideoAnalyticsConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleMetadataConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleMetadataConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleMetadataConfigurationsRequest()
	{
	}

	public GetCompatibleMetadataConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleMetadataConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleMetadataConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public MetadataConfiguration[] Configurations;

	public GetCompatibleMetadataConfigurationsResponse()
	{
	}

	public GetCompatibleMetadataConfigurationsResponse(MetadataConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioOutputConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioOutputConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleAudioOutputConfigurationsRequest()
	{
	}

	public GetCompatibleAudioOutputConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioOutputConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioOutputConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioOutputConfiguration[] Configurations;

	public GetCompatibleAudioOutputConfigurationsResponse()
	{
	}

	public GetCompatibleAudioOutputConfigurationsResponse(AudioOutputConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioDecoderConfigurations", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioDecoderConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleAudioDecoderConfigurationsRequest()
	{
	}

	public GetCompatibleAudioDecoderConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleAudioDecoderConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetCompatibleAudioDecoderConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("Configurations")]
	public AudioDecoderConfiguration[] Configurations;

	public GetCompatibleAudioDecoderConfigurationsResponse()
	{
	}

	public GetCompatibleAudioDecoderConfigurationsResponse(AudioDecoderConfiguration[] Configurations)
	{
		this.Configurations = Configurations;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetGuaranteedNumberOfVideoEncoderInstances", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetGuaranteedNumberOfVideoEncoderInstancesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ConfigurationToken;

	public GetGuaranteedNumberOfVideoEncoderInstancesRequest()
	{
	}

	public GetGuaranteedNumberOfVideoEncoderInstancesRequest(string ConfigurationToken)
	{
		this.ConfigurationToken = ConfigurationToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetGuaranteedNumberOfVideoEncoderInstancesResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetGuaranteedNumberOfVideoEncoderInstancesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public int TotalNumber;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 1)]
	public int JPEG;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 2)]
	public int H264;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 3)]
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

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoSourceModes", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoSourceModesRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string VideoSourceToken;

	public GetVideoSourceModesRequest()
	{
	}

	public GetVideoSourceModesRequest(string VideoSourceToken)
	{
		this.VideoSourceToken = VideoSourceToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetVideoSourceModesResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetVideoSourceModesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("VideoSourceModes")]
	public VideoSourceMode[] VideoSourceModes;

	public GetVideoSourceModesResponse()
	{
	}

	public GetVideoSourceModesResponse(VideoSourceMode[] VideoSourceModes)
	{
		this.VideoSourceModes = VideoSourceModes;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetOSDs", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetOSDsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ConfigurationToken;

	public GetOSDsRequest()
	{
	}

	public GetOSDsRequest(string ConfigurationToken)
	{
		this.ConfigurationToken = ConfigurationToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetOSDsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetOSDsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	[XmlElementAttribute("OSDs")]
	public OSDConfiguration[] OSDs;

	public GetOSDsResponse()
	{
	}

	public GetOSDsResponse(OSDConfiguration[] OSDs)
	{
		this.OSDs = OSDs;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetOSD", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetOSDRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string OSDToken;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public GetOSDRequest()
	{
	}

	public GetOSDRequest(string OSDToken, XElement[] Any)
	{
		this.OSDToken = OSDToken;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetOSDResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetOSDResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public OSDConfiguration OSD;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public GetOSDResponse()
	{
	}

	public GetOSDResponse(OSDConfiguration OSD, XElement[] Any)
	{
		this.OSD = OSD;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetOSDOptions", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetOSDOptionsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string ConfigurationToken;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public GetOSDOptionsRequest()
	{
	}

	public GetOSDOptionsRequest(string ConfigurationToken, XElement[] Any)
	{
		this.ConfigurationToken = ConfigurationToken;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "GetOSDOptionsResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class GetOSDOptionsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public OSDConfigurationOptions OSDOptions;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public GetOSDOptionsResponse()
	{
	}

	public GetOSDOptionsResponse(OSDConfigurationOptions OSDOptions, XElement[] Any)
	{
		this.OSDOptions = OSDOptions;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "SetOSD", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class SetOSDRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public OSDConfiguration OSD;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public SetOSDRequest()
	{
	}

	public SetOSDRequest(OSDConfiguration OSD, XElement[] Any)
	{
		this.OSD = OSD;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "SetOSDResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class SetOSDResponse
{

	[MessageBodyMemberAttribute(Namespace = "", Order = 0)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public SetOSDResponse()
	{
	}

	public SetOSDResponse(XElement[] Any)
	{
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "CreateOSD", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class CreateOSDRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public OSDConfiguration OSD;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public CreateOSDRequest()
	{
	}

	public CreateOSDRequest(OSDConfiguration OSD, XElement[] Any)
	{
		this.OSD = OSD;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "CreateOSDResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class CreateOSDResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string OSDToken;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public CreateOSDResponse()
	{
	}

	public CreateOSDResponse(string OSDToken, XElement[] Any)
	{
		this.OSDToken = OSDToken;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "DeleteOSD", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class DeleteOSDRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", Order = 0)]
	public string OSDToken;

	[MessageBodyMemberAttribute(Namespace = "", Order = 1)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public DeleteOSDRequest()
	{
	}

	public DeleteOSDRequest(string OSDToken, XElement[] Any)
	{
		this.OSDToken = OSDToken;
		this.Any = Any;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "DeleteOSDResponse", WrapperNamespace = "http://www.onvif.org/ver10/media/wsdl", IsWrapped = true)]
public partial class DeleteOSDResponse
{

	[MessageBodyMemberAttribute(Namespace = "", Order = 0)]
	[XmlAnyElementAttribute()]
	public XElement[] Any;

	public DeleteOSDResponse()
	{
	}

	public DeleteOSDResponse(XElement[] Any)
	{
		this.Any = Any;
	}
}

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public interface MediaChannel : Media, IClientChannel
{
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public partial class MediaClient : ClientBase<Media>, Media
{

	internal MediaClient(Binding binding, EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
	{
	}

	public Task<Capabilities> GetServiceCapabilitiesAsync()
	{
		return base.Channel.GetServiceCapabilitiesAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetVideoSourcesResponse> Media.GetVideoSourcesAsync(GetVideoSourcesRequest request)
	{
		return base.Channel.GetVideoSourcesAsync(request);
	}

	public Task<GetVideoSourcesResponse> GetVideoSourcesAsync()
	{
		GetVideoSourcesRequest inValue = new GetVideoSourcesRequest();
		return ((Media)(this)).GetVideoSourcesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetAudioSourcesResponse> Media.GetAudioSourcesAsync(GetAudioSourcesRequest request)
	{
		return base.Channel.GetAudioSourcesAsync(request);
	}

	public Task<GetAudioSourcesResponse> GetAudioSourcesAsync()
	{
		GetAudioSourcesRequest inValue = new GetAudioSourcesRequest();
		return ((Media)(this)).GetAudioSourcesAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetAudioOutputsResponse> Media.GetAudioOutputsAsync(GetAudioOutputsRequest request)
	{
		return base.Channel.GetAudioOutputsAsync(request);
	}

	public Task<GetAudioOutputsResponse> GetAudioOutputsAsync()
	{
		GetAudioOutputsRequest inValue = new GetAudioOutputsRequest();
		return ((Media)(this)).GetAudioOutputsAsync(inValue);
	}

	public Task<Profile> CreateProfileAsync(string Name, string Token)
	{
		return base.Channel.CreateProfileAsync(Name, Token);
	}

	public Task<Profile> GetProfileAsync(string ProfileToken)
	{
		return base.Channel.GetProfileAsync(ProfileToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetProfilesResponse> Media.GetProfilesAsync(GetProfilesRequest request)
	{
		return base.Channel.GetProfilesAsync(request);
	}

	public Task<GetProfilesResponse> GetProfilesAsync()
	{
		GetProfilesRequest inValue = new GetProfilesRequest();
		return ((Media)(this)).GetProfilesAsync(inValue);
	}

	public Task AddVideoEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddVideoEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveVideoEncoderConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveVideoEncoderConfigurationAsync(ProfileToken);
	}

	public Task AddVideoSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddVideoSourceConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveVideoSourceConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveVideoSourceConfigurationAsync(ProfileToken);
	}

	public Task AddAudioEncoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddAudioEncoderConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveAudioEncoderConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveAudioEncoderConfigurationAsync(ProfileToken);
	}

	public Task AddAudioSourceConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddAudioSourceConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveAudioSourceConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveAudioSourceConfigurationAsync(ProfileToken);
	}

	public Task AddPTZConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddPTZConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemovePTZConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemovePTZConfigurationAsync(ProfileToken);
	}

	public Task AddVideoAnalyticsConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddVideoAnalyticsConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveVideoAnalyticsConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveVideoAnalyticsConfigurationAsync(ProfileToken);
	}

	public Task AddMetadataConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddMetadataConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveMetadataConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveMetadataConfigurationAsync(ProfileToken);
	}

	public Task AddAudioOutputConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddAudioOutputConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveAudioOutputConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveAudioOutputConfigurationAsync(ProfileToken);
	}

	public Task AddAudioDecoderConfigurationAsync(string ProfileToken, string ConfigurationToken)
	{
		return base.Channel.AddAudioDecoderConfigurationAsync(ProfileToken, ConfigurationToken);
	}

	public Task RemoveAudioDecoderConfigurationAsync(string ProfileToken)
	{
		return base.Channel.RemoveAudioDecoderConfigurationAsync(ProfileToken);
	}

	public Task DeleteProfileAsync(string ProfileToken)
	{
		return base.Channel.DeleteProfileAsync(ProfileToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetVideoSourceConfigurationsResponse> Media.GetVideoSourceConfigurationsAsync(GetVideoSourceConfigurationsRequest request)
	{
		return base.Channel.GetVideoSourceConfigurationsAsync(request);
	}

	public Task<GetVideoSourceConfigurationsResponse> GetVideoSourceConfigurationsAsync()
	{
		GetVideoSourceConfigurationsRequest inValue = new GetVideoSourceConfigurationsRequest();
		return ((Media)(this)).GetVideoSourceConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetVideoEncoderConfigurationsResponse> Media.GetVideoEncoderConfigurationsAsync(GetVideoEncoderConfigurationsRequest request)
	{
		return base.Channel.GetVideoEncoderConfigurationsAsync(request);
	}

	public Task<GetVideoEncoderConfigurationsResponse> GetVideoEncoderConfigurationsAsync()
	{
		GetVideoEncoderConfigurationsRequest inValue = new GetVideoEncoderConfigurationsRequest();
		return ((Media)(this)).GetVideoEncoderConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetAudioSourceConfigurationsResponse> Media.GetAudioSourceConfigurationsAsync(GetAudioSourceConfigurationsRequest request)
	{
		return base.Channel.GetAudioSourceConfigurationsAsync(request);
	}

	public Task<GetAudioSourceConfigurationsResponse> GetAudioSourceConfigurationsAsync()
	{
		GetAudioSourceConfigurationsRequest inValue = new GetAudioSourceConfigurationsRequest();
		return ((Media)(this)).GetAudioSourceConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetAudioEncoderConfigurationsResponse> Media.GetAudioEncoderConfigurationsAsync(GetAudioEncoderConfigurationsRequest request)
	{
		return base.Channel.GetAudioEncoderConfigurationsAsync(request);
	}

	public Task<GetAudioEncoderConfigurationsResponse> GetAudioEncoderConfigurationsAsync()
	{
		GetAudioEncoderConfigurationsRequest inValue = new GetAudioEncoderConfigurationsRequest();
		return ((Media)(this)).GetAudioEncoderConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetVideoAnalyticsConfigurationsResponse> Media.GetVideoAnalyticsConfigurationsAsync(GetVideoAnalyticsConfigurationsRequest request)
	{
		return base.Channel.GetVideoAnalyticsConfigurationsAsync(request);
	}

	public Task<GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurationsAsync()
	{
		GetVideoAnalyticsConfigurationsRequest inValue = new GetVideoAnalyticsConfigurationsRequest();
		return ((Media)(this)).GetVideoAnalyticsConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetMetadataConfigurationsResponse> Media.GetMetadataConfigurationsAsync(GetMetadataConfigurationsRequest request)
	{
		return base.Channel.GetMetadataConfigurationsAsync(request);
	}

	public Task<GetMetadataConfigurationsResponse> GetMetadataConfigurationsAsync()
	{
		GetMetadataConfigurationsRequest inValue = new GetMetadataConfigurationsRequest();
		return ((Media)(this)).GetMetadataConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetAudioOutputConfigurationsResponse> Media.GetAudioOutputConfigurationsAsync(GetAudioOutputConfigurationsRequest request)
	{
		return base.Channel.GetAudioOutputConfigurationsAsync(request);
	}

	public Task<GetAudioOutputConfigurationsResponse> GetAudioOutputConfigurationsAsync()
	{
		GetAudioOutputConfigurationsRequest inValue = new GetAudioOutputConfigurationsRequest();
		return ((Media)(this)).GetAudioOutputConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetAudioDecoderConfigurationsResponse> Media.GetAudioDecoderConfigurationsAsync(GetAudioDecoderConfigurationsRequest request)
	{
		return base.Channel.GetAudioDecoderConfigurationsAsync(request);
	}

	public Task<GetAudioDecoderConfigurationsResponse> GetAudioDecoderConfigurationsAsync()
	{
		GetAudioDecoderConfigurationsRequest inValue = new GetAudioDecoderConfigurationsRequest();
		return ((Media)(this)).GetAudioDecoderConfigurationsAsync(inValue);
	}

	public Task<VideoSourceConfiguration> GetVideoSourceConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetVideoSourceConfigurationAsync(ConfigurationToken);
	}

	public Task<VideoEncoderConfiguration> GetVideoEncoderConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetVideoEncoderConfigurationAsync(ConfigurationToken);
	}

	public Task<AudioSourceConfiguration> GetAudioSourceConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetAudioSourceConfigurationAsync(ConfigurationToken);
	}

	public Task<AudioEncoderConfiguration> GetAudioEncoderConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetAudioEncoderConfigurationAsync(ConfigurationToken);
	}

	public Task<VideoAnalyticsConfiguration> GetVideoAnalyticsConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetVideoAnalyticsConfigurationAsync(ConfigurationToken);
	}

	public Task<MetadataConfiguration> GetMetadataConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetMetadataConfigurationAsync(ConfigurationToken);
	}

	public Task<AudioOutputConfiguration> GetAudioOutputConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetAudioOutputConfigurationAsync(ConfigurationToken);
	}

	public Task<AudioDecoderConfiguration> GetAudioDecoderConfigurationAsync(string ConfigurationToken)
	{
		return base.Channel.GetAudioDecoderConfigurationAsync(ConfigurationToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleVideoEncoderConfigurationsResponse> Media.GetCompatibleVideoEncoderConfigurationsAsync(GetCompatibleVideoEncoderConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleVideoEncoderConfigurationsAsync(request);
	}

	public Task<GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleVideoEncoderConfigurationsRequest inValue = new GetCompatibleVideoEncoderConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleVideoEncoderConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleVideoSourceConfigurationsResponse> Media.GetCompatibleVideoSourceConfigurationsAsync(GetCompatibleVideoSourceConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleVideoSourceConfigurationsAsync(request);
	}

	public Task<GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleVideoSourceConfigurationsRequest inValue = new GetCompatibleVideoSourceConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleVideoSourceConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleAudioEncoderConfigurationsResponse> Media.GetCompatibleAudioEncoderConfigurationsAsync(GetCompatibleAudioEncoderConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleAudioEncoderConfigurationsAsync(request);
	}

	public Task<GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleAudioEncoderConfigurationsRequest inValue = new GetCompatibleAudioEncoderConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleAudioEncoderConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleAudioSourceConfigurationsResponse> Media.GetCompatibleAudioSourceConfigurationsAsync(GetCompatibleAudioSourceConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleAudioSourceConfigurationsAsync(request);
	}

	public Task<GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleAudioSourceConfigurationsRequest inValue = new GetCompatibleAudioSourceConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleAudioSourceConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleVideoAnalyticsConfigurationsResponse> Media.GetCompatibleVideoAnalyticsConfigurationsAsync(GetCompatibleVideoAnalyticsConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleVideoAnalyticsConfigurationsAsync(request);
	}

	public Task<GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleVideoAnalyticsConfigurationsRequest inValue = new GetCompatibleVideoAnalyticsConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleVideoAnalyticsConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleMetadataConfigurationsResponse> Media.GetCompatibleMetadataConfigurationsAsync(GetCompatibleMetadataConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleMetadataConfigurationsAsync(request);
	}

	public Task<GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleMetadataConfigurationsRequest inValue = new GetCompatibleMetadataConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleMetadataConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleAudioOutputConfigurationsResponse> Media.GetCompatibleAudioOutputConfigurationsAsync(GetCompatibleAudioOutputConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleAudioOutputConfigurationsAsync(request);
	}

	public Task<GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleAudioOutputConfigurationsRequest inValue = new GetCompatibleAudioOutputConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleAudioOutputConfigurationsAsync(inValue);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleAudioDecoderConfigurationsResponse> Media.GetCompatibleAudioDecoderConfigurationsAsync(GetCompatibleAudioDecoderConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleAudioDecoderConfigurationsAsync(request);
	}

	public Task<GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleAudioDecoderConfigurationsRequest inValue = new GetCompatibleAudioDecoderConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((Media)(this)).GetCompatibleAudioDecoderConfigurationsAsync(inValue);
	}

	public Task SetVideoSourceConfigurationAsync(VideoSourceConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetVideoSourceConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetVideoEncoderConfigurationAsync(VideoEncoderConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetVideoEncoderConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetAudioSourceConfigurationAsync(AudioSourceConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetAudioSourceConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetAudioEncoderConfigurationAsync(AudioEncoderConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetAudioEncoderConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetVideoAnalyticsConfigurationAsync(VideoAnalyticsConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetVideoAnalyticsConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetMetadataConfigurationAsync(MetadataConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetMetadataConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetAudioOutputConfigurationAsync(AudioOutputConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetAudioOutputConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task SetAudioDecoderConfigurationAsync(AudioDecoderConfiguration Configuration, bool ForcePersistence)
	{
		return base.Channel.SetAudioDecoderConfigurationAsync(Configuration, ForcePersistence);
	}

	public Task<VideoSourceConfigurationOptions> GetVideoSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetVideoSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<VideoEncoderConfigurationOptions> GetVideoEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetVideoEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<AudioSourceConfigurationOptions> GetAudioSourceConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetAudioSourceConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<AudioEncoderConfigurationOptions> GetAudioEncoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetAudioEncoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<MetadataConfigurationOptions> GetMetadataConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetMetadataConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<AudioOutputConfigurationOptions> GetAudioOutputConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetAudioOutputConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<AudioDecoderConfigurationOptions> GetAudioDecoderConfigurationOptionsAsync(string ConfigurationToken, string ProfileToken)
	{
		return base.Channel.GetAudioDecoderConfigurationOptionsAsync(ConfigurationToken, ProfileToken);
	}

	public Task<GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstancesAsync(GetGuaranteedNumberOfVideoEncoderInstancesRequest request)
	{
		return base.Channel.GetGuaranteedNumberOfVideoEncoderInstancesAsync(request);
	}

	public Task<MediaUri> GetStreamUriAsync(StreamSetup StreamSetup, string ProfileToken)
	{
		return base.Channel.GetStreamUriAsync(StreamSetup, ProfileToken);
	}

	public Task StartMulticastStreamingAsync(string ProfileToken)
	{
		return base.Channel.StartMulticastStreamingAsync(ProfileToken);
	}

	public Task StopMulticastStreamingAsync(string ProfileToken)
	{
		return base.Channel.StopMulticastStreamingAsync(ProfileToken);
	}

	public Task SetSynchronizationPointAsync(string ProfileToken)
	{
		return base.Channel.SetSynchronizationPointAsync(ProfileToken);
	}

	public Task<MediaUri> GetSnapshotUriAsync(string ProfileToken)
	{
		return base.Channel.GetSnapshotUriAsync(ProfileToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetVideoSourceModesResponse> Media.GetVideoSourceModesAsync(GetVideoSourceModesRequest request)
	{
		return base.Channel.GetVideoSourceModesAsync(request);
	}

	public Task<GetVideoSourceModesResponse> GetVideoSourceModesAsync(string VideoSourceToken)
	{
		GetVideoSourceModesRequest inValue = new GetVideoSourceModesRequest();
		inValue.VideoSourceToken = VideoSourceToken;
		return ((Media)(this)).GetVideoSourceModesAsync(inValue);
	}

	public Task<bool> SetVideoSourceModeAsync(string VideoSourceToken, string VideoSourceModeToken)
	{
		return base.Channel.SetVideoSourceModeAsync(VideoSourceToken, VideoSourceModeToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetOSDsResponse> Media.GetOSDsAsync(GetOSDsRequest request)
	{
		return base.Channel.GetOSDsAsync(request);
	}

	public Task<GetOSDsResponse> GetOSDsAsync(string ConfigurationToken)
	{
		GetOSDsRequest inValue = new GetOSDsRequest();
		inValue.ConfigurationToken = ConfigurationToken;
		return ((Media)(this)).GetOSDsAsync(inValue);
	}

	public Task<GetOSDResponse> GetOSDAsync(GetOSDRequest request)
	{
		return base.Channel.GetOSDAsync(request);
	}

	public Task<GetOSDOptionsResponse> GetOSDOptionsAsync(GetOSDOptionsRequest request)
	{
		return base.Channel.GetOSDOptionsAsync(request);
	}

	public Task<SetOSDResponse> SetOSDAsync(SetOSDRequest request)
	{
		return base.Channel.SetOSDAsync(request);
	}

	public Task<CreateOSDResponse> CreateOSDAsync(CreateOSDRequest request)
	{
		return base.Channel.CreateOSDAsync(request);
	}

	public Task<DeleteOSDResponse> DeleteOSDAsync(DeleteOSDRequest request)
	{
		return base.Channel.DeleteOSDAsync(request);
	}

	public virtual Task OpenAsync()
	{
		return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndOpen));
	}

	public virtual Task CloseAsync()
	{
		return Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new Action<IAsyncResult>(((ICommunicationObject)(this)).EndClose));
	}
}
