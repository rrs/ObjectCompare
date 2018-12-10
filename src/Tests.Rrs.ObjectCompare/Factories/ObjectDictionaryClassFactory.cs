using System.Collections.Generic;
using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ObjectDictionaryClassFactory : IObjectFactory<ObjectDictionaryClass>
    {
        public ObjectDictionaryClass New() => new ObjectDictionaryClass
        {
            DictionaryProperty = new Dictionary<int, IntClass>
            {
                { 1, new IntClass{ IntProperty = 1} },
                { 2, new IntClass{ IntProperty = 2} },
                { 3, new IntClass{ IntProperty = 3} },
                { 4, new IntClass{ IntProperty = 4} },
                { 7, new IntClass{ IntProperty = 7} },
                { 56, new IntClass{ IntProperty = 56} },
                { 0, new IntClass{ IntProperty = 0} }
            }
        };
    }
}
