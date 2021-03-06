﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace STP_Task6.Collections.Utils
{
    static public class Qsort
    {
        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            if (!list.Any())
            {
                return Enumerable.Empty<T>();
            }
            var pivot = list.First();
            var smaller = list.Skip(1).Where(item => item.CompareTo(pivot) <= 0).QuickSort();
            var larger = list.Skip(1).Where(item => item.CompareTo(pivot) > 0).QuickSort();

            return smaller.Concat(new[] { pivot }).Concat(larger);
        }

        public static IEnumerable<TValue> QuickSortWithDelegate<TValue>
            (this IEnumerable<TValue> list, 
            STP_Task6.Collections.Utils.ListUtils<TValue>.CompareDelegate<TValue> compareDelegate)
        {
            if (!list.Any())
            {
                return Enumerable.Empty<TValue>();
            }
            var pivot = list.First();
            var smaller = list.Skip(1).Where(item => compareDelegate(item, pivot) <= 0).QuickSortWithDelegate(compareDelegate);
            var larger = list.Skip(1).Where(item => compareDelegate(item, pivot) > 0).QuickSortWithDelegate(compareDelegate);

            return smaller.Concat(new[] { pivot }).Concat(larger);
        }



        public static IEnumerable<TValue> LinqQuickSort<TValue>(this IEnumerable<TValue> list) where TValue : IComparable<TValue>
        {
            return !list.Any() ? Enumerable.Empty<TValue>() : list.Skip(1).Where(
                item => item.CompareTo(list.First()) <= 0).LinqQuickSort().Concat(new[] { list.First() })
                    .Concat(list.Skip(1).Where(item => item.CompareTo(list.First()) > 0).LinqQuickSort());
        }
    }
}
