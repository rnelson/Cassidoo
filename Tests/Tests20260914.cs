using Cassidoo;

namespace Tests;

public class Tests20260914
{
    [Theory]
    [InlineData("The autumn leaves almost glow.", "almost")]
    [InlineData("The autumn leaves almost glow. Hello", "almost")]
    [InlineData("A cool sheep sleeps.", "A")] // "A" is a word, is it not?
    public void Test(string s, string expected)
    {
        var actual = Cassidoo20260914_LongestSorted.LongestSorted(s);
        Assert.Equal(expected, actual);
    }
}
