using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Onvif.Core.Internals
{
    internal ref struct Fnv1aImpl
    {
        private const uint fnv_prime = 0x01000193;
        private const uint fnv_offset_basis = 0x01000193;

        private uint _hash;
        public Fnv1aImpl()
        {
            _hash = fnv_offset_basis;
        }

        public readonly int Hash => (int)_hash;

        public Fnv1aImpl AppendObj<T>(in T obj)
        {
            return obj == null
             ? this
             : Append(obj.GetHashCode());
        }

        public Fnv1aImpl AppendObjs<T>(IEnumerable<T> obj)
        {
            if (obj == null)
            {
                return this;
            }
            foreach (T item in obj)
            {
                if (item != null)
                {
                    Append(item.GetHashCode());
                }
            }
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Fnv1aImpl Append<T>(T data)
            where T : unmanaged
        {
            unsafe
            {
                int size = sizeof(T);
                byte* p = (byte*)&data;
                while (size > 0)
                {
                    --size;
                    _hash ^= p[size];
                    _hash *= fnv_prime;
                }
                return this;
            }
        }
    }
}
