using System.Diagnostics.CodeAnalysis;
using Cassidoo.Extensions;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250428_Compress
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250428.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static IEnumerable<string> Compress(IEnumerable<string> chars)
    {
        foreach (var g in chars.Group())
        {
            yield return g.First()!;
            if (g.Count() > 1)
                yield return g.Count().ToString();
        }
    }
}
