using System.Diagnostics.CodeAnalysis;
using Cassidoo;

namespace Tests;

[SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible")]
public class Tests20261019
{
    [Theory]
    [InlineData("ghost", "ghost")]
    [InlineData("b", "a#~b")]
    [InlineData("abb", "ab~c#")]
    [InlineData("BOO", "BBB##O~")]
    public void Test(string expected, string input)
    {
        var actual = Cassidoo20261019_Ghostwriter.Ghostwriter(input);
        Assert.Equal(expected, actual);
    }
}
