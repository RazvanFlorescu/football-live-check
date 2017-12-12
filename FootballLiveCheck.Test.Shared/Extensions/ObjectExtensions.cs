using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FootballLiveCheck.Tests.Shared.Extensions
{
    public static class ObjectExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this T item)
        {
            return GetListFromItem(item);
        }

        public static ICollection<T> ToCollection<T>(this T item)
        {
            return GetListFromItem(item);
        }

        public static IReadOnlyCollection<T> ToReadOnlyCollection<T>(this T item)
        {
            return new ReadOnlyCollection<T>(GetListFromItem(item));
        }

        public static IQueryable<T> ToQueryableCollection<T>(this T item)
        {
            return new EnumerableQuery<T>(GetListFromItem(item));
        }

        private static List<T> GetListFromItem<T>(this T item)
        {
            var list = new List<T> {item};
            return list;
        }

    }
}