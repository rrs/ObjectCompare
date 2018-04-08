using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ByteClassFactory : IObjectFactory<ByteClass>
    {
        public ByteClass New() =>  new ByteClass { ByteProperty = byte.MaxValue };
    }
}
