using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250927_Hyperfactorial
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250927.cs
    /// <see cref="https://mathworld.wolfram.com/Hyperfactorial.html"/>
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static BigInteger Hyperfactorial(BigInteger input)
    {
        var r = Range(0, input);
        return Range(1, input).Aggregate((s, n) => s + Pow(n, n));
    }

    private static IEnumerable<BigInteger> Range(BigInteger start, BigInteger end)
    {
        for (var i = start; i <= end; i++)
            yield return i;
    }

    private static BigInteger Pow(this BigInteger n, BigInteger power)
    {
        var result = BigInteger.One;
        
        for (var i = n; n < n + power; n++)
        {
            result *= n;
        }

        return result;
    }
}
