using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CsvHelper;
using JetBrains.Annotations;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20251013_CsvToList
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20251013.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static IEnumerable<string> CsvToList(string input)
    {
        var options = new CsvReaderOptions 
        {
            NormalizeHeaderName = s => s.ToLower(CultureInfo.InvariantCulture)
        };

        var reader = new StringReader(input.Replace("\\n", Environment.NewLine));
        using var csv = CsvReader.Create(reader, options);
        return csv
            .GetRecords<Entry20251013>()
            .ToList()
            .Select(e => e.ToString());
    }
}

[UsedImplicitly]
[CsvRecord]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Local")]
[SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
[SuppressMessage("CsvHelper", "CSVH001:CSV record types must be partial")]
public partial class Entry20251013
{
    public string Name { get; init; } = string.Empty;
    public int Age { get; init; }
    public string City { get; init; } = string.Empty;

    public override string ToString() => $"{Name}, age {Age}, from {City}";
}
