using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Onvif.Core.Client.Ptz;

/// <remarks/>
[GeneratedCodeAttribute("dotnet-svcutil", "1.0.3")]
[DebuggerStepThroughAttribute()]
[XmlTypeAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
public partial class Capabilities
{

	private XElement[] anyField;

	private bool eFlipField;

	private bool eFlipFieldSpecified;

	private bool reverseField;

	private bool reverseFieldSpecified;

	private bool getCompatibleConfigurationsField;

	private bool getCompatibleConfigurationsFieldSpecified;

	private bool moveStatusField;

	private bool moveStatusFieldSpecified;

	private bool statusPositionField;

	private bool statusPositionFieldSpecified;

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
	public bool EFlip
	{
		get
		{
			return this.eFlipField;
		}
		set
		{
			this.eFlipField = value;
		}
	}

	/// <remarks/>
	[XmlIgnoreAttribute()]
	public bool EFlipSpecified
	{
		get
		{
			return this.eFlipFieldSpecified;
		}
		set
		{
			this.eFlipFieldSpecified = value;
		}
	}

	/// <remarks/>
	[XmlAttributeAttribute()]
	public bool Reverse
	{
		get
		{
			return this.reverseField;
		}
		set
		{
			this.reverseField = value;
		}
	}

	/// <remarks/>
	[XmlIgnoreAttribute()]
	public bool ReverseSpecified
	{
		get
		{
			return this.reverseFieldSpecified;
		}
		set
		{
			this.reverseFieldSpecified = value;
		}
	}

	/// <remarks/>
	[XmlAttributeAttribute()]
	public bool GetCompatibleConfigurations
	{
		get
		{
			return this.getCompatibleConfigurationsField;
		}
		set
		{
			this.getCompatibleConfigurationsField = value;
		}
	}

	/// <remarks/>
	[XmlIgnoreAttribute()]
	public bool GetCompatibleConfigurationsSpecified
	{
		get
		{
			return this.getCompatibleConfigurationsFieldSpecified;
		}
		set
		{
			this.getCompatibleConfigurationsFieldSpecified = value;
		}
	}

	/// <remarks/>
	[XmlAttributeAttribute()]
	public bool MoveStatus
	{
		get
		{
			return this.moveStatusField;
		}
		set
		{
			this.moveStatusField = value;
		}
	}

	/// <remarks/>
	[XmlIgnoreAttribute()]
	public bool MoveStatusSpecified
	{
		get
		{
			return this.moveStatusFieldSpecified;
		}
		set
		{
			this.moveStatusFieldSpecified = value;
		}
	}

	/// <remarks/>
	[XmlAttributeAttribute()]
	public bool StatusPosition
	{
		get
		{
			return this.statusPositionField;
		}
		set
		{
			this.statusPositionField = value;
		}
	}

	/// <remarks/>
	[XmlIgnoreAttribute()]
	public bool StatusPositionSpecified
	{
		get
		{
			return this.statusPositionFieldSpecified;
		}
		set
		{
			this.statusPositionFieldSpecified = value;
		}
	}
}