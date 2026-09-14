namespace Cassidoo;

public static class Cassidoo20260914_LongestSorted
{
    private static readonly char[] Punctuation = [' ', '.', ';', '!', '?', ':', ','];

    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260914.cs
    public static string LongestSorted(string s)
    {
        var words = s.Split(Punctuation);
        var tuples = words
            .Select((w, i) => new
            {
                Index = i,
                Word = w.ToLower(),
                Ascii = w.ToLower().ToCharArray().Select(c => (int)c).ToArray(),
                SortedAscii = w.ToLower().ToCharArray().Select(c => (int)c).Order().ToArray()
            })
            .Where(t =>
                t.Word.Trim().Length > 0 &&
                Enumerable.SequenceEqual(t.Ascii, t.SortedAscii))
            .ToArray();

        return tuples.Length == 0
            ? ""
            : words[tuples.OrderByDescending(t => t.Word.Length).First().Index];
    }
}
