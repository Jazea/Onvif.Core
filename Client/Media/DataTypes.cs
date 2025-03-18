using Onvif.Core.Client.Common;

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Onvif.Core.Client.Media;

/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
public partial class Capabilities
{

    private ProfileCapabilities profileCapabilitiesField;

    private StreamingCapabilities streamingCapabilitiesField;

    private XElement[] anyField;

    private bool snapshotUriField;

    private bool snapshotUriFieldSpecified;

    private bool rotationField;

    private bool rotationFieldSpecified;

    private bool videoSourceModeField;

    private bool videoSourceModeFieldSpecified;

    private bool oSDField;

    private bool oSDFieldSpecified;

    private bool temporaryOSDTextField;

    private bool temporaryOSDTextFieldSpecified;

    private bool eXICompressionField;

    private bool eXICompressionFieldSpecified;

    /// <remarks/>
    [XmlElementAttribute(Order = 0)]
    public ProfileCapabilities ProfileCapabilities
    {
        get
        {
            return this.profileCapabilitiesField;
        }
        set
        {
            this.profileCapabilitiesField = value;
        }
    }

    /// <remarks/>
    [XmlElementAttribute(Order = 1)]
    public StreamingCapabilities StreamingCapabilities
    {
        get
        {
            return this.streamingCapabilitiesField;
        }
        set
        {
            this.streamingCapabilitiesField = value;
        }
    }

