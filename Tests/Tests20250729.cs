using Cassidoo;

namespace Tests;

public class Tests20250729
{
    [Theory]
    [InlineData(new[] {2, 3, 8, 8, 2, 3}, true)]
    [InlineData(new[] {1, 2, 3, 4, 5, 6}, false)]
    [InlineData(new[] {2, 2, 2, 2, 2, 2, 2}, false)]
    [InlineData(new[] {2, 2, 2, 2, 2, 2}, true)]
    [InlineData(new[] {1, 2, 3, 2, 1, 3}, true)]
    public void Test(IEnumerable<int> input, bool expected)
    {
        var actual = Cassidoo20250729_CanFormHexagon.CanFormHexagon(input);
        Assert.Equal(expected, actual);
    }
}
