using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ULongClassFactory : IObjectFactory<ULongClass>
    {
        public ULongClass New() =>  new ULongClass { ULongProperty = ulong.MaxValue };
    }
}
