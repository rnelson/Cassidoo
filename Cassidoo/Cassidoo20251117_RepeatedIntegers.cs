using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20251117_RepeatedIntegers
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20251117.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static IEnumerable<int> RepeatedIntegers(int n)
    {
        var result = new List<int>();

        for (var i = 1; i <= n; i++)
            for (var j = 0; j < i; j++)
                result.Add(i);
        
        return result;
    }
}
