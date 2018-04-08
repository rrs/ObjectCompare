using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class CharClassFactory : IObjectFactory<CharClass>
    {
        public CharClass New() => new CharClass { CharProperty = 'A' };
    }
}
