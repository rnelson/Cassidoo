using Cassidoo;

namespace Tests;

public class Tests20260629
{
    [Theory]
    [InlineData(6, 2.00d)]
    [InlineData(40, 4.45d)]
    public void Test(int n, double expected)
    {
        var actual = Cassidoo20260629_MeanBits.NiceBits(n);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260629
    Restore complete (0.6s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 10.0.6)
    [xUnit.net 00:00:00.10]   Discovering: Tests
    [xUnit.net 00:00:00.18]   Discovered:  Tests
    [xUnit.net 00:00:00.19]   Starting:    Tests
    [xUnit.net 00:00:00.25]   Finished:    Tests
      Tests test net10.0 succeeded (1.1s)

    Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 1.1s
    Build succeeded in 2.1s
    [rnelson@roto cassidoo]$
 */