using Cassidoo;

namespace Tests;

public class Tests20260713
{
    [Theory]
    [InlineData(0, "")]
    public void Test(int n, string expected)
    {
        var actual = Cassidoo20260713_SpiralGrid.SpiralGrid(n);
        Assert.Equal(expected, actual);
    }
}
