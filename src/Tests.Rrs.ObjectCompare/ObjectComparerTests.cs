using Rrs.ObjectCompare;
using Rrs.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tests.Rrs.ObjectCompare.Classes;
using Tests.Rrs.ObjectCompare.Factories;
using Xunit;

namespace Tests.Rrs.ObjectCompare
{
    public class ObjectComparerTests
    {
        [Fact]
        public void AnEnumClassEquals() => TestEqual<AnEnumClass>();

        [Fact]
        public void AnEnumClassNotEquals() => TestNotEqual<AnEnumClass>();

        [Fact]
        public void AStructClassEquals() => TestEqual<AStructClass>();

        [Fact]
        public void AStructClassNotEquals() => TestNotEqual<AStructClass>();

        [Fact]
        public void BoolClassEquals() => TestEqual<BoolClass>();

        [Fact]
        public void BoolClassNotEquals() => TestNotEqual<BoolClass>();

        [Fact]
        public void ByteClassEquals() => TestEqual<ByteClass>();

        [Fact]
        public void ByteClassNotEquals() => TestNotEqual<ByteClass>();

        [Fact]
        public void CharClassEquals() => TestEqual<CharClass>();

        [Fact]
        public void CharClassNotEquals() => TestNotEqual<CharClass>();

        [Fact]
        public void DecimalClassEquals() => TestEqual<DecimalClass>();

        [Fact]
        public void DecimalClassNotEquals() => TestNotEqual<DecimalClass>();

        [Fact]
        public void DoubleClassEquals() => TestEqual<DoubleClass>();

        [Fact]
        public void DoubleClassNotEquals() => TestNotEqual<DoubleClass>();

        [Fact]
        public void FloatClassEquals() => TestEqual<FloatClass>();

        [Fact]
        public void FloatClassNotEquals() => TestNotEqual<FloatClass>();

        [Fact]
        public void IntClassEquals() => TestEqual<IntClass>();

        [Fact]
        public void IntClassNotEquals() => TestNotEqual<IntClass>();

        [Fact]
        public void LongClassEquals() => TestEqual<LongClass>();

        [Fact]
        public void LongClassNotEquals() => TestNotEqual<LongClass>();

        [Fact]
        public void SByteClassEquals() => TestEqual<SByteClass>();

        [Fact]
        public void SByteClassNotEquals() => TestNotEqual<SByteClass>();

        [Fact]
        public void ShortClassEquals() => TestEqual<ShortClass>();

        [Fact]
        public void ShortClassNotEquals() => TestNotEqual<ShortClass>();

        [Fact]
        public void UIntClassEquals() => TestEqual<UIntClass>();

        [Fact]
        public void UIntClassNotEquals() => TestNotEqual<UIntClass>();

        [Fact]
        public void ULongClassEquals() => TestEqual<ULongClass>();

        [Fact]
        public void ULongClassNotEquals() => TestNotEqual<ULongClass>();

        [Fact]
        public void UShortClassEquals() => TestEqual<UShortClass>();

        [Fact]
        public void UShortClassNotEquals() => TestNotEqual<UShortClass>();

        [Fact]
        public void StringClassEquals() => TestEqual<StringClass>();

        [Fact]
        public void StringClassNotEquals() => TestNotEqual<StringClass>();

        [Fact]
        public void ValueClassEquals() => TestEqual<ValueClass>();

        [Fact]
        public void ValueClassNotEquals() => TestNotEqual<ValueClass>();

        [Fact]
        public void NullableValueClassEquals() => TestEqual<NullableValueClass>();

        [Fact]
        public void NullableValueClassNotEquals() => TestNotEqual<NullableValueClass>();

        [Fact]
        public void HasNestedClassEquals() => TestEqual<HasNestedClass>();

        [Fact]
        public void HasNestedClassNotEquals() => TestNotEqual<HasNestedClass>();

        [Fact]
        public void ValueArrayClassEquals() => TestEqual<ValueArrayClass>();

        [Fact]
        public void ValueArrayClassNotEquals() => TestNotEqual<ValueArrayClass>();

        [Fact]
        public void ValueEnumerableClassEquals() => TestEqual<ValueEnumerableClass>();

        [Fact]
        public void ValueEnumerableClassNotEquals() => TestNotEqual<ValueEnumerableClass>();

