using Onvif.Core.Client.Common;

namespace Onvif.Core.Client.Ptz
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", ConfigurationName="Onvif.Core.Client.Ptz.PTZ")]
    public interface PTZ
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetServiceCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Capabilities")]
        System.Threading.Tasks.Task<Capabilities> GetServiceCapabilitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetNodes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetNodesResponse> GetNodesAsync(Onvif.Core.Client.Ptz.GetNodesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetNode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PTZNode")]
        System.Threading.Tasks.Task<PTZNode> GetNodeAsync(string NodeToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PTZConfiguration")]
        System.Threading.Tasks.Task<PTZConfiguration> GetConfigurationAsync(string PTZConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetConfigurationsResponse> GetConfigurationsAsync(Onvif.Core.Client.Ptz.GetConfigurationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/SetConfiguration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetConfigurationAsync(PTZConfiguration PTZConfiguration, bool ForcePersistence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetConfigurationOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PTZConfigurationOptions")]
        System.Threading.Tasks.Task<PTZConfigurationOptions> GetConfigurationOptionsAsync(string ConfigurationToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/SendAuxiliaryCommand", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="AuxiliaryResponse")]
        System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string ProfileToken, string AuxiliaryData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetPresets", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetPresetsResponse> GetPresetsAsync(Onvif.Core.Client.Ptz.GetPresetsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/SetPreset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.SetPresetResponse> SetPresetAsync(Onvif.Core.Client.Ptz.SetPresetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/RemovePreset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemovePresetAsync(string ProfileToken, string PresetToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GotoPreset", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task GotoPresetAsync(string ProfileToken, string PresetToken, PTZSpeed Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GotoHomePosition", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task GotoHomePositionAsync(string ProfileToken, PTZSpeed Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/SetHomePosition", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task SetHomePositionAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/ContinuousMove", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.ContinuousMoveResponse> ContinuousMoveAsync(Onvif.Core.Client.Ptz.ContinuousMoveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/RelativeMove", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RelativeMoveAsync(string ProfileToken, PTZVector Translation, PTZSpeed Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PTZStatus")]
        System.Threading.Tasks.Task<PTZStatus> GetStatusAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/AbsoluteMove", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task AbsoluteMoveAsync(string ProfileToken, PTZVector Position, PTZSpeed Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GeoMove", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task GeoMoveAsync(string ProfileToken, GeoLocation Target, PTZSpeed Speed, float AreaHeight, float AreaWidth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/Stop", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task StopAsync(string ProfileToken, bool PanTilt, bool Zoom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetPresetTours", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetPresetToursResponse> GetPresetToursAsync(Onvif.Core.Client.Ptz.GetPresetToursRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetPresetTour", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PresetTour")]
        System.Threading.Tasks.Task<PresetTour> GetPresetTourAsync(string ProfileToken, string PresetTourToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetPresetTourOptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Options")]
        System.Threading.Tasks.Task<PTZPresetTourOptions> GetPresetTourOptionsAsync(string ProfileToken, string PresetTourToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/CreatePresetTour", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PresetTourToken")]
        System.Threading.Tasks.Task<string> CreatePresetTourAsync(string ProfileToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/ModifyPresetTour", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task ModifyPresetTourAsync(string ProfileToken, PresetTour PresetTour);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/OperatePresetTour", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task OperatePresetTourAsync(string ProfileToken, string PresetTourToken, PTZPresetTourOperation Operation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/RemovePresetTour", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task RemovePresetTourAsync(string ProfileToken, string PresetTourToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.onvif.org/ver20/ptz/wsdl/GetCompatibleConfigurations", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConfigurationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DeviceEntity))]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetCompatibleConfigurationsResponse> GetCompatibleConfigurationsAsync(Onvif.Core.Client.Ptz.GetCompatibleConfigurationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNodes", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetNodesRequest
    {
        
        public GetNodesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNodesResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetNodesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("PTZNode")]
        public PTZNode[] PTZNode;
        
        public GetNodesResponse()
        {
        }
        
        public GetNodesResponse(PTZNode[] PTZNode)
        {
            this.PTZNode = PTZNode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetConfigurations", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetConfigurationsRequest
    {
        
        public GetConfigurationsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("PTZConfiguration")]
        public PTZConfiguration[] PTZConfiguration;
        
        public GetConfigurationsResponse()
        {
        }
        
        public GetConfigurationsResponse(PTZConfiguration[] PTZConfiguration)
        {
            this.PTZConfiguration = PTZConfiguration;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPresets", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetPresetsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetPresetsRequest()
        {
        }
        
        public GetPresetsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPresetsResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetPresetsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Preset")]
        public PTZPreset[] Preset;
        
        public GetPresetsResponse()
        {
        }
        
        public GetPresetsResponse(PTZPreset[] Preset)
        {
            this.Preset = Preset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetPreset", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class SetPresetRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        public string ProfileToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=1)]
        public string PresetName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=2)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetPresetResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class SetPresetResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        public string PresetToken;
        
        public SetPresetResponse()
        {
        }
        
        public SetPresetResponse(string PresetToken)
        {
            this.PresetToken = PresetToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContinuousMove", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class ContinuousMoveRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        public string ProfileToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=1)]
        public PTZSpeed Velocity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Timeout;
        
        public ContinuousMoveRequest()
        {
        }
        
        public ContinuousMoveRequest(string ProfileToken, PTZSpeed Velocity, string Timeout)
        {
            this.ProfileToken = ProfileToken;
            this.Velocity = Velocity;
            this.Timeout = Timeout;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ContinuousMoveResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class ContinuousMoveResponse
    {
        
        public ContinuousMoveResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPresetTours", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetPresetToursRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetPresetToursRequest()
        {
        }
        
        public GetPresetToursRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPresetToursResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetPresetToursResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("PresetTour")]
        public PresetTour[] PresetTour;
        
        public GetPresetToursResponse()
        {
        }
        
        public GetPresetToursResponse(PresetTour[] PresetTour)
        {
            this.PresetTour = PresetTour;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleConfigurations", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetCompatibleConfigurationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        public string ProfileToken;
        
        public GetCompatibleConfigurationsRequest()
        {
        }
        
        public GetCompatibleConfigurationsRequest(string ProfileToken)
        {
            this.ProfileToken = ProfileToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCompatibleConfigurationsResponse", WrapperNamespace="http://www.onvif.org/ver20/ptz/wsdl", IsWrapped=true)]
    public partial class GetCompatibleConfigurationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.onvif.org/ver20/ptz/wsdl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("PTZConfiguration")]
        public PTZConfiguration[] PTZConfiguration;
        
        public GetCompatibleConfigurationsResponse()
        {
        }
        
        public GetCompatibleConfigurationsResponse(PTZConfiguration[] PTZConfiguration)
        {
            this.PTZConfiguration = PTZConfiguration;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public interface PTZChannel : Onvif.Core.Client.Ptz.PTZ, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
    public partial class PTZClient : System.ServiceModel.ClientBase<Onvif.Core.Client.Ptz.PTZ>, Onvif.Core.Client.Ptz.PTZ
    {
        
        internal PTZClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Capabilities> GetServiceCapabilitiesAsync()
        {
            return base.Channel.GetServiceCapabilitiesAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetNodesResponse> Onvif.Core.Client.Ptz.PTZ.GetNodesAsync(Onvif.Core.Client.Ptz.GetNodesRequest request)
        {
            return base.Channel.GetNodesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetNodesResponse> GetNodesAsync()
        {
            Onvif.Core.Client.Ptz.GetNodesRequest inValue = new Onvif.Core.Client.Ptz.GetNodesRequest();
            return ((Onvif.Core.Client.Ptz.PTZ)(this)).GetNodesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<PTZNode> GetNodeAsync(string NodeToken)
        {
            return base.Channel.GetNodeAsync(NodeToken);
        }
        
        public System.Threading.Tasks.Task<PTZConfiguration> GetConfigurationAsync(string PTZConfigurationToken)
        {
            return base.Channel.GetConfigurationAsync(PTZConfigurationToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetConfigurationsResponse> Onvif.Core.Client.Ptz.PTZ.GetConfigurationsAsync(Onvif.Core.Client.Ptz.GetConfigurationsRequest request)
        {
            return base.Channel.GetConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetConfigurationsResponse> GetConfigurationsAsync()
        {
            Onvif.Core.Client.Ptz.GetConfigurationsRequest inValue = new Onvif.Core.Client.Ptz.GetConfigurationsRequest();
            return ((Onvif.Core.Client.Ptz.PTZ)(this)).GetConfigurationsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task SetConfigurationAsync(PTZConfiguration PTZConfiguration, bool ForcePersistence)
        {
            return base.Channel.SetConfigurationAsync(PTZConfiguration, ForcePersistence);
        }
        
        public System.Threading.Tasks.Task<PTZConfigurationOptions> GetConfigurationOptionsAsync(string ConfigurationToken)
        {
            return base.Channel.GetConfigurationOptionsAsync(ConfigurationToken);
        }
        
        public System.Threading.Tasks.Task<string> SendAuxiliaryCommandAsync(string ProfileToken, string AuxiliaryData)
        {
            return base.Channel.SendAuxiliaryCommandAsync(ProfileToken, AuxiliaryData);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetPresetsResponse> Onvif.Core.Client.Ptz.PTZ.GetPresetsAsync(Onvif.Core.Client.Ptz.GetPresetsRequest request)
        {
            return base.Channel.GetPresetsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetPresetsResponse> GetPresetsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Ptz.GetPresetsRequest inValue = new Onvif.Core.Client.Ptz.GetPresetsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Ptz.PTZ)(this)).GetPresetsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.SetPresetResponse> SetPresetAsync(Onvif.Core.Client.Ptz.SetPresetRequest request)
        {
            return base.Channel.SetPresetAsync(request);
        }
        
        public System.Threading.Tasks.Task RemovePresetAsync(string ProfileToken, string PresetToken)
        {
            return base.Channel.RemovePresetAsync(ProfileToken, PresetToken);
        }
        
        public System.Threading.Tasks.Task GotoPresetAsync(string ProfileToken, string PresetToken, PTZSpeed Speed)
        {
            return base.Channel.GotoPresetAsync(ProfileToken, PresetToken, Speed);
        }
        
        public System.Threading.Tasks.Task GotoHomePositionAsync(string ProfileToken, PTZSpeed Speed)
        {
            return base.Channel.GotoHomePositionAsync(ProfileToken, Speed);
        }
        
        public System.Threading.Tasks.Task SetHomePositionAsync(string ProfileToken)
        {
            return base.Channel.SetHomePositionAsync(ProfileToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.ContinuousMoveResponse> Onvif.Core.Client.Ptz.PTZ.ContinuousMoveAsync(Onvif.Core.Client.Ptz.ContinuousMoveRequest request)
        {
            return base.Channel.ContinuousMoveAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.ContinuousMoveResponse> ContinuousMoveAsync(string ProfileToken, PTZSpeed Velocity, string Timeout)
        {
            Onvif.Core.Client.Ptz.ContinuousMoveRequest inValue = new Onvif.Core.Client.Ptz.ContinuousMoveRequest();
            inValue.ProfileToken = ProfileToken;
            inValue.Velocity = Velocity;
            inValue.Timeout = Timeout;
            return ((Onvif.Core.Client.Ptz.PTZ)(this)).ContinuousMoveAsync(inValue);
        }
        
        public System.Threading.Tasks.Task RelativeMoveAsync(string ProfileToken, PTZVector Translation, PTZSpeed Speed)
        {
            return base.Channel.RelativeMoveAsync(ProfileToken, Translation, Speed);
        }
        
        public System.Threading.Tasks.Task<PTZStatus> GetStatusAsync(string ProfileToken)
        {
            return base.Channel.GetStatusAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task AbsoluteMoveAsync(string ProfileToken, PTZVector Position, PTZSpeed Speed)
        {
            return base.Channel.AbsoluteMoveAsync(ProfileToken, Position, Speed);
        }
        
        public System.Threading.Tasks.Task GeoMoveAsync(string ProfileToken, GeoLocation Target, PTZSpeed Speed, float AreaHeight, float AreaWidth)
        {
            return base.Channel.GeoMoveAsync(ProfileToken, Target, Speed, AreaHeight, AreaWidth);
        }
        
        public System.Threading.Tasks.Task StopAsync(string ProfileToken, bool PanTilt, bool Zoom)
        {
            return base.Channel.StopAsync(ProfileToken, PanTilt, Zoom);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetPresetToursResponse> Onvif.Core.Client.Ptz.PTZ.GetPresetToursAsync(Onvif.Core.Client.Ptz.GetPresetToursRequest request)
        {
            return base.Channel.GetPresetToursAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetPresetToursResponse> GetPresetToursAsync(string ProfileToken)
        {
            Onvif.Core.Client.Ptz.GetPresetToursRequest inValue = new Onvif.Core.Client.Ptz.GetPresetToursRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Ptz.PTZ)(this)).GetPresetToursAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<PresetTour> GetPresetTourAsync(string ProfileToken, string PresetTourToken)
        {
            return base.Channel.GetPresetTourAsync(ProfileToken, PresetTourToken);
        }
        
        public System.Threading.Tasks.Task<PTZPresetTourOptions> GetPresetTourOptionsAsync(string ProfileToken, string PresetTourToken)
        {
            return base.Channel.GetPresetTourOptionsAsync(ProfileToken, PresetTourToken);
        }
        
        public System.Threading.Tasks.Task<string> CreatePresetTourAsync(string ProfileToken)
        {
            return base.Channel.CreatePresetTourAsync(ProfileToken);
        }
        
        public System.Threading.Tasks.Task ModifyPresetTourAsync(string ProfileToken, PresetTour PresetTour)
        {
            return base.Channel.ModifyPresetTourAsync(ProfileToken, PresetTour);
        }
        
        public System.Threading.Tasks.Task OperatePresetTourAsync(string ProfileToken, string PresetTourToken, PTZPresetTourOperation Operation)
        {
            return base.Channel.OperatePresetTourAsync(ProfileToken, PresetTourToken, Operation);
        }
        
        public System.Threading.Tasks.Task RemovePresetTourAsync(string ProfileToken, string PresetTourToken)
        {
            return base.Channel.RemovePresetTourAsync(ProfileToken, PresetTourToken);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetCompatibleConfigurationsResponse> Onvif.Core.Client.Ptz.PTZ.GetCompatibleConfigurationsAsync(Onvif.Core.Client.Ptz.GetCompatibleConfigurationsRequest request)
        {
            return base.Channel.GetCompatibleConfigurationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Onvif.Core.Client.Ptz.GetCompatibleConfigurationsResponse> GetCompatibleConfigurationsAsync(string ProfileToken)
        {
            Onvif.Core.Client.Ptz.GetCompatibleConfigurationsRequest inValue = new Onvif.Core.Client.Ptz.GetCompatibleConfigurationsRequest();
            inValue.ProfileToken = ProfileToken;
            return ((Onvif.Core.Client.Ptz.PTZ)(this)).GetCompatibleConfigurationsAsync(inValue);
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
