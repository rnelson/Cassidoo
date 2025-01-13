using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public class Cassidoo20240701_FruitStand
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20240701.cs
    private readonly Dictionary<string, Tuple<int, double>> _d = new();

    public void AddFruit(string fruit, int quantity, double cost)
    {
        _d.Add(fruit, new(quantity, cost));
    }

    public void UpdateQuantity(string fruit, int quantity)
    {
        _d[fruit] = new(quantity, _d[fruit].Item2);
    }

    public double GetTotalValue() =>
        _d.Sum(i => i.Value.Item1 * i.Value.Item2);
}