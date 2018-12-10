using Rrs.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Rrs.ObjectCompare
{
    public static class ObjectComparer
    {
        public static bool AreEqual<T>(T first, T second)
        {
            if (first == null) return second == null;
            if (second == null) return false;
            if (ReferenceEquals(first, second)) return true;
            return new ObjectComparer<T>().AreEqual(first, second);
        }
    }

    public class ObjectComparer<T>
    {
        private static readonly Func<T, T, bool> _compareFunc;

        static ObjectComparer()
        {
            var exps = new List<Expression>();

            var first = Expression.Parameter(typeof(T), "first");
            var second = Expression.Parameter(typeof(T), "second");

            var areEqual = Expression.Variable(typeof(bool), "areEqual");

            exps.Add(Expression.Assign(areEqual, Expression.Constant(true)));

            if (typeof(T).IsValueType || typeof(T) == typeof(string))
            {
                var equals = Expression.Equal(first, second);

                exps.Add(Expression.AndAssign(areEqual, equals));
            }
            else
            {
                var props = typeof(T).GetFlattenedProperties(BindingFlags.Instance | BindingFlags.Public);

                foreach (var prop in props)
                {
                    var firstProp = Expression.Property(first, prop);
                    var secondProp = Expression.Property(second, prop);

                    // basic built in types
                    if (prop.PropertyType.IsValueType || prop.PropertyType == typeof(string))
                    {
                        var equals = Expression.Equal(secondProp, firstProp);

                        exps.Add(Expression.AndAssign(areEqual, equals));
                    }
                    // enumerables
                    else if (typeof(IEnumerable).IsAssignableFrom(prop.PropertyType))
                    {
                        var genericType = prop.PropertyType.GetEnumerableItemType();

                        // dont't handle IEnumerable
                        if (genericType == null)
                        {
                            exps.Add(Expression.AndAssign(areEqual, Expression.Constant(false)));
                            continue;
                        }

                        string sequenceEqualName;
                        Type[] genericTypes = null;
                        // value type enumerables
                        if (genericType.IsValueType || genericType == typeof(string))
                        {
                            if (genericType.IsConcreteImplementation(typeof(KeyValuePair<,>)))
                            {
                                sequenceEqualName = nameof(Sequences.KeyValuePairSequenceEqual);
                                genericTypes = genericType.GetGenericArguments();
                            }
                            else
                            {
                                sequenceEqualName = nameof(Sequences.ValueSequenceEqual);
                                genericTypes = new[] { genericType };
                            }
                        }
                        else
                        {
                            sequenceEqualName = nameof(Sequences.ObjectSequenceEqual);
                            genericTypes = new[] { genericType };
                        }

                        var method = typeof(Sequences).GetMethod(sequenceEqualName);
                        var genericMethod = method.MakeGenericMethod(genericTypes);
                        var equals = Expression.Call(genericMethod, secondProp, firstProp);

                        exps.Add(Expression.AndAssign(areEqual, equals));
                    }
                    // anything else i.e. 'normal' objects
                    else
                    {
                        var method = typeof(ObjectComparer).GetMethod(nameof(ObjectComparer.AreEqual));
                        var genericMethod = method.MakeGenericMethod(prop.PropertyType);
                        var equals = Expression.Call(genericMethod, secondProp, firstProp);

                        exps.Add(Expression.AndAssign(areEqual, equals));
                    }
                }
            }


            _compareFunc = Expression.Lambda<Func<T, T, bool>>(Expression.Block(new[] { areEqual }, exps), new[] { first, second }).Compile();
        }

        public bool AreEqual(T first, T second)
        {
            return _compareFunc.Invoke(first, second);
        }
    }
}
