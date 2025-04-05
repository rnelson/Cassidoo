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
}