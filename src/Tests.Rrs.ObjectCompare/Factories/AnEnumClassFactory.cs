using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class AnEnumClassFactory : IObjectFactory<AnEnumClass>
    {
        public AnEnumClass New() => new AnEnumClass { AnEnumProperty = AnEnum.Two };
    }
}
