using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ValueEnumerableClassFactory : IObjectFactory<ValueEnumerableClass>
    {
        public ValueEnumerableClass New() => new ValueEnumerableClass
        {
            EnumerableProperty = new [] 
            {
                1,
                2,
                3,
                4
            }
        };
    }
}
