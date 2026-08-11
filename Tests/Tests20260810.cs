using Cassidoo;

namespace Tests;

public class Tests20260810
{
    [Theory]
    [InlineData("leading", "   hello world   ", "hello world   ")]
    [InlineData("trailing", "   hello world   ", "   hello world")]
    [InlineData("both", "   hello world   ", "hello world")]
    [InlineData("compress", "hello   world  !", "hello world !")]
    [InlineData("compress", "  hi   there  ", " hi there ")]
    public void Test(string type, string s, string expected)
    {
        var actual = Cassidoo20260810_Trim.Trim(type, s);
        Assert.Equal(expected, actual);
    }
}