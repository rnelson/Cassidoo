namespace Cassidoo;

public static class Cassidoo20260914_LongestSorted
{
    private static readonly char[] Punctuation = [' ', '.', ';', '!', '?', ':', ','];

    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260914.cs
    public static string LongestSorted(string s)
    {
        var words = s.Split(Punctuation);
        var littleWords = words
            .Select((w, i) => new
            {
                Index = i,
                Word = w.ToLower(),
                Letters = w.ToCharArray(),
                Ascii = w.ToCharArray().Select(c => (int)c).ToArray(),
                SortedAscii = w.ToCharArray().Select(c => (int)c).Order().ToArray()
            })
            .Where(p => p.Word.Trim().Length > 0);
        var candidates = littleWords
            .Where(c => Enumerable.SequenceEqual(c.Ascii, c.SortedAscii))
            .ToArray();

        return candidates.Length == 0
            ? ""
            : words[candidates.OrderByDescending(c => c.Word.Length).First().Index];
    }
}
