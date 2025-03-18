using Onvif.Core.Client.Common;

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Onvif.Core.Client.Imaging;

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl", ConfigurationName = "Imaging")]
public interface Imaging
{

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetServiceCapabilities", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[return: MessageParameterAttribute(Name = "Capabilities")]
	Task<Capabilities> GetServiceCapabilitiesAsync();

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetImagingSettings", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[return: MessageParameterAttribute(Name = "ImagingSettings")]
	Task<ImagingSettings20> GetImagingSettingsAsync(string VideoSourceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/SetImagingSettings", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	Task SetImagingSettingsAsync(string VideoSourceToken, ImagingSettings20 ImagingSettings, bool ForcePersistence);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[return: MessageParameterAttribute(Name = "ImagingOptions")]
	Task<ImagingOptions20> GetOptionsAsync(string VideoSourceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/Move", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	Task MoveAsync(string VideoSourceToken, FocusMove Focus);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetMoveOptions", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[return: MessageParameterAttribute(Name = "MoveOptions")]
	Task<MoveOptions20> GetMoveOptionsAsync(string VideoSourceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/FocusStop", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	Task StopAsync(string VideoSourceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetStatus", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[return: MessageParameterAttribute(Name = "Status")]
	Task<ImagingStatus20> GetStatusAsync(string VideoSourceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetPresets", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	Task<GetPresetsResponse> GetPresetsAsync(GetPresetsRequest request);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/GetCurrentPreset", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	[return: MessageParameterAttribute(Name = "Preset")]
	Task<ImagingPreset> GetCurrentPresetAsync(string VideoSourceToken);

	[OperationContractAttribute(Action = "http://www.onvif.org/ver20/imaging/wsdl/SetCurrentPreset", ReplyAction = "*")]
	[XmlSerializerFormatAttribute(SupportFaults = true)]
	Task SetCurrentPresetAsync(string VideoSourceToken, string PresetToken);
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPresets", WrapperNamespace = "http://www.onvif.org/ver20/imaging/wsdl", IsWrapped = true)]
public partial class GetPresetsRequest
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl", Order = 0)]
	public string VideoSourceToken;

	public GetPresetsRequest()
	{
	}

	public GetPresetsRequest(string VideoSourceToken)
	{
		this.VideoSourceToken = VideoSourceToken;
	}
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
[MessageContractAttribute(WrapperName = "GetPresetsResponse", WrapperNamespace = "http://www.onvif.org/ver20/imaging/wsdl", IsWrapped = true)]
public partial class GetPresetsResponse
{

	[MessageBodyMemberAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl", Order = 0)]
	[XmlElementAttribute("Preset")]
	public ImagingPreset[] Preset;

	public GetPresetsResponse()
	{
	}

	public GetPresetsResponse(ImagingPreset[] Preset)
	{
		this.Preset = Preset;
	}
}

[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public interface ImagingChannel : Imaging, IClientChannel
{
}

[DebuggerStepThroughAttribute()]
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
public partial class ImagingClient : ClientBase<Imaging>, Imaging
{

	internal ImagingClient(Binding binding, EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
	{
	}

	public Task<Capabilities> GetServiceCapabilitiesAsync()
	{
		return base.Channel.GetServiceCapabilitiesAsync();
	}

	public Task<ImagingSettings20> GetImagingSettingsAsync(string VideoSourceToken)
	{
		return base.Channel.GetImagingSettingsAsync(VideoSourceToken);
	}

	public Task SetImagingSettingsAsync(string VideoSourceToken, ImagingSettings20 ImagingSettings, bool ForcePersistence)
	{
		return base.Channel.SetImagingSettingsAsync(VideoSourceToken, ImagingSettings, ForcePersistence);
	}

	public Task<ImagingOptions20> GetOptionsAsync(string VideoSourceToken)
	{
		return base.Channel.GetOptionsAsync(VideoSourceToken);
	}

	public Task MoveAsync(string VideoSourceToken, FocusMove Focus)
	{
		return base.Channel.MoveAsync(VideoSourceToken, Focus);
	}

	public Task<MoveOptions20> GetMoveOptionsAsync(string VideoSourceToken)
	{
		return base.Channel.GetMoveOptionsAsync(VideoSourceToken);
	}

	public Task StopAsync(string VideoSourceToken)
	{
		return base.Channel.StopAsync(VideoSourceToken);
	}

	public Task<ImagingStatus20> GetStatusAsync(string VideoSourceToken)
	{
		return base.Channel.GetStatusAsync(VideoSourceToken);
	}

	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	Task<GetPresetsResponse> Imaging.GetPresetsAsync(GetPresetsRequest request)
	{
		return base.Channel.GetPresetsAsync(request);
	}

	public Task<GetPresetsResponse> GetPresetsAsync(string VideoSourceToken)
	{
		GetPresetsRequest inValue = new GetPresetsRequest();
		inValue.VideoSourceToken = VideoSourceToken;
		return ((Imaging)(this)).GetPresetsAsync(inValue);
	}

	public Task<ImagingPreset> GetCurrentPresetAsync(string VideoSourceToken)
	{
		return base.Channel.GetCurrentPresetAsync(VideoSourceToken);
	}

	public Task SetCurrentPresetAsync(string VideoSourceToken, string PresetToken)
	{
		return base.Channel.SetCurrentPresetAsync(VideoSourceToken, PresetToken);
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
