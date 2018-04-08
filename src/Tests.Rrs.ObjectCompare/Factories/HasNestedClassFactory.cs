using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class HasNestedClassFactory : IObjectFactory<HasNestedClass>
    {
        public HasNestedClass New() =>  new HasNestedClass { NestedClassProperty = new ValueClassFactory().New() };
    }
}
