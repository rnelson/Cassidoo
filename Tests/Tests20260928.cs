using Cassidoo;

namespace Tests;

public class Tests20260928
{
    [Theory]
    [InlineData(new[]{70, 68, 72, 60, 65, 55}, 5, new[]{3, 2, 1, 2, 1, 0})]
    [InlineData(new[]{50, 49, 48}, 5, new[]{0, 0, 0})]
    [InlineData(new[]{40, 30, 45, 20}, 10, new[]{1, 2, 1, 0})]
    public void Test(int[] temperatures, int drop, int[] expected)
    {
        var actual = Cassidoo20260928_FirstFrost.FirstFrost(temperatures, drop);
        Assert.Equal(expected, actual);
    }
}
