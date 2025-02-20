using Cassidoo;

namespace Tests;

public class Tests20250217
{
    [Theory]
    [InlineData(2, new[] {10, 20, 30, 40}, 50)]
    [InlineData(-1, new[] {1, 2, 3, 4}, 20)]
    [InlineData(0, new[] {50}, 30)]
    public void Test(int expected, IEnumerable<int> hits, int shieldTotal)
    {
        var actual = Cassidoo20250217_ShieldDamage.FindShieldBreak(hits, shieldTotal);
        
        Assert.Equal(expected, actual);
    }
    
/*
    rnelson@krang:~/dev/cassidoo $ ./test.sh Tests20250217
    Restore complete (9.9s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (26.5s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (6.9s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.03] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
    [xUnit.net 00:00:00.80]   Discovering: Tests
    [xUnit.net 00:00:01.35]   Discovered:  Tests
    [xUnit.net 00:00:01.42]   Starting:    Tests
    [xUnit.net 00:00:02.08]   Finished:    Tests
      Tests test succeeded (10.5s)

    Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0, duration: 10.4s
    Build succeeded in 57.8s
    rnelson@krang:~/dev/cassidoo $
*/
}