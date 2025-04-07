using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250407_GetLelandNumbers
{
    public static IEnumerable<long> GetLelandNumbers()
    {
        for (var x = 2L; x < long.MaxValue; x++)
        for (var y = 2L; y < long.MaxValue; y++)
            yield return (long)Math.Pow(x, y) + (long)Math.Pow(y, x);
    }
}