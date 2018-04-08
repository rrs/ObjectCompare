using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class AStructClassFactory : IObjectFactory<AStructClass>
    {
        public AStructClass New() => new AStructClass { AStructProperty = new AStruct(int.MinValue, int.MaxValue) };
    }
}
