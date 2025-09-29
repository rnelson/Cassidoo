using System.Numerics;

namespace Cassidoo.Extensions;

internal static class EnumerableExtensions
{
    /// <summary>
    /// Chunks <paramref name="source"/> into pairs.
    /// </summary>
    /// <param name="source">The source data to enumerate.</param>
    /// <typeparam name="T">The type of data in <paramref name="source"/>.</typeparam>
    /// <returns><paramref name="source"/> split into pairs.</returns>
    /// <remarks>
    /// Chunks always
    /// start with the sequentially next element, so the first chunk always starts with the first element,
    /// the second chunk always starts with the second element, and so forth.
    /// </remarks>
    public static IEnumerable<Tuple<T, T>> Pair<T>(this IEnumerable<T> source)
    {
        ArgumentNullException.ThrowIfNull(source);

        var data = source.ToArray();
        ArgumentOutOfRangeException.ThrowIfGreaterThan(2, data.Length, nameof(data));
        
        for (var i = 0; i < data.Length - 1; i++)
            yield return Tuple.Create(data[i], data[i + 1]);
    }

    /// <summary>
    /// Collects groups of consecutive values in <paramref name="source"/> that are identical.
    /// </summary>
    /// <param name="source">The <see cref="IEnumerable{T}"/> to group.</param>
    /// <typeparam name="T">The type of data in <paramref name="source"/>.</typeparam>
    /// <returns>Each group of consecutive identical <typeparamref name="T"/>s.</returns>
    /// <remarks>Here be dragons, and bad code.</remarks>
    public static IEnumerable<IEnumerable<T?>> Group<T>(this IEnumerable<T?> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        var data = source.ToArray();

        if (data.Length < 2)
            yield return data;
        else
        {
            var current = data[0]!;
            var segment = new List<T?> { current };
            
            var idx = 1;
            while (idx <= data.Length)
            {
                // If we're at the end, send the last bit and bail
                if (idx >= data.Length)
                {
                    yield return segment;
                    yield break;
                }
                
                // If we're on to new data, send what we had then keep going
                if (!current.Equals(data[idx]))
                {
                    yield return segment;

                    current = data[idx]!;
                    segment = [data[idx]];
                    idx++;
                }
                else
                {
                    while (idx < data.Length && current.Equals(data[idx]))
                    {
                        current = data[idx]!;
                        segment.Add(data[idx]);
                        idx++;
                    }
                }
            }
        }
    }
    
    private static BigInteger Sum(this IEnumerable<BigInteger> source)
    {
        return source.Aggregate(BigInteger.Zero, (current, next) => current + next);
    }
}