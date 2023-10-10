using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ValueArrayClassFactory : IObjectFactory<ValueArrayClass>
    {
        public ValueArrayClass New() => new ValueArrayClass
        {
            ArrayProperty = new [] 
            {
                1,
                2,
                3,
                4
            }
        };
    }
}
