using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250630_NonRepeat
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250630.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static char NonRepeat(string input) =>
        input.LastOrDefault(c => input.Count(ch => ch == c) == 1);
}
