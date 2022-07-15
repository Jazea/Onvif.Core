using Onvif.Core.Client.Common;

namespace Onvif.Core.Client.Imaging
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.onvif.org/ver20/imaging/wsdl", ConfigurationName="Onvif.Core.Client.Imaging.Imaging")]
    public interface Imaging
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetServiceCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Capabilities")]
        System.Threading.Tasks.Task<Capabilities> GetServiceCapabilitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetImagingSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ImagingSettings")]
        System.Threading.Tasks.Task<ImagingSettings20> GetImagingSettingsAsync(string VideoSourceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/SetImagingSettings", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task SetImagingSettingsAsync(string VideoSourceToken, ImagingSettings20 ImagingSettings, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ImagingOptions")]
        System.Threading.Tasks.Task<ImagingOptions20> GetOptionsAsync(string VideoSourceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/Move", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task MoveAsync(string VideoSourceToken, FocusMove Focus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetMoveOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MoveOptions")]
        System.Threading.Tasks.Task<MoveOptions20> GetMoveOptionsAsync(string VideoSourceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/FocusStop", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task StopAsync(string videoSourceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Status")]
        System.Threading.Tasks.Task<ImagingStatus20> GetStatusAsync(string VideoSourceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetPresets", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Imaging.GetPresetsResponse> GetPresetsAsync(Onvif.Core.Client.Imaging.GetPresetsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/GetCurrentPreset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Preset")]
        System.Threading.Tasks.Task<ImagingPreset> GetCurrentPresetAsync(string VideoSourceToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/imaging/wsdl/SetCurrentPreset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task SetCurrentPresetAsync(string VideoSourceToken, string PresetToken);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPresets", WrapperNamespace="http://www.onvif.org/ver20/imaging/wsdl", IsWrapped=true)]
    public partial class GetPresetsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/imaging/wsdl", Order=0)]
        public string VideoSourceToken;
        
        public GetPresetsRequest()
        {
        }
        
        public GetPresetsRequest(string VideoSourceToken)
        {
            this.VideoSourceToken = VideoSourceToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPresetsResponse", WrapperNamespace="http://www.onvif.org/ver20/imaging/wsdl", IsWrapped=true)]
    public partial class GetPresetsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/imaging/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Preset")]
        public ImagingPreset[] Preset;
        
        public GetPresetsResponse()
        {
        }
        
        public GetPresetsResponse(ImagingPreset[] Preset)
        {
            this.Preset = Preset;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public interface ImagingChannel : Onvif.Core.Client.Imaging.Imaging, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public partial class ImagingClient : System.ServiceModel.ClientBase<Onvif.Core.Client.Imaging.Imaging>, Onvif.Core.Client.Imaging.Imaging
    {
        
        internal ImagingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Capabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }
        
        public System.Threading.Tasks.Task<ImagingSettings20> GetImagingSettingsAsync(string videoSourceToken)
        {
            return base.Channel.GetImagingSettingsAsync(videoSourceToken);
        }
        
        public System.Threading.Tasks.Task SetImagingSettingsAsync(string videoSourceToken, ImagingSettings20 imagingSettings, bool forcePersistence)
        {
            return base.Channel.SetImagingSettingsAsync(videoSourceToken, imagingSettings, forcePersistence);
        }
        
        public System.Threading.Tasks.Task<ImagingOptions20> GetOptionsAsync(string videoSourceToken)
        {
            return base.Channel.GetOptionsAsync(videoSourceToken);
        }
        
        public System.Threading.Tasks.Task MoveAsync(string videoSourceToken, FocusMove focus)
        {
            return base.Channel.MoveAsync(videoSourceToken, focus);
        }
        
        public System.Threading.Tasks.Task<MoveOptions20> GetMoveOptionsAsync(string videoSourceToken)
        {
            return base.Channel.GetMoveOptionsAsync(videoSourceToken);
        }
        
        public System.Threading.Tasks.Task StopAsync(string VideoSourceToken)
        {
            return base.Channel.StopAsync(VideoSourceToken);
        }
        
        public System.Threading.Tasks.Task<ImagingStatus20> GetStatusAsync(string VideoSourceToken)
        {
            return base.Channel.GetStatusAsync(VideoSourceToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Imaging.GetPresetsResponse> Onvif.Core.Client.Imaging.Imaging.GetPresetsAsync(Onvif.Core.Client.Imaging.GetPresetsRequest request)
        {
            return base.Channel.GetPresetsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Imaging.GetPresetsResponse> GetPresetsAsync(string VideoSourceToken)
        {
            Onvif.Core.Client.Imaging.GetPresetsRequest inValue = new Onvif.Core.Client.Imaging.GetPresetsRequest();
            inValue.VideoSourceToken = VideoSourceToken;
            return ((Onvif.Core.Client.Imaging.Imaging)(this)).GetPresetsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ImagingPreset> GetCurrentPresetAsync(string VideoSourceToken)
        {
            return base.Channel.GetCurrentPresetAsync(VideoSourceToken);
        }
        
        public System.Threading.Tasks.Task SetCurrentPresetAsync(string VideoSourceToken, string PresetToken)
        {
            return base.Channel.SetCurrentPresetAsync(VideoSourceToken, PresetToken);
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
