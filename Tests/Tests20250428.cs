using Cassidoo;
using Xunit.Abstractions;

namespace Tests;

public class Tests20250428
{
    [Theory]
    [InlineData(new[] {"a", "b", "b", "b", "c"}, new[] {"a", "b", "3", "c"})]
    [InlineData(new[] {"a", "a", "b", "b", "c", "c", "c"}, new[] {"a", "2", "b", "2", "c", "3"})]
    public void Test(IEnumerable<string> input, IEnumerable<string> expected)
    {
        var actual = Cassidoo20250428_Compress.Compress(input);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20250428
    Restore complete (0.6s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.2s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.4)
    [xUnit.net 00:00:00.14]   Discovering: Tests
    [xUnit.net 00:00:00.25]   Discovered:  Tests
    [xUnit.net 00:00:00.26]   Starting:    Tests
    [xUnit.net 00:00:00.39]   Finished:    Tests
      Tests test succeeded (1.8s)

    Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 1.8s
    Build succeeded in 3.2s
    [rnelson@roto cassidoo]$
*/
