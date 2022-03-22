using Onvif.Core.Client.Common;

namespace Onvif.Core.Client.Device {
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class Service {

		private string namespaceField;

		private string xAddrField;

		private System.Xml.Linq.XElement capabilitiesField;

		private OnvifVersion versionField;

		private System.Xml.Linq.XElement [] anyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string Namespace {
			get {
				return this.namespaceField;
			}
			set {
				this.namespaceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 1)]
		public string XAddr {
			get {
				return this.xAddrField;
			}
			set {
				this.xAddrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public System.Xml.Linq.XElement Capabilities {
			get {
				return this.capabilitiesField;
			}
			set {
				this.capabilitiesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public OnvifVersion Version {
			get {
				return this.versionField;
			}
			set {
				this.versionField = value;
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
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class UserCredential {

		private string userNameField;

		private string passwordField;

		private UserCredentialExtension extensionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public string UserName {
			get {
				return this.userNameField;
			}
			set {
				this.userNameField = value;
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
		public UserCredentialExtension Extension {
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
	[System.Xml.Serialization.XmlTypeAttribute (AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class UserCredentialExtension {

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
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class StorageConfigurationData {

		private string localPathField;

		private string storageUriField;

		private UserCredential userField;

		private StorageConfigurationDataExtension extensionField;

		private string typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 0)]
		public string LocalPath {
			get {
				return this.localPathField;
			}
			set {
				this.localPathField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (DataType = "anyURI", Order = 1)]
		public string StorageUri {
			get {
				return this.storageUriField;
			}
			set {
				this.storageUriField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public UserCredential User {
			get {
				return this.userField;
			}
			set {
				this.userField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public StorageConfigurationDataExtension Extension {
			get {
				return this.extensionField;
			}
			set {
				this.extensionField = value;
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class StorageConfigurationDataExtension {

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
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class StorageConfiguration : DeviceEntity {

		private StorageConfigurationData dataField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public StorageConfigurationData Data {
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
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class MiscCapabilities {

		private string [] auxiliaryCommandsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string [] AuxiliaryCommands {
			get {
				return this.auxiliaryCommandsField;
			}
			set {
				this.auxiliaryCommandsField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class SystemCapabilities {

		private bool discoveryResolveField;

		private bool discoveryResolveFieldSpecified;

		private bool discoveryByeField;

		private bool discoveryByeFieldSpecified;

		private bool remoteDiscoveryField;

		private bool remoteDiscoveryFieldSpecified;

		private bool systemBackupField;

		private bool systemBackupFieldSpecified;

		private bool systemLoggingField;

		private bool systemLoggingFieldSpecified;

		private bool firmwareUpgradeField;

		private bool firmwareUpgradeFieldSpecified;

		private bool httpFirmwareUpgradeField;

		private bool httpFirmwareUpgradeFieldSpecified;

		private bool httpSystemBackupField;

		private bool httpSystemBackupFieldSpecified;

		private bool httpSystemLoggingField;

		private bool httpSystemLoggingFieldSpecified;

		private bool httpSupportInformationField;

		private bool httpSupportInformationFieldSpecified;

		private bool storageConfigurationField;

		private bool storageConfigurationFieldSpecified;

		private int maxStorageConfigurationsField;

		private bool maxStorageConfigurationsFieldSpecified;

		private int geoLocationEntriesField;

		private bool geoLocationEntriesFieldSpecified;

		private string [] autoGeoField;

		private string [] storageTypesSupportedField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool DiscoveryResolve {
			get {
				return this.discoveryResolveField;
			}
			set {
				this.discoveryResolveField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DiscoveryResolveSpecified {
			get {
				return this.discoveryResolveFieldSpecified;
			}
			set {
				this.discoveryResolveFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool DiscoveryBye {
			get {
				return this.discoveryByeField;
			}
			set {
				this.discoveryByeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DiscoveryByeSpecified {
			get {
				return this.discoveryByeFieldSpecified;
			}
			set {
				this.discoveryByeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool RemoteDiscovery {
			get {
				return this.remoteDiscoveryField;
			}
			set {
				this.remoteDiscoveryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RemoteDiscoverySpecified {
			get {
				return this.remoteDiscoveryFieldSpecified;
			}
			set {
				this.remoteDiscoveryFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool SystemBackup {
			get {
				return this.systemBackupField;
			}
			set {
				this.systemBackupField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SystemBackupSpecified {
			get {
				return this.systemBackupFieldSpecified;
			}
			set {
				this.systemBackupFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool SystemLogging {
			get {
				return this.systemLoggingField;
			}
			set {
				this.systemLoggingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SystemLoggingSpecified {
			get {
				return this.systemLoggingFieldSpecified;
			}
			set {
				this.systemLoggingFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool FirmwareUpgrade {
			get {
				return this.firmwareUpgradeField;
			}
			set {
				this.firmwareUpgradeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool FirmwareUpgradeSpecified {
			get {
				return this.firmwareUpgradeFieldSpecified;
			}
			set {
				this.firmwareUpgradeFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool StorageConfiguration {
			get {
				return this.storageConfigurationField;
			}
			set {
				this.storageConfigurationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool StorageConfigurationSpecified {
			get {
				return this.storageConfigurationFieldSpecified;
			}
			set {
				this.storageConfigurationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxStorageConfigurations {
			get {
				return this.maxStorageConfigurationsField;
			}
			set {
				this.maxStorageConfigurationsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxStorageConfigurationsSpecified {
			get {
				return this.maxStorageConfigurationsFieldSpecified;
			}
			set {
				this.maxStorageConfigurationsFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int GeoLocationEntries {
			get {
				return this.geoLocationEntriesField;
			}
			set {
				this.geoLocationEntriesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool GeoLocationEntriesSpecified {
			get {
				return this.geoLocationEntriesFieldSpecified;
			}
			set {
				this.geoLocationEntriesFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string [] AutoGeo {
			get {
				return this.autoGeoField;
			}
			set {
				this.autoGeoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public string [] StorageTypesSupported {
			get {
				return this.storageTypesSupportedField;
			}
			set {
				this.storageTypesSupportedField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class SecurityCapabilities {

		private bool tLS10Field;

		private bool tLS10FieldSpecified;

		private bool tLS11Field;

		private bool tLS11FieldSpecified;

		private bool tLS12Field;

		private bool tLS12FieldSpecified;

		private bool onboardKeyGenerationField;

		private bool onboardKeyGenerationFieldSpecified;

		private bool accessPolicyConfigField;

		private bool accessPolicyConfigFieldSpecified;

		private bool defaultAccessPolicyField;

		private bool defaultAccessPolicyFieldSpecified;

		private bool dot1XField;

		private bool dot1XFieldSpecified;

		private bool remoteUserHandlingField;

		private bool remoteUserHandlingFieldSpecified;

		private bool x509TokenField;

		private bool x509TokenFieldSpecified;

		private bool sAMLTokenField;

		private bool sAMLTokenFieldSpecified;

		private bool kerberosTokenField;

		private bool kerberosTokenFieldSpecified;

		private bool usernameTokenField;

		private bool usernameTokenFieldSpecified;

		private bool httpDigestField;

		private bool httpDigestFieldSpecified;

		private bool rELTokenField;

		private bool rELTokenFieldSpecified;

		private int [] supportedEAPMethodsField;

		private int maxUsersField;

		private bool maxUsersFieldSpecified;

		private int maxUserNameLengthField;

		private bool maxUserNameLengthFieldSpecified;

		private int maxPasswordLengthField;

		private bool maxPasswordLengthFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ("TLS1.0")]
		public bool TLS10 {
			get {
				return this.tLS10Field;
			}
			set {
				this.tLS10Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool TLS10Specified {
			get {
				return this.tLS10FieldSpecified;
			}
			set {
				this.tLS10FieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ("TLS1.1")]
		public bool TLS11 {
			get {
				return this.tLS11Field;
			}
			set {
				this.tLS11Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool TLS11Specified {
			get {
				return this.tLS11FieldSpecified;
			}
			set {
				this.tLS11FieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ("TLS1.2")]
		public bool TLS12 {
			get {
				return this.tLS12Field;
			}
			set {
				this.tLS12Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool TLS12Specified {
			get {
				return this.tLS12FieldSpecified;
			}
			set {
				this.tLS12FieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool OnboardKeyGeneration {
			get {
				return this.onboardKeyGenerationField;
			}
			set {
				this.onboardKeyGenerationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool OnboardKeyGenerationSpecified {
			get {
				return this.onboardKeyGenerationFieldSpecified;
			}
			set {
				this.onboardKeyGenerationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool AccessPolicyConfig {
			get {
				return this.accessPolicyConfigField;
			}
			set {
				this.accessPolicyConfigField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool AccessPolicyConfigSpecified {
			get {
				return this.accessPolicyConfigFieldSpecified;
			}
			set {
				this.accessPolicyConfigFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool DefaultAccessPolicy {
			get {
				return this.defaultAccessPolicyField;
			}
			set {
				this.defaultAccessPolicyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DefaultAccessPolicySpecified {
			get {
				return this.defaultAccessPolicyFieldSpecified;
			}
			set {
				this.defaultAccessPolicyFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool Dot1X {
			get {
				return this.dot1XField;
			}
			set {
				this.dot1XField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool Dot1XSpecified {
			get {
				return this.dot1XFieldSpecified;
			}
			set {
				this.dot1XFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool RemoteUserHandling {
			get {
				return this.remoteUserHandlingField;
			}
			set {
				this.remoteUserHandlingField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RemoteUserHandlingSpecified {
			get {
				return this.remoteUserHandlingFieldSpecified;
			}
			set {
				this.remoteUserHandlingFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ("X.509Token")]
		public bool X509Token {
			get {
				return this.x509TokenField;
			}
			set {
				this.x509TokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool X509TokenSpecified {
			get {
				return this.x509TokenFieldSpecified;
			}
			set {
				this.x509TokenFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool SAMLToken {
			get {
				return this.sAMLTokenField;
			}
			set {
				this.sAMLTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool SAMLTokenSpecified {
			get {
				return this.sAMLTokenFieldSpecified;
			}
			set {
				this.sAMLTokenFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool KerberosToken {
			get {
				return this.kerberosTokenField;
			}
			set {
				this.kerberosTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool KerberosTokenSpecified {
			get {
				return this.kerberosTokenFieldSpecified;
			}
			set {
				this.kerberosTokenFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool UsernameToken {
			get {
				return this.usernameTokenField;
			}
			set {
				this.usernameTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool UsernameTokenSpecified {
			get {
				return this.usernameTokenFieldSpecified;
			}
			set {
				this.usernameTokenFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool HttpDigest {
			get {
				return this.httpDigestField;
			}
			set {
				this.httpDigestField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HttpDigestSpecified {
			get {
				return this.httpDigestFieldSpecified;
			}
			set {
				this.httpDigestFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool RELToken {
			get {
				return this.rELTokenField;
			}
			set {
				this.rELTokenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool RELTokenSpecified {
			get {
				return this.rELTokenFieldSpecified;
			}
			set {
				this.rELTokenFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int [] SupportedEAPMethods {
			get {
				return this.supportedEAPMethodsField;
			}
			set {
				this.supportedEAPMethodsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxUsers {
			get {
				return this.maxUsersField;
			}
			set {
				this.maxUsersField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxUsersSpecified {
			get {
				return this.maxUsersFieldSpecified;
			}
			set {
				this.maxUsersFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxUserNameLength {
			get {
				return this.maxUserNameLengthField;
			}
			set {
				this.maxUserNameLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxUserNameLengthSpecified {
			get {
				return this.maxUserNameLengthFieldSpecified;
			}
			set {
				this.maxUserNameLengthFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int MaxPasswordLength {
			get {
				return this.maxPasswordLengthField;
			}
			set {
				this.maxPasswordLengthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool MaxPasswordLengthSpecified {
			get {
				return this.maxPasswordLengthFieldSpecified;
			}
			set {
				this.maxPasswordLengthFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class NetworkCapabilities {

		private bool iPFilterField;

		private bool iPFilterFieldSpecified;

		private bool zeroConfigurationField;

		private bool zeroConfigurationFieldSpecified;

		private bool iPVersion6Field;

		private bool iPVersion6FieldSpecified;

		private bool dynDNSField;

		private bool dynDNSFieldSpecified;

		private bool dot11ConfigurationField;

		private bool dot11ConfigurationFieldSpecified;

		private int dot1XConfigurationsField;

		private bool dot1XConfigurationsFieldSpecified;

		private bool hostnameFromDHCPField;

		private bool hostnameFromDHCPFieldSpecified;

		private int nTPField;

		private bool nTPFieldSpecified;

		private bool dHCPv6Field;

		private bool dHCPv6FieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
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
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int Dot1XConfigurations {
			get {
				return this.dot1XConfigurationsField;
			}
			set {
				this.dot1XConfigurationsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool Dot1XConfigurationsSpecified {
			get {
				return this.dot1XConfigurationsFieldSpecified;
			}
			set {
				this.dot1XConfigurationsFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool HostnameFromDHCP {
			get {
				return this.hostnameFromDHCPField;
			}
			set {
				this.hostnameFromDHCPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool HostnameFromDHCPSpecified {
			get {
				return this.hostnameFromDHCPFieldSpecified;
			}
			set {
				this.hostnameFromDHCPFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public int NTP {
			get {
				return this.nTPField;
			}
			set {
				this.nTPField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool NTPSpecified {
			get {
				return this.nTPFieldSpecified;
			}
			set {
				this.nTPFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute ()]
		public bool DHCPv6 {
			get {
				return this.dHCPv6Field;
			}
			set {
				this.dHCPv6Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute ()]
		public bool DHCPv6Specified {
			get {
				return this.dHCPv6FieldSpecified;
			}
			set {
				this.dHCPv6FieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class DeviceServiceCapabilities {

		private NetworkCapabilities networkField;

		private SecurityCapabilities securityField;

		private SystemCapabilities systemField;

		private MiscCapabilities miscField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 0)]
		public NetworkCapabilities Network {
			get {
				return this.networkField;
			}
			set {
				this.networkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 1)]
		public SecurityCapabilities Security {
			get {
				return this.securityField;
			}
			set {
				this.securityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 2)]
		public SystemCapabilities System {
			get {
				return this.systemField;
			}
			set {
				this.systemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute (Order = 3)]
		public MiscCapabilities Misc {
			get {
				return this.miscField;
			}
			set {
				this.miscField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute ("dotnet-svcutil", "1.0.3")]
	[System.Diagnostics.DebuggerStepThroughAttribute ()]
	[System.Xml.Serialization.XmlTypeAttribute (AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
	public partial class GetSystemUrisResponseExtension {

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
}