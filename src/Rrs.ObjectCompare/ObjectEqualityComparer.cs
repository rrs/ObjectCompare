using System.Collections.Generic;

namespace Rrs.ObjectCompare
{
    internal class ObjectEqualityComparer<T> : IEqualityComparer<T>
            where T : class
    {
        public bool Equals(T x, T y)
        {
            return ObjectComparer.AreEqual(x, y);
        }

        public int GetHashCode(T obj)
        {
            return 0;
        }
    }
}
