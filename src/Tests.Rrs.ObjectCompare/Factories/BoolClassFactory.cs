using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class BoolClassFactory : IObjectFactory<BoolClass>
    {
        public BoolClass New() =>  new BoolClass { BoolProperty = true };
    }
}
