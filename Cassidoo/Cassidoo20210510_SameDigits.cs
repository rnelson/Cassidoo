using System.Diagnostics.CodeAnalysis;
using Cassidoo.Extensions;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20210510_SameDigits
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20210510.cs
    public static bool SameDigits(long n)
    {
        var n3 = n * n * n;
        var nSet = GetDigits(n);
        var n3Set = GetDigits(n3);
        var eq = nSet.ContainSameDigits(n3Set);

        return eq;
    }
    
    private static HashSet<char> GetDigits(long n) =>
    [..n
        .ToString()
        .ToCharArray()
        .Distinct()
        .OrderBy(c => c)
        .ToArray()
    ];
}