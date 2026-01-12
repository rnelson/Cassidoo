using Cassidoo;

namespace Tests;

public class Tests20260112
{
    [Fact]
    public void Test()
    {
        var expected = new[] { "Chicago", "Winnie" };
        var actual = Cassidoo20260112_HungryBears.HungryBears(Cassidoo20260112_HungryBears.TestBears).ToArray();
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260112
    Restore complete (0.6s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 10.0.1)
    [xUnit.net 00:00:00.06]   Discovering: Tests
    [xUnit.net 00:00:00.13]   Discovered:  Tests
    [xUnit.net 00:00:00.13]   Starting:    Tests
    [xUnit.net 00:00:00.20]   Finished:    Tests
      Tests test net10.0 succeeded (0.9s)

    Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0, duration: 0.9s
    Build succeeded in 2.0s
    [rnelson@roto cassidoo]$
 */