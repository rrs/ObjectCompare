using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class UIntClassFactory : IObjectFactory<UIntClass>
    {
        public UIntClass New() =>  new UIntClass { UIntProperty = uint.MaxValue };
    }
}
