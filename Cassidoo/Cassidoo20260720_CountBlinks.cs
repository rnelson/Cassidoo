namespace Cassidoo;

public static class Cassidoo20260720_CountBlinks
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260720.cs
    public static int CountBlinks(string input) => input
        .Substrings('_')
        .Where(s => !string.IsNullOrEmpty(s))
        .Select(s => s.Substring(1, s.Length - 2))
        .OrderByDescending(s => s.Length)
        .FirstOrDefault()?
        .Length ?? 0;
}

public static class Cassidoo20260720_StringExtensions
{
    public static IEnumerable<string> Substrings(this string input, char marker)
    {
        var first = input.IndexOf(marker);
        var last = input.LastIndexOf(marker);

        if (first < 0 || last < 0 || first == last)
        {
            yield return string.Empty;
            yield break;
        }

        for (var i = first; i < last;)
        {
            var next = input.IndexOf(marker, i + 1);
            yield return input.Substring(i, next - i + 1);

            i = next;
        }
    }
}