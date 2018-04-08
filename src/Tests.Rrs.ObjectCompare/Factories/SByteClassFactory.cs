using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class SByteClassFactory : IObjectFactory<SByteClass>
    {
        public SByteClass New() =>  new SByteClass { SByteProperty = sbyte.MinValue };
    }
}
