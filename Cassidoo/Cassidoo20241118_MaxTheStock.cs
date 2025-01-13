using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class Cassidoo20241118_MaxTheStock
{
    public static int MaxTheStock(params IEnumerable<int> stock) =>
        Math.Max(0, BuildCombinations(stock).Max(c => c.Item3));

    [SuppressMessage("Performance", "CA1859:Use concrete types when possible for improved performance")]
    private static IEnumerable<Tuple<int, int, int>> BuildCombinations(IEnumerable<int> stock)
    {
        var combinations = new List<Tuple<int, int, int>>();
        var data = stock.ToArray();
        
        for (var i = 0; i < data.Length; i++)
        for (var j = i + 1; j < data.Length; j++)
            combinations.Add(new(data[i], data[j], data[j] - data[i]));
        
        return combinations;
    }
}