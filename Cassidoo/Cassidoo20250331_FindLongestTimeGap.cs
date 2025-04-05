using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250331_FindLongestTimeGap
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250331.cs
    public static int FindLongestTimeGap(IEnumerable<string> times)
    {
        // See the unit tests (link above) for the reason that this doesn't get sorted
        // in any way.
        var converted = times.Select(TimeOnly.Parse).ToArray();
        var max = 0;

        if (converted.Length < 2) return 0;

        for (var i = 0; i < converted.Length - 1; i++)
            max = Math.Max(max, (int)new TimeSpan(converted[i+1].Ticks - converted[i].Ticks).TotalMinutes);

        return max;
    }
}