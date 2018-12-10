using System;
using System.Collections.Generic;
using System.Linq;

namespace Rrs.ObjectCompare
{
    internal static class Sequences
    {
        public static bool ValueSequenceEqual<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            if (first == null) return second == null;
            if (second == null) return false;
            if (ReferenceEquals(first, second)) return true;

            return Enumerable.SequenceEqual(first, second);
        }

        public static bool ObjectSequenceEqual<T>(IEnumerable<T> first, IEnumerable<T> second)
            where T : class
        {
            if (first == null) return second == null;
            if (second == null) return false;
            if (ReferenceEquals(first, second)) return true;

            if (typeof(IComparable).IsAssignableFrom(typeof(T)) || typeof(IComparable<T>).IsAssignableFrom(typeof(T)))
            {
                first = first.OrderBy(o => o);
                second = second.OrderBy(o => o);
            }

            return Enumerable.SequenceEqual(first, second, new ObjectEqualityComparer<T>());
        }

        public static bool KeyValuePairSequenceEqual<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> first, IEnumerable<KeyValuePair<TKey, TValue>> second)
        {
            if (first == null) return second == null;
            if (second == null) return false;
            if (ReferenceEquals(first, second)) return true;

            return Enumerable.SequenceEqual(first, second, new KeyValuePairEqualityComparer<TKey, TValue>());
        }
    }
}
