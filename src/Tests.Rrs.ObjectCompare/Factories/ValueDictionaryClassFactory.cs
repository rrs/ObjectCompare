using System.Collections.Generic;
using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ValueDictionaryClassFactory : IObjectFactory<ValueDictionaryClass>
    {
        public ValueDictionaryClass New() => new ValueDictionaryClass
        {
            DictionaryProperty = new Dictionary<int,int>
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 7, 7 },
                { 56, 56 },
                { 0, 0 }
            }
        };
    }
}
