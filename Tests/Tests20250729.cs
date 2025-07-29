using Cassidoo;

namespace Tests;

public class Tests20250729
{
    [Theory]
    [InlineData(new[] {2, 3, 8, 8, 2, 3}, true)]
    [InlineData(new[] {1, 2, 3, 4, 5, 6}, false)]
    [InlineData(new[] {2, 2, 2, 2, 2, 2, 2}, false)]
    [InlineData(new[] {2, 2, 2, 2, 2, 2}, true)]
    [InlineData(new[] {1, 2, 3, 2, 1, 3}, true)]
    public void Test(IEnumerable<int> input, bool expected)
    {
        var actual = Cassidoo20250729_CanFormHexagon.CanFormHexagon(input);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20250729
    Restore complete (0.8s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.3s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.7)
    [xUnit.net 00:00:00.18]   Discovering: Tests
    [xUnit.net 00:00:00.28]   Discovered:  Tests
    [xUnit.net 00:00:00.29]   Starting:    Tests
    [xUnit.net 00:00:00.41]   Finished:    Tests
      Tests test succeeded (1.9s)

    Test summary: total: 5, failed: 0, succeeded: 5, skipped: 0, duration: 1.9s
    Build succeeded in 3.5s
    [rnelson@roto cassidoo]$
*/
