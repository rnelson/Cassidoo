using Cassidoo;

namespace Tests;

public class Tests20210510
{
    [Theory]
    [InlineData(1, true)]
    [InlineData(10, true)]
    [InlineData(251894, true)]
    [InlineData(251895, false)]
    public void TestSameDigits(int n, bool expected)
    {
        var actual = Cassidoo20210510_SameDigits.sameDigits(n);
        Assert.Equal(expected, actual);
    }
}