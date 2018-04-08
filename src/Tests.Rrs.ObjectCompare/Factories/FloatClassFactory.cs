using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class FloatClassFactory : IObjectFactory<FloatClass>
    {
        public FloatClass New() =>  new FloatClass { FloatProperty = float.MaxValue };
    }
}
