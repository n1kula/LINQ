using System;
using System.Collections.Generic;

namespace BasicQueries
{
    public static class MyLinq
    {
        public static IEnumerable<T> MyFilter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in source)
            {
                if (predicate(item)) result.Add(item);
            }

            return result;
        }

        public static IEnumerable<T> MyFilterLikeWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                yield return item;
            }
        }
    }
}
