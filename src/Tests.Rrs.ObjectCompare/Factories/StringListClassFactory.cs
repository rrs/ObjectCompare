using System.Collections.Generic;
using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class StringListClassFactory : IObjectFactory<StringListClass>
    {
        public StringListClass New() => new StringListClass
        {
            ListProperty = new List<string> 
            {
                "One",
                "Two",
                "Three",
                "Four"
            }
        };
    }
}
