using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordFinderChallenge.Extensions
{
    public static class MatrixExtensions
    {
        public static IEnumerable<IEnumerable<T>> Pivot<T>(this IEnumerable<IEnumerable<T>> source)
        {
            return source.SelectMany(inner => inner.Select((item, index) => new { item, index }))
                    .GroupBy(i => i.index, i => i.item)
                    .Select(g => g.ToList());
        }
    }
}
