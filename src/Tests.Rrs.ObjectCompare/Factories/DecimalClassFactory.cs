using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class DecimalClassFactory : IObjectFactory<DecimalClass>
    {
        public DecimalClass New() => new DecimalClass { DecimalProperty = decimal.MaxValue };
    }
}
