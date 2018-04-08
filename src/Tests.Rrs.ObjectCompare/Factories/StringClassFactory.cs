using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class StringClassFactory : IObjectFactory<StringClass>
    {
        public StringClass New() =>  new StringClass { StringProperty = "Test" };
    }
}