    /// <remarks/>
    [XmlAnyElementAttribute(Order = 2)]
    public XElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool SnapshotUri
    {
        get
        {
            return this.snapshotUriField;
        }
        set
        {
            this.snapshotUriField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool SnapshotUriSpecified
    {
        get
        {
            return this.snapshotUriFieldSpecified;
        }
        set
        {
            this.snapshotUriFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool Rotation
    {
        get
        {
            return this.rotationField;
        }
        set
        {
            this.rotationField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool RotationSpecified
    {
        get
        {
            return this.rotationFieldSpecified;
        }
        set
        {
            this.rotationFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool VideoSourceMode
    {
        get
        {
            return this.videoSourceModeField;
        }
        set
        {
            this.videoSourceModeField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool VideoSourceModeSpecified
    {
        get
        {
            return this.videoSourceModeFieldSpecified;
        }
        set
        {
            this.videoSourceModeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool OSD
    {
        get
        {
            return this.oSDField;
        }
        set
        {
            this.oSDField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool OSDSpecified
    {
        get
        {
            return this.oSDFieldSpecified;
        }
        set
        {
            this.oSDFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool TemporaryOSDText
    {
        get
        {
            return this.temporaryOSDTextField;
        }
        set
        {
            this.temporaryOSDTextField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool TemporaryOSDTextSpecified
    {
        get
        {
            return this.temporaryOSDTextFieldSpecified;
        }
        set
        {
            this.temporaryOSDTextFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool EXICompression
    {
        get
        {
            return this.eXICompressionField;
        }
        set
        {
            this.eXICompressionField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool EXICompressionSpecified
    {
        get
        {
            return this.eXICompressionFieldSpecified;
        }
        set
        {
            this.eXICompressionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
public partial class ProfileCapabilities
{

    private XElement[] anyField;

    private int maximumNumberOfProfilesField;

    private bool maximumNumberOfProfilesFieldSpecified;

    /// <remarks/>
    [XmlAnyElementAttribute(Order = 0)]
    public XElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public int MaximumNumberOfProfiles
    {
        get
        {
            return this.maximumNumberOfProfilesField;
        }
        set
        {
            this.maximumNumberOfProfilesField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool MaximumNumberOfProfilesSpecified
    {
        get
        {
            return this.maximumNumberOfProfilesFieldSpecified;
        }
        set
        {
            this.maximumNumberOfProfilesFieldSpecified = value;
        }
    }
}


/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
public partial class VideoSourceModeExtension
{

    private XElement[] anyField;

    /// <remarks/>
    [XmlAnyElementAttribute(Order = 0)]
    public XElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
public partial class VideoSourceMode
{

    private float maxFramerateField;

    private VideoResolution maxResolutionField;

    private string encodingsField;

    private bool rebootField;

    private string descriptionField;

    private VideoSourceModeExtension extensionField;

    private string tokenField;

    private bool enabledField;

    private bool enabledFieldSpecified;

    /// <remarks/>
    [XmlElementAttribute(Order = 0)]
    public float MaxFramerate
    {
        get
        {
            return this.maxFramerateField;
        }
        set
        {
            this.maxFramerateField = value;
        }
    }

    /// <remarks/>
    [XmlElementAttribute(Order = 1)]
    public VideoResolution MaxResolution
    {
        get
        {
            return this.maxResolutionField;
        }
        set
        {
            this.maxResolutionField = value;
        }
    }

    /// <remarks/>
    [XmlElementAttribute(Order = 2)]
    public string Encodings
    {
        get
        {
            return this.encodingsField;
        }
        set
        {
            this.encodingsField = value;
        }
    }

    /// <remarks/>
    [XmlElementAttribute(Order = 3)]
    public bool Reboot
    {
        get
        {
            return this.rebootField;
        }
        set
        {
            this.rebootField = value;
        }
    }

    /// <remarks/>
    [XmlElementAttribute(Order = 4)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [XmlElementAttribute(Order = 5)]
    public VideoSourceModeExtension Extension
    {
        get
        {
            return this.extensionField;
        }
        set
        {
            this.extensionField = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public string token
    {
        get
        {
            return this.tokenField;
        }
        set
        {
            this.tokenField = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool EnabledSpecified
    {
        get
        {
            return this.enabledFieldSpecified;
        }
        set
        {
            this.enabledFieldSpecified = value;
        }
    }
}


/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
public partial class StreamingCapabilities
{

    private XElement[] anyField;

    private bool rTPMulticastField;

    private bool rTPMulticastFieldSpecified;

    private bool rTP_TCPField;

    private bool rTP_TCPFieldSpecified;

    private bool rTP_RTSP_TCPField;

    private bool rTP_RTSP_TCPFieldSpecified;

    private bool nonAggregateControlField;

    private bool nonAggregateControlFieldSpecified;

    private bool noRTSPStreamingField;

    private bool noRTSPStreamingFieldSpecified;

    /// <remarks/>
    [XmlAnyElementAttribute(Order = 0)]
    public XElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool RTPMulticast
    {
        get
        {
            return this.rTPMulticastField;
        }
        set
        {
            this.rTPMulticastField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool RTPMulticastSpecified
    {
        get
        {
            return this.rTPMulticastFieldSpecified;
        }
        set
        {
            this.rTPMulticastFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool RTP_TCP
    {
        get
        {
            return this.rTP_TCPField;
        }
        set
        {
            this.rTP_TCPField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool RTP_TCPSpecified
    {
        get
        {
            return this.rTP_TCPFieldSpecified;
        }
        set
        {
            this.rTP_TCPFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool RTP_RTSP_TCP
    {
        get
        {
            return this.rTP_RTSP_TCPField;
        }
        set
        {
            this.rTP_RTSP_TCPField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool RTP_RTSP_TCPSpecified
    {
        get
        {
            return this.rTP_RTSP_TCPFieldSpecified;
        }
        set
        {
            this.rTP_RTSP_TCPFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool NonAggregateControl
    {
        get
        {
            return this.nonAggregateControlField;
        }
        set
        {
            this.nonAggregateControlField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool NonAggregateControlSpecified
    {
        get
        {
            return this.nonAggregateControlFieldSpecified;
        }
        set
        {
            this.nonAggregateControlFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool NoRTSPStreaming
    {
        get
        {
            return this.noRTSPStreamingField;
        }
        set
        {
            this.noRTSPStreamingField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool NoRTSPStreamingSpecified
    {
        get
        {
            return this.noRTSPStreamingFieldSpecified;
        }
        set
        {
            this.noRTSPStreamingFieldSpecified = value;
        }
    }
}