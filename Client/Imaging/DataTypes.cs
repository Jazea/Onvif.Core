using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Onvif.Core.Client.Imaging;

/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
public partial class Capabilities
{

    private XElement[] anyField;

    private bool imageStabilizationField;

    private bool imageStabilizationFieldSpecified;

    private bool presetsField;

    private bool presetsFieldSpecified;

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
    public bool ImageStabilization
    {
        get
        {
            return this.imageStabilizationField;
        }
        set
        {
            this.imageStabilizationField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool ImageStabilizationSpecified
    {
        get
        {
            return this.imageStabilizationFieldSpecified;
        }
        set
        {
            this.imageStabilizationFieldSpecified = value;
        }
    }

    /// <remarks/>
    [XmlAttributeAttribute()]
    public bool Presets
    {
        get
        {
            return this.presetsField;
        }
        set
        {
            this.presetsField = value;
        }
    }

    /// <remarks/>
    [XmlIgnoreAttribute()]
    public bool PresetsSpecified
    {
        get
        {
            return this.presetsFieldSpecified;
        }
        set
        {
            this.presetsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
public partial class ImagingPreset
{

    private string nameField;

    private string tokenField;

    private string typeField;

    /// <remarks/>
    [XmlElementAttribute(Order = 0)]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
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
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}