using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Onvif.Core.Discovery.Models
{
    public class DiscoveryDevice : IEquatable<DiscoveryDevice>
    {
        public IEnumerable<string> Types { get; internal set; }
        public IEnumerable<string> XAdresses { get; internal set; }
        public string Model { get; internal set; }
        public string Name { get; internal set; }
        public IPAddress Address { get; internal set; }

        public override bool Equals(object obj)
        {
            return obj is DiscoveryDevice o &&
                    Equals(o);
        }

        public bool Equals(DiscoveryDevice other)
        {
            if (other == null ||
                Model != other.Model ||
                Name != other.Name)
            {
                return false;
            }

            if (Address == null)
            {
                if (other.Address != null)
                {
                    return false;
                }
            }
            else if (!Address.Equals(other.Address))
            {
                return false;
            }

            return SequenceEqualCore(Types, other.Types) &&
                   SequenceEqualCore(XAdresses, other.XAdresses);
        }

        public override int GetHashCode()
        {
            const int FnvOffsetBias = unchecked((int)2166136261);

            int hash = FnvOffsetBias;

            CombineListHash(ref hash, Types);
            CombineListHash(ref hash, XAdresses);

            if (Model != null)
            {
                CombineHashCode(ref hash, Model.GetHashCode());
            }

            if (Name != null)
            {
                CombineHashCode(ref hash, Name.GetHashCode());
            }

            if (Address != null)
            {
                CombineHashCode(ref hash, Address.GetHashCode());
            }

            return hash;
        }

        private static bool SequenceEqualCore(IEnumerable<string> self, IEnumerable<string> other)
        {
            if (self == null)
            {
                return other == null;
            }
            else if (other == null)
            {
                return false;
            }
            return self.SequenceEqual(other);
        }

        private static void CombineListHash(ref int hash, IEnumerable<string> list)
        {
            if (list != null)
            {
                foreach (string item in list)
                {
                    CombineHashCode(ref hash, item.GetHashCode());
                }
            }
        }

        private static void CombineHashCode(ref int hash, int hashcode)
        {
            const int FnvPrime = 16777619;

            unsafe
            {
                byte* tempPtr = (byte*)&hashcode;
                hash = unchecked((hash ^ tempPtr[0]) * FnvPrime);
                hash = unchecked((hash ^ tempPtr[1]) * FnvPrime);
                hash = unchecked((hash ^ tempPtr[2]) * FnvPrime);
                hash = unchecked((hash ^ tempPtr[3]) * FnvPrime);
            }
        }

    }
}
