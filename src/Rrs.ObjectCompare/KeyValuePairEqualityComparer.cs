using System.Collections.Generic;

namespace Rrs.ObjectCompare
{
    class KeyValuePairEqualityComparer<TKey, TValue> : IEqualityComparer<KeyValuePair<TKey, TValue>>
    {
        public bool Equals(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
        {
            return ObjectComparer.AreEqual(x.Key, y.Key) && ObjectComparer.AreEqual(x.Value, y.Value);
        }

        public int GetHashCode(KeyValuePair<TKey, TValue> obj)
        {
            return 0;
        }
    }
}
