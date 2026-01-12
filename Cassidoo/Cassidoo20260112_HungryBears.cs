using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20260112_HungryBears
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260112.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static IEnumerable<string> HungryBears(IEnumerable<Bear> bears)
    {
        var average = (uint)(bears.Sum(b => b.Hunger) / bears.Count());
        return bears
            .Where(b => b.Hunger > average)
            .OrderBy(b => b.Name)
            .Select(b => b.Name);
    }

    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public record Bear(string Name, uint Hunger);
    
    
    
    public static Bear[] TestBears => new List<Bear>
    {
        new("Baloo", 6),
        new("Yogi", 9),
        new("Paddington", 4),
        new("Winnie", 10),
        new("Chicago", 20),
    }.ToArray();
}
