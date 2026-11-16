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
            // Make a copy of the input word that we can mess with. string -> char[] -> Span<char>
            var characters = new Span<char>(word.ToCharArray());
            
            // Replace any character in that (copy of the) original word that isn't also in our synonym
            // with an ASCII bell. Any character is fine, just something that we can safely remove.
            characters.ReplaceAnyExcept(
                SearchValues.Create(new Span<char>(synonym.ToCharArray())),
                '\b');
            
            // Build a new string object with that subset of characters, bells removed.
            var kept = new string(characters.ToArray().Where(c => c != '\b').ToArray());

            // If the synonym is now a subset of the word, we know that joey exists in order. There may or
            // may not be extra characters surrounding it, we don't care.
            if (kept.Contains(synonym))
                joeys.Add(synonym);
        }

        return joeys;
    }
}
