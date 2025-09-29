using System.Numerics;
using Cassidoo;

namespace Tests;

public class Tests20250927
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(2, 4)]
    [InlineData(3, 108)]
    [InlineData(7, 3319766398771200000)]
    public void Test(BigInteger input, BigInteger expected)
    {
        var actual = Cassidoo20250927_Hyperfactorial.Hyperfactorial(input);
        Assert.Equal(expected, actual);
    }
}
