﻿using System;
using System.Collections.Generic;

namespace MyLinq
{
    public static class IEnumerableExtransions
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Predicate<TSource> criterion)
        {
            if (source == null)
                throw new InvalidOperationException();

            var result = new List<TSource>();

            foreach (var item in source)
            {
                if (criterion?.Invoke(item) == true)
                    result.Add(item);
            }
            return result.ToArray();
        }
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
                return item;

            throw new InvalidOperationException();
        }
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
                return item;
            return default(TSource);
        }
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Predicate<TSource> criterion)
        {
            foreach (var item in source)
            {
                if (criterion?.Invoke(item) is true)
                    return item;
            }

            return default(TSource);
        }
        public static TSource First<TSource>(this IEnumerable<TSource> source, Predicate<TSource> criterion)
        {
            foreach (var item in source)
            {
                if (criterion?.Invoke(item) is true)
                    return item;
            }

            throw new InvalidOperationException();
        }
        public static bool Any<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new InvalidOperationException();
            return source.GetEnumerator().MoveNext();
        }
        public static bool Any<TSource>(this IEnumerable<TSource> source, Predicate<TSource> criterion)
        {
            foreach (var item in source)
            {
                if (criterion.Invoke(item) is true)
                    return true;
            }
            return false;
        }
        public static List<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> function)
        {
            List<TResult> results = new List<TResult>();

            foreach (var item in source)
            {
                results.Add(function.Invoke(item));
            }
            return results;
        }
    }
}
