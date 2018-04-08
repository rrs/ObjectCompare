using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ShortClassFactory : IObjectFactory<ShortClass>
    {
        public ShortClass New() =>  new ShortClass { ShortProperty = short.MinValue };
    }
}
