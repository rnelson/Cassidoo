using Cassidoo;

namespace Tests;

public class Tests20251117
{
    [Theory]
    [InlineData(4, new[]{1, 2, 2, 3, 3, 3, 4, 4, 4, 4})]
    [InlineData(7, new[]{1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7})]
    [InlineData(1, new[]{1})]
    public void Test(int n, IEnumerable<int> expected)
    {
        var actual = Cassidoo20251117_RepeatedIntegers.RepeatedIntegers(n);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20251117
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.1s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.10)
    [xUnit.net 00:00:00.06]   Discovering: Tests
    [xUnit.net 00:00:00.13]   Discovered:  Tests
    [xUnit.net 00:00:00.13]   Starting:    Tests
    [xUnit.net 00:00:00.18]   Finished:    Tests
      Tests test succeeded (0.9s)

    Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0, duration: 0.9s
    Build succeeded in 1.9s
    [rnelson@roto cassidoo]$
*/