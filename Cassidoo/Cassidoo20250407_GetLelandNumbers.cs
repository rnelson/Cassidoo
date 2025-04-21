using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250407_GetLelandNumbers
{
    public static IEnumerable<ulong> GetLelandNumbers(ulong size)
    {
        var results = new List<ulong>();
        
        for (var x = 2UL; x <= size; x++)
        for (var y = 2UL; y <= x; y++)
            results.Add((ulong)Math.Pow(x, y) + (ulong)Math.Pow(y, x));

        return results.Order().Take((int)size);
    }
}