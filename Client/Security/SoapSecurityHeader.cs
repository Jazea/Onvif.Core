using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;

namespace Onvif.Core.Client.Security
{
    public class SoapSecurityHeader : MessageHeader
    {
        const string ns_wsu = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
        readonly string username;
        readonly string password;
        readonly TimeSpan time_shift;

        public override string Name { get; } = "Security";
        public override string Namespace { get; } = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

        public SoapSecurityHeader(string username, string password, TimeSpan timeShift)
        {
            this.username = username;
            this.password = password;
            time_shift = timeShift;
        }

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            var nonce = GetNonce();
            var created = DateTime.UtcNow.Add(time_shift).ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            var nonce_str = Convert.ToBase64String(nonce);
            string password_hash = PasswordDigest(nonce, created, password);

            writer.WriteStartElement("UsernameToken");

            writer.WriteStartElement("Username");
            writer.WriteValue(username);
            writer.WriteEndElement();

            writer.WriteStartElement("Password");
            writer.WriteAttributeString("Type", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordDigest");
            writer.WriteValue(password_hash);
            writer.WriteEndElement();

            writer.WriteStartElement("Nonce");
            writer.WriteAttributeString("EncodingType", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary");
            writer.WriteValue(nonce_str);
            writer.WriteEndElement();

            writer.WriteStartElement("Created");
            writer.WriteXmlnsAttribute("", ns_wsu);
            writer.WriteValue(created);
            writer.WriteEndElement();

            writer.WriteEndElement();
        }

        protected override void OnWriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteStartElement("", Name, Namespace);
            writer.WriteAttributeString("s", "mustUnderstand", "http://www.w3.org/2003/05/soap-envelope", "1");
            writer.WriteXmlnsAttribute("", Namespace);
        }

        string PasswordDigest(byte[] nonce, string created, string secret)
        {
            string str = created + secret;
            int nonceLength = nonce.Length;
            int strLength = str.Length;

            byte[] buffer = ArrayPool<byte>.Shared.Rent((nonceLength + strLength) << 1);

            unsafe
            {
                fixed (byte* noncePtr = nonce,
                             bufferPtr = buffer)
                {
                    Unsafe.CopyBlock(bufferPtr, noncePtr, (uint)nonceLength);
                }
            }

            try
            {
                int strBytesLength = Encoding.ASCII.GetBytes(str, 0, strLength, buffer, nonceLength);
                using (SHA1 sha1 = SHA1.Create())
                {
                    return Convert.ToBase64String(sha1.ComputeHash(buffer, 0, nonceLength + strBytesLength));
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }

        byte[] GetNonce()
        {
            byte[] nonce = new byte[0x10];
            using (var generator = new RNGCryptoServiceProvider())
            {
                generator.GetBytes(nonce);
                return nonce;
            }
        }
    }
}