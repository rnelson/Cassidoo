using System.Buffers;
using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20261116_FindJoeys
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20261116.cs
    public static IEnumerable<string> FindJoeys(string word, IEnumerable<string> synonyms)
    {
        var syn = synonyms.ToArray();
        var joeys = new List<string>();
        
        // this won't happen, but I like safety
        if (syn.Length == 0)
            return [];

        foreach (var synonym in syn)
        {
            var characters = new Span<char>(word.ToCharArray());
            var keepers = new Span<char>(synonym.ToCharArray());
            characters.ReplaceAnyExcept(SearchValues.Create(keepers), '\b');
            var a = characters.ToArray().Where(c => c != '\b').ToArray();
            var kept = new string(a);

            if (kept.Contains(synonym))
                joeys.Add(synonym);
        }

        return joeys;
    }
}
