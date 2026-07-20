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

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260720
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.10)
    [xUnit.net 00:00:00.08]   Discovering: Tests
    [xUnit.net 00:00:00.17]   Discovered:  Tests
    [xUnit.net 00:00:00.19]   Starting:    Tests
    [xUnit.net 00:00:00.25]   Finished:    Tests
      Tests test net10.0 succeeded (1.2s)

    Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 1.2s
    Build succeeded in 2.2s
    [rnelson@roto cassidoo]$
 */