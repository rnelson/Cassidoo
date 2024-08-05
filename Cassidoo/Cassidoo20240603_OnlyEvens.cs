using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20240603_OnlyEvens
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20240603.cs
    public static IEnumerable<int> onlyEvens(IEnumerable<int> list) => list
        .Where(i => i % 2 == 0)
        .OrderBy(i => i);
}