using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20240805_SumOfSquares
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20240805.cs
    public static int SumSquares(int n)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(n, 1);
        return ((int[]) [..Enumerable.Range(1, n)]).Sum(i => i * i);
    }
}