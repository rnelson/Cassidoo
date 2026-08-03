using Cassidoo;

namespace Tests;

public class Tests20260803
{
    [Theory]
    [InlineData(new[]{"C", "D", "E", "F", "G", "H"},
        new uint[]{3, 0, 4, 1, 2, 5},
        new[]{"D", "F", "G", "C", "E", "H"})]
    public void Test(string[] values, uint[] indexes, string[] expected)
    {
        var actual = Cassidoo20260803_Reorder.Reorder(values, indexes).ToArray();
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260803
    Restore complete (0.6s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.10)
    [xUnit.net 00:00:00.10]   Discovering: Tests
    [xUnit.net 00:00:00.19]   Discovered:  Tests
    [xUnit.net 00:00:00.22]   Starting:    Tests
    [xUnit.net 00:00:00.29]   Finished:    Tests
      Tests test net10.0 succeeded (1.4s)

    Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0, duration: 1.4s
    Build succeeded in 2.4s
    [rnelson@roto cassidoo]$
 */