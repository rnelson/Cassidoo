using Cassidoo;

namespace Tests;

public class Tests20251117
{
    [Theory]
    [InlineData(4, new[]{1, 2, 2, 3, 3, 3, 4, 4, 4, 4})]
    [InlineData(7, new[]{1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7})]
    [InlineData(1, new[]{1})]
    public void Test(int n, IEnumerable<int> expected)
    {
        var actual = Cassidoo20251117_RepeatedIntegers.RepeatedIntegers(n);
        Assert.Equal(expected, actual);
    }
}
