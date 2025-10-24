using Cassidoo;

namespace Tests;

public class Tests20251020
{
    [Theory]
    [InlineData("Supercalifragilisticexpialidocious", new[] { 5, 9, 4 }, new[] { "Super", "califragi", "list", "icex", "pial", "idoc", "ious" })]
    [InlineData("I'm just an adult and life is a nightmare", new[] { 4, 5, 3, 6, 4 }, new[] { "I'm ", "just ", "an ", "adult ", "and ", "life", " is ", "a ni", "ghtm", "are" })]
    public void Test(string input, IEnumerable<int> widths, IEnumerable<string> expected)
    {
        var actual = Cassidoo20251020_SplitByWidths.SplitByWidths(input, widths);
        Assert.Equal(expected, actual);
    }
}
