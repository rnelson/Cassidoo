using System.Diagnostics.CodeAnalysis;
using Cassidoo.Extensions;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250331_FindLongestTimeGap
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250331.cs
    public static int FindLongestTimeGap(IEnumerable<string> times)
    {
        ArgumentNullException.ThrowIfNull(times);
        
        var data = times.ToArray();
        ArgumentOutOfRangeException.ThrowIfLessThan(data.Length, 1);
        if (data.Length == 1) return 0;
        
        // See the unit tests (link above) for the reason that
        // this isn't getting sorted.
        return data
            .Select(TimeOnly.Parse)
            .Pair()
            .Max(p => GetMinutes(p.Item1, p.Item2));
    }
    
    private static int GetMinutes(TimeOnly one, TimeOnly two) =>
        (int)new TimeSpan(two.Ticks - one.Ticks).TotalMinutes;
}