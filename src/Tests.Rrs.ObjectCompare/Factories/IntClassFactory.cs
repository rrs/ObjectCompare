using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class IntClassFactory : IObjectFactory<IntClass>
    {
        public IntClass New() =>  new IntClass { IntProperty = int.MinValue };
    }
}
