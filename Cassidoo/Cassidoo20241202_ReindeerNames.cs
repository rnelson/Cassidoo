using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class Cassidoo20241202_ReindeerNames
{
    public static IEnumerable<string?> RollCall(params IEnumerable<string> input) =>
        input
                ; /*
            .ToArray()
            .Select(i => new string(i.ToCharArray().Reverse().ToArray()))
            .Order()
            .ToArray(); */
}