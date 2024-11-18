using Cassidoo;

namespace Tests;

public class Tests20241118
{
    [Theory]
    [InlineData(5, new[] {7, 1, 5, 3, 6, 4})]
    [InlineData(0, new[] {7, 6, 4, 3, 1})]
    public void Test(int expected, IEnumerable<int> prices)
    {
        var actual = Cassidoo20241118_MaxTheStock.MaxTheStock(prices);
        Assert.Equal(expected, actual);
    }
}

/*
    rnelson@krang:~/dev/cassidoo $ ./test.sh Tests20241118
    Restore succeeded with 2 warning(s) in 5.5s
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (2.1s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded with 2 warning(s) (0.9s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.02] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 9.0.0)
    [xUnit.net 00:00:03.29]   Discovering: Tests
    [xUnit.net 00:00:03.66]   Discovered:  Tests
    [xUnit.net 00:00:03.72]   Starting:    Tests
    [xUnit.net 00:00:04.35]   Finished:    Tests
      Tests test succeeded (11.0s)

    Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 10.9s
    Build succeeded with 4 warning(s) in 22.6s
    rnelson@krang:~/dev/cassidoo $
*/