namespace Onvif.Core.Client.Ptz {
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
	public partial class Capabilities {

		private System.Xml.Linq.XElement [] anyField;

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
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool EFlip {
			get {
				return this.eFlipField;
			}
			set {
				this.eFlipField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool EFlipSpecified {
			get {
				return this.eFlipFieldSpecified;
			}
			set {
				this.eFlipFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool Reverse {
			get {
				return this.reverseField;
			}
			set {
				this.reverseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ReverseSpecified {
			get {
				return this.reverseFieldSpecified;
			}
			set {
				this.reverseFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool GetCompatibleConfigurations {
			get {
				return this.getCompatibleConfigurationsField;
			}
			set {
				this.getCompatibleConfigurationsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GetCompatibleConfigurationsSpecified {
			get {
				return this.getCompatibleConfigurationsFieldSpecified;
			}
			set {
				this.getCompatibleConfigurationsFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool MoveStatus {
			get {
				return this.moveStatusField;
			}
			set {
				this.moveStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MoveStatusSpecified {
			get {
				return this.moveStatusFieldSpecified;
			}
			set {
				this.moveStatusFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool StatusPosition {
			get {
				return this.statusPositionField;
			}
			set {
				this.statusPositionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool StatusPositionSpecified {
			get {
				return this.statusPositionFieldSpecified;
			}
			set {
				this.statusPositionFieldSpecified = value;
			}
		}
	}
}