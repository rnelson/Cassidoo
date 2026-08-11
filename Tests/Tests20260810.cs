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

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260810
    Restore complete (0.9s)
    Determining projects to restore...
    All projects are up-to-date for restore.
        Cassidoo net10.0 succeeded (3.3s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
    Tests net10.0 succeeded (0.6s) → Tests/bin/Debug/net10.0/Tests.dll
        [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.10)
        [xUnit.net 00:00:00.08]   Discovering: Tests
        [xUnit.net 00:00:00.17]   Discovered:  Tests
        [xUnit.net 00:00:00.19]   Starting:    Tests
        [xUnit.net 00:00:00.24]   Finished:    Tests
        Tests test net10.0 succeeded (1.0s)

    Test summary: total: 5, failed: 0, succeeded: 5, skipped: 0, duration: 0.9s
    Build succeeded in 6.1s
    [rnelson@roto cassidoo]$
*/