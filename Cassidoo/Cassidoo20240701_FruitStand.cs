using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public class Cassidoo20240701_FruitStand
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20240701.cs
    private readonly Dictionary<string, Tuple<int, double>> _d = new();

    public void addFruit(string fruit, int quantity, double cost)
    {
        _d.Add(fruit, new Tuple<int, double>(quantity, cost));
    }

    public void updateQuantity(string fruit, int quantity)
    {
        _d[fruit] = new Tuple<int, double>(quantity, _d[fruit].Item2);
    }

    public double totalValue() =>
        _d.Sum(i => i.Value.Item1 * i.Value.Item2);
}