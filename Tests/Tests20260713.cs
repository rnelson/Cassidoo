using Cassidoo;

namespace Tests;

public class Tests20260713
{
    [Theory]
    [InlineData(0, " 0")]
    [InlineData(1, " 0  1")]
    [InlineData(30, " 0  1  2  3  4  5\n19 20 21 22 23  6\n18          24  7\n17 30       25  8\n16 29 28 27 26  9\n15 14 13 12 11 10")]
    public void Test(int n, string expected)
    {
        var actual = Cassidoo20260713_SpiralGrid.SpiralGrid(n);
        Assert.Equal(expected, actual);
    }
}
