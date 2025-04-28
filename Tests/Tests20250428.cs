using Cassidoo;
using Xunit.Abstractions;

namespace Tests;

public class Tests20250428(ITestOutputHelper testOutputHelper)
{
    [Theory]
    [InlineData(new[] {"a", "b", "b", "b", "c"}, new[] {"a", "b", "3", "c"})]
    [InlineData(new[] {"a", "a", "b", "b", "c", "c", "c"}, new[] {"a", "2", "b", "2", "c", "3"})]
    public void Test(IEnumerable<string> input, IEnumerable<string> expected)
    {
        var actual = Cassidoo20250428_Compress.Compress(input);
        Assert.Equal(expected, actual);
    }
}
