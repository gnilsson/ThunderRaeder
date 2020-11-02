using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ThunderRaeder.API.Extensions
{
    public static class GenericExtensions
    {
        internal static IEnumerable<U> Test<T, U>(
                                 this IEnumerable<T> items,
                                 Func<T, U> converter)
        {
            foreach (T item in items)
            {
                yield return converter(item);
            }
        }

        public static T CastTo<T>(this object input)
        {
            return (T)input;
        }

        public static T ConvertTo<T>(this object input)
        {
            return (T)Convert.ChangeType(input, typeof(T));
        }

    }
}
