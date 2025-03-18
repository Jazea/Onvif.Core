using Onvif.Core.Client.Common;
using Onvif.Core.Internals;

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Onvif.Core.Client.Ptz;

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[ServiceContractAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", ConfigurationName = "PTZ")]
public interface PTZ
{

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetServiceCapabilities", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Capabilities")]
	Task<Capabilities> GetServiceCapabilitiesAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetNodes", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetNodesResponse> GetNodesAsync(GetNodesRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetNode", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PTZNode")]
	Task<PTZNode> GetNodeAsync(string NodeToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PTZConfiguration")]
	Task<PTZConfiguration> GetConfigurationAsync(string PTZConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetConfigurationsResponse> GetConfigurationsAsync(GetConfigurationsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/SetConfiguration", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetConfigurationAsync(PTZConfiguration PTZConfiguration, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetConfigurationOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PTZConfigurationOptions")]
	Task<PTZConfigurationOptions> GetConfigurationOptionsAsync(string ConfigurationToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/SendAuxiliaryCommand", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "AuxiliaryResponse")]
	Task<string> SendAuxiliaryCommandAsync(string ProfileToken, string AuxiliaryData);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetPresets", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetPresetsResponse> GetPresetsAsync(GetPresetsRequest request);

	// CODEGEN: Generating message contract since the operation has multiple return values.
	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/SetPreset", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<SetPresetResponse> SetPresetAsync(SetPresetRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/RemovePreset", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemovePresetAsync(string ProfileToken, string PresetToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GotoPreset", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task GotoPresetAsync(string ProfileToken, string PresetToken, PTZSpeed Speed);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GotoHomePosition", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task GotoHomePositionAsync(string ProfileToken, PTZSpeed Speed);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/SetHomePosition", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task SetHomePositionAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/ContinuousMove", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<ContinuousMoveResponse> ContinuousMoveAsync(ContinuousMoveRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/RelativeMove", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RelativeMoveAsync(string ProfileToken, PTZVector Translation, PTZSpeed Speed);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetStatus", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PTZStatus")]
	Task<PTZStatus> GetStatusAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/AbsoluteMove", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task AbsoluteMoveAsync(string ProfileToken, PTZVector Position, PTZSpeed Speed);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GeoMove", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task GeoMoveAsync(string ProfileToken, GeoLocation Target, PTZSpeed Speed, float AreaHeight, float AreaWidth);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/Stop", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task StopAsync(string ProfileToken, bool PanTilt, bool Zoom);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetPresetTours", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetPresetToursResponse> GetPresetToursAsync(GetPresetToursRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetPresetTour", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PresetTour")]
	Task<PresetTour> GetPresetTourAsync(string ProfileToken, string PresetTourToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetPresetTourOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "Options")]
	Task<PTZPresetTourOptions> GetPresetTourOptionsAsync(string ProfileToken, string PresetTourToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/CreatePresetTour", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	[return: MessageParameterAttribute(Name = "PresetTourToken")]
	Task<string> CreatePresetTourAsync(string ProfileToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/ModifyPresetTour", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task ModifyPresetTourAsync(string ProfileToken, PresetTour PresetTour);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/OperatePresetTour", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task OperatePresetTourAsync(string ProfileToken, string PresetTourToken, PTZPresetTourOperation Operation);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/RemovePresetTour", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task RemovePresetTourAsync(string ProfileToken, string PresetTourToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/ptz/wsdl/GetCompatibleConfigurations", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
	[ServiceKnownTypeAttribute(typeof(DeviceEntity))]
	Task<GetCompatibleConfigurationsResponse> GetCompatibleConfigurationsAsync(GetCompatibleConfigurationsRequest request);
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetNodes", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetNodesRequest
{

	public GetNodesRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetNodesResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetNodesResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	[XmlElementAttribute("PTZNode")]
	public PTZNode[] PTZNode;

	public GetNodesResponse()
	{
	}

	public GetNodesResponse(PTZNode[] PTZNode)
	{
		this.PTZNode = PTZNode;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetConfigurations", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetConfigurationsRequest
{

	public GetConfigurationsRequest()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	[XmlElementAttribute("PTZConfiguration")]
	public PTZConfiguration[] PTZConfiguration;

	public GetConfigurationsResponse()
	{
	}

	public GetConfigurationsResponse(PTZConfiguration[] PTZConfiguration)
	{
		this.PTZConfiguration = PTZConfiguration;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPresets", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetPresetsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	public string ProfileToken;

	public GetPresetsRequest()
	{
	}

	public GetPresetsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPresetsResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetPresetsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	[XmlElementAttribute("Preset")]
	public PTZPreset[] Preset;

	public GetPresetsResponse()
	{
	}

	public GetPresetsResponse(PTZPreset[] Preset)
	{
		this.Preset = Preset;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "SetPreset", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class SetPresetRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	public string ProfileToken;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 1)]
	public string PresetName;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 2)]
	public string PresetToken;

	public SetPresetRequest()
	{
	}

	public SetPresetRequest(string ProfileToken, string PresetName, string PresetToken)
	{
		this.ProfileToken = ProfileToken;
		this.PresetName = PresetName;
		this.PresetToken = PresetToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[MessageContractAttribute(WrapperName = "SetPresetResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class SetPresetResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	public string PresetToken;

	public SetPresetResponse()
	{
	}

	public SetPresetResponse(string PresetToken)
	{
		this.PresetToken = PresetToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "ContinuousMove", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class ContinuousMoveRequest
{
	[XmlIgnore]
	public TimeSpan? TimeoutField;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	public string ProfileToken;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 1)]
	public PTZSpeed Velocity;

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 2)]
	[XmlElementAttribute(DataType = "duration")]
	public string Timeout
	{
		get => TimeoutField.ToXmlString();
		set => NullableTimeSpanExtensions.GetTimeSpanFromString(value);
	}

	public ContinuousMoveRequest()
	{
	}

	public ContinuousMoveRequest(string ProfileToken, PTZSpeed Velocity, TimeSpan? Timeout)
	{
		this.ProfileToken = ProfileToken;
		this.Velocity = Velocity;
		TimeoutField = Timeout;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "ContinuousMoveResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class ContinuousMoveResponse
{

	public ContinuousMoveResponse()
	{
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPresetTours", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetPresetToursRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	public string ProfileToken;

	public GetPresetToursRequest()
	{
	}

	public GetPresetToursRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPresetToursResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetPresetToursResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	[XmlElementAttribute("PresetTour")]
	public PresetTour[] PresetTour;

	public GetPresetToursResponse()
	{
	}

	public GetPresetToursResponse(PresetTour[] PresetTour)
	{
		this.PresetTour = PresetTour;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleConfigurations", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetCompatibleConfigurationsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	public string ProfileToken;

	public GetCompatibleConfigurationsRequest()
	{
	}

	public GetCompatibleConfigurationsRequest(string ProfileToken)
	{
		this.ProfileToken = ProfileToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetCompatibleConfigurationsResponse", WrapperNamespace = "http://www.onvif.org/ver20/ptz/wsdl", IsWrapped = true)]
public partial class GetCompatibleConfigurationsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", Order = 0)]
	[XmlElementAttribute("PTZConfiguration")]
	public PTZConfiguration[] PTZConfiguration;

	public GetCompatibleConfigurationsResponse()
	{
	}

	public GetCompatibleConfigurationsResponse(PTZConfiguration[] PTZConfiguration)
	{
		this.PTZConfiguration = PTZConfiguration;
	}
}

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public interface PTZChannel : PTZ, IClientChannel
{
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public partial class PTZClient : ClientBase<PTZ>, PTZ
{

	internal PTZClient(Binding binding, EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
	{
	}

	public Task<Capabilities> GetServiceCapabilitiesAsync()
	{
		return base.Channel.GetServiceCapabilitiesAsync();
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetNodesResponse> PTZ.GetNodesAsync(GetNodesRequest request)
	{
		return base.Channel.GetNodesAsync(request);
	}

	public Task<GetNodesResponse> GetNodesAsync()
	{
		GetNodesRequest inValue = new GetNodesRequest();
		return ((PTZ)(this)).GetNodesAsync(inValue);
	}

	public Task<PTZNode> GetNodeAsync(string NodeToken)
	{
		return base.Channel.GetNodeAsync(NodeToken);
	}

	public Task<PTZConfiguration> GetConfigurationAsync(string PTZConfigurationToken)
	{
		return base.Channel.GetConfigurationAsync(PTZConfigurationToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetConfigurationsResponse> PTZ.GetConfigurationsAsync(GetConfigurationsRequest request)
	{
		return base.Channel.GetConfigurationsAsync(request);
	}

	public Task<GetConfigurationsResponse> GetConfigurationsAsync()
	{
		GetConfigurationsRequest inValue = new GetConfigurationsRequest();
		return ((PTZ)(this)).GetConfigurationsAsync(inValue);
	}

	public Task SetConfigurationAsync(PTZConfiguration PTZConfiguration, bool ForcePersistence)
	{
		return base.Channel.SetConfigurationAsync(PTZConfiguration, ForcePersistence);
	}

	public Task<PTZConfigurationOptions> GetConfigurationOptionsAsync(string ConfigurationToken)
	{
		return base.Channel.GetConfigurationOptionsAsync(ConfigurationToken);
	}

	public Task<string> SendAuxiliaryCommandAsync(string ProfileToken, string AuxiliaryData)
	{
		return base.Channel.SendAuxiliaryCommandAsync(ProfileToken, AuxiliaryData);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetPresetsResponse> PTZ.GetPresetsAsync(GetPresetsRequest request)
	{
		return base.Channel.GetPresetsAsync(request);
	}

	public Task<GetPresetsResponse> GetPresetsAsync(string ProfileToken)
	{
		GetPresetsRequest inValue = new GetPresetsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((PTZ)(this)).GetPresetsAsync(inValue);
	}

	public Task<SetPresetResponse> SetPresetAsync(SetPresetRequest request)
	{
		return base.Channel.SetPresetAsync(request);
	}

	public Task RemovePresetAsync(string ProfileToken, string PresetToken)
	{
		return base.Channel.RemovePresetAsync(ProfileToken, PresetToken);
	}

	public Task GotoPresetAsync(string ProfileToken, string PresetToken, PTZSpeed Speed)
	{
		return base.Channel.GotoPresetAsync(ProfileToken, PresetToken, Speed);
	}

	public Task GotoHomePositionAsync(string ProfileToken, PTZSpeed Speed)
	{
		return base.Channel.GotoHomePositionAsync(ProfileToken, Speed);
	}

	public Task SetHomePositionAsync(string ProfileToken)
	{
		return base.Channel.SetHomePositionAsync(ProfileToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<ContinuousMoveResponse> PTZ.ContinuousMoveAsync(ContinuousMoveRequest request)
	{
		return base.Channel.ContinuousMoveAsync(request);
	}

	public Task<ContinuousMoveResponse> ContinuousMoveAsync(string ProfileToken, PTZSpeed Velocity, TimeSpan? Timeout)
	{
		ContinuousMoveRequest inValue = new ContinuousMoveRequest();
		inValue.ProfileToken = ProfileToken;
		inValue.Velocity = Velocity;
		inValue.TimeoutField = Timeout;
		return ((PTZ)(this)).ContinuousMoveAsync(inValue);
	}

	public Task RelativeMoveAsync(string ProfileToken, PTZVector Translation, PTZSpeed Speed)
	{
		return base.Channel.RelativeMoveAsync(ProfileToken, Translation, Speed);
	}

	public Task<PTZStatus> GetStatusAsync(string ProfileToken)
	{
		return base.Channel.GetStatusAsync(ProfileToken);
	}

	public Task AbsoluteMoveAsync(string ProfileToken, PTZVector Position, PTZSpeed Speed)
	{
		return base.Channel.AbsoluteMoveAsync(ProfileToken, Position, Speed);
	}

	public Task GeoMoveAsync(string ProfileToken, GeoLocation Target, PTZSpeed Speed, float AreaHeight, float AreaWidth)
	{
		return base.Channel.GeoMoveAsync(ProfileToken, Target, Speed, AreaHeight, AreaWidth);
	}

	public Task StopAsync(string ProfileToken, bool PanTilt, bool Zoom)
	{
		return base.Channel.StopAsync(ProfileToken, PanTilt, Zoom);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetPresetToursResponse> PTZ.GetPresetToursAsync(GetPresetToursRequest request)
	{
		return base.Channel.GetPresetToursAsync(request);
	}

	public Task<GetPresetToursResponse> GetPresetToursAsync(string ProfileToken)
	{
		GetPresetToursRequest inValue = new GetPresetToursRequest();
		inValue.ProfileToken = ProfileToken;
		return ((PTZ)(this)).GetPresetToursAsync(inValue);
	}

	public Task<PresetTour> GetPresetTourAsync(string ProfileToken, string PresetTourToken)
	{
		return base.Channel.GetPresetTourAsync(ProfileToken, PresetTourToken);
	}

	public Task<PTZPresetTourOptions> GetPresetTourOptionsAsync(string ProfileToken, string PresetTourToken)
	{
		return base.Channel.GetPresetTourOptionsAsync(ProfileToken, PresetTourToken);
	}

	public Task<string> CreatePresetTourAsync(string ProfileToken)
	{
		return base.Channel.CreatePresetTourAsync(ProfileToken);
	}

	public Task ModifyPresetTourAsync(string ProfileToken, PresetTour PresetTour)
	{
		return base.Channel.ModifyPresetTourAsync(ProfileToken, PresetTour);
	}

	public Task OperatePresetTourAsync(string ProfileToken, string PresetTourToken, PTZPresetTourOperation Operation)
	{
		return base.Channel.OperatePresetTourAsync(ProfileToken, PresetTourToken, Operation);
	}

	public Task RemovePresetTourAsync(string ProfileToken, string PresetTourToken)
	{
		return base.Channel.RemovePresetTourAsync(ProfileToken, PresetTourToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetCompatibleConfigurationsResponse> PTZ.GetCompatibleConfigurationsAsync(GetCompatibleConfigurationsRequest request)
	{
		return base.Channel.GetCompatibleConfigurationsAsync(request);
	}

	public Task<GetCompatibleConfigurationsResponse> GetCompatibleConfigurationsAsync(string ProfileToken)
	{
		GetCompatibleConfigurationsRequest inValue = new GetCompatibleConfigurationsRequest();
		inValue.ProfileToken = ProfileToken;
		return ((PTZ)(this)).GetCompatibleConfigurationsAsync(inValue);
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
