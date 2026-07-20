using Cassidoo;

namespace Tests;

public class Tests20260720
{
    [Theory]
    [InlineData("_..__...._.", 4)]
    [InlineData("...._", 0)]
    public void Test(string input, int expected)
    {
        var actual = Cassidoo20260720_CountBlinks.CountBlinks(input);
        Assert.Equal(expected, actual);
    }
}