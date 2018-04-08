using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class DoubleClassFactory : IObjectFactory<DoubleClass>
    {
        public DoubleClass New() =>  new DoubleClass { DoubleProperty = double.MaxValue };
    }
}
