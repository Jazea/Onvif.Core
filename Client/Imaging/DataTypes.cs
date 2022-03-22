namespace Onvif.Core.Client.Imaging {
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
	public partial class Capabilities {

		private System.Xml.Linq.XElement [] anyField;

		private bool imageStabilizationField;

		private bool imageStabilizationFieldSpecified;

		private bool presetsField;

		private bool presetsFieldSpecified;

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
		public bool ImageStabilization {
			get {
				return this.imageStabilizationField;
			}
			set {
				this.imageStabilizationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ImageStabilizationSpecified {
			get {
				return this.imageStabilizationFieldSpecified;
			}
			set {
				this.imageStabilizationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool Presets {
			get {
				return this.presetsField;
			}
			set {
				this.presetsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PresetsSpecified {
			get {
				return this.presetsFieldSpecified;
			}
			set {
				this.presetsFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
	public partial class ImagingPreset {

		private string nameField;

		private string tokenField;

		private string typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}
	}
}