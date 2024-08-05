﻿using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20210510_SameDigits
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20210510.cs
    public static bool sameDigits(long n)
    {
        var n3 = n * n * n;
        var nSet = GetDigits(n);
        var n3Set = GetDigits(n3);
        var eq = Eq(nSet, n3Set);

        return eq;
    }
    
    private static HashSet<char>? GetDigits(long n) =>
    [..n
        .ToString()
        .ToCharArray()
        .Distinct()
        .OrderBy(c => c)
        .ToArray()
    ];

    private static bool Eq<T>(HashSet<T>? one, HashSet<T>? two)
    {
        if (one is null && two != null || one != null && two is null) return false;
        if (one!.Count != two!.Count) return false;
	
        return one.Intersect(two).Count() == one.Count;
    }

    
}