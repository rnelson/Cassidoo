using Cassidoo;

namespace Tests;

public class Tests20260629
{
    [Theory]
    [InlineData(6, 2.00d)]
    [InlineData(40, 4.45d)]
    public void Test(int n, double expected)
    {
        var actual = Cassidoo20260629_MeanBits.NiceBits(n);
        Assert.Equal(expected, actual);
    }
}
