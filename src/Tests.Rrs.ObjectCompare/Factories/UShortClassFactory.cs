using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class UShortClassFactory : IObjectFactory<UShortClass>
    {
        public UShortClass New() =>  new UShortClass { UShortProperty = ushort.MaxValue };
    }
}
