namespace Rrs.ObjectCompare
{
    public static class ObjectExtensions
    {
        public static bool IsEqualTo<T>(this T left, T right) where T : class
        {
            return ObjectComparer.AreEqual(left, right);
        }

        public static bool IsNotEqualTo<T>(this T left, T right) where T : class
        {
            return !ObjectComparer.AreEqual(left, right);
        }
    }
}
