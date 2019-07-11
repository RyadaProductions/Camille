using System.Collections.Generic;
using System.Linq;

namespace MingweiSamuel.Camille.Util
{
    public static class SequenceEquality
    {
        public static bool SequenceEqualNullAsEmpty<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            return (first ?? Enumerable.Empty<T>()).SequenceEqual(second ?? Enumerable.Empty<T>());
        }

        public static int SequenceHashCodeNullAsEmpty<T>(IEnumerable<T> enumerable)
        {
            const int prime = 397;
            return (enumerable ?? Enumerable.Empty<T>())
                .Aggregate(1, (current, x) => (current * prime) ^ x.GetHashCode());
        }
    }
}
