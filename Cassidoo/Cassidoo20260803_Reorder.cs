namespace Cassidoo;

public static class Cassidoo20260803_Reorder
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260803.cs
    public static IEnumerable<string> Reorder(IEnumerable<string> strings, IEnumerable<uint> indexes)
    {
        return indexes
            .Zip(strings, (idx, str) => new { Index = idx, Value = str })
            .OrderBy(o => o.Index)
            .Select(o => o.Value);
    }
}
