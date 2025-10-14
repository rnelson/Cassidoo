using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using JetBrains.Annotations;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20251013_CsvToList
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20251013.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static IEnumerable<string> CsvToList(string input)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower()
        };

        var reader = new StringReader(input.Replace("\\n", Environment.NewLine));
        using var csv = new CsvReader(reader, config);
        return csv
            .GetRecords<Entry>()
            .ToList()
            .Select(e => e.ToString());
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Local")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    private class Entry
    {
        public string Name { get; init; } = string.Empty;
        public int Age { get; init; }
        public string City { get; init; } = string.Empty;

        public override string ToString() => $"{Name}, age {Age}, from {City}";
    }
}
