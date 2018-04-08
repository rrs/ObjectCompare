using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ObjectEnumerableClassFactory : IObjectFactory<ObjectEnumerableClass>
    {
        public ObjectEnumerableClass New() => new ObjectEnumerableClass
        {
            EnumerableProperty = new[]
            {
                new IntClass{ IntProperty = 1},
                new IntClass{ IntProperty = 2},
                new IntClass{ IntProperty = 3},
                new IntClass{ IntProperty = 4},
            }
        };
    }
}
