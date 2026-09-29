namespace Cassidoo;

public static class Cassidoo20260928_FirstFrost
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260928.cs
    public static IEnumerable<int> FirstFrost(int[] temperatures, int drop)
    {
        var results = Enumerable.Repeat(0, temperatures.Length).ToArray();

        for (var i = 0; i < results.Length; i++)
        {
            var dropped = temperatures.Skip(i).FirstOrDefault(t => temperatures[i] - t >= drop);
            results[i] = dropped > 0
                ? temperatures.Skip(i).ToArray().IndexOf(dropped)
                : 0;
        }
        
        return results;
    }
}
