using Cassidoo;
using Xunit.Abstractions;

namespace Tests;

public class Tests20250630
{
    [Theory]
    [InlineData("candy canes do taste yummy", 'u')]
    [InlineData("abcdefg", 'g')]
    [InlineData("Cassidoo", 'd')]
    public void Test(string input, char expected)
    {
        var actual = Cassidoo20250630_NonRepeat.NonRepeat(input);
        Assert.Equal(expected, actual);
    }
}
