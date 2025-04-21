using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250421_CalculateIngredients
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250421.cs
    public static IDictionary<string, uint> CalculateIngredients(IDictionary<string, uint> ingredients,
        uint targetServings) => ingredients.ToDictionary(
            entry => entry.Key, 
            entry => entry.Value * targetServings);
}
