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

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260330
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 10.0.4)
    [xUnit.net 00:00:00.06]   Discovering: Tests
    [xUnit.net 00:00:00.13]   Discovered:  Tests
    [xUnit.net 00:00:00.14]   Starting:    Tests
    [xUnit.net 00:00:00.19]   Finished:    Tests
      Tests test net10.0 succeeded (0.9s)

    Test summary: total: 4, failed: 0, succeeded: 4, skipped: 0, duration: 0.9s
    Build succeeded in 2.0s
    [rnelson@roto cassidoo]$
 */