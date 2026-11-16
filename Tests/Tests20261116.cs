using Cassidoo;

namespace Tests;

public class Tests20261116
{
    [Theory]
    [InlineData("blossom", new[]{"flower", "bloom"}, new[]{"bloom"})]
    [InlineData("chocolate", new[]{"cocoa", "candy"}, new[]{"cocoa"})]
    [InlineData("cat", new[]{"feline"}, new string[]{})]
    public void Test(string word, IEnumerable<string> synonyms, IEnumerable<string> expected)
    {
        var actual = Cassidoo20261116_FindJoeys.FindJoeys(word, synonyms);
        Assert.Equal(expected, actual);
    }
}
