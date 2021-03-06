﻿using Tests.Rrs.ObjectCompare.Classes;

namespace Tests.Rrs.ObjectCompare.Factories
{
    class ValueClassFactory : IObjectFactory<ValueClass>
    {
        public ValueClass New() => new ValueClass
        {
            BoolProperty = true,
            CharProperty = 'A',
            SByteProperty = sbyte.MinValue,
            ShortProperty = short.MinValue,
            IntProperty = int.MinValue,
            LongProperty = long.MinValue,
            ByteProperty = byte.MaxValue,
            UShortProperty = ushort.MaxValue,
            UIntProperty = uint.MaxValue,
            ULongProperty = ulong.MaxValue,
            FloatProperty = float.MaxValue,
            DoubleProperty = double.MaxValue,
            DecimalProperty = decimal.MaxValue,
            AnEnumProperty = AnEnum.Two,
            AStructProperty = new AStruct(int.MinValue, int.MaxValue)
        };
    }
}
