using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ComparableIntEnumerableClassFactory : IObjectFactory<ComparableIntEnumerableClass>
    {
        public ComparableIntEnumerableClass New() => new ComparableIntEnumerableClass
        {
            EnumerableProperty = new[]
            {
                new ComparableIntClass{ IntProperty = 1},
                new ComparableIntClass{ IntProperty = 2},
                new ComparableIntClass{ IntProperty = 3},
                new ComparableIntClass{ IntProperty = 4},
            }
        };
    }
}
