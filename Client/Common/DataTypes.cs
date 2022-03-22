using Onvif.Core.Client.Device;

namespace Onvif.Core.Client.Common {
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OnvifVersion {

		private int majorField;

		private int minorField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Major {
			get {
				return this.majorField;
			}
			set {
				this.majorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Minor {
			get {
				return this.minorField;
			}
			set {
				this.minorField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LocalOrientation {

		private System.Xml.Linq.XElement [] anyField;

		private float panField;

		private bool panFieldSpecified;

		private float tiltField;

		private bool tiltFieldSpecified;

		private float rollField;

		private bool rollFieldSpecified;

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
		public float pan {
			get {
				return this.panField;
			}
			set {
				this.panField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool panSpecified {
			get {
				return this.panFieldSpecified;
			}
			set {
				this.panFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float tilt {
			get {
				return this.tiltField;
			}
			set {
				this.tiltField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool tiltSpecified {
			get {
				return this.tiltFieldSpecified;
			}
			set {
				this.tiltFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float roll {
			get {
				return this.rollField;
			}
			set {
				this.rollField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool rollSpecified {
			get {
				return this.rollFieldSpecified;
			}
			set {
				this.rollFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LocalLocation {

		private System.Xml.Linq.XElement [] anyField;

		private float xField;

		private bool xFieldSpecified;

		private float yField;

		private bool yFieldSpecified;

		private float zField;

		private bool zFieldSpecified;

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
		public float x {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool xSpecified {
			get {
				return this.xFieldSpecified;
			}
			set {
				this.xFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ySpecified {
			get {
				return this.yFieldSpecified;
			}
			set {
				this.yFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float z {
			get {
				return this.zField;
			}
			set {
				this.zField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool zSpecified {
			get {
				return this.zFieldSpecified;
			}
			set {
				this.zFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class GeoOrientation {

		private System.Xml.Linq.XElement [] anyField;

		private float rollField;

		private bool rollFieldSpecified;

		private float pitchField;

		private bool pitchFieldSpecified;

		private float yawField;

		private bool yawFieldSpecified;

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
		public float roll {
			get {
				return this.rollField;
			}
			set {
				this.rollField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool rollSpecified {
			get {
				return this.rollFieldSpecified;
			}
			set {
				this.rollFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float pitch {
			get {
				return this.pitchField;
			}
			set {
				this.pitchField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool pitchSpecified {
			get {
				return this.pitchFieldSpecified;
			}
			set {
				this.pitchFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float yaw {
			get {
				return this.yawField;
			}
			set {
				this.yawField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool yawSpecified {
			get {
				return this.yawFieldSpecified;
			}
			set {
				this.yawFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class GeoLocation {

		private System.Xml.Linq.XElement [] anyField;

		private double lonField;

		private bool lonFieldSpecified;

		private double latField;

		private bool latFieldSpecified;

		private float elevationField;

		private bool elevationFieldSpecified;

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
		public double lon {
			get {
				return this.lonField;
			}
			set {
				this.lonField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool lonSpecified {
			get {
				return this.lonFieldSpecified;
			}
			set {
				this.lonFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public double lat {
			get {
				return this.latField;
			}
			set {
				this.latField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool latSpecified {
			get {
				return this.latFieldSpecified;
			}
			set {
				this.latFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float elevation {
			get {
				return this.elevationField;
			}
			set {
				this.elevationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool elevationSpecified {
			get {
				return this.elevationFieldSpecified;
			}
			set {
				this.elevationFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LocationEntity {

		private GeoLocation geoLocationField;

		private GeoOrientation geoOrientationField;

		private LocalLocation localLocationField;

		private LocalOrientation localOrientationField;

		private string entityField;

		private string tokenField;

		private bool fixedField;

		private bool fixedFieldSpecified;

		private string geoSourceField;

		private bool autoGeoField;

		private bool autoGeoFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public GeoLocation GeoLocation {
			get {
				return this.geoLocationField;
			}
			set {
				this.geoLocationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public GeoOrientation GeoOrientation {
			get {
				return this.geoOrientationField;
			}
			set {
				this.geoOrientationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public LocalLocation LocalLocation {
			get {
				return this.localLocationField;
			}
			set {
				this.localLocationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public LocalOrientation LocalOrientation {
			get {
				return this.localOrientationField;
			}
			set {
				this.localOrientationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string Entity {
			get {
				return this.entityField;
			}
			set {
				this.entityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string Token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool Fixed {
			get {
				return this.fixedField;
			}
			set {
				this.fixedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool FixedSpecified {
			get {
				return this.fixedFieldSpecified;
			}
			set {
				this.fixedFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute (DataType = "anyURI")]
		public string GeoSource {
			get {
				return this.geoSourceField;
			}
			set {
				this.geoSourceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool AutoGeo {
			get {
				return this.autoGeoField;
			}
			set {
				this.autoGeoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AutoGeoSpecified {
			get {
				return this.autoGeoFieldSpecified;
			}
			set {
				this.autoGeoFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemLogUri {

		private SystemLogType typeField;

		private string uriField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public SystemLogType Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 1)]
		public string Uri {
			get {
				return this.uriField;
			}
			set {
				this.uriField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum SystemLogType {

		/// <remarks/>
		System,

		/// <remarks/>
		Access,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11AvailableNetworksExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11AvailableNetworks {

		private byte [] sSIDField;

		private string bSSIDField;

		private Dot11AuthAndMangementSuite [] authAndMangementSuiteField;

		private Dot11Cipher [] pairCipherField;

		private Dot11Cipher [] groupCipherField;

		private Dot11SignalStrength signalStrengthField;

		private bool signalStrengthFieldSpecified;

		private Dot11AvailableNetworksExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "hexBinary", Order = 0)]
		public byte [] SSID {
			get {
				return this.sSIDField;
			}
			set {
				this.sSIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string BSSID {
			get {
				return this.bSSIDField;
			}
			set {
				this.bSSIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AuthAndMangementSuite", Order = 2)]
		public Dot11AuthAndMangementSuite [] AuthAndMangementSuite {
			get {
				return this.authAndMangementSuiteField;
			}
			set {
				this.authAndMangementSuiteField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("PairCipher", Order = 3)]
		public Dot11Cipher [] PairCipher {
			get {
				return this.pairCipherField;
			}
			set {
				this.pairCipherField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("GroupCipher", Order = 4)]
		public Dot11Cipher [] GroupCipher {
			get {
				return this.groupCipherField;
			}
			set {
				this.groupCipherField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public Dot11SignalStrength SignalStrength {
			get {
				return this.signalStrengthField;
			}
			set {
				this.signalStrengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SignalStrengthSpecified {
			get {
				return this.signalStrengthFieldSpecified;
			}
			set {
				this.signalStrengthFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public Dot11AvailableNetworksExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Dot11AuthAndMangementSuite {

		/// <remarks/>
		None,

		/// <remarks/>
		Dot1X,

		/// <remarks/>
		PSK,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Dot11Cipher {

		/// <remarks/>
		CCMP,

		/// <remarks/>
		TKIP,

		/// <remarks/>
		Any,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Dot11SignalStrength {

		/// <remarks/>
		None,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute ("Very Bad")]
		VeryBad,

		/// <remarks/>
		Bad,

		/// <remarks/>
		Good,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute ("Very Good")]
		VeryGood,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11Status {

		private byte [] sSIDField;

		private string bSSIDField;

		private Dot11Cipher pairCipherField;

		private bool pairCipherFieldSpecified;

		private Dot11Cipher groupCipherField;

		private bool groupCipherFieldSpecified;

		private Dot11SignalStrength signalStrengthField;

		private bool signalStrengthFieldSpecified;

		private string activeConfigAliasField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "hexBinary", Order = 0)]
		public byte [] SSID {
			get {
				return this.sSIDField;
			}
			set {
				this.sSIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string BSSID {
			get {
				return this.bSSIDField;
			}
			set {
				this.bSSIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Dot11Cipher PairCipher {
			get {
				return this.pairCipherField;
			}
			set {
				this.pairCipherField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PairCipherSpecified {
			get {
				return this.pairCipherFieldSpecified;
			}
			set {
				this.pairCipherFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public Dot11Cipher GroupCipher {
			get {
				return this.groupCipherField;
			}
			set {
				this.groupCipherField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GroupCipherSpecified {
			get {
				return this.groupCipherFieldSpecified;
			}
			set {
				this.groupCipherFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public Dot11SignalStrength SignalStrength {
			get {
				return this.signalStrengthField;
			}
			set {
				this.signalStrengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SignalStrengthSpecified {
			get {
				return this.signalStrengthFieldSpecified;
			}
			set {
				this.signalStrengthFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public string ActiveConfigAlias {
			get {
				return this.activeConfigAliasField;
			}
			set {
				this.activeConfigAliasField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 6)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11Capabilities {

		private bool tKIPField;

		private bool scanAvailableNetworksField;

		private bool multipleConfigurationField;

		private bool adHocStationModeField;

		private bool wEPField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool TKIP {
			get {
				return this.tKIPField;
			}
			set {
				this.tKIPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool ScanAvailableNetworks {
			get {
				return this.scanAvailableNetworksField;
			}
			set {
				this.scanAvailableNetworksField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool MultipleConfiguration {
			get {
				return this.multipleConfigurationField;
			}
			set {
				this.multipleConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool AdHocStationMode {
			get {
				return this.adHocStationModeField;
			}
			set {
				this.adHocStationModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public bool WEP {
			get {
				return this.wEPField;
			}
			set {
				this.wEPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 5)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot1XConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EapMethodExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class TLSConfiguration {

		private string certificateIDField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string CertificateID {
			get {
				return this.certificateIDField;
			}
			set {
				this.certificateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EAPMethodConfiguration {

		private TLSConfiguration tLSConfigurationField;

		private string passwordField;

		private EapMethodExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public TLSConfiguration TLSConfiguration {
			get {
				return this.tLSConfigurationField;
			}
			set {
				this.tLSConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string Password {
			get {
				return this.passwordField;
			}
			set {
				this.passwordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public EapMethodExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot1XConfiguration {

		private string dot1XConfigurationTokenField;

		private string identityField;

		private string anonymousIDField;

		private int eAPMethodField;

		private string [] cACertificateIDField;

		private EAPMethodConfiguration eAPMethodConfigurationField;

		private Dot1XConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Dot1XConfigurationToken {
			get {
				return this.dot1XConfigurationTokenField;
			}
			set {
				this.dot1XConfigurationTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string Identity {
			get {
				return this.identityField;
			}
			set {
				this.identityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public string AnonymousID {
			get {
				return this.anonymousIDField;
			}
			set {
				this.anonymousIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public int EAPMethod {
			get {
				return this.eAPMethodField;
			}
			set {
				this.eAPMethodField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("CACertificateID", DataType = "token", Order = 4)]
		public string [] CACertificateID {
			get {
				return this.cACertificateIDField;
			}
			set {
				this.cACertificateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public EAPMethodConfiguration EAPMethodConfiguration {
			get {
				return this.eAPMethodConfigurationField;
			}
			set {
				this.eAPMethodConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public Dot1XConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CertificateInformationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DateTimeRange {

		private System.DateTime fromField;

		private System.DateTime untilField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public System.DateTime From {
			get {
				return this.fromField;
			}
			set {
				this.fromField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public System.DateTime Until {
			get {
				return this.untilField;
			}
			set {
				this.untilField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CertificateUsage {

		private bool criticalField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool Critical {
			get {
				return this.criticalField;
			}
			set {
				this.criticalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute ()]
		public string Value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CertificateInformation {

		private string certificateIDField;

		private string issuerDNField;

		private string subjectDNField;

		private CertificateUsage keyUsageField;

		private CertificateUsage extendedKeyUsageField;

		private int keyLengthField;

		private bool keyLengthFieldSpecified;

		private string versionField;

		private string serialNumField;

		private string signatureAlgorithmField;

		private DateTimeRange validityField;

		private CertificateInformationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string CertificateID {
			get {
				return this.certificateIDField;
			}
			set {
				this.certificateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string IssuerDN {
			get {
				return this.issuerDNField;
			}
			set {
				this.issuerDNField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public string SubjectDN {
			get {
				return this.subjectDNField;
			}
			set {
				this.subjectDNField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public CertificateUsage KeyUsage {
			get {
				return this.keyUsageField;
			}
			set {
				this.keyUsageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public CertificateUsage ExtendedKeyUsage {
			get {
				return this.extendedKeyUsageField;
			}
			set {
				this.extendedKeyUsageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public int KeyLength {
			get {
				return this.keyLengthField;
			}
			set {
				this.keyLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool KeyLengthSpecified {
			get {
				return this.keyLengthFieldSpecified;
			}
			set {
				this.keyLengthFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public string Version {
			get {
				return this.versionField;
			}
			set {
				this.versionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public string SerialNum {
			get {
				return this.serialNumField;
			}
			set {
				this.serialNumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public string SignatureAlgorithm {
			get {
				return this.signatureAlgorithmField;
			}
			set {
				this.signatureAlgorithmField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public DateTimeRange Validity {
			get {
				return this.validityField;
			}
			set {
				this.validityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public CertificateInformationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CertificateWithPrivateKey {

		private string certificateIDField;

		private BinaryData certificateField;

		private BinaryData privateKeyField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string CertificateID {
			get {
				return this.certificateIDField;
			}
			set {
				this.certificateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public BinaryData Certificate {
			get {
				return this.certificateField;
			}
			set {
				this.certificateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public BinaryData PrivateKey {
			get {
				return this.privateKeyField;
			}
			set {
				this.privateKeyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class BinaryData {

		private byte [] dataField;

		private string contentTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "base64Binary", Order = 0)]
		public byte [] Data {
			get {
				return this.dataField;
			}
			set {
				this.dataField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute (Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/2005/05/xmlmime")]
		public string contentType {
			get {
				return this.contentTypeField;
			}
			set {
				this.contentTypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CertificateStatus {

		private string certificateIDField;

		private bool statusField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string CertificateID {
			get {
				return this.certificateIDField;
			}
			set {
				this.certificateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Certificate {

		private string certificateIDField;

		private BinaryData certificate1Field;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string CertificateID {
			get {
				return this.certificateIDField;
			}
			set {
				this.certificateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Certificate", Order = 1)]
		public BinaryData Certificate1 {
			get {
				return this.certificate1Field;
			}
			set {
				this.certificate1Field = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPAddressFilterExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPAddressFilter {

		private IPAddressFilterType typeField;

		private PrefixedIPv4Address [] iPv4AddressField;

		private PrefixedIPv6Address [] iPv6AddressField;

		private IPAddressFilterExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IPAddressFilterType Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("IPv4Address", Order = 1)]
		public PrefixedIPv4Address [] IPv4Address {
			get {
				return this.iPv4AddressField;
			}
			set {
				this.iPv4AddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("IPv6Address", Order = 2)]
		public PrefixedIPv6Address [] IPv6Address {
			get {
				return this.iPv6AddressField;
			}
			set {
				this.iPv6AddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IPAddressFilterExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum IPAddressFilterType {

		/// <remarks/>
		Allow,

		/// <remarks/>
		Deny,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PrefixedIPv4Address {

		private string addressField;

		private int prefixLengthField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string Address {
			get {
				return this.addressField;
			}
			set {
				this.addressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int PrefixLength {
			get {
				return this.prefixLengthField;
			}
			set {
				this.prefixLengthField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PrefixedIPv6Address {

		private string addressField;

		private int prefixLengthField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string Address {
			get {
				return this.addressField;
			}
			set {
				this.addressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int PrefixLength {
			get {
				return this.prefixLengthField;
			}
			set {
				this.prefixLengthField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkZeroConfigurationExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkZeroConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

		private NetworkZeroConfiguration [] additionalField;

		private NetworkZeroConfigurationExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute ("Additional", Order = 1)]
		public NetworkZeroConfiguration [] Additional {
			get {
				return this.additionalField;
			}
			set {
				this.additionalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public NetworkZeroConfigurationExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkZeroConfiguration {

		private string interfaceTokenField;

		private bool enabledField;

		private string [] addressesField;

		private NetworkZeroConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string InterfaceToken {
			get {
				return this.interfaceTokenField;
			}
			set {
				this.interfaceTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Addresses", DataType = "token", Order = 2)]
		public string [] Addresses {
			get {
				return this.addressesField;
			}
			set {
				this.addressesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public NetworkZeroConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkGateway {

		private string [] iPv4AddressField;

		private string [] iPv6AddressField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("IPv4Address", DataType = "token", Order = 0)]
		public string [] IPv4Address {
			get {
				return this.iPv4AddressField;
			}
			set {
				this.iPv4AddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("IPv6Address", DataType = "token", Order = 1)]
		public string [] IPv6Address {
			get {
				return this.iPv6AddressField;
			}
			set {
				this.iPv6AddressField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkProtocolExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkProtocol {

		private NetworkProtocolType nameField;

		private bool enabledField;

		private int [] portField;

		private NetworkProtocolExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public NetworkProtocolType Name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Port", Order = 2)]
		public int [] Port {
			get {
				return this.portField;
			}
			set {
				this.portField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public NetworkProtocolExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum NetworkProtocolType {

		/// <remarks/>
		HTTP,

		/// <remarks/>
		HTTPS,

		/// <remarks/>
		RTSP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceSetConfigurationExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceSetConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

		private Dot3Configuration [] dot3Field;

		private Dot11Configuration [] dot11Field;

		private NetworkInterfaceSetConfigurationExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute ("Dot3", Order = 1)]
		public Dot3Configuration [] Dot3 {
			get {
				return this.dot3Field;
			}
			set {
				this.dot3Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Dot11", Order = 2)]
		public Dot11Configuration [] Dot11 {
			get {
				return this.dot11Field;
			}
			set {
				this.dot11Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public NetworkInterfaceSetConfigurationExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot3Configuration {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11Configuration {

		private byte [] sSIDField;

		private Dot11StationMode modeField;

		private string aliasField;

		private string priorityField;

		private Dot11SecurityConfiguration securityField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "hexBinary", Order = 0)]
		public byte [] SSID {
			get {
				return this.sSIDField;
			}
			set {
				this.sSIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Dot11StationMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public string Alias {
			get {
				return this.aliasField;
			}
			set {
				this.aliasField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "integer", Order = 3)]
		public string Priority {
			get {
				return this.priorityField;
			}
			set {
				this.priorityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public Dot11SecurityConfiguration Security {
			get {
				return this.securityField;
			}
			set {
				this.securityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 5)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Dot11StationMode {

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute ("Ad-hoc")]
		Adhoc,

		/// <remarks/>
		Infrastructure,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11SecurityConfiguration {

		private Dot11SecurityMode modeField;

		private Dot11Cipher algorithmField;

		private bool algorithmFieldSpecified;

		private Dot11PSKSet pSKField;

		private string dot1XField;

		private Dot11SecurityConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Dot11SecurityMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Dot11Cipher Algorithm {
			get {
				return this.algorithmField;
			}
			set {
				this.algorithmField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AlgorithmSpecified {
			get {
				return this.algorithmFieldSpecified;
			}
			set {
				this.algorithmFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Dot11PSKSet PSK {
			get {
				return this.pSKField;
			}
			set {
				this.pSKField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public string Dot1X {
			get {
				return this.dot1XField;
			}
			set {
				this.dot1XField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public Dot11SecurityConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Dot11SecurityMode {

		/// <remarks/>
		None,

		/// <remarks/>
		WEP,

		/// <remarks/>
		PSK,

		/// <remarks/>
		Dot1X,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11PSKSet {

		private byte [] keyField;

		private string passphraseField;

		private Dot11PSKSetExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "hexBinary", Order = 0)]
		public byte [] Key {
			get {
				return this.keyField;
			}
			set {
				this.keyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string Passphrase {
			get {
				return this.passphraseField;
			}
			set {
				this.passphraseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Dot11PSKSetExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11PSKSetExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Dot11SecurityConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv6NetworkInterfaceSetConfiguration {

		private bool enabledField;

		private bool enabledFieldSpecified;

		private bool acceptRouterAdvertField;

		private bool acceptRouterAdvertFieldSpecified;

		private PrefixedIPv6Address [] manualField;

		private IPv6DHCPConfiguration dHCPField;

		private bool dHCPFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool EnabledSpecified {
			get {
				return this.enabledFieldSpecified;
			}
			set {
				this.enabledFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool AcceptRouterAdvert {
			get {
				return this.acceptRouterAdvertField;
			}
			set {
				this.acceptRouterAdvertField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AcceptRouterAdvertSpecified {
			get {
				return this.acceptRouterAdvertFieldSpecified;
			}
			set {
				this.acceptRouterAdvertFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Manual", Order = 2)]
		public PrefixedIPv6Address [] Manual {
			get {
				return this.manualField;
			}
			set {
				this.manualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IPv6DHCPConfiguration DHCP {
			get {
				return this.dHCPField;
			}
			set {
				this.dHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DHCPSpecified {
			get {
				return this.dHCPFieldSpecified;
			}
			set {
				this.dHCPFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum IPv6DHCPConfiguration {

		/// <remarks/>
		Auto,

		/// <remarks/>
		Stateful,

		/// <remarks/>
		Stateless,

		/// <remarks/>
		Off,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv4NetworkInterfaceSetConfiguration {

		private bool enabledField;

		private bool enabledFieldSpecified;

		private PrefixedIPv4Address [] manualField;

		private bool dHCPField;

		private bool dHCPFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool EnabledSpecified {
			get {
				return this.enabledFieldSpecified;
			}
			set {
				this.enabledFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Manual", Order = 1)]
		public PrefixedIPv4Address [] Manual {
			get {
				return this.manualField;
			}
			set {
				this.manualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool DHCP {
			get {
				return this.dHCPField;
			}
			set {
				this.dHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DHCPSpecified {
			get {
				return this.dHCPFieldSpecified;
			}
			set {
				this.dHCPFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceSetConfiguration {

		private bool enabledField;

		private bool enabledFieldSpecified;

		private NetworkInterfaceConnectionSetting linkField;

		private int mTUField;

		private bool mTUFieldSpecified;

		private IPv4NetworkInterfaceSetConfiguration iPv4Field;

		private IPv6NetworkInterfaceSetConfiguration iPv6Field;

		private NetworkInterfaceSetConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool EnabledSpecified {
			get {
				return this.enabledFieldSpecified;
			}
			set {
				this.enabledFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public NetworkInterfaceConnectionSetting Link {
			get {
				return this.linkField;
			}
			set {
				this.linkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int MTU {
			get {
				return this.mTUField;
			}
			set {
				this.mTUField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MTUSpecified {
			get {
				return this.mTUFieldSpecified;
			}
			set {
				this.mTUFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IPv4NetworkInterfaceSetConfiguration IPv4 {
			get {
				return this.iPv4Field;
			}
			set {
				this.iPv4Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public IPv6NetworkInterfaceSetConfiguration IPv6 {
			get {
				return this.iPv6Field;
			}
			set {
				this.iPv6Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public NetworkInterfaceSetConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceConnectionSetting {

		private bool autoNegotiationField;

		private int speedField;

		private Duplex duplexField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool AutoNegotiation {
			get {
				return this.autoNegotiationField;
			}
			set {
				this.autoNegotiationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Duplex Duplex {
			get {
				return this.duplexField;
			}
			set {
				this.duplexField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Duplex {

		/// <remarks/>
		Full,

		/// <remarks/>
		Half,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDImgConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDImgConfiguration {

		private string imgPathField;

		private OSDImgConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string ImgPath {
			get {
				return this.imgPathField;
			}
			set {
				this.imgPathField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public OSDImgConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDTextConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Color {

		private float xField;

		private float yField;

		private float zField;

		private string colorspaceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float X {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float Y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float Z {
			get {
				return this.zField;
			}
			set {
				this.zField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute (DataType = "anyURI")]
		public string Colorspace {
			get {
				return this.colorspaceField;
			}
			set {
				this.colorspaceField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDColor {

		private Color colorField;

		private int transparentField;

		private bool transparentFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Color Color {
			get {
				return this.colorField;
			}
			set {
				this.colorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int Transparent {
			get {
				return this.transparentField;
			}
			set {
				this.transparentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool TransparentSpecified {
			get {
				return this.transparentFieldSpecified;
			}
			set {
				this.transparentFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDTextConfiguration {

		private string typeField;

		private string dateFormatField;

		private string timeFormatField;

		private int fontSizeField;

		private bool fontSizeFieldSpecified;

		private OSDColor fontColorField;

		private OSDColor backgroundColorField;

		private string plainTextField;

		private OSDTextConfigurationExtension extensionField;

		private bool isPersistentTextField;

		private bool isPersistentTextFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string DateFormat {
			get {
				return this.dateFormatField;
			}
			set {
				this.dateFormatField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public string TimeFormat {
			get {
				return this.timeFormatField;
			}
			set {
				this.timeFormatField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public int FontSize {
			get {
				return this.fontSizeField;
			}
			set {
				this.fontSizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool FontSizeSpecified {
			get {
				return this.fontSizeFieldSpecified;
			}
			set {
				this.fontSizeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public OSDColor FontColor {
			get {
				return this.fontColorField;
			}
			set {
				this.fontColorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public OSDColor BackgroundColor {
			get {
				return this.backgroundColorField;
			}
			set {
				this.backgroundColorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public string PlainText {
			get {
				return this.plainTextField;
			}
			set {
				this.plainTextField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public OSDTextConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool IsPersistentText {
			get {
				return this.isPersistentTextField;
			}
			set {
				this.isPersistentTextField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IsPersistentTextSpecified {
			get {
				return this.isPersistentTextFieldSpecified;
			}
			set {
				this.isPersistentTextFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDPosConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Vector {

		private float xField;

		private bool xFieldSpecified;

		private float yField;

		private bool yFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float x {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool xSpecified {
			get {
				return this.xFieldSpecified;
			}
			set {
				this.xFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ySpecified {
			get {
				return this.yFieldSpecified;
			}
			set {
				this.yFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDPosConfiguration {

		private string typeField;

		private Vector posField;

		private OSDPosConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Vector Pos {
			get {
				return this.posField;
			}
			set {
				this.posField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public OSDPosConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDReference {

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute ()]
		public string Value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZNodeExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourSupportedExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourSupported {

		private int maximumNumberOfPresetToursField;

		private PTZPresetTourOperation [] pTZPresetTourOperationField;

		private PTZPresetTourSupportedExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int MaximumNumberOfPresetTours {
			get {
				return this.maximumNumberOfPresetToursField;
			}
			set {
				this.maximumNumberOfPresetToursField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("PTZPresetTourOperation", Order = 1)]
		public PTZPresetTourOperation [] PTZPresetTourOperation {
			get {
				return this.pTZPresetTourOperationField;
			}
			set {
				this.pTZPresetTourOperationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTZPresetTourSupportedExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum PTZPresetTourOperation {

		/// <remarks/>
		Start,

		/// <remarks/>
		Stop,

		/// <remarks/>
		Pause,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZNodeExtension {

		private System.Xml.Linq.XElement [] anyField;

		private PTZPresetTourSupported supportedPresetTourField;

		private PTZNodeExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZPresetTourSupported SupportedPresetTour {
			get {
				return this.supportedPresetTourField;
			}
			set {
				this.supportedPresetTourField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTZNodeExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZSpacesExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Space1DDescription {

		private string uRIField;

		private FloatRange xRangeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string URI {
			get {
				return this.uRIField;
			}
			set {
				this.uRIField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange XRange {
			get {
				return this.xRangeField;
			}
			set {
				this.xRangeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FloatRange {

		private float minField;

		private float maxField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Min {
			get {
				return this.minField;
			}
			set {
				this.minField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Max {
			get {
				return this.maxField;
			}
			set {
				this.maxField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Space2DDescription {

		private string uRIField;

		private FloatRange xRangeField;

		private FloatRange yRangeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string URI {
			get {
				return this.uRIField;
			}
			set {
				this.uRIField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange XRange {
			get {
				return this.xRangeField;
			}
			set {
				this.xRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public FloatRange YRange {
			get {
				return this.yRangeField;
			}
			set {
				this.yRangeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZSpaces {

		private Space2DDescription [] absolutePanTiltPositionSpaceField;

		private Space1DDescription [] absoluteZoomPositionSpaceField;

		private Space2DDescription [] relativePanTiltTranslationSpaceField;

		private Space1DDescription [] relativeZoomTranslationSpaceField;

		private Space2DDescription [] continuousPanTiltVelocitySpaceField;

		private Space1DDescription [] continuousZoomVelocitySpaceField;

		private Space1DDescription [] panTiltSpeedSpaceField;

		private Space1DDescription [] zoomSpeedSpaceField;

		private PTZSpacesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AbsolutePanTiltPositionSpace", Order = 0)]
		public Space2DDescription [] AbsolutePanTiltPositionSpace {
			get {
				return this.absolutePanTiltPositionSpaceField;
			}
			set {
				this.absolutePanTiltPositionSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AbsoluteZoomPositionSpace", Order = 1)]
		public Space1DDescription [] AbsoluteZoomPositionSpace {
			get {
				return this.absoluteZoomPositionSpaceField;
			}
			set {
				this.absoluteZoomPositionSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("RelativePanTiltTranslationSpace", Order = 2)]
		public Space2DDescription [] RelativePanTiltTranslationSpace {
			get {
				return this.relativePanTiltTranslationSpaceField;
			}
			set {
				this.relativePanTiltTranslationSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("RelativeZoomTranslationSpace", Order = 3)]
		public Space1DDescription [] RelativeZoomTranslationSpace {
			get {
				return this.relativeZoomTranslationSpaceField;
			}
			set {
				this.relativeZoomTranslationSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ContinuousPanTiltVelocitySpace", Order = 4)]
		public Space2DDescription [] ContinuousPanTiltVelocitySpace {
			get {
				return this.continuousPanTiltVelocitySpaceField;
			}
			set {
				this.continuousPanTiltVelocitySpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ContinuousZoomVelocitySpace", Order = 5)]
		public Space1DDescription [] ContinuousZoomVelocitySpace {
			get {
				return this.continuousZoomVelocitySpaceField;
			}
			set {
				this.continuousZoomVelocitySpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("PanTiltSpeedSpace", Order = 6)]
		public Space1DDescription [] PanTiltSpeedSpace {
			get {
				return this.panTiltSpeedSpaceField;
			}
			set {
				this.panTiltSpeedSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ZoomSpeedSpace", Order = 7)]
		public Space1DDescription [] ZoomSpeedSpace {
			get {
				return this.zoomSpeedSpaceField;
			}
			set {
				this.zoomSpeedSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public PTZSpacesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RelayOutputSettings {

		private RelayMode modeField;

		private string delayTimeField;

		private RelayIdleState idleStateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public RelayMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 1)]
		public string DelayTime {
			get {
				return this.delayTimeField;
			}
			set {
				this.delayTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public RelayIdleState IdleState {
			get {
				return this.idleStateField;
			}
			set {
				this.idleStateField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum RelayMode {

		/// <remarks/>
		Monostable,

		/// <remarks/>
		Bistable,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum RelayIdleState {

		/// <remarks/>
		closed,

		/// <remarks/>
		open,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceExtension {

		private System.Xml.Linq.XElement [] anyField;

		private int interfaceTypeField;

		private Dot3Configuration [] dot3Field;

		private Dot11Configuration [] dot11Field;

		private NetworkInterfaceExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int InterfaceType {
			get {
				return this.interfaceTypeField;
			}
			set {
				this.interfaceTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Dot3", Order = 2)]
		public Dot3Configuration [] Dot3 {
			get {
				return this.dot3Field;
			}
			set {
				this.dot3Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Dot11", Order = 3)]
		public Dot11Configuration [] Dot11 {
			get {
				return this.dot11Field;
			}
			set {
				this.dot11Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public NetworkInterfaceExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv6ConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv6Configuration {

		private bool acceptRouterAdvertField;

		private bool acceptRouterAdvertFieldSpecified;

		private IPv6DHCPConfiguration dHCPField;

		private PrefixedIPv6Address [] manualField;

		private PrefixedIPv6Address [] linkLocalField;

		private PrefixedIPv6Address [] fromDHCPField;

		private PrefixedIPv6Address [] fromRAField;

		private IPv6ConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool AcceptRouterAdvert {
			get {
				return this.acceptRouterAdvertField;
			}
			set {
				this.acceptRouterAdvertField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AcceptRouterAdvertSpecified {
			get {
				return this.acceptRouterAdvertFieldSpecified;
			}
			set {
				this.acceptRouterAdvertFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IPv6DHCPConfiguration DHCP {
			get {
				return this.dHCPField;
			}
			set {
				this.dHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Manual", Order = 2)]
		public PrefixedIPv6Address [] Manual {
			get {
				return this.manualField;
			}
			set {
				this.manualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("LinkLocal", Order = 3)]
		public PrefixedIPv6Address [] LinkLocal {
			get {
				return this.linkLocalField;
			}
			set {
				this.linkLocalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("FromDHCP", Order = 4)]
		public PrefixedIPv6Address [] FromDHCP {
			get {
				return this.fromDHCPField;
			}
			set {
				this.fromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("FromRA", Order = 5)]
		public PrefixedIPv6Address [] FromRA {
			get {
				return this.fromRAField;
			}
			set {
				this.fromRAField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public IPv6ConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv6NetworkInterface {

		private bool enabledField;

		private IPv6Configuration configField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IPv6Configuration Config {
			get {
				return this.configField;
			}
			set {
				this.configField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv4Configuration {

		private PrefixedIPv4Address [] manualField;

		private PrefixedIPv4Address linkLocalField;

		private PrefixedIPv4Address fromDHCPField;

		private bool dHCPField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Manual", Order = 0)]
		public PrefixedIPv4Address [] Manual {
			get {
				return this.manualField;
			}
			set {
				this.manualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PrefixedIPv4Address LinkLocal {
			get {
				return this.linkLocalField;
			}
			set {
				this.linkLocalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PrefixedIPv4Address FromDHCP {
			get {
				return this.fromDHCPField;
			}
			set {
				this.fromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool DHCP {
			get {
				return this.dHCPField;
			}
			set {
				this.dHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPv4NetworkInterface {

		private bool enabledField;

		private IPv4Configuration configField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IPv4Configuration Config {
			get {
				return this.configField;
			}
			set {
				this.configField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceLink {

		private NetworkInterfaceConnectionSetting adminSettingsField;

		private NetworkInterfaceConnectionSetting operSettingsField;

		private int interfaceTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public NetworkInterfaceConnectionSetting AdminSettings {
			get {
				return this.adminSettingsField;
			}
			set {
				this.adminSettingsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public NetworkInterfaceConnectionSetting OperSettings {
			get {
				return this.operSettingsField;
			}
			set {
				this.operSettingsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int InterfaceType {
			get {
				return this.interfaceTypeField;
			}
			set {
				this.interfaceTypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterfaceInfo {

		private string nameField;

		private string hwAddressField;

		private int mTUField;

		private bool mTUFieldSpecified;

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
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 1)]
		public string HwAddress {
			get {
				return this.hwAddressField;
			}
			set {
				this.hwAddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int MTU {
			get {
				return this.mTUField;
			}
			set {
				this.mTUField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MTUSpecified {
			get {
				return this.mTUFieldSpecified;
			}
			set {
				this.mTUFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoOutputExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LayoutExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PaneLayout {

		private string paneField;

		private Rectangle areaField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Pane {
			get {
				return this.paneField;
			}
			set {
				this.paneField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Rectangle Area {
			get {
				return this.areaField;
			}
			set {
				this.areaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Rectangle {

		private float bottomField;

		private bool bottomFieldSpecified;

		private float topField;

		private bool topFieldSpecified;

		private float rightField;

		private bool rightFieldSpecified;

		private float leftField;

		private bool leftFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float bottom {
			get {
				return this.bottomField;
			}
			set {
				this.bottomField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool bottomSpecified {
			get {
				return this.bottomFieldSpecified;
			}
			set {
				this.bottomFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float top {
			get {
				return this.topField;
			}
			set {
				this.topField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool topSpecified {
			get {
				return this.topFieldSpecified;
			}
			set {
				this.topFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float right {
			get {
				return this.rightField;
			}
			set {
				this.rightField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool rightSpecified {
			get {
				return this.rightFieldSpecified;
			}
			set {
				this.rightFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float left {
			get {
				return this.leftField;
			}
			set {
				this.leftField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool leftSpecified {
			get {
				return this.leftFieldSpecified;
			}
			set {
				this.leftFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Layout {

		private PaneLayout [] paneLayoutField;

		private LayoutExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("PaneLayout", Order = 0)]
		public PaneLayout [] PaneLayout {
			get {
				return this.paneLayoutField;
			}
			set {
				this.paneLayoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public LayoutExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettingsExtension204 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NoiseReduction {

		private float levelField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DefoggingExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Defogging {

		private string modeField;

		private float levelField;

		private bool levelFieldSpecified;

		private DefoggingExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool LevelSpecified {
			get {
				return this.levelFieldSpecified;
			}
			set {
				this.levelFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public DefoggingExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ToneCompensationExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ToneCompensation {

		private string modeField;

		private float levelField;

		private bool levelFieldSpecified;

		private ToneCompensationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool LevelSpecified {
			get {
				return this.levelFieldSpecified;
			}
			set {
				this.levelFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ToneCompensationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettingsExtension203 {

		private ToneCompensation toneCompensationField;

		private Defogging defoggingField;

		private NoiseReduction noiseReductionField;

		private ImagingSettingsExtension204 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ToneCompensation ToneCompensation {
			get {
				return this.toneCompensationField;
			}
			set {
				this.toneCompensationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Defogging Defogging {
			get {
				return this.defoggingField;
			}
			set {
				this.defoggingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public NoiseReduction NoiseReduction {
			get {
				return this.noiseReductionField;
			}
			set {
				this.noiseReductionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public ImagingSettingsExtension204 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IrCutFilterAutoAdjustmentExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IrCutFilterAutoAdjustment {

		private string boundaryTypeField;

		private float boundaryOffsetField;

		private bool boundaryOffsetFieldSpecified;

		private string responseTimeField;

		private IrCutFilterAutoAdjustmentExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string BoundaryType {
			get {
				return this.boundaryTypeField;
			}
			set {
				this.boundaryTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float BoundaryOffset {
			get {
				return this.boundaryOffsetField;
			}
			set {
				this.boundaryOffsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool BoundaryOffsetSpecified {
			get {
				return this.boundaryOffsetFieldSpecified;
			}
			set {
				this.boundaryOffsetFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 2)]
		public string ResponseTime {
			get {
				return this.responseTimeField;
			}
			set {
				this.responseTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IrCutFilterAutoAdjustmentExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettingsExtension202 {

		private IrCutFilterAutoAdjustment [] irCutFilterAutoAdjustmentField;

		private ImagingSettingsExtension203 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("IrCutFilterAutoAdjustment", Order = 0)]
		public IrCutFilterAutoAdjustment [] IrCutFilterAutoAdjustment {
			get {
				return this.irCutFilterAutoAdjustmentField;
			}
			set {
				this.irCutFilterAutoAdjustmentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ImagingSettingsExtension203 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImageStabilizationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImageStabilization {

		private ImageStabilizationMode modeField;

		private float levelField;

		private bool levelFieldSpecified;

		private ImageStabilizationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ImageStabilizationMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool LevelSpecified {
			get {
				return this.levelFieldSpecified;
			}
			set {
				this.levelFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ImageStabilizationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum ImageStabilizationMode {

		/// <remarks/>
		OFF,

		/// <remarks/>
		ON,

		/// <remarks/>
		AUTO,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettingsExtension20 {

		private System.Xml.Linq.XElement [] anyField;

		private ImageStabilization imageStabilizationField;

		private ImagingSettingsExtension202 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ImageStabilization ImageStabilization {
			get {
				return this.imageStabilizationField;
			}
			set {
				this.imageStabilizationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ImagingSettingsExtension202 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WhiteBalance20Extension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WhiteBalance20 {

		private WhiteBalanceMode modeField;

		private float crGainField;

		private bool crGainFieldSpecified;

		private float cbGainField;

		private bool cbGainFieldSpecified;

		private WhiteBalance20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public WhiteBalanceMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float CrGain {
			get {
				return this.crGainField;
			}
			set {
				this.crGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool CrGainSpecified {
			get {
				return this.crGainFieldSpecified;
			}
			set {
				this.crGainFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float CbGain {
			get {
				return this.cbGainField;
			}
			set {
				this.cbGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool CbGainSpecified {
			get {
				return this.cbGainFieldSpecified;
			}
			set {
				this.cbGainFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public WhiteBalance20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum WhiteBalanceMode {

		/// <remarks/>
		AUTO,

		/// <remarks/>
		MANUAL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WideDynamicRange20 {

		private WideDynamicMode modeField;

		private float levelField;

		private bool levelFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public WideDynamicMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool LevelSpecified {
			get {
				return this.levelFieldSpecified;
			}
			set {
				this.levelFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum WideDynamicMode {

		/// <remarks/>
		OFF,

		/// <remarks/>
		ON,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusConfiguration20Extension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusConfiguration20 {

		private AutoFocusMode autoFocusModeField;

		private float defaultSpeedField;

		private bool defaultSpeedFieldSpecified;

		private float nearLimitField;

		private bool nearLimitFieldSpecified;

		private float farLimitField;

		private bool farLimitFieldSpecified;

		private FocusConfiguration20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AutoFocusMode AutoFocusMode {
			get {
				return this.autoFocusModeField;
			}
			set {
				this.autoFocusModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float DefaultSpeed {
			get {
				return this.defaultSpeedField;
			}
			set {
				this.defaultSpeedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DefaultSpeedSpecified {
			get {
				return this.defaultSpeedFieldSpecified;
			}
			set {
				this.defaultSpeedFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float NearLimit {
			get {
				return this.nearLimitField;
			}
			set {
				this.nearLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool NearLimitSpecified {
			get {
				return this.nearLimitFieldSpecified;
			}
			set {
				this.nearLimitFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float FarLimit {
			get {
				return this.farLimitField;
			}
			set {
				this.farLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool FarLimitSpecified {
			get {
				return this.farLimitFieldSpecified;
			}
			set {
				this.farLimitFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public FocusConfiguration20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum AutoFocusMode {

		/// <remarks/>
		AUTO,

		/// <remarks/>
		MANUAL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Exposure20 {

		private ExposureMode modeField;

		private ExposurePriority priorityField;

		private bool priorityFieldSpecified;

		private Rectangle windowField;

		private float minExposureTimeField;

		private bool minExposureTimeFieldSpecified;

		private float maxExposureTimeField;

		private bool maxExposureTimeFieldSpecified;

		private float minGainField;

		private bool minGainFieldSpecified;

		private float maxGainField;

		private bool maxGainFieldSpecified;

		private float minIrisField;

		private bool minIrisFieldSpecified;

		private float maxIrisField;

		private bool maxIrisFieldSpecified;

		private float exposureTimeField;

		private bool exposureTimeFieldSpecified;

		private float gainField;

		private bool gainFieldSpecified;

		private float irisField;

		private bool irisFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ExposureMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ExposurePriority Priority {
			get {
				return this.priorityField;
			}
			set {
				this.priorityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PrioritySpecified {
			get {
				return this.priorityFieldSpecified;
			}
			set {
				this.priorityFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Rectangle Window {
			get {
				return this.windowField;
			}
			set {
				this.windowField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float MinExposureTime {
			get {
				return this.minExposureTimeField;
			}
			set {
				this.minExposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MinExposureTimeSpecified {
			get {
				return this.minExposureTimeFieldSpecified;
			}
			set {
				this.minExposureTimeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public float MaxExposureTime {
			get {
				return this.maxExposureTimeField;
			}
			set {
				this.maxExposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxExposureTimeSpecified {
			get {
				return this.maxExposureTimeFieldSpecified;
			}
			set {
				this.maxExposureTimeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public float MinGain {
			get {
				return this.minGainField;
			}
			set {
				this.minGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MinGainSpecified {
			get {
				return this.minGainFieldSpecified;
			}
			set {
				this.minGainFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public float MaxGain {
			get {
				return this.maxGainField;
			}
			set {
				this.maxGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxGainSpecified {
			get {
				return this.maxGainFieldSpecified;
			}
			set {
				this.maxGainFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public float MinIris {
			get {
				return this.minIrisField;
			}
			set {
				this.minIrisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MinIrisSpecified {
			get {
				return this.minIrisFieldSpecified;
			}
			set {
				this.minIrisFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public float MaxIris {
			get {
				return this.maxIrisField;
			}
			set {
				this.maxIrisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxIrisSpecified {
			get {
				return this.maxIrisFieldSpecified;
			}
			set {
				this.maxIrisFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public float ExposureTime {
			get {
				return this.exposureTimeField;
			}
			set {
				this.exposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ExposureTimeSpecified {
			get {
				return this.exposureTimeFieldSpecified;
			}
			set {
				this.exposureTimeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public float Gain {
			get {
				return this.gainField;
			}
			set {
				this.gainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GainSpecified {
			get {
				return this.gainFieldSpecified;
			}
			set {
				this.gainFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 11)]
		public float Iris {
			get {
				return this.irisField;
			}
			set {
				this.irisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IrisSpecified {
			get {
				return this.irisFieldSpecified;
			}
			set {
				this.irisFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum ExposureMode {

		/// <remarks/>
		AUTO,

		/// <remarks/>
		MANUAL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum ExposurePriority {

		/// <remarks/>
		LowNoise,

		/// <remarks/>
		FrameRate,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class BacklightCompensation20 {

		private BacklightCompensationMode modeField;

		private float levelField;

		private bool levelFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public BacklightCompensationMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool LevelSpecified {
			get {
				return this.levelFieldSpecified;
			}
			set {
				this.levelFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum BacklightCompensationMode {

		/// <remarks/>
		OFF,

		/// <remarks/>
		ON,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettings20 {

		private BacklightCompensation20 backlightCompensationField;

		private float brightnessField;

		private bool brightnessFieldSpecified;

		private float colorSaturationField;

		private bool colorSaturationFieldSpecified;

		private float contrastField;

		private bool contrastFieldSpecified;

		private Exposure20 exposureField;

		private FocusConfiguration20 focusField;

		private IrCutFilterMode irCutFilterField;

		private bool irCutFilterFieldSpecified;

		private float sharpnessField;

		private bool sharpnessFieldSpecified;

		private WideDynamicRange20 wideDynamicRangeField;

		private WhiteBalance20 whiteBalanceField;

		private ImagingSettingsExtension20 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public BacklightCompensation20 BacklightCompensation {
			get {
				return this.backlightCompensationField;
			}
			set {
				this.backlightCompensationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Brightness {
			get {
				return this.brightnessField;
			}
			set {
				this.brightnessField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool BrightnessSpecified {
			get {
				return this.brightnessFieldSpecified;
			}
			set {
				this.brightnessFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float ColorSaturation {
			get {
				return this.colorSaturationField;
			}
			set {
				this.colorSaturationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ColorSaturationSpecified {
			get {
				return this.colorSaturationFieldSpecified;
			}
			set {
				this.colorSaturationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float Contrast {
			get {
				return this.contrastField;
			}
			set {
				this.contrastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ContrastSpecified {
			get {
				return this.contrastFieldSpecified;
			}
			set {
				this.contrastFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public Exposure20 Exposure {
			get {
				return this.exposureField;
			}
			set {
				this.exposureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public FocusConfiguration20 Focus {
			get {
				return this.focusField;
			}
			set {
				this.focusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public IrCutFilterMode IrCutFilter {
			get {
				return this.irCutFilterField;
			}
			set {
				this.irCutFilterField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IrCutFilterSpecified {
			get {
				return this.irCutFilterFieldSpecified;
			}
			set {
				this.irCutFilterFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public float Sharpness {
			get {
				return this.sharpnessField;
			}
			set {
				this.sharpnessField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SharpnessSpecified {
			get {
				return this.sharpnessFieldSpecified;
			}
			set {
				this.sharpnessFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public WideDynamicRange20 WideDynamicRange {
			get {
				return this.wideDynamicRangeField;
			}
			set {
				this.wideDynamicRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public WhiteBalance20 WhiteBalance {
			get {
				return this.whiteBalanceField;
			}
			set {
				this.whiteBalanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public ImagingSettingsExtension20 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum IrCutFilterMode {

		/// <remarks/>
		ON,

		/// <remarks/>
		OFF,

		/// <remarks/>
		AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceExtension {

		private System.Xml.Linq.XElement [] anyField;

		private ImagingSettings20 imagingField;

		private VideoSourceExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ImagingSettings20 Imaging {
			get {
				return this.imagingField;
			}
			set {
				this.imagingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public VideoSourceExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettingsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WhiteBalance {

		private WhiteBalanceMode modeField;

		private float crGainField;

		private float cbGainField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public WhiteBalanceMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float CrGain {
			get {
				return this.crGainField;
			}
			set {
				this.crGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float CbGain {
			get {
				return this.cbGainField;
			}
			set {
				this.cbGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WideDynamicRange {

		private WideDynamicMode modeField;

		private float levelField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public WideDynamicMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusConfiguration {

		private AutoFocusMode autoFocusModeField;

		private float defaultSpeedField;

		private float nearLimitField;

		private float farLimitField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AutoFocusMode AutoFocusMode {
			get {
				return this.autoFocusModeField;
			}
			set {
				this.autoFocusModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float DefaultSpeed {
			get {
				return this.defaultSpeedField;
			}
			set {
				this.defaultSpeedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float NearLimit {
			get {
				return this.nearLimitField;
			}
			set {
				this.nearLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float FarLimit {
			get {
				return this.farLimitField;
			}
			set {
				this.farLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Exposure {

		private ExposureMode modeField;

		private ExposurePriority priorityField;

		private Rectangle windowField;

		private float minExposureTimeField;

		private float maxExposureTimeField;

		private float minGainField;

		private float maxGainField;

		private float minIrisField;

		private float maxIrisField;

		private float exposureTimeField;

		private float gainField;

		private float irisField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ExposureMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ExposurePriority Priority {
			get {
				return this.priorityField;
			}
			set {
				this.priorityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Rectangle Window {
			get {
				return this.windowField;
			}
			set {
				this.windowField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float MinExposureTime {
			get {
				return this.minExposureTimeField;
			}
			set {
				this.minExposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public float MaxExposureTime {
			get {
				return this.maxExposureTimeField;
			}
			set {
				this.maxExposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public float MinGain {
			get {
				return this.minGainField;
			}
			set {
				this.minGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public float MaxGain {
			get {
				return this.maxGainField;
			}
			set {
				this.maxGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public float MinIris {
			get {
				return this.minIrisField;
			}
			set {
				this.minIrisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public float MaxIris {
			get {
				return this.maxIrisField;
			}
			set {
				this.maxIrisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public float ExposureTime {
			get {
				return this.exposureTimeField;
			}
			set {
				this.exposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public float Gain {
			get {
				return this.gainField;
			}
			set {
				this.gainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 11)]
		public float Iris {
			get {
				return this.irisField;
			}
			set {
				this.irisField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class BacklightCompensation {

		private BacklightCompensationMode modeField;

		private float levelField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public BacklightCompensationMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingSettings {

		private BacklightCompensation backlightCompensationField;

		private float brightnessField;

		private bool brightnessFieldSpecified;

		private float colorSaturationField;

		private bool colorSaturationFieldSpecified;

		private float contrastField;

		private bool contrastFieldSpecified;

		private Exposure exposureField;

		private FocusConfiguration focusField;

		private IrCutFilterMode irCutFilterField;

		private bool irCutFilterFieldSpecified;

		private float sharpnessField;

		private bool sharpnessFieldSpecified;

		private WideDynamicRange wideDynamicRangeField;

		private WhiteBalance whiteBalanceField;

		private ImagingSettingsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public BacklightCompensation BacklightCompensation {
			get {
				return this.backlightCompensationField;
			}
			set {
				this.backlightCompensationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Brightness {
			get {
				return this.brightnessField;
			}
			set {
				this.brightnessField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool BrightnessSpecified {
			get {
				return this.brightnessFieldSpecified;
			}
			set {
				this.brightnessFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float ColorSaturation {
			get {
				return this.colorSaturationField;
			}
			set {
				this.colorSaturationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ColorSaturationSpecified {
			get {
				return this.colorSaturationFieldSpecified;
			}
			set {
				this.colorSaturationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float Contrast {
			get {
				return this.contrastField;
			}
			set {
				this.contrastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ContrastSpecified {
			get {
				return this.contrastFieldSpecified;
			}
			set {
				this.contrastFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public Exposure Exposure {
			get {
				return this.exposureField;
			}
			set {
				this.exposureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public FocusConfiguration Focus {
			get {
				return this.focusField;
			}
			set {
				this.focusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public IrCutFilterMode IrCutFilter {
			get {
				return this.irCutFilterField;
			}
			set {
				this.irCutFilterField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IrCutFilterSpecified {
			get {
				return this.irCutFilterFieldSpecified;
			}
			set {
				this.irCutFilterFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public float Sharpness {
			get {
				return this.sharpnessField;
			}
			set {
				this.sharpnessField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SharpnessSpecified {
			get {
				return this.sharpnessFieldSpecified;
			}
			set {
				this.sharpnessFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public WideDynamicRange WideDynamicRange {
			get {
				return this.wideDynamicRangeField;
			}
			set {
				this.wideDynamicRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public WhiteBalance WhiteBalance {
			get {
				return this.whiteBalanceField;
			}
			set {
				this.whiteBalanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public ImagingSettingsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoResolution {

		private int widthField;

		private int heightField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Width {
			get {
				return this.widthField;
			}
			set {
				this.widthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Height {
			get {
				return this.heightField;
			}
			set {
				this.heightField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (OSDConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (PTZNode))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (DigitalInput))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (RelayOutput))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (NetworkInterface))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioOutput))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoOutput))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioSource))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoSource))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (StorageConfiguration))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DeviceEntity {

		private string tokenField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDConfiguration : DeviceEntity {

		private OSDReference videoSourceConfigurationTokenField;

		private OSDType typeField;

		private OSDPosConfiguration positionField;

		private OSDTextConfiguration textStringField;

		private OSDImgConfiguration imageField;

		private OSDConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public OSDReference VideoSourceConfigurationToken {
			get {
				return this.videoSourceConfigurationTokenField;
			}
			set {
				this.videoSourceConfigurationTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public OSDType Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public OSDPosConfiguration Position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public OSDTextConfiguration TextString {
			get {
				return this.textStringField;
			}
			set {
				this.textStringField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public OSDImgConfiguration Image {
			get {
				return this.imageField;
			}
			set {
				this.imageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public OSDConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum OSDType {

		/// <remarks/>
		Text,

		/// <remarks/>
		Image,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZNode : DeviceEntity {

		private string nameField;

		private PTZSpaces supportedPTZSpacesField;

		private int maximumNumberOfPresetsField;

		private bool homeSupportedField;

		private string [] auxiliaryCommandsField;

		private PTZNodeExtension extensionField;

		private bool fixedHomePositionField;

		private bool fixedHomePositionFieldSpecified;

		private bool geoMoveField;

		private bool geoMoveFieldSpecified;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZSpaces SupportedPTZSpaces {
			get {
				return this.supportedPTZSpacesField;
			}
			set {
				this.supportedPTZSpacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int MaximumNumberOfPresets {
			get {
				return this.maximumNumberOfPresetsField;
			}
			set {
				this.maximumNumberOfPresetsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool HomeSupported {
			get {
				return this.homeSupportedField;
			}
			set {
				this.homeSupportedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AuxiliaryCommands", Order = 4)]
		public string [] AuxiliaryCommands {
			get {
				return this.auxiliaryCommandsField;
			}
			set {
				this.auxiliaryCommandsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public PTZNodeExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool FixedHomePosition {
			get {
				return this.fixedHomePositionField;
			}
			set {
				this.fixedHomePositionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool FixedHomePositionSpecified {
			get {
				return this.fixedHomePositionFieldSpecified;
			}
			set {
				this.fixedHomePositionFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool GeoMove {
			get {
				return this.geoMoveField;
			}
			set {
				this.geoMoveField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GeoMoveSpecified {
			get {
				return this.geoMoveFieldSpecified;
			}
			set {
				this.geoMoveFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DigitalInput : DeviceEntity {

		private System.Xml.Linq.XElement [] anyField;

		private DigitalIdleState idleStateField;

		private bool idleStateFieldSpecified;

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
		public DigitalIdleState IdleState {
			get {
				return this.idleStateField;
			}
			set {
				this.idleStateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IdleStateSpecified {
			get {
				return this.idleStateFieldSpecified;
			}
			set {
				this.idleStateFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum DigitalIdleState {

		/// <remarks/>
		closed,

		/// <remarks/>
		open,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RelayOutput : DeviceEntity {

		private RelayOutputSettings propertiesField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public RelayOutputSettings Properties {
			get {
				return this.propertiesField;
			}
			set {
				this.propertiesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkInterface : DeviceEntity {

		private bool enabledField;

		private NetworkInterfaceInfo infoField;

		private NetworkInterfaceLink linkField;

		private IPv4NetworkInterface iPv4Field;

		private IPv6NetworkInterface iPv6Field;

		private NetworkInterfaceExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Enabled {
			get {
				return this.enabledField;
			}
			set {
				this.enabledField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public NetworkInterfaceInfo Info {
			get {
				return this.infoField;
			}
			set {
				this.infoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public NetworkInterfaceLink Link {
			get {
				return this.linkField;
			}
			set {
				this.linkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IPv4NetworkInterface IPv4 {
			get {
				return this.iPv4Field;
			}
			set {
				this.iPv4Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public IPv6NetworkInterface IPv6 {
			get {
				return this.iPv6Field;
			}
			set {
				this.iPv6Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public NetworkInterfaceExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioOutput : DeviceEntity {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoOutput : DeviceEntity {

		private Layout layoutField;

		private VideoResolution resolutionField;

		private float refreshRateField;

		private bool refreshRateFieldSpecified;

		private float aspectRatioField;

		private bool aspectRatioFieldSpecified;

		private VideoOutputExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Layout Layout {
			get {
				return this.layoutField;
			}
			set {
				this.layoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoResolution Resolution {
			get {
				return this.resolutionField;
			}
			set {
				this.resolutionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float RefreshRate {
			get {
				return this.refreshRateField;
			}
			set {
				this.refreshRateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RefreshRateSpecified {
			get {
				return this.refreshRateFieldSpecified;
			}
			set {
				this.refreshRateFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public float AspectRatio {
			get {
				return this.aspectRatioField;
			}
			set {
				this.aspectRatioField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AspectRatioSpecified {
			get {
				return this.aspectRatioFieldSpecified;
			}
			set {
				this.aspectRatioFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public VideoOutputExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioSource : DeviceEntity {

		private int channelsField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Channels {
			get {
				return this.channelsField;
			}
			set {
				this.channelsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSource : DeviceEntity {

		private float framerateField;

		private VideoResolution resolutionField;

		private ImagingSettings imagingField;

		private VideoSourceExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Framerate {
			get {
				return this.framerateField;
			}
			set {
				this.framerateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoResolution Resolution {
			get {
				return this.resolutionField;
			}
			set {
				this.resolutionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ImagingSettings Imaging {
			get {
				return this.imagingField;
			}
			set {
				this.imagingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public VideoSourceExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DynamicDNSInformationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DynamicDNSInformation {

		private DynamicDNSType typeField;

		private string nameField;

		private string tTLField;

		private DynamicDNSInformationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public DynamicDNSType Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 1)]
		public string Name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 2)]
		public string TTL {
			get {
				return this.tTLField;
			}
			set {
				this.tTLField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public DynamicDNSInformationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum DynamicDNSType {

		/// <remarks/>
		NoUpdate,

		/// <remarks/>
		ClientUpdates,

		/// <remarks/>
		ServerUpdates,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NTPInformationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NTPInformation {

		private bool fromDHCPField;

		private NetworkHost [] nTPFromDHCPField;

		private NetworkHost [] nTPManualField;

		private NTPInformationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool FromDHCP {
			get {
				return this.fromDHCPField;
			}
			set {
				this.fromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("NTPFromDHCP", Order = 1)]
		public NetworkHost [] NTPFromDHCP {
			get {
				return this.nTPFromDHCPField;
			}
			set {
				this.nTPFromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("NTPManual", Order = 2)]
		public NetworkHost [] NTPManual {
			get {
				return this.nTPManualField;
			}
			set {
				this.nTPManualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public NTPInformationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkHost {

		private NetworkHostType typeField;

		private string iPv4AddressField;

		private string iPv6AddressField;

		private string dNSnameField;

		private NetworkHostExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public NetworkHostType Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 1)]
		public string IPv4Address {
			get {
				return this.iPv4AddressField;
			}
			set {
				this.iPv4AddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 2)]
		public string IPv6Address {
			get {
				return this.iPv6AddressField;
			}
			set {
				this.iPv6AddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 3)]
		public string DNSname {
			get {
				return this.dNSnameField;
			}
			set {
				this.dNSnameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public NetworkHostExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum NetworkHostType {

		/// <remarks/>
		IPv4,

		/// <remarks/>
		IPv6,

		/// <remarks/>
		DNS,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkHostExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DNSInformationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IPAddress {

		private IPType typeField;

		private string iPv4AddressField;

		private string iPv6AddressField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IPType Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 1)]
		public string IPv4Address {
			get {
				return this.iPv4AddressField;
			}
			set {
				this.iPv4AddressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 2)]
		public string IPv6Address {
			get {
				return this.iPv6AddressField;
			}
			set {
				this.iPv6AddressField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum IPType {

		/// <remarks/>
		IPv4,

		/// <remarks/>
		IPv6,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DNSInformation {

		private bool fromDHCPField;

		private string [] searchDomainField;

		private IPAddress [] dNSFromDHCPField;

		private IPAddress [] dNSManualField;

		private DNSInformationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool FromDHCP {
			get {
				return this.fromDHCPField;
			}
			set {
				this.fromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("SearchDomain", DataType = "token", Order = 1)]
		public string [] SearchDomain {
			get {
				return this.searchDomainField;
			}
			set {
				this.searchDomainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("DNSFromDHCP", Order = 2)]
		public IPAddress [] DNSFromDHCP {
			get {
				return this.dNSFromDHCPField;
			}
			set {
				this.dNSFromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("DNSManual", Order = 3)]
		public IPAddress [] DNSManual {
			get {
				return this.dNSManualField;
			}
			set {
				this.dNSManualField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public DNSInformationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class HostnameInformationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class HostnameInformation {

		private bool fromDHCPField;

		private string nameField;

		private HostnameInformationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool FromDHCP {
			get {
				return this.fromDHCPField;
			}
			set {
				this.fromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 1)]
		public string Name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public HostnameInformationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CapabilitiesExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsDeviceExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsDeviceCapabilities {

		private string xAddrField;

		private bool ruleSupportField;

		private bool ruleSupportFieldSpecified;

		private AnalyticsDeviceExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool RuleSupport {
			get {
				return this.ruleSupportField;
			}
			set {
				this.ruleSupportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RuleSupportSpecified {
			get {
				return this.ruleSupportFieldSpecified;
			}
			set {
				this.ruleSupportFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public AnalyticsDeviceExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ReceiverCapabilities {

		private string xAddrField;

		private bool rTP_MulticastField;

		private bool rTP_TCPField;

		private bool rTP_RTSP_TCPField;

		private int supportedReceiversField;

		private int maximumRTSPURILengthField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool RTP_Multicast {
			get {
				return this.rTP_MulticastField;
			}
			set {
				this.rTP_MulticastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool RTP_TCP {
			get {
				return this.rTP_TCPField;
			}
			set {
				this.rTP_TCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool RTP_RTSP_TCP {
			get {
				return this.rTP_RTSP_TCPField;
			}
			set {
				this.rTP_RTSP_TCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public int SupportedReceivers {
			get {
				return this.supportedReceiversField;
			}
			set {
				this.supportedReceiversField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public int MaximumRTSPURILength {
			get {
				return this.maximumRTSPURILengthField;
			}
			set {
				this.maximumRTSPURILengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 6)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ReplayCapabilities {

		private string xAddrField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SearchCapabilities {

		private string xAddrField;

		private bool metadataSearchField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool MetadataSearch {
			get {
				return this.metadataSearchField;
			}
			set {
				this.metadataSearchField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RecordingCapabilities {

		private string xAddrField;

		private bool receiverSourceField;

		private bool mediaProfileSourceField;

		private bool dynamicRecordingsField;

		private bool dynamicTracksField;

		private int maxStringLengthField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool ReceiverSource {
			get {
				return this.receiverSourceField;
			}
			set {
				this.receiverSourceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool MediaProfileSource {
			get {
				return this.mediaProfileSourceField;
			}
			set {
				this.mediaProfileSourceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool DynamicRecordings {
			get {
				return this.dynamicRecordingsField;
			}
			set {
				this.dynamicRecordingsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public bool DynamicTracks {
			get {
				return this.dynamicTracksField;
			}
			set {
				this.dynamicTracksField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public int MaxStringLength {
			get {
				return this.maxStringLengthField;
			}
			set {
				this.maxStringLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 6)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DisplayCapabilities {

		private string xAddrField;

		private bool fixedLayoutField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool FixedLayout {
			get {
				return this.fixedLayoutField;
			}
			set {
				this.fixedLayoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DeviceIOCapabilities {

		private string xAddrField;

		private int videoSourcesField;

		private int videoOutputsField;

		private int audioSourcesField;

		private int audioOutputsField;

		private int relayOutputsField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int VideoSources {
			get {
				return this.videoSourcesField;
			}
			set {
				this.videoSourcesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int VideoOutputs {
			get {
				return this.videoOutputsField;
			}
			set {
				this.videoOutputsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public int AudioSources {
			get {
				return this.audioSourcesField;
			}
			set {
				this.audioSourcesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public int AudioOutputs {
			get {
				return this.audioOutputsField;
			}
			set {
				this.audioOutputsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public int RelayOutputs {
			get {
				return this.relayOutputsField;
			}
			set {
				this.relayOutputsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 6)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class CapabilitiesExtension {

		private System.Xml.Linq.XElement [] anyField;

		private DeviceIOCapabilities deviceIOField;

		private DisplayCapabilities displayField;

		private RecordingCapabilities recordingField;

		private SearchCapabilities searchField;

		private ReplayCapabilities replayField;

		private ReceiverCapabilities receiverField;

		private AnalyticsDeviceCapabilities analyticsDeviceField;

		private CapabilitiesExtension2 extensionsField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public DeviceIOCapabilities DeviceIO {
			get {
				return this.deviceIOField;
			}
			set {
				this.deviceIOField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public DisplayCapabilities Display {
			get {
				return this.displayField;
			}
			set {
				this.displayField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public RecordingCapabilities Recording {
			get {
				return this.recordingField;
			}
			set {
				this.recordingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public SearchCapabilities Search {
			get {
				return this.searchField;
			}
			set {
				this.searchField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public ReplayCapabilities Replay {
			get {
				return this.replayField;
			}
			set {
				this.replayField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public ReceiverCapabilities Receiver {
			get {
				return this.receiverField;
			}
			set {
				this.receiverField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public AnalyticsDeviceCapabilities AnalyticsDevice {
			get {
				return this.analyticsDeviceField;
			}
			set {
				this.analyticsDeviceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public CapabilitiesExtension2 Extensions {
			get {
				return this.extensionsField;
			}
			set {
				this.extensionsField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZCapabilities {

		private string xAddrField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ProfileCapabilities {

		private int maximumNumberOfProfilesField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int MaximumNumberOfProfiles {
			get {
				return this.maximumNumberOfProfilesField;
			}
			set {
				this.maximumNumberOfProfilesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MediaCapabilitiesExtension {

		private ProfileCapabilities profileCapabilitiesField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ProfileCapabilities ProfileCapabilities {
			get {
				return this.profileCapabilitiesField;
			}
			set {
				this.profileCapabilitiesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RealTimeStreamingCapabilitiesExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RealTimeStreamingCapabilities {

		private bool rTPMulticastField;

		private bool rTPMulticastFieldSpecified;

		private bool rTP_TCPField;

		private bool rTP_TCPFieldSpecified;

		private bool rTP_RTSP_TCPField;

		private bool rTP_RTSP_TCPFieldSpecified;

		private RealTimeStreamingCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool RTPMulticast {
			get {
				return this.rTPMulticastField;
			}
			set {
				this.rTPMulticastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RTPMulticastSpecified {
			get {
				return this.rTPMulticastFieldSpecified;
			}
			set {
				this.rTPMulticastFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool RTP_TCP {
			get {
				return this.rTP_TCPField;
			}
			set {
				this.rTP_TCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RTP_TCPSpecified {
			get {
				return this.rTP_TCPFieldSpecified;
			}
			set {
				this.rTP_TCPFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool RTP_RTSP_TCP {
			get {
				return this.rTP_RTSP_TCPField;
			}
			set {
				this.rTP_RTSP_TCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RTP_RTSP_TCPSpecified {
			get {
				return this.rTP_RTSP_TCPFieldSpecified;
			}
			set {
				this.rTP_RTSP_TCPFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public RealTimeStreamingCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MediaCapabilities {

		private string xAddrField;

		private RealTimeStreamingCapabilities streamingCapabilitiesField;

		private System.Xml.Linq.XElement [] anyField;

		private MediaCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public RealTimeStreamingCapabilities StreamingCapabilities {
			get {
				return this.streamingCapabilitiesField;
			}
			set {
				this.streamingCapabilitiesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public MediaCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingCapabilities {

		private string xAddrField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EventCapabilities {

		private string xAddrField;

		private bool wSSubscriptionPolicySupportField;

		private bool wSPullPointSupportField;

		private bool wSPausableSubscriptionManagerInterfaceSupportField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool WSSubscriptionPolicySupport {
			get {
				return this.wSSubscriptionPolicySupportField;
			}
			set {
				this.wSSubscriptionPolicySupportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool WSPullPointSupport {
			get {
				return this.wSPullPointSupportField;
			}
			set {
				this.wSPullPointSupportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool WSPausableSubscriptionManagerInterfaceSupport {
			get {
				return this.wSPausableSubscriptionManagerInterfaceSupportField;
			}
			set {
				this.wSPausableSubscriptionManagerInterfaceSupportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DeviceCapabilitiesExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SecurityCapabilitiesExtension2 {

		private bool dot1XField;

		private int [] supportedEAPMethodField;

		private bool remoteUserHandlingField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Dot1X {
			get {
				return this.dot1XField;
			}
			set {
				this.dot1XField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("SupportedEAPMethod", Order = 1)]
		public int [] SupportedEAPMethod {
			get {
				return this.supportedEAPMethodField;
			}
			set {
				this.supportedEAPMethodField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool RemoteUserHandling {
			get {
				return this.remoteUserHandlingField;
			}
			set {
				this.remoteUserHandlingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SecurityCapabilitiesExtension {

		private bool tLS10Field;

		private SecurityCapabilitiesExtension2 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("TLS1.0", Order = 0)]
		public bool TLS10 {
			get {
				return this.tLS10Field;
			}
			set {
				this.tLS10Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public SecurityCapabilitiesExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (TypeName = "SecurityCapabilities", Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SecurityCapabilities1 {

		private bool tLS11Field;

		private bool tLS12Field;

		private bool onboardKeyGenerationField;

		private bool accessPolicyConfigField;

		private bool x509TokenField;

		private bool sAMLTokenField;

		private bool kerberosTokenField;

		private bool rELTokenField;

		private System.Xml.Linq.XElement [] anyField;

		private SecurityCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("TLS1.1", Order = 0)]
		public bool TLS11 {
			get {
				return this.tLS11Field;
			}
			set {
				this.tLS11Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("TLS1.2", Order = 1)]
		public bool TLS12 {
			get {
				return this.tLS12Field;
			}
			set {
				this.tLS12Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool OnboardKeyGeneration {
			get {
				return this.onboardKeyGenerationField;
			}
			set {
				this.onboardKeyGenerationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool AccessPolicyConfig {
			get {
				return this.accessPolicyConfigField;
			}
			set {
				this.accessPolicyConfigField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("X.509Token", Order = 4)]
		public bool X509Token {
			get {
				return this.x509TokenField;
			}
			set {
				this.x509TokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public bool SAMLToken {
			get {
				return this.sAMLTokenField;
			}
			set {
				this.sAMLTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public bool KerberosToken {
			get {
				return this.kerberosTokenField;
			}
			set {
				this.kerberosTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public bool RELToken {
			get {
				return this.rELTokenField;
			}
			set {
				this.rELTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 8)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public SecurityCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IOCapabilitiesExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IOCapabilitiesExtension {

		private System.Xml.Linq.XElement [] anyField;

		private bool auxiliaryField;

		private bool auxiliaryFieldSpecified;

		private string [] auxiliaryCommandsField;

		private IOCapabilitiesExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Auxiliary {
			get {
				return this.auxiliaryField;
			}
			set {
				this.auxiliaryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AuxiliarySpecified {
			get {
				return this.auxiliaryFieldSpecified;
			}
			set {
				this.auxiliaryFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AuxiliaryCommands", Order = 2)]
		public string [] AuxiliaryCommands {
			get {
				return this.auxiliaryCommandsField;
			}
			set {
				this.auxiliaryCommandsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IOCapabilitiesExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IOCapabilities {

		private int inputConnectorsField;

		private bool inputConnectorsFieldSpecified;

		private int relayOutputsField;

		private bool relayOutputsFieldSpecified;

		private IOCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int InputConnectors {
			get {
				return this.inputConnectorsField;
			}
			set {
				this.inputConnectorsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool InputConnectorsSpecified {
			get {
				return this.inputConnectorsFieldSpecified;
			}
			set {
				this.inputConnectorsFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int RelayOutputs {
			get {
				return this.relayOutputsField;
			}
			set {
				this.relayOutputsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RelayOutputsSpecified {
			get {
				return this.relayOutputsFieldSpecified;
			}
			set {
				this.relayOutputsFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public IOCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemCapabilitiesExtension2 {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemCapabilitiesExtension {

		private System.Xml.Linq.XElement [] anyField;

		private bool httpFirmwareUpgradeField;

		private bool httpFirmwareUpgradeFieldSpecified;

		private bool httpSystemBackupField;

		private bool httpSystemBackupFieldSpecified;

		private bool httpSystemLoggingField;

		private bool httpSystemLoggingFieldSpecified;

		private bool httpSupportInformationField;

		private bool httpSupportInformationFieldSpecified;

		private SystemCapabilitiesExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool HttpFirmwareUpgrade {
			get {
				return this.httpFirmwareUpgradeField;
			}
			set {
				this.httpFirmwareUpgradeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HttpFirmwareUpgradeSpecified {
			get {
				return this.httpFirmwareUpgradeFieldSpecified;
			}
			set {
				this.httpFirmwareUpgradeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool HttpSystemBackup {
			get {
				return this.httpSystemBackupField;
			}
			set {
				this.httpSystemBackupField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HttpSystemBackupSpecified {
			get {
				return this.httpSystemBackupFieldSpecified;
			}
			set {
				this.httpSystemBackupFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool HttpSystemLogging {
			get {
				return this.httpSystemLoggingField;
			}
			set {
				this.httpSystemLoggingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HttpSystemLoggingSpecified {
			get {
				return this.httpSystemLoggingFieldSpecified;
			}
			set {
				this.httpSystemLoggingFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public bool HttpSupportInformation {
			get {
				return this.httpSupportInformationField;
			}
			set {
				this.httpSupportInformationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HttpSupportInformationSpecified {
			get {
				return this.httpSupportInformationFieldSpecified;
			}
			set {
				this.httpSupportInformationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public SystemCapabilitiesExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (TypeName = "SystemCapabilities", Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemCapabilities1 {

		private bool discoveryResolveField;

		private bool discoveryByeField;

		private bool remoteDiscoveryField;

		private bool systemBackupField;

		private bool systemLoggingField;

		private bool firmwareUpgradeField;

		private OnvifVersion [] supportedVersionsField;

		private SystemCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool DiscoveryResolve {
			get {
				return this.discoveryResolveField;
			}
			set {
				this.discoveryResolveField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool DiscoveryBye {
			get {
				return this.discoveryByeField;
			}
			set {
				this.discoveryByeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool RemoteDiscovery {
			get {
				return this.remoteDiscoveryField;
			}
			set {
				this.remoteDiscoveryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool SystemBackup {
			get {
				return this.systemBackupField;
			}
			set {
				this.systemBackupField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public bool SystemLogging {
			get {
				return this.systemLoggingField;
			}
			set {
				this.systemLoggingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public bool FirmwareUpgrade {
			get {
				return this.firmwareUpgradeField;
			}
			set {
				this.firmwareUpgradeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("SupportedVersions", Order = 6)]
		public OnvifVersion [] SupportedVersions {
			get {
				return this.supportedVersionsField;
			}
			set {
				this.supportedVersionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public SystemCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkCapabilitiesExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkCapabilitiesExtension {

		private System.Xml.Linq.XElement [] anyField;

		private bool dot11ConfigurationField;

		private bool dot11ConfigurationFieldSpecified;

		private NetworkCapabilitiesExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Dot11Configuration {
			get {
				return this.dot11ConfigurationField;
			}
			set {
				this.dot11ConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool Dot11ConfigurationSpecified {
			get {
				return this.dot11ConfigurationFieldSpecified;
			}
			set {
				this.dot11ConfigurationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public NetworkCapabilitiesExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (TypeName = "NetworkCapabilities", Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NetworkCapabilities1 {

		private bool iPFilterField;

		private bool iPFilterFieldSpecified;

		private bool zeroConfigurationField;

		private bool zeroConfigurationFieldSpecified;

		private bool iPVersion6Field;

		private bool iPVersion6FieldSpecified;

		private bool dynDNSField;

		private bool dynDNSFieldSpecified;

		private NetworkCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool IPFilter {
			get {
				return this.iPFilterField;
			}
			set {
				this.iPFilterField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IPFilterSpecified {
			get {
				return this.iPFilterFieldSpecified;
			}
			set {
				this.iPFilterFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool ZeroConfiguration {
			get {
				return this.zeroConfigurationField;
			}
			set {
				this.zeroConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ZeroConfigurationSpecified {
			get {
				return this.zeroConfigurationFieldSpecified;
			}
			set {
				this.zeroConfigurationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool IPVersion6 {
			get {
				return this.iPVersion6Field;
			}
			set {
				this.iPVersion6Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool IPVersion6Specified {
			get {
				return this.iPVersion6FieldSpecified;
			}
			set {
				this.iPVersion6FieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool DynDNS {
			get {
				return this.dynDNSField;
			}
			set {
				this.dynDNSField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DynDNSSpecified {
			get {
				return this.dynDNSFieldSpecified;
			}
			set {
				this.dynDNSFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public NetworkCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DeviceCapabilities {

		private string xAddrField;

		private NetworkCapabilities1 networkField;

		private SystemCapabilities1 systemField;

		private IOCapabilities ioField;

		private SecurityCapabilities1 securityField;

		private DeviceCapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public NetworkCapabilities1 Network {
			get {
				return this.networkField;
			}
			set {
				this.networkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public SystemCapabilities1 System {
			get {
				return this.systemField;
			}
			set {
				this.systemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IOCapabilities IO {
			get {
				return this.ioField;
			}
			set {
				this.ioField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public SecurityCapabilities1 Security {
			get {
				return this.securityField;
			}
			set {
				this.securityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public DeviceCapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsCapabilities {

		private string xAddrField;

		private bool ruleSupportField;

		private bool analyticsModuleSupportField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool RuleSupport {
			get {
				return this.ruleSupportField;
			}
			set {
				this.ruleSupportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool AnalyticsModuleSupport {
			get {
				return this.analyticsModuleSupportField;
			}
			set {
				this.analyticsModuleSupportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Capabilities {

		private AnalyticsCapabilities analyticsField;

		private DeviceCapabilities deviceField;

		private EventCapabilities eventsField;

		private ImagingCapabilities imagingField;

		private MediaCapabilities mediaField;

		private PTZCapabilities pTZField;

		private CapabilitiesExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AnalyticsCapabilities Analytics {
			get {
				return this.analyticsField;
			}
			set {
				this.analyticsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public DeviceCapabilities Device {
			get {
				return this.deviceField;
			}
			set {
				this.deviceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public EventCapabilities Events {
			get {
				return this.eventsField;
			}
			set {
				this.eventsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public ImagingCapabilities Imaging {
			get {
				return this.imagingField;
			}
			set {
				this.imagingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public MediaCapabilities Media {
			get {
				return this.mediaField;
			}
			set {
				this.mediaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public PTZCapabilities PTZ {
			get {
				return this.pTZField;
			}
			set {
				this.pTZField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public CapabilitiesExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class UserExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class User {

		private string usernameField;

		private string passwordField;

		private UserLevel userLevelField;

		private UserExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Username {
			get {
				return this.usernameField;
			}
			set {
				this.usernameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string Password {
			get {
				return this.passwordField;
			}
			set {
				this.passwordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public UserLevel UserLevel {
			get {
				return this.userLevelField;
			}
			set {
				this.userLevelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public UserExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum UserLevel {

		/// <remarks/>
		Administrator,

		/// <remarks/>
		Operator,

		/// <remarks/>
		User,

		/// <remarks/>
		Anonymous,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RemoteUser {

		private string usernameField;

		private string passwordField;

		private bool useDerivedPasswordField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Username {
			get {
				return this.usernameField;
			}
			set {
				this.usernameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string Password {
			get {
				return this.passwordField;
			}
			set {
				this.passwordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool UseDerivedPassword {
			get {
				return this.useDerivedPasswordField;
			}
			set {
				this.useDerivedPasswordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Scope {

		private ScopeDefinition scopeDefField;

		private string scopeItemField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ScopeDefinition ScopeDef {
			get {
				return this.scopeDefField;
			}
			set {
				this.scopeDefField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 1)]
		public string ScopeItem {
			get {
				return this.scopeItemField;
			}
			set {
				this.scopeItemField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum ScopeDefinition {

		/// <remarks/>
		Fixed,

		/// <remarks/>
		Configurable,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SupportInformation {

		private AttachmentData binaryField;

		private string stringField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AttachmentData Binary {
			get {
				return this.binaryField;
			}
			set {
				this.binaryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string String {
			get {
				return this.stringField;
			}
			set {
				this.stringField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AttachmentData {

		private Include includeField;

		private string contentTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Namespace = "http://www.w3.org/2004/08/xop/include", Order = 0)]
		public Include Include {
			get {
				return this.includeField;
			}
			set {
				this.includeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute (Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/2005/05/xmlmime")]
		public string contentType {
			get {
				return this.contentTypeField;
			}
			set {
				this.contentTypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.w3.org/2004/08/xop/include")]
	public partial class Include {

		private System.Xml.Linq.XElement [] anyField;

		private string hrefField;

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
		[System.Xml.Serialization.XmlAttributeAttribute (DataType = "anyURI")]
		public string href {
			get {
				return this.hrefField;
			}
			set {
				this.hrefField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemLog {

		private AttachmentData binaryField;

		private string stringField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AttachmentData Binary {
			get {
				return this.binaryField;
			}
			set {
				this.binaryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string String {
			get {
				return this.stringField;
			}
			set {
				this.stringField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class BackupFile {

		private string nameField;

		private AttachmentData dataField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AttachmentData Data {
			get {
				return this.dataField;
			}
			set {
				this.dataField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemDateTimeExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SystemDateTime {

		private SetDateTimeType dateTimeTypeField;

		private bool daylightSavingsField;

		private TimeZone timeZoneField;

		private DateTime uTCDateTimeField;

		private DateTime localDateTimeField;

		private SystemDateTimeExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public SetDateTimeType DateTimeType {
			get {
				return this.dateTimeTypeField;
			}
			set {
				this.dateTimeTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool DaylightSavings {
			get {
				return this.daylightSavingsField;
			}
			set {
				this.daylightSavingsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public TimeZone TimeZone {
			get {
				return this.timeZoneField;
			}
			set {
				this.timeZoneField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public DateTime UTCDateTime {
			get {
				return this.uTCDateTimeField;
			}
			set {
				this.uTCDateTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public DateTime LocalDateTime {
			get {
				return this.localDateTimeField;
			}
			set {
				this.localDateTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public SystemDateTimeExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum SetDateTimeType {

		/// <remarks/>
		Manual,

		/// <remarks/>
		NTP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class TimeZone {

		private string tzField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "token", Order = 0)]
		public string TZ {
			get {
				return this.tzField;
			}
			set {
				this.tzField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DateTime {

		private Time timeField;

		private Date dateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Time Time {
			get {
				return this.timeField;
			}
			set {
				this.timeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Date Date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Time {

		private int hourField;

		private int minuteField;

		private int secondField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Hour {
			get {
				return this.hourField;
			}
			set {
				this.hourField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Minute {
			get {
				return this.minuteField;
			}
			set {
				this.minuteField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int Second {
			get {
				return this.secondField;
			}
			set {
				this.secondField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Date {

		private int yearField;

		private int monthField;

		private int dayField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Year {
			get {
				return this.yearField;
			}
			set {
				this.yearField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Month {
			get {
				return this.monthField;
			}
			set {
				this.monthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int Day {
			get {
				return this.dayField;
			}
			set {
				this.dayField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum FactoryDefaultType {

		/// <remarks/>
		Hard,

		/// <remarks/>
		Soft,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum DiscoveryMode {

		/// <remarks/>
		Discoverable,

		/// <remarks/>
		NonDiscoverable,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum CapabilityCategory {

		/// <remarks/>
		All,

		/// <remarks/>
		Analytics,

		/// <remarks/>
		Device,

		/// <remarks/>
		Events,

		/// <remarks/>
		Imaging,

		/// <remarks/>
		Media,

		/// <remarks/>
		PTZ,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum RelayLogicalState {

		/// <remarks/>
		active,

		/// <remarks/>
		inactive,
	}









	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDConfigurationOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDImgOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDImgOptions {

		private string [] imagePathField;

		private OSDImgOptionsExtension extensionField;

		private string [] formatsSupportedField;

		private int maxSizeField;

		private bool maxSizeFieldSpecified;

		private int maxWidthField;

		private bool maxWidthFieldSpecified;

		private int maxHeightField;

		private bool maxHeightFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ImagePath", DataType = "anyURI", Order = 0)]
		public string [] ImagePath {
			get {
				return this.imagePathField;
			}
			set {
				this.imagePathField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public OSDImgOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string [] FormatsSupported {
			get {
				return this.formatsSupportedField;
			}
			set {
				this.formatsSupportedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxSize {
			get {
				return this.maxSizeField;
			}
			set {
				this.maxSizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxSizeSpecified {
			get {
				return this.maxSizeFieldSpecified;
			}
			set {
				this.maxSizeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxWidth {
			get {
				return this.maxWidthField;
			}
			set {
				this.maxWidthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxWidthSpecified {
			get {
				return this.maxWidthFieldSpecified;
			}
			set {
				this.maxWidthFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxHeight {
			get {
				return this.maxHeightField;
			}
			set {
				this.maxHeightField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxHeightSpecified {
			get {
				return this.maxHeightFieldSpecified;
			}
			set {
				this.maxHeightFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDTextOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDColorOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ColorspaceRange {

		private FloatRange xField;

		private FloatRange yField;

		private FloatRange zField;

		private string colorspaceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public FloatRange X {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public FloatRange Z {
			get {
				return this.zField;
			}
			set {
				this.zField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 3)]
		public string Colorspace {
			get {
				return this.colorspaceField;
			}
			set {
				this.colorspaceField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ColorOptions {

		private object [] itemsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ColorList", typeof (Color), Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute ("ColorspaceRange", typeof (ColorspaceRange), Order = 0)]
		public object [] Items {
			get {
				return this.itemsField;
			}
			set {
				this.itemsField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDColorOptions {

		private ColorOptions colorField;

		private IntRange transparentField;

		private OSDColorOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ColorOptions Color {
			get {
				return this.colorField;
			}
			set {
				this.colorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRange Transparent {
			get {
				return this.transparentField;
			}
			set {
				this.transparentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public OSDColorOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IntRange {

		private int minField;

		private int maxField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Min {
			get {
				return this.minField;
			}
			set {
				this.minField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Max {
			get {
				return this.maxField;
			}
			set {
				this.maxField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDTextOptions {

		private string [] typeField;

		private IntRange fontSizeRangeField;

		private string [] dateFormatField;

		private string [] timeFormatField;

		private OSDColorOptions fontColorField;

		private OSDColorOptions backgroundColorField;

		private OSDTextOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Type", Order = 0)]
		public string [] Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRange FontSizeRange {
			get {
				return this.fontSizeRangeField;
			}
			set {
				this.fontSizeRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("DateFormat", Order = 2)]
		public string [] DateFormat {
			get {
				return this.dateFormatField;
			}
			set {
				this.dateFormatField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("TimeFormat", Order = 3)]
		public string [] TimeFormat {
			get {
				return this.timeFormatField;
			}
			set {
				this.timeFormatField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public OSDColorOptions FontColor {
			get {
				return this.fontColorField;
			}
			set {
				this.fontColorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public OSDColorOptions BackgroundColor {
			get {
				return this.backgroundColorField;
			}
			set {
				this.backgroundColorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public OSDTextOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MaximumNumberOfOSDs {

		private int totalField;

		private int imageField;

		private bool imageFieldSpecified;

		private int plainTextField;

		private bool plainTextFieldSpecified;

		private int dateField;

		private bool dateFieldSpecified;

		private int timeField;

		private bool timeFieldSpecified;

		private int dateAndTimeField;

		private bool dateAndTimeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int Total {
			get {
				return this.totalField;
			}
			set {
				this.totalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int Image {
			get {
				return this.imageField;
			}
			set {
				this.imageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ImageSpecified {
			get {
				return this.imageFieldSpecified;
			}
			set {
				this.imageFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int PlainText {
			get {
				return this.plainTextField;
			}
			set {
				this.plainTextField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PlainTextSpecified {
			get {
				return this.plainTextFieldSpecified;
			}
			set {
				this.plainTextFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int Date {
			get {
				return this.dateField;
			}
			set {
				this.dateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DateSpecified {
			get {
				return this.dateFieldSpecified;
			}
			set {
				this.dateFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int Time {
			get {
				return this.timeField;
			}
			set {
				this.timeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool TimeSpecified {
			get {
				return this.timeFieldSpecified;
			}
			set {
				this.timeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int DateAndTime {
			get {
				return this.dateAndTimeField;
			}
			set {
				this.dateAndTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DateAndTimeSpecified {
			get {
				return this.dateAndTimeFieldSpecified;
			}
			set {
				this.dateAndTimeFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class OSDConfigurationOptions {

		private MaximumNumberOfOSDs maximumNumberOfOSDsField;

		private OSDType [] typeField;

		private string [] positionOptionField;

		private OSDTextOptions textOptionField;

		private OSDImgOptions imageOptionField;

		private OSDConfigurationOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public MaximumNumberOfOSDs MaximumNumberOfOSDs {
			get {
				return this.maximumNumberOfOSDsField;
			}
			set {
				this.maximumNumberOfOSDsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Type", Order = 1)]
		public OSDType [] Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("PositionOption", Order = 2)]
		public string [] PositionOption {
			get {
				return this.positionOptionField;
			}
			set {
				this.positionOptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public OSDTextOptions TextOption {
			get {
				return this.textOptionField;
			}
			set {
				this.textOptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public OSDImgOptions ImageOption {
			get {
				return this.imageOptionField;
			}
			set {
				this.imageOptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public OSDConfigurationOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MediaUri {

		private string uriField;

		private bool invalidAfterConnectField;

		private bool invalidAfterRebootField;

		private string timeoutField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string Uri {
			get {
				return this.uriField;
			}
			set {
				this.uriField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool InvalidAfterConnect {
			get {
				return this.invalidAfterConnectField;
			}
			set {
				this.invalidAfterConnectField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool InvalidAfterReboot {
			get {
				return this.invalidAfterRebootField;
			}
			set {
				this.invalidAfterRebootField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 3)]
		public string Timeout {
			get {
				return this.timeoutField;
			}
			set {
				this.timeoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Transport {

		private TransportProtocol protocolField;

		private Transport tunnelField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public TransportProtocol Protocol {
			get {
				return this.protocolField;
			}
			set {
				this.protocolField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Transport Tunnel {
			get {
				return this.tunnelField;
			}
			set {
				this.tunnelField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum TransportProtocol {

		/// <remarks/>
		UDP,

		/// <remarks/>
		TCP,

		/// <remarks/>
		RTSP,

		/// <remarks/>
		HTTP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class StreamSetup {

		private StreamType streamField;

		private Transport transportField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public StreamType Stream {
			get {
				return this.streamField;
			}
			set {
				this.streamField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Transport Transport {
			get {
				return this.transportField;
			}
			set {
				this.transportField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum StreamType {

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute ("RTP-Unicast")]
		RTPUnicast,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute ("RTP-Multicast")]
		RTPMulticast,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioDecoderConfigurationOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class G726DecOptions {

		private int [] bitrateField;

		private int [] sampleRateRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 0)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] Bitrate {
			get {
				return this.bitrateField;
			}
			set {
				this.bitrateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 1)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] SampleRateRange {
			get {
				return this.sampleRateRangeField;
			}
			set {
				this.sampleRateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class G711DecOptions {

		private int [] bitrateField;

		private int [] sampleRateRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 0)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] Bitrate {
			get {
				return this.bitrateField;
			}
			set {
				this.bitrateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 1)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] SampleRateRange {
			get {
				return this.sampleRateRangeField;
			}
			set {
				this.sampleRateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AACDecOptions {

		private int [] bitrateField;

		private int [] sampleRateRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 0)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] Bitrate {
			get {
				return this.bitrateField;
			}
			set {
				this.bitrateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 1)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] SampleRateRange {
			get {
				return this.sampleRateRangeField;
			}
			set {
				this.sampleRateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioDecoderConfigurationOptions {

		private AACDecOptions aACDecOptionsField;

		private G711DecOptions g711DecOptionsField;

		private G726DecOptions g726DecOptionsField;

		private AudioDecoderConfigurationOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AACDecOptions AACDecOptions {
			get {
				return this.aACDecOptionsField;
			}
			set {
				this.aACDecOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public G711DecOptions G711DecOptions {
			get {
				return this.g711DecOptionsField;
			}
			set {
				this.g711DecOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public G726DecOptions G726DecOptions {
			get {
				return this.g726DecOptionsField;
			}
			set {
				this.g726DecOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public AudioDecoderConfigurationOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioOutputConfigurationOptions {

		private string [] outputTokensAvailableField;

		private string [] sendPrimacyOptionsField;

		private IntRange outputLevelRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("OutputTokensAvailable", Order = 0)]
		public string [] OutputTokensAvailable {
			get {
				return this.outputTokensAvailableField;
			}
			set {
				this.outputTokensAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("SendPrimacyOptions", DataType = "anyURI", Order = 1)]
		public string [] SendPrimacyOptions {
			get {
				return this.sendPrimacyOptionsField;
			}
			set {
				this.sendPrimacyOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public IntRange OutputLevelRange {
			get {
				return this.outputLevelRangeField;
			}
			set {
				this.outputLevelRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataConfigurationOptionsExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataConfigurationOptionsExtension {

		private string [] compressionTypeField;

		private MetadataConfigurationOptionsExtension2 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("CompressionType", Order = 0)]
		public string [] CompressionType {
			get {
				return this.compressionTypeField;
			}
			set {
				this.compressionTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public MetadataConfigurationOptionsExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZStatusFilterOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZStatusFilterOptions {

		private bool panTiltStatusSupportedField;

		private bool zoomStatusSupportedField;

		private System.Xml.Linq.XElement [] anyField;

		private bool panTiltPositionSupportedField;

		private bool panTiltPositionSupportedFieldSpecified;

		private bool zoomPositionSupportedField;

		private bool zoomPositionSupportedFieldSpecified;

		private PTZStatusFilterOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool PanTiltStatusSupported {
			get {
				return this.panTiltStatusSupportedField;
			}
			set {
				this.panTiltStatusSupportedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool ZoomStatusSupported {
			get {
				return this.zoomStatusSupportedField;
			}
			set {
				this.zoomStatusSupportedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool PanTiltPositionSupported {
			get {
				return this.panTiltPositionSupportedField;
			}
			set {
				this.panTiltPositionSupportedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PanTiltPositionSupportedSpecified {
			get {
				return this.panTiltPositionSupportedFieldSpecified;
			}
			set {
				this.panTiltPositionSupportedFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public bool ZoomPositionSupported {
			get {
				return this.zoomPositionSupportedField;
			}
			set {
				this.zoomPositionSupportedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ZoomPositionSupportedSpecified {
			get {
				return this.zoomPositionSupportedFieldSpecified;
			}
			set {
				this.zoomPositionSupportedFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public PTZStatusFilterOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataConfigurationOptions {

		private PTZStatusFilterOptions pTZStatusFilterOptionsField;

		private System.Xml.Linq.XElement [] anyField;

		private MetadataConfigurationOptionsExtension extensionField;

		private bool geoLocationField;

		private bool geoLocationFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZStatusFilterOptions PTZStatusFilterOptions {
			get {
				return this.pTZStatusFilterOptionsField;
			}
			set {
				this.pTZStatusFilterOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public MetadataConfigurationOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool GeoLocation {
			get {
				return this.geoLocationField;
			}
			set {
				this.geoLocationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GeoLocationSpecified {
			get {
				return this.geoLocationFieldSpecified;
			}
			set {
				this.geoLocationFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioEncoderConfigurationOption {

		private AudioEncoding encodingField;

		private int [] bitrateListField;

		private int [] sampleRateListField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AudioEncoding Encoding {
			get {
				return this.encodingField;
			}
			set {
				this.encodingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 1)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] BitrateList {
			get {
				return this.bitrateListField;
			}
			set {
				this.bitrateListField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 2)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] SampleRateList {
			get {
				return this.sampleRateListField;
			}
			set {
				this.sampleRateListField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum AudioEncoding {

		/// <remarks/>
		G711,

		/// <remarks/>
		G726,

		/// <remarks/>
		AAC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioEncoderConfigurationOptions {

		private AudioEncoderConfigurationOption [] optionsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Options", Order = 0)]
		public AudioEncoderConfigurationOption [] Options {
			get {
				return this.optionsField;
			}
			set {
				this.optionsField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioSourceOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioSourceConfigurationOptions {

		private string [] inputTokensAvailableField;

		private AudioSourceOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("InputTokensAvailable", Order = 0)]
		public string [] InputTokensAvailable {
			get {
				return this.inputTokensAvailableField;
			}
			set {
				this.inputTokensAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AudioSourceOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoEncoderOptionsExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoEncoderOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		private JpegOptions2 jPEGField;

		private Mpeg4Options2 mPEG4Field;

		private H264Options2 h264Field;

		private VideoEncoderOptionsExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public JpegOptions2 JPEG {
			get {
				return this.jPEGField;
			}
			set {
				this.jPEGField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Mpeg4Options2 MPEG4 {
			get {
				return this.mPEG4Field;
			}
			set {
				this.mPEG4Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public H264Options2 H264 {
			get {
				return this.h264Field;
			}
			set {
				this.h264Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public VideoEncoderOptionsExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class JpegOptions2 : JpegOptions {

		private IntRange bitrateRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRange BitrateRange {
			get {
				return this.bitrateRangeField;
			}
			set {
				this.bitrateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (JpegOptions2))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class JpegOptions {

		private VideoResolution [] resolutionsAvailableField;

		private IntRange frameRateRangeField;

		private IntRange encodingIntervalRangeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ResolutionsAvailable", Order = 0)]
		public VideoResolution [] ResolutionsAvailable {
			get {
				return this.resolutionsAvailableField;
			}
			set {
				this.resolutionsAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRange FrameRateRange {
			get {
				return this.frameRateRangeField;
			}
			set {
				this.frameRateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public IntRange EncodingIntervalRange {
			get {
				return this.encodingIntervalRangeField;
			}
			set {
				this.encodingIntervalRangeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Mpeg4Options2 : Mpeg4Options {

		private IntRange bitrateRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRange BitrateRange {
			get {
				return this.bitrateRangeField;
			}
			set {
				this.bitrateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (Mpeg4Options2))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Mpeg4Options {

		private VideoResolution [] resolutionsAvailableField;

		private IntRange govLengthRangeField;

		private IntRange frameRateRangeField;

		private IntRange encodingIntervalRangeField;

		private Mpeg4Profile [] mpeg4ProfilesSupportedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ResolutionsAvailable", Order = 0)]
		public VideoResolution [] ResolutionsAvailable {
			get {
				return this.resolutionsAvailableField;
			}
			set {
				this.resolutionsAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRange GovLengthRange {
			get {
				return this.govLengthRangeField;
			}
			set {
				this.govLengthRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public IntRange FrameRateRange {
			get {
				return this.frameRateRangeField;
			}
			set {
				this.frameRateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IntRange EncodingIntervalRange {
			get {
				return this.encodingIntervalRangeField;
			}
			set {
				this.encodingIntervalRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mpeg4ProfilesSupported", Order = 4)]
		public Mpeg4Profile [] Mpeg4ProfilesSupported {
			get {
				return this.mpeg4ProfilesSupportedField;
			}
			set {
				this.mpeg4ProfilesSupportedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum Mpeg4Profile {

		/// <remarks/>
		SP,

		/// <remarks/>
		ASP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class H264Options2 : H264Options {

		private IntRange bitrateRangeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRange BitrateRange {
			get {
				return this.bitrateRangeField;
			}
			set {
				this.bitrateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (H264Options2))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class H264Options {

		private VideoResolution [] resolutionsAvailableField;

		private IntRange govLengthRangeField;

		private IntRange frameRateRangeField;

		private IntRange encodingIntervalRangeField;

		private H264Profile [] h264ProfilesSupportedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ResolutionsAvailable", Order = 0)]
		public VideoResolution [] ResolutionsAvailable {
			get {
				return this.resolutionsAvailableField;
			}
			set {
				this.resolutionsAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRange GovLengthRange {
			get {
				return this.govLengthRangeField;
			}
			set {
				this.govLengthRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public IntRange FrameRateRange {
			get {
				return this.frameRateRangeField;
			}
			set {
				this.frameRateRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IntRange EncodingIntervalRange {
			get {
				return this.encodingIntervalRangeField;
			}
			set {
				this.encodingIntervalRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("H264ProfilesSupported", Order = 4)]
		public H264Profile [] H264ProfilesSupported {
			get {
				return this.h264ProfilesSupportedField;
			}
			set {
				this.h264ProfilesSupportedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum H264Profile {

		/// <remarks/>
		Baseline,

		/// <remarks/>
		Main,

		/// <remarks/>
		Extended,

		/// <remarks/>
		High,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoEncoderConfigurationOptions {

		private IntRange qualityRangeField;

		private JpegOptions jPEGField;

		private Mpeg4Options mPEG4Field;

		private H264Options h264Field;

		private VideoEncoderOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRange QualityRange {
			get {
				return this.qualityRangeField;
			}
			set {
				this.qualityRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public JpegOptions JPEG {
			get {
				return this.jPEGField;
			}
			set {
				this.jPEGField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Mpeg4Options MPEG4 {
			get {
				return this.mPEG4Field;
			}
			set {
				this.mPEG4Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public H264Options H264 {
			get {
				return this.h264Field;
			}
			set {
				this.h264Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public VideoEncoderOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceConfigurationOptionsExtension2 {

		private SceneOrientationMode [] sceneOrientationModeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("SceneOrientationMode", Order = 0)]
		public SceneOrientationMode [] SceneOrientationMode {
			get {
				return this.sceneOrientationModeField;
			}
			set {
				this.sceneOrientationModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum SceneOrientationMode {

		/// <remarks/>
		MANUAL,

		/// <remarks/>
		AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RotateOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RotateOptions {

		private RotateMode [] modeField;

		private int [] degreeListField;

		private RotateOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public RotateMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute (Order = 1)]
		[System.Xml.Serialization.XmlArrayItemAttribute ("Items", IsNullable = false)]
		public int [] DegreeList {
			get {
				return this.degreeListField;
			}
			set {
				this.degreeListField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public RotateOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum RotateMode {

		/// <remarks/>
		OFF,

		/// <remarks/>
		ON,

		/// <remarks/>
		AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceConfigurationOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		private RotateOptions rotateField;

		private VideoSourceConfigurationOptionsExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public RotateOptions Rotate {
			get {
				return this.rotateField;
			}
			set {
				this.rotateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public VideoSourceConfigurationOptionsExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IntRectangleRange {

		private IntRange xRangeField;

		private IntRange yRangeField;

		private IntRange widthRangeField;

		private IntRange heightRangeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRange XRange {
			get {
				return this.xRangeField;
			}
			set {
				this.xRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRange YRange {
			get {
				return this.yRangeField;
			}
			set {
				this.yRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public IntRange WidthRange {
			get {
				return this.widthRangeField;
			}
			set {
				this.widthRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IntRange HeightRange {
			get {
				return this.heightRangeField;
			}
			set {
				this.heightRangeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceConfigurationOptions {

		private IntRectangleRange boundsRangeField;

		private string [] videoSourceTokensAvailableField;

		private VideoSourceConfigurationOptionsExtension extensionField;

		private int maximumNumberOfProfilesField;

		private bool maximumNumberOfProfilesFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRectangleRange BoundsRange {
			get {
				return this.boundsRangeField;
			}
			set {
				this.boundsRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("VideoSourceTokensAvailable", Order = 1)]
		public string [] VideoSourceTokensAvailable {
			get {
				return this.videoSourceTokensAvailableField;
			}
			set {
				this.videoSourceTokensAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public VideoSourceConfigurationOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaximumNumberOfProfiles {
			get {
				return this.maximumNumberOfProfilesField;
			}
			set {
				this.maximumNumberOfProfilesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaximumNumberOfProfilesSpecified {
			get {
				return this.maximumNumberOfProfilesFieldSpecified;
			}
			set {
				this.maximumNumberOfProfilesFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ProfileExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ProfileExtension {

		private System.Xml.Linq.XElement [] anyField;

		private AudioOutputConfiguration audioOutputConfigurationField;

		private AudioDecoderConfiguration audioDecoderConfigurationField;

		private ProfileExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AudioOutputConfiguration AudioOutputConfiguration {
			get {
				return this.audioOutputConfigurationField;
			}
			set {
				this.audioOutputConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public AudioDecoderConfiguration AudioDecoderConfiguration {
			get {
				return this.audioDecoderConfigurationField;
			}
			set {
				this.audioDecoderConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public ProfileExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioOutputConfiguration : ConfigurationEntity {

		private string outputTokenField;

		private string sendPrimacyField;

		private int outputLevelField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string OutputToken {
			get {
				return this.outputTokenField;
			}
			set {
				this.outputTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 1)]
		public string SendPrimacy {
			get {
				return this.sendPrimacyField;
			}
			set {
				this.sendPrimacyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int OutputLevel {
			get {
				return this.outputLevelField;
			}
			set {
				this.outputLevelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AnalyticsEngineControl))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AnalyticsEngineInput))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AnalyticsEngine))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (PTZConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioDecoderConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioOutputConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoOutputConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (MetadataConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoAnalyticsConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioEncoder2Configuration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioEncoderConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (AudioSourceConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoEncoder2Configuration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoEncoderConfiguration))]
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (VideoSourceConfiguration))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ConfigurationEntity {

		private string nameField;

		private int useCountField;

		private string tokenField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int UseCount {
			get {
				return this.useCountField;
			}
			set {
				this.useCountField = value;
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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngineControl : ConfigurationEntity {

		private string engineTokenField;

		private string engineConfigTokenField;

		private string [] inputTokenField;

		private string [] receiverTokenField;

		private MulticastConfiguration multicastField;

		private Config subscriptionField;

		private ModeOfOperation modeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string EngineToken {
			get {
				return this.engineTokenField;
			}
			set {
				this.engineTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string EngineConfigToken {
			get {
				return this.engineConfigTokenField;
			}
			set {
				this.engineConfigTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("InputToken", Order = 2)]
		public string [] InputToken {
			get {
				return this.inputTokenField;
			}
			set {
				this.inputTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ReceiverToken", Order = 3)]
		public string [] ReceiverToken {
			get {
				return this.receiverTokenField;
			}
			set {
				this.receiverTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public MulticastConfiguration Multicast {
			get {
				return this.multicastField;
			}
			set {
				this.multicastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public Config Subscription {
			get {
				return this.subscriptionField;
			}
			set {
				this.subscriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public ModeOfOperation Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 7)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MulticastConfiguration {

		private IPAddress addressField;

		private int portField;

		private int tTLField;

		private bool autoStartField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IPAddress Address {
			get {
				return this.addressField;
			}
			set {
				this.addressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Port {
			get {
				return this.portField;
			}
			set {
				this.portField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int TTL {
			get {
				return this.tTLField;
			}
			set {
				this.tTLField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public bool AutoStart {
			get {
				return this.autoStartField;
			}
			set {
				this.autoStartField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Config {

		private ItemList parametersField;

		private string nameField;

		private System.Xml.XmlQualifiedName typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ItemList Parameters {
			get {
				return this.parametersField;
			}
			set {
				this.parametersField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		public System.Xml.XmlQualifiedName Type {
			get {
				return this.typeField;
			}
			set {
				this.typeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ItemList {

		private ItemListSimpleItem [] simpleItemField;

		private ItemListElementItem [] elementItemField;

		private ItemListExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("SimpleItem", Order = 0)]
		public ItemListSimpleItem [] SimpleItem {
			get {
				return this.simpleItemField;
			}
			set {
				this.simpleItemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("ElementItem", Order = 1)]
		public ItemListElementItem [] ElementItem {
			get {
				return this.elementItemField;
			}
			set {
				this.elementItemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ItemListExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ItemListSimpleItem {

		private string nameField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		public string Value {
			get {
				return this.valueField;
			}
			set {
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ItemListElementItem {

		private System.Xml.Linq.XElement anyField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 0)]
		public System.Xml.Linq.XElement Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string Name {
			get {
				return this.nameField;
			}
			set {
				this.nameField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ItemListExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum ModeOfOperation {

		/// <remarks/>
		Idle,

		/// <remarks/>
		Active,

		/// <remarks/>
		Unknown,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngineInput : ConfigurationEntity {

		private SourceIdentification sourceIdentificationField;

		private VideoEncoderConfiguration videoInputField;

		private MetadataInput metadataInputField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public SourceIdentification SourceIdentification {
			get {
				return this.sourceIdentificationField;
			}
			set {
				this.sourceIdentificationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoEncoderConfiguration VideoInput {
			get {
				return this.videoInputField;
			}
			set {
				this.videoInputField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public MetadataInput MetadataInput {
			get {
				return this.metadataInputField;
			}
			set {
				this.metadataInputField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SourceIdentification {

		private string nameField;

		private string [] tokenField;

		private SourceIdentificationExtension extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute ("Token", Order = 1)]
		public string [] Token {
			get {
				return this.tokenField;
			}
			set {
				this.tokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public SourceIdentificationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SourceIdentificationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoEncoderConfiguration : ConfigurationEntity {

		private VideoEncoding encodingField;

		private VideoResolution resolutionField;

		private float qualityField;

		private VideoRateControl rateControlField;

		private Mpeg4Configuration mPEG4Field;

		private H264Configuration h264Field;

		private MulticastConfiguration multicastField;

		private string sessionTimeoutField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public VideoEncoding Encoding {
			get {
				return this.encodingField;
			}
			set {
				this.encodingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoResolution Resolution {
			get {
				return this.resolutionField;
			}
			set {
				this.resolutionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float Quality {
			get {
				return this.qualityField;
			}
			set {
				this.qualityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public VideoRateControl RateControl {
			get {
				return this.rateControlField;
			}
			set {
				this.rateControlField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public Mpeg4Configuration MPEG4 {
			get {
				return this.mPEG4Field;
			}
			set {
				this.mPEG4Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public H264Configuration H264 {
			get {
				return this.h264Field;
			}
			set {
				this.h264Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public MulticastConfiguration Multicast {
			get {
				return this.multicastField;
			}
			set {
				this.multicastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 7)]
		public string SessionTimeout {
			get {
				return this.sessionTimeoutField;
			}
			set {
				this.sessionTimeoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 8)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum VideoEncoding {

		/// <remarks/>
		JPEG,

		/// <remarks/>
		MPEG4,

		/// <remarks/>
		H264,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoRateControl {

		private int frameRateLimitField;

		private int encodingIntervalField;

		private int bitrateLimitField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int FrameRateLimit {
			get {
				return this.frameRateLimitField;
			}
			set {
				this.frameRateLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int EncodingInterval {
			get {
				return this.encodingIntervalField;
			}
			set {
				this.encodingIntervalField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int BitrateLimit {
			get {
				return this.bitrateLimitField;
			}
			set {
				this.bitrateLimitField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Mpeg4Configuration {

		private int govLengthField;

		private Mpeg4Profile mpeg4ProfileField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int GovLength {
			get {
				return this.govLengthField;
			}
			set {
				this.govLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Mpeg4Profile Mpeg4Profile {
			get {
				return this.mpeg4ProfileField;
			}
			set {
				this.mpeg4ProfileField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class H264Configuration {

		private int govLengthField;

		private H264Profile h264ProfileField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int GovLength {
			get {
				return this.govLengthField;
			}
			set {
				this.govLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public H264Profile H264Profile {
			get {
				return this.h264ProfileField;
			}
			set {
				this.h264ProfileField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataInput {

		private Config [] metadataConfigField;

		private MetadataInputExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("MetadataConfig", Order = 0)]
		public Config [] MetadataConfig {
			get {
				return this.metadataConfigField;
			}
			set {
				this.metadataConfigField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public MetadataInputExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataInputExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngine : ConfigurationEntity {

		private AnalyticsDeviceEngineConfiguration analyticsEngineConfigurationField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AnalyticsDeviceEngineConfiguration AnalyticsEngineConfiguration {
			get {
				return this.analyticsEngineConfigurationField;
			}
			set {
				this.analyticsEngineConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsDeviceEngineConfiguration {

		private EngineConfiguration [] engineConfigurationField;

		private AnalyticsDeviceEngineConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("EngineConfiguration", Order = 0)]
		public EngineConfiguration [] EngineConfiguration {
			get {
				return this.engineConfigurationField;
			}
			set {
				this.engineConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AnalyticsDeviceEngineConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EngineConfiguration {

		private VideoAnalyticsConfiguration videoAnalyticsConfigurationField;

		private AnalyticsEngineInputInfo analyticsEngineInputInfoField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public VideoAnalyticsConfiguration VideoAnalyticsConfiguration {
			get {
				return this.videoAnalyticsConfigurationField;
			}
			set {
				this.videoAnalyticsConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AnalyticsEngineInputInfo AnalyticsEngineInputInfo {
			get {
				return this.analyticsEngineInputInfoField;
			}
			set {
				this.analyticsEngineInputInfoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoAnalyticsConfiguration : ConfigurationEntity {

		private AnalyticsEngineConfiguration analyticsEngineConfigurationField;

		private RuleEngineConfiguration ruleEngineConfigurationField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AnalyticsEngineConfiguration AnalyticsEngineConfiguration {
			get {
				return this.analyticsEngineConfigurationField;
			}
			set {
				this.analyticsEngineConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public RuleEngineConfiguration RuleEngineConfiguration {
			get {
				return this.ruleEngineConfigurationField;
			}
			set {
				this.ruleEngineConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngineConfiguration {

		private Config [] analyticsModuleField;

		private AnalyticsEngineConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AnalyticsModule", Order = 0)]
		public Config [] AnalyticsModule {
			get {
				return this.analyticsModuleField;
			}
			set {
				this.analyticsModuleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AnalyticsEngineConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngineConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RuleEngineConfiguration {

		private Config [] ruleField;

		private RuleEngineConfigurationExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Rule", Order = 0)]
		public Config [] Rule {
			get {
				return this.ruleField;
			}
			set {
				this.ruleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public RuleEngineConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RuleEngineConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngineInputInfo {

		private Config inputInfoField;

		private AnalyticsEngineInputInfoExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Config InputInfo {
			get {
				return this.inputInfoField;
			}
			set {
				this.inputInfoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public AnalyticsEngineInputInfoExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsEngineInputInfoExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AnalyticsDeviceEngineConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZConfiguration : ConfigurationEntity {

		private string nodeTokenField;

		private string defaultAbsolutePantTiltPositionSpaceField;

		private string defaultAbsoluteZoomPositionSpaceField;

		private string defaultRelativePanTiltTranslationSpaceField;

		private string defaultRelativeZoomTranslationSpaceField;

		private string defaultContinuousPanTiltVelocitySpaceField;

		private string defaultContinuousZoomVelocitySpaceField;

		private PTZSpeed defaultPTZSpeedField;

		private string defaultPTZTimeoutField;

		private PanTiltLimits panTiltLimitsField;

		private ZoomLimits zoomLimitsField;

		private PTZConfigurationExtension extensionField;

		private int moveRampField;

		private bool moveRampFieldSpecified;

		private int presetRampField;

		private bool presetRampFieldSpecified;

		private int presetTourRampField;

		private bool presetTourRampFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string NodeToken {
			get {
				return this.nodeTokenField;
			}
			set {
				this.nodeTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 1)]
		public string DefaultAbsolutePantTiltPositionSpace {
			get {
				return this.defaultAbsolutePantTiltPositionSpaceField;
			}
			set {
				this.defaultAbsolutePantTiltPositionSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 2)]
		public string DefaultAbsoluteZoomPositionSpace {
			get {
				return this.defaultAbsoluteZoomPositionSpaceField;
			}
			set {
				this.defaultAbsoluteZoomPositionSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 3)]
		public string DefaultRelativePanTiltTranslationSpace {
			get {
				return this.defaultRelativePanTiltTranslationSpaceField;
			}
			set {
				this.defaultRelativePanTiltTranslationSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 4)]
		public string DefaultRelativeZoomTranslationSpace {
			get {
				return this.defaultRelativeZoomTranslationSpaceField;
			}
			set {
				this.defaultRelativeZoomTranslationSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 5)]
		public string DefaultContinuousPanTiltVelocitySpace {
			get {
				return this.defaultContinuousPanTiltVelocitySpaceField;
			}
			set {
				this.defaultContinuousPanTiltVelocitySpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 6)]
		public string DefaultContinuousZoomVelocitySpace {
			get {
				return this.defaultContinuousZoomVelocitySpaceField;
			}
			set {
				this.defaultContinuousZoomVelocitySpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public PTZSpeed DefaultPTZSpeed {
			get {
				return this.defaultPTZSpeedField;
			}
			set {
				this.defaultPTZSpeedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 8)]
		public string DefaultPTZTimeout {
			get {
				return this.defaultPTZTimeoutField;
			}
			set {
				this.defaultPTZTimeoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public PanTiltLimits PanTiltLimits {
			get {
				return this.panTiltLimitsField;
			}
			set {
				this.panTiltLimitsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public ZoomLimits ZoomLimits {
			get {
				return this.zoomLimitsField;
			}
			set {
				this.zoomLimitsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 11)]
		public PTZConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MoveRamp {
			get {
				return this.moveRampField;
			}
			set {
				this.moveRampField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MoveRampSpecified {
			get {
				return this.moveRampFieldSpecified;
			}
			set {
				this.moveRampFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int PresetRamp {
			get {
				return this.presetRampField;
			}
			set {
				this.presetRampField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PresetRampSpecified {
			get {
				return this.presetRampFieldSpecified;
			}
			set {
				this.presetRampFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int PresetTourRamp {
			get {
				return this.presetTourRampField;
			}
			set {
				this.presetTourRampField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PresetTourRampSpecified {
			get {
				return this.presetTourRampFieldSpecified;
			}
			set {
				this.presetTourRampFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZSpeed {

		private Vector2D panTiltField;

		private Vector1D zoomField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Vector2D PanTilt {
			get {
				return this.panTiltField;
			}
			set {
				this.panTiltField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Vector1D Zoom {
			get {
				return this.zoomField;
			}
			set {
				this.zoomField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Vector2D {

		private float xField;

		private float yField;

		private string spaceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float x {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute (DataType = "anyURI")]
		public string space {
			get {
				return this.spaceField;
			}
			set {
				this.spaceField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Vector1D {

		private float xField;

		private string spaceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float x {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute (DataType = "anyURI")]
		public string space {
			get {
				return this.spaceField;
			}
			set {
				this.spaceField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PanTiltLimits {

		private Space2DDescription rangeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Space2DDescription Range {
			get {
				return this.rangeField;
			}
			set {
				this.rangeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ZoomLimits {

		private Space1DDescription rangeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Space1DDescription Range {
			get {
				return this.rangeField;
			}
			set {
				this.rangeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

		private PTControlDirection pTControlDirectionField;

		private PTZConfigurationExtension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTControlDirection PTControlDirection {
			get {
				return this.pTControlDirectionField;
			}
			set {
				this.pTControlDirectionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTZConfigurationExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTControlDirection {

		private EFlip eFlipField;

		private Reverse reverseField;

		private PTControlDirectionExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public EFlip EFlip {
			get {
				return this.eFlipField;
			}
			set {
				this.eFlipField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Reverse Reverse {
			get {
				return this.reverseField;
			}
			set {
				this.reverseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTControlDirectionExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EFlip {

		private EFlipMode modeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public EFlipMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum EFlipMode {

		/// <remarks/>
		OFF,

		/// <remarks/>
		ON,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Reverse {

		private ReverseMode modeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ReverseMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum ReverseMode {

		/// <remarks/>
		OFF,

		/// <remarks/>
		ON,

		/// <remarks/>
		AUTO,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTControlDirectionExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZConfigurationExtension2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioDecoderConfiguration : ConfigurationEntity {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoOutputConfiguration : ConfigurationEntity {

		private string outputTokenField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string OutputToken {
			get {
				return this.outputTokenField;
			}
			set {
				this.outputTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataConfiguration : ConfigurationEntity {

		private PTZFilter pTZStatusField;

		private EventSubscription eventsField;

		private bool analyticsField;

		private bool analyticsFieldSpecified;

		private MulticastConfiguration multicastField;

		private string sessionTimeoutField;

		private System.Xml.Linq.XElement [] anyField;

		private AnalyticsEngineConfiguration analyticsEngineConfigurationField;

		private MetadataConfigurationExtension extensionField;

		private string compressionTypeField;

		private bool geoLocationField;

		private bool geoLocationFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZFilter PTZStatus {
			get {
				return this.pTZStatusField;
			}
			set {
				this.pTZStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public EventSubscription Events {
			get {
				return this.eventsField;
			}
			set {
				this.eventsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool Analytics {
			get {
				return this.analyticsField;
			}
			set {
				this.analyticsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AnalyticsSpecified {
			get {
				return this.analyticsFieldSpecified;
			}
			set {
				this.analyticsFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public MulticastConfiguration Multicast {
			get {
				return this.multicastField;
			}
			set {
				this.multicastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 4)]
		public string SessionTimeout {
			get {
				return this.sessionTimeoutField;
			}
			set {
				this.sessionTimeoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 5)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public AnalyticsEngineConfiguration AnalyticsEngineConfiguration {
			get {
				return this.analyticsEngineConfigurationField;
			}
			set {
				this.analyticsEngineConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public MetadataConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string CompressionType {
			get {
				return this.compressionTypeField;
			}
			set {
				this.compressionTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool GeoLocation {
			get {
				return this.geoLocationField;
			}
			set {
				this.geoLocationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GeoLocationSpecified {
			get {
				return this.geoLocationFieldSpecified;
			}
			set {
				this.geoLocationFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZFilter {

		private bool statusField;

		private bool positionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EventSubscription {

		private FilterType filterField;

		private EventSubscriptionSubscriptionPolicy subscriptionPolicyField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public FilterType Filter {
			get {
				return this.filterField;
			}
			set {
				this.filterField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public EventSubscriptionSubscriptionPolicy SubscriptionPolicy {
			get {
				return this.subscriptionPolicyField;
			}
			set {
				this.subscriptionPolicyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlIncludeAttribute (typeof (EventFilter))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://docs.oasis-open.org/wsn/b-2")]
	public partial class FilterType {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EventFilter : FilterType {
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EventSubscriptionSubscriptionPolicy {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MetadataConfigurationExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioEncoder2Configuration : ConfigurationEntity {

		private string encodingField;

		private MulticastConfiguration multicastField;

		private int bitrateField;

		private int sampleRateField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Encoding {
			get {
				return this.encodingField;
			}
			set {
				this.encodingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public MulticastConfiguration Multicast {
			get {
				return this.multicastField;
			}
			set {
				this.multicastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int Bitrate {
			get {
				return this.bitrateField;
			}
			set {
				this.bitrateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public int SampleRate {
			get {
				return this.sampleRateField;
			}
			set {
				this.sampleRateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioEncoderConfiguration : ConfigurationEntity {

		private AudioEncoding encodingField;

		private int bitrateField;

		private int sampleRateField;

		private MulticastConfiguration multicastField;

		private string sessionTimeoutField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AudioEncoding Encoding {
			get {
				return this.encodingField;
			}
			set {
				this.encodingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Bitrate {
			get {
				return this.bitrateField;
			}
			set {
				this.bitrateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public int SampleRate {
			get {
				return this.sampleRateField;
			}
			set {
				this.sampleRateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public MulticastConfiguration Multicast {
			get {
				return this.multicastField;
			}
			set {
				this.multicastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 4)]
		public string SessionTimeout {
			get {
				return this.sessionTimeoutField;
			}
			set {
				this.sessionTimeoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 5)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AudioSourceConfiguration : ConfigurationEntity {

		private string sourceTokenField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string SourceToken {
			get {
				return this.sourceTokenField;
			}
			set {
				this.sourceTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoEncoder2Configuration : ConfigurationEntity {

		private string encodingField;

		private VideoResolution2 resolutionField;

		private VideoRateControl2 rateControlField;

		private MulticastConfiguration multicastField;

		private float qualityField;

		private System.Xml.Linq.XElement [] anyField;

		private int govLengthField;

		private bool govLengthFieldSpecified;

		private string profileField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string Encoding {
			get {
				return this.encodingField;
			}
			set {
				this.encodingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoResolution2 Resolution {
			get {
				return this.resolutionField;
			}
			set {
				this.resolutionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public VideoRateControl2 RateControl {
			get {
				return this.rateControlField;
			}
			set {
				this.rateControlField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public MulticastConfiguration Multicast {
			get {
				return this.multicastField;
			}
			set {
				this.multicastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public float Quality {
			get {
				return this.qualityField;
			}
			set {
				this.qualityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 5)]
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
		public int GovLength {
			get {
				return this.govLengthField;
			}
			set {
				this.govLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GovLengthSpecified {
			get {
				return this.govLengthFieldSpecified;
			}
			set {
				this.govLengthFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string Profile {
			get {
				return this.profileField;
			}
			set {
				this.profileField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoResolution2 {

		private int widthField;

		private int heightField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int Width {
			get {
				return this.widthField;
			}
			set {
				this.widthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Height {
			get {
				return this.heightField;
			}
			set {
				this.heightField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoRateControl2 {

		private float frameRateLimitField;

		private int bitrateLimitField;

		private System.Xml.Linq.XElement [] anyField;

		private bool constantBitRateField;

		private bool constantBitRateFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float FrameRateLimit {
			get {
				return this.frameRateLimitField;
			}
			set {
				this.frameRateLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int BitrateLimit {
			get {
				return this.bitrateLimitField;
			}
			set {
				this.bitrateLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
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
		public bool ConstantBitRate {
			get {
				return this.constantBitRateField;
			}
			set {
				this.constantBitRateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ConstantBitRateSpecified {
			get {
				return this.constantBitRateFieldSpecified;
			}
			set {
				this.constantBitRateFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceConfiguration : ConfigurationEntity {

		private string sourceTokenField;

		private IntRectangle boundsField;

		private System.Xml.Linq.XElement [] anyField;

		private VideoSourceConfigurationExtension extensionField;

		private string viewModeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string SourceToken {
			get {
				return this.sourceTokenField;
			}
			set {
				this.sourceTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public IntRectangle Bounds {
			get {
				return this.boundsField;
			}
			set {
				this.boundsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public VideoSourceConfigurationExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string ViewMode {
			get {
				return this.viewModeField;
			}
			set {
				this.viewModeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IntRectangle {

		private int xField;

		private int yField;

		private int widthField;

		private int heightField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int x {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int width {
			get {
				return this.widthField;
			}
			set {
				this.widthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int height {
			get {
				return this.heightField;
			}
			set {
				this.heightField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceConfigurationExtension {

		private Rotate rotateField;

		private VideoSourceConfigurationExtension2 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Rotate Rotate {
			get {
				return this.rotateField;
			}
			set {
				this.rotateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoSourceConfigurationExtension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Rotate {

		private RotateMode modeField;

		private int degreeField;

		private bool degreeFieldSpecified;

		private RotateExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public RotateMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public int Degree {
			get {
				return this.degreeField;
			}
			set {
				this.degreeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DegreeSpecified {
			get {
				return this.degreeFieldSpecified;
			}
			set {
				this.degreeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public RotateExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RotateExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class VideoSourceConfigurationExtension2 {

		private LensDescription [] lensDescriptionField;

		private SceneOrientation sceneOrientationField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("LensDescription", Order = 0)]
		public LensDescription [] LensDescription {
			get {
				return this.lensDescriptionField;
			}
			set {
				this.lensDescriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public SceneOrientation SceneOrientation {
			get {
				return this.sceneOrientationField;
			}
			set {
				this.sceneOrientationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LensDescription {

		private LensOffset offsetField;

		private LensProjection [] projectionField;

		private float xFactorField;

		private System.Xml.Linq.XElement [] anyField;

		private float focalLengthField;

		private bool focalLengthFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public LensOffset Offset {
			get {
				return this.offsetField;
			}
			set {
				this.offsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Projection", Order = 1)]
		public LensProjection [] Projection {
			get {
				return this.projectionField;
			}
			set {
				this.projectionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float XFactor {
			get {
				return this.xFactorField;
			}
			set {
				this.xFactorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
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
		public float FocalLength {
			get {
				return this.focalLengthField;
			}
			set {
				this.focalLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool FocalLengthSpecified {
			get {
				return this.focalLengthFieldSpecified;
			}
			set {
				this.focalLengthFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LensOffset {

		private float xField;

		private bool xFieldSpecified;

		private float yField;

		private bool yFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float x {
			get {
				return this.xField;
			}
			set {
				this.xField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool xSpecified {
			get {
				return this.xFieldSpecified;
			}
			set {
				this.xFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public float y {
			get {
				return this.yField;
			}
			set {
				this.yField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ySpecified {
			get {
				return this.yFieldSpecified;
			}
			set {
				this.yFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class LensProjection {

		private float angleField;

		private float radiusField;

		private float transmittanceField;

		private bool transmittanceFieldSpecified;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Angle {
			get {
				return this.angleField;
			}
			set {
				this.angleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Radius {
			get {
				return this.radiusField;
			}
			set {
				this.radiusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public float Transmittance {
			get {
				return this.transmittanceField;
			}
			set {
				this.transmittanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool TransmittanceSpecified {
			get {
				return this.transmittanceFieldSpecified;
			}
			set {
				this.transmittanceFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class SceneOrientation {

		private SceneOrientationMode modeField;

		private string orientationField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public SceneOrientationMode Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public string Orientation {
			get {
				return this.orientationField;
			}
			set {
				this.orientationField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class Profile {

		private string nameField;

		private VideoSourceConfiguration videoSourceConfigurationField;

		private AudioSourceConfiguration audioSourceConfigurationField;

		private VideoEncoderConfiguration videoEncoderConfigurationField;

		private AudioEncoderConfiguration audioEncoderConfigurationField;

		private VideoAnalyticsConfiguration videoAnalyticsConfigurationField;

		private PTZConfiguration pTZConfigurationField;

		private MetadataConfiguration metadataConfigurationField;

		private ProfileExtension extensionField;

		private string tokenField;

		private bool fixedField;

		private bool fixedFieldSpecified;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public VideoSourceConfiguration VideoSourceConfiguration {
			get {
				return this.videoSourceConfigurationField;
			}
			set {
				this.videoSourceConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public AudioSourceConfiguration AudioSourceConfiguration {
			get {
				return this.audioSourceConfigurationField;
			}
			set {
				this.audioSourceConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public VideoEncoderConfiguration VideoEncoderConfiguration {
			get {
				return this.videoEncoderConfigurationField;
			}
			set {
				this.videoEncoderConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public AudioEncoderConfiguration AudioEncoderConfiguration {
			get {
				return this.audioEncoderConfigurationField;
			}
			set {
				this.audioEncoderConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public VideoAnalyticsConfiguration VideoAnalyticsConfiguration {
			get {
				return this.videoAnalyticsConfigurationField;
			}
			set {
				this.videoAnalyticsConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public PTZConfiguration PTZConfiguration {
			get {
				return this.pTZConfigurationField;
			}
			set {
				this.pTZConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public MetadataConfiguration MetadataConfiguration {
			get {
				return this.metadataConfigurationField;
			}
			set {
				this.metadataConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public ProfileExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
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
		public bool @fixed {
			get {
				return this.fixedField;
			}
			set {
				this.fixedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool fixedSpecified {
			get {
				return this.fixedFieldSpecified;
			}
			set {
				this.fixedFieldSpecified = value;
			}
		}
	}


























	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourPresetDetailOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourPresetDetailOptions {

		private string [] presetTokenField;

		private bool homeField;

		private bool homeFieldSpecified;

		private Space2DDescription panTiltPositionSpaceField;

		private Space1DDescription zoomPositionSpaceField;

		private PTZPresetTourPresetDetailOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("PresetToken", Order = 0)]
		public string [] PresetToken {
			get {
				return this.presetTokenField;
			}
			set {
				this.presetTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Home {
			get {
				return this.homeField;
			}
			set {
				this.homeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HomeSpecified {
			get {
				return this.homeFieldSpecified;
			}
			set {
				this.homeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public Space2DDescription PanTiltPositionSpace {
			get {
				return this.panTiltPositionSpaceField;
			}
			set {
				this.panTiltPositionSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public Space1DDescription ZoomPositionSpace {
			get {
				return this.zoomPositionSpaceField;
			}
			set {
				this.zoomPositionSpaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public PTZPresetTourPresetDetailOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourSpotOptions {

		private PTZPresetTourPresetDetailOptions presetDetailField;

		private DurationRange stayTimeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZPresetTourPresetDetailOptions PresetDetail {
			get {
				return this.presetDetailField;
			}
			set {
				this.presetDetailField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public DurationRange StayTime {
			get {
				return this.stayTimeField;
			}
			set {
				this.stayTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DurationRange {

		private string minField;

		private string maxField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 0)]
		public string Min {
			get {
				return this.minField;
			}
			set {
				this.minField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 1)]
		public string Max {
			get {
				return this.maxField;
			}
			set {
				this.maxField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourStartingConditionOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourStartingConditionOptions {

		private IntRange recurringTimeField;

		private DurationRange recurringDurationField;

		private PTZPresetTourDirection [] directionField;

		private PTZPresetTourStartingConditionOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IntRange RecurringTime {
			get {
				return this.recurringTimeField;
			}
			set {
				this.recurringTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public DurationRange RecurringDuration {
			get {
				return this.recurringDurationField;
			}
			set {
				this.recurringDurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Direction", Order = 2)]
		public PTZPresetTourDirection [] Direction {
			get {
				return this.directionField;
			}
			set {
				this.directionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public PTZPresetTourStartingConditionOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum PTZPresetTourDirection {

		/// <remarks/>
		Forward,

		/// <remarks/>
		Backward,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourOptions {

		private bool autoStartField;

		private PTZPresetTourStartingConditionOptions startingConditionField;

		private PTZPresetTourSpotOptions tourSpotField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool AutoStart {
			get {
				return this.autoStartField;
			}
			set {
				this.autoStartField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZPresetTourStartingConditionOptions StartingCondition {
			get {
				return this.startingConditionField;
			}
			set {
				this.startingConditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTZPresetTourSpotOptions TourSpot {
			get {
				return this.tourSpotField;
			}
			set {
				this.tourSpotField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 3)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourStartingConditionExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourStartingCondition {

		private int recurringTimeField;

		private bool recurringTimeFieldSpecified;

		private string recurringDurationField;

		private PTZPresetTourDirection directionField;

		private bool directionFieldSpecified;

		private PTZPresetTourStartingConditionExtension extensionField;

		private bool randomPresetOrderField;

		private bool randomPresetOrderFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public int RecurringTime {
			get {
				return this.recurringTimeField;
			}
			set {
				this.recurringTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RecurringTimeSpecified {
			get {
				return this.recurringTimeFieldSpecified;
			}
			set {
				this.recurringTimeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 1)]
		public string RecurringDuration {
			get {
				return this.recurringDurationField;
			}
			set {
				this.recurringDurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTZPresetTourDirection Direction {
			get {
				return this.directionField;
			}
			set {
				this.directionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DirectionSpecified {
			get {
				return this.directionFieldSpecified;
			}
			set {
				this.directionFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public PTZPresetTourStartingConditionExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool RandomPresetOrder {
			get {
				return this.randomPresetOrderField;
			}
			set {
				this.randomPresetOrderField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RandomPresetOrderSpecified {
			get {
				return this.randomPresetOrderFieldSpecified;
			}
			set {
				this.randomPresetOrderFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourStatusExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourSpotExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourTypeExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourPresetDetail {

		private object itemField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Home", typeof (bool), Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute ("PTZPosition", typeof (PTZVector), Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute ("PresetToken", typeof (string), Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute ("TypeExtension", typeof (PTZPresetTourTypeExtension), Order = 0)]
		public object Item {
			get {
				return this.itemField;
			}
			set {
				this.itemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZVector {

		private Vector2D panTiltField;

		private Vector1D zoomField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public Vector2D PanTilt {
			get {
				return this.panTiltField;
			}
			set {
				this.panTiltField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public Vector1D Zoom {
			get {
				return this.zoomField;
			}
			set {
				this.zoomField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourSpot {

		private PTZPresetTourPresetDetail presetDetailField;

		private PTZSpeed speedField;

		private string stayTimeField;

		private PTZPresetTourSpotExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZPresetTourPresetDetail PresetDetail {
			get {
				return this.presetDetailField;
			}
			set {
				this.presetDetailField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZSpeed Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "duration", Order = 2)]
		public string StayTime {
			get {
				return this.stayTimeField;
			}
			set {
				this.stayTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public PTZPresetTourSpotExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPresetTourStatus {

		private PTZPresetTourState stateField;

		private PTZPresetTourSpot currentTourSpotField;

		private PTZPresetTourStatusExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZPresetTourState State {
			get {
				return this.stateField;
			}
			set {
				this.stateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZPresetTourSpot CurrentTourSpot {
			get {
				return this.currentTourSpotField;
			}
			set {
				this.currentTourSpotField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTZPresetTourStatusExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum PTZPresetTourState {

		/// <remarks/>
		Idle,

		/// <remarks/>
		Touring,

		/// <remarks/>
		Paused,

		/// <remarks/>
		Extended,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PresetTour {

		private string nameField;

		private PTZPresetTourStatus statusField;

		private bool autoStartField;

		private PTZPresetTourStartingCondition startingConditionField;

		private PTZPresetTourSpot [] tourSpotField;

		private PTZPresetTourExtension extensionField;

		private string tokenField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZPresetTourStatus Status {
			get {
				return this.statusField;
			}
			set {
				this.statusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public bool AutoStart {
			get {
				return this.autoStartField;
			}
			set {
				this.autoStartField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public PTZPresetTourStartingCondition StartingCondition {
			get {
				return this.startingConditionField;
			}
			set {
				this.startingConditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("TourSpot", Order = 4)]
		public PTZPresetTourSpot [] TourSpot {
			get {
				return this.tourSpotField;
			}
			set {
				this.tourSpotField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public PTZPresetTourExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZMoveStatus {

		private MoveStatus panTiltField;

		private bool panTiltFieldSpecified;

		private MoveStatus zoomField;

		private bool zoomFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public MoveStatus PanTilt {
			get {
				return this.panTiltField;
			}
			set {
				this.panTiltField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool PanTiltSpecified {
			get {
				return this.panTiltFieldSpecified;
			}
			set {
				this.panTiltFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public MoveStatus Zoom {
			get {
				return this.zoomField;
			}
			set {
				this.zoomField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool ZoomSpecified {
			get {
				return this.zoomFieldSpecified;
			}
			set {
				this.zoomFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public enum MoveStatus {

		/// <remarks/>
		IDLE,

		/// <remarks/>
		MOVING,

		/// <remarks/>
		UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZStatus {

		private PTZVector positionField;

		private PTZMoveStatus moveStatusField;

		private string errorField;

		private System.DateTime utcTimeField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZVector Position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZMoveStatus MoveStatus {
			get {
				return this.moveStatusField;
			}
			set {
				this.moveStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public string Error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public System.DateTime UtcTime {
			get {
				return this.utcTimeField;
			}
			set {
				this.utcTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 4)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZPreset {

		private string nameField;

		private PTZVector pTZPositionField;

		private string tokenField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public PTZVector PTZPosition {
			get {
				return this.pTZPositionField;
			}
			set {
				this.pTZPositionField = value;
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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZConfigurationOptions2 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTControlDirectionOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ReverseOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ReverseOptions {

		private ReverseMode [] modeField;

		private ReverseOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public ReverseMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ReverseOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EFlipOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class EFlipOptions {

		private EFlipMode [] modeField;

		private EFlipOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public EFlipMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public EFlipOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTControlDirectionOptions {

		private EFlipOptions eFlipField;

		private ReverseOptions reverseField;

		private PTControlDirectionOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public EFlipOptions EFlip {
			get {
				return this.eFlipField;
			}
			set {
				this.eFlipField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ReverseOptions Reverse {
			get {
				return this.reverseField;
			}
			set {
				this.reverseField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public PTControlDirectionOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class PTZConfigurationOptions {

		private PTZSpaces spacesField;

		private DurationRange pTZTimeoutField;

		private System.Xml.Linq.XElement [] anyField;

		private PTControlDirectionOptions pTControlDirectionField;

		private PTZConfigurationOptions2 extensionField;

		private int [] pTZRampsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public PTZSpaces Spaces {
			get {
				return this.spacesField;
			}
			set {
				this.spacesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public DurationRange PTZTimeout {
			get {
				return this.pTZTimeoutField;
			}
			set {
				this.pTZTimeoutField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public PTControlDirectionOptions PTControlDirection {
			get {
				return this.pTControlDirectionField;
			}
			set {
				this.pTControlDirectionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public PTZConfigurationOptions2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int [] PTZRamps {
			get {
				return this.pTZRampsField;
			}
			set {
				this.pTZRampsField = value;
			}
		}
	}






	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingStatus20Extension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusStatus20Extension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusStatus20 {

		private float positionField;

		private MoveStatus moveStatusField;

		private string errorField;

		private FocusStatus20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public MoveStatus MoveStatus {
			get {
				return this.moveStatusField;
			}
			set {
				this.moveStatusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public string Error {
			get {
				return this.errorField;
			}
			set {
				this.errorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public FocusStatus20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingStatus20 {

		private FocusStatus20 focusStatus20Field;

		private ImagingStatus20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public FocusStatus20 FocusStatus20 {
			get {
				return this.focusStatus20Field;
			}
			set {
				this.focusStatus20Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ImagingStatus20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ContinuousFocusOptions {

		private FloatRange speedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public FloatRange Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RelativeFocusOptions20 {

		private FloatRange distanceField;

		private FloatRange speedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public FloatRange Distance {
			get {
				return this.distanceField;
			}
			set {
				this.distanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AbsoluteFocusOptions {

		private FloatRange positionField;

		private FloatRange speedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public FloatRange Position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class MoveOptions20 {

		private AbsoluteFocusOptions absoluteField;

		private RelativeFocusOptions20 relativeField;

		private ContinuousFocusOptions continuousField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AbsoluteFocusOptions Absolute {
			get {
				return this.absoluteField;
			}
			set {
				this.absoluteField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public RelativeFocusOptions20 Relative {
			get {
				return this.relativeField;
			}
			set {
				this.relativeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ContinuousFocusOptions Continuous {
			get {
				return this.continuousField;
			}
			set {
				this.continuousField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ContinuousFocus {

		private float speedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class RelativeFocus {

		private float distanceField;

		private float speedField;

		private bool speedFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Distance {
			get {
				return this.distanceField;
			}
			set {
				this.distanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SpeedSpecified {
			get {
				return this.speedFieldSpecified;
			}
			set {
				this.speedFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class AbsoluteFocus {

		private float positionField;

		private float speedField;

		private bool speedFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public float Position {
			get {
				return this.positionField;
			}
			set {
				this.positionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public float Speed {
			get {
				return this.speedField;
			}
			set {
				this.speedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SpeedSpecified {
			get {
				return this.speedFieldSpecified;
			}
			set {
				this.speedFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusMove {

		private AbsoluteFocus absoluteField;

		private RelativeFocus relativeField;

		private ContinuousFocus continuousField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public AbsoluteFocus Absolute {
			get {
				return this.absoluteField;
			}
			set {
				this.absoluteField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public RelativeFocus Relative {
			get {
				return this.relativeField;
			}
			set {
				this.relativeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ContinuousFocus Continuous {
			get {
				return this.continuousField;
			}
			set {
				this.continuousField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingOptions20Extension4 {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class NoiseReductionOptions {

		private bool levelField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public bool Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 1)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class DefoggingOptions {

		private string [] modeField;

		private bool levelField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public string [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ToneCompensationOptions {

		private string [] modeField;

		private bool levelField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public string [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingOptions20Extension3 {

		private ToneCompensationOptions toneCompensationOptionsField;

		private DefoggingOptions defoggingOptionsField;

		private NoiseReductionOptions noiseReductionOptionsField;

		private ImagingOptions20Extension4 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public ToneCompensationOptions ToneCompensationOptions {
			get {
				return this.toneCompensationOptionsField;
			}
			set {
				this.toneCompensationOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public DefoggingOptions DefoggingOptions {
			get {
				return this.defoggingOptionsField;
			}
			set {
				this.defoggingOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public NoiseReductionOptions NoiseReductionOptions {
			get {
				return this.noiseReductionOptionsField;
			}
			set {
				this.noiseReductionOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public ImagingOptions20Extension4 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IrCutFilterAutoAdjustmentOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAnyElementAttribute (Namespace = "http://www.onvif.org/ver10/schema", Order = 0)]
		public System.Xml.Linq.XElement [] Any {
			get {
				return this.anyField;
			}
			set {
				this.anyField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class IrCutFilterAutoAdjustmentOptions {

		private string [] boundaryTypeField;

		private bool boundaryOffsetField;

		private bool boundaryOffsetFieldSpecified;

		private DurationRange responseTimeRangeField;

		private IrCutFilterAutoAdjustmentOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("BoundaryType", Order = 0)]
		public string [] BoundaryType {
			get {
				return this.boundaryTypeField;
			}
			set {
				this.boundaryTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public bool BoundaryOffset {
			get {
				return this.boundaryOffsetField;
			}
			set {
				this.boundaryOffsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool BoundaryOffsetSpecified {
			get {
				return this.boundaryOffsetFieldSpecified;
			}
			set {
				this.boundaryOffsetFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public DurationRange ResponseTimeRange {
			get {
				return this.responseTimeRangeField;
			}
			set {
				this.responseTimeRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public IrCutFilterAutoAdjustmentOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingOptions20Extension2 {

		private IrCutFilterAutoAdjustmentOptions irCutFilterAutoAdjustmentField;

		private ImagingOptions20Extension3 extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public IrCutFilterAutoAdjustmentOptions IrCutFilterAutoAdjustment {
			get {
				return this.irCutFilterAutoAdjustmentField;
			}
			set {
				this.irCutFilterAutoAdjustmentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ImagingOptions20Extension3 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImageStabilizationOptionsExtension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImageStabilizationOptions {

		private ImageStabilizationMode [] modeField;

		private FloatRange levelField;

		private ImageStabilizationOptionsExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public ImageStabilizationMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ImageStabilizationOptionsExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingOptions20Extension {

		private System.Xml.Linq.XElement [] anyField;

		private ImageStabilizationOptions imageStabilizationField;

		private ImagingOptions20Extension2 extensionField;

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
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public ImageStabilizationOptions ImageStabilization {
			get {
				return this.imageStabilizationField;
			}
			set {
				this.imageStabilizationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public ImagingOptions20Extension2 Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WhiteBalanceOptions20Extension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WhiteBalanceOptions20 {

		private WhiteBalanceMode [] modeField;

		private FloatRange yrGainField;

		private FloatRange ybGainField;

		private WhiteBalanceOptions20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public WhiteBalanceMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange YrGain {
			get {
				return this.yrGainField;
			}
			set {
				this.yrGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public FloatRange YbGain {
			get {
				return this.ybGainField;
			}
			set {
				this.ybGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public WhiteBalanceOptions20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class WideDynamicRangeOptions20 {

		private WideDynamicMode [] modeField;

		private FloatRange levelField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public WideDynamicMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusOptions20Extension {

		private System.Xml.Linq.XElement [] anyField;

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
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class FocusOptions20 {

		private AutoFocusMode [] autoFocusModesField;

		private FloatRange defaultSpeedField;

		private FloatRange nearLimitField;

		private FloatRange farLimitField;

		private FocusOptions20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("AutoFocusModes", Order = 0)]
		public AutoFocusMode [] AutoFocusModes {
			get {
				return this.autoFocusModesField;
			}
			set {
				this.autoFocusModesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange DefaultSpeed {
			get {
				return this.defaultSpeedField;
			}
			set {
				this.defaultSpeedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public FloatRange NearLimit {
			get {
				return this.nearLimitField;
			}
			set {
				this.nearLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public FloatRange FarLimit {
			get {
				return this.farLimitField;
			}
			set {
				this.farLimitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public FocusOptions20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ExposureOptions20 {

		private ExposureMode [] modeField;

		private ExposurePriority [] priorityField;

		private FloatRange minExposureTimeField;

		private FloatRange maxExposureTimeField;

		private FloatRange minGainField;

		private FloatRange maxGainField;

		private FloatRange minIrisField;

		private FloatRange maxIrisField;

		private FloatRange exposureTimeField;

		private FloatRange gainField;

		private FloatRange irisField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public ExposureMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Priority", Order = 1)]
		public ExposurePriority [] Priority {
			get {
				return this.priorityField;
			}
			set {
				this.priorityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public FloatRange MinExposureTime {
			get {
				return this.minExposureTimeField;
			}
			set {
				this.minExposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public FloatRange MaxExposureTime {
			get {
				return this.maxExposureTimeField;
			}
			set {
				this.maxExposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public FloatRange MinGain {
			get {
				return this.minGainField;
			}
			set {
				this.minGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public FloatRange MaxGain {
			get {
				return this.maxGainField;
			}
			set {
				this.maxGainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 6)]
		public FloatRange MinIris {
			get {
				return this.minIrisField;
			}
			set {
				this.minIrisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public FloatRange MaxIris {
			get {
				return this.maxIrisField;
			}
			set {
				this.maxIrisField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public FloatRange ExposureTime {
			get {
				return this.exposureTimeField;
			}
			set {
				this.exposureTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public FloatRange Gain {
			get {
				return this.gainField;
			}
			set {
				this.gainField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public FloatRange Iris {
			get {
				return this.irisField;
			}
			set {
				this.irisField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class BacklightCompensationOptions20 {

		private BacklightCompensationMode [] modeField;

		private FloatRange levelField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("Mode", Order = 0)]
		public BacklightCompensationMode [] Mode {
			get {
				return this.modeField;
			}
			set {
				this.modeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Level {
			get {
				return this.levelField;
			}
			set {
				this.levelField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/schema")]
	public partial class ImagingOptions20 {

		private BacklightCompensationOptions20 backlightCompensationField;

		private FloatRange brightnessField;

		private FloatRange colorSaturationField;

		private FloatRange contrastField;

		private ExposureOptions20 exposureField;

		private FocusOptions20 focusField;

		private IrCutFilterMode [] irCutFilterModesField;

		private FloatRange sharpnessField;

		private WideDynamicRangeOptions20 wideDynamicRangeField;

		private WhiteBalanceOptions20 whiteBalanceField;

		private ImagingOptions20Extension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public BacklightCompensationOptions20 BacklightCompensation {
			get {
				return this.backlightCompensationField;
			}
			set {
				this.backlightCompensationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public FloatRange Brightness {
			get {
				return this.brightnessField;
			}
			set {
				this.brightnessField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public FloatRange ColorSaturation {
			get {
				return this.colorSaturationField;
			}
			set {
				this.colorSaturationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public FloatRange Contrast {
			get {
				return this.contrastField;
			}
			set {
				this.contrastField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 4)]
		public ExposureOptions20 Exposure {
			get {
				return this.exposureField;
			}
			set {
				this.exposureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 5)]
		public FocusOptions20 Focus {
			get {
				return this.focusField;
			}
			set {
				this.focusField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute ("IrCutFilterModes", Order = 6)]
		public IrCutFilterMode [] IrCutFilterModes {
			get {
				return this.irCutFilterModesField;
			}
			set {
				this.irCutFilterModesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 7)]
		public FloatRange Sharpness {
			get {
				return this.sharpnessField;
			}
			set {
				this.sharpnessField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 8)]
		public WideDynamicRangeOptions20 WideDynamicRange {
			get {
				return this.wideDynamicRangeField;
			}
			set {
				this.wideDynamicRangeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 9)]
		public WhiteBalanceOptions20 WhiteBalance {
			get {
				return this.whiteBalanceField;
			}
			set {
				this.whiteBalanceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 10)]
		public ImagingOptions20Extension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
			}
		}
	}
}