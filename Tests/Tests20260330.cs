using Cassidoo;

namespace Tests;

public class Tests20260330
{
    [Theory]
    [InlineData("/a", "/c")]
    [InlineData("/alias", "/real")]
    [InlineData("/loop1", null)]
    [InlineData("/real", "/real")]
    public void Test(string path, string? expected)
    {
        var actual = Cassidoo20260330_ResolvePath.ResolvePath(Cassidoo20260330_ResolvePath.TestFilesystem, path);
        Assert.Equal(expected, actual);
    }
}
