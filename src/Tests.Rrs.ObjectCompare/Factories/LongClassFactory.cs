using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class LongClassFactory : IObjectFactory<LongClass>
    {
        public LongClass New() =>  new LongClass { LongProperty = long.MinValue };
    }
}