        [Fact]
        public void StringListClassEquals() => TestEqual<StringListClass>();

        [Fact]
        public void StringListClassNotEquals() => TestNotEqual<StringListClass>();

        [Fact]
        public void ObjectEnumerableClassEquals() => TestEqual<ObjectEnumerableClass>();

        [Fact]
        public void ObjectEnumerableClassNotEquals() => TestNotEqual<ObjectEnumerableClass>();

        [Fact]
        public void ComparableIntEnumerableClassEquals() => TestEqual<ComparableIntEnumerableClass>();

        [Fact]
        public void ComparableIntEnumerableClassNotEquals() => TestNotEqual<ComparableIntEnumerableClass>();

        [Fact]
        public void ValueDictionaryClassEquals() => TestEqual<ValueDictionaryClass>();

        [Fact]
        public void ValueDictionaryClassNotEquals() => TestNotEqual<ValueDictionaryClass>();

        [Fact]
        public void ObjectDictionaryClassEquals() => TestEqual<ObjectDictionaryClass>();

        [Fact]
        public void ObjectDictionaryClassNotEquals() => TestNotEqual<ObjectDictionaryClass>();

        [Fact]
        public void ObjectReferenceEquals()
        {
            var nested = new ValueClassFactory().New();
            var a = new HasNestedClass { NestedClassProperty = nested };
            var b = new HasNestedClass { NestedClassProperty = nested };

            var areEqual = ObjectComparer.AreEqual(a, b);

            Assert.True(areEqual);
        }

        [Fact]
        public void ValueSequenceDifferentOrder()
        {
            var values = new List<int> { 1, 2, 3, 4 };
            var reversedValues = new List<int> { 4, 3, 2, 1 };

            var a = new ValueEnumerableClass { EnumerableProperty = values };
            var b = new ValueEnumerableClass { EnumerableProperty = reversedValues };

            var areEqual = ObjectComparer.AreEqual(a, b);

            Assert.False(areEqual);
        }

        [Fact]
        public void ComparableIntEnumerableClassDifferentOrder()
        {
            var values = new List<ComparableIntClass>
            {
                new ComparableIntClass{ IntProperty = 1},
                new ComparableIntClass{ IntProperty = 2},
                new ComparableIntClass{ IntProperty = 3},
                new ComparableIntClass{ IntProperty = 4},
            };

            var reversedValues = new List<ComparableIntClass>
            {
                new ComparableIntClass{ IntProperty = 4},
                new ComparableIntClass{ IntProperty = 3},
                new ComparableIntClass{ IntProperty = 2},
                new ComparableIntClass{ IntProperty = 1},
            };

            var a = new ComparableIntEnumerableClass { EnumerableProperty = values };
            var b = new ComparableIntEnumerableClass { EnumerableProperty = reversedValues };

            var areEqual = ObjectComparer.AreEqual(a, b);

            Assert.True(areEqual);
        }

        [Fact]
        public void IsNotEqualToExtension()
        {
            var a = new ValueClassFactory().New();
            var b = new ValueClass();

            var areEqual = a.IsEqualTo(b);

            Assert.False(areEqual);
        }


        [Fact]
        public void IsEqualToExtension()
        {
            var a = new ValueClassFactory().New();
            var b = new ValueClassFactory().New();

            var areEqual = a.IsEqualTo(b);

            Assert.True(areEqual);
        }

        private void TestEqual<T>() where T : class
        {
            var factory = FindFactory<T>();

            var a = factory.New();
            var b = factory.New();

            var areEqual = ObjectComparer.AreEqual(a, b);

            Assert.True(areEqual);
        }

        private void TestNotEqual<T>() where T : class, new()
        {
            var factory = FindFactory<T>();

            var a = factory.New();
            var b = new T();

            var areEqual = ObjectComparer.AreEqual(a, b);

            Assert.False(areEqual);
        }

        private IObjectFactory<T> FindFactory<T>()
        {
            var factoryType = Assembly.GetExecutingAssembly().GetTypes().Single(t => t.ImplementsInterfaceWithGenericTypeOf(typeof(IObjectFactory<>), typeof(T)));

            var factory = (IObjectFactory<T>)Activator.CreateInstance(factoryType);

            return factory;
        }
    }
}
