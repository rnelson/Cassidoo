using Cassidoo;

namespace Tests;

public class Tests20251110
{
    [Theory]
    [InlineData(new[]{'1', '3', '5', '0', '0', '0'}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '5', '6'})]
    [InlineData(new[]{'1', '3', '0', '0', '0', '0'}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '6', '0'})]
    [InlineData(new[]{'1', '3', '0', '0', '0', (char)0}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '6', (char)0})]
    [InlineData(new[]{'1', '3', '0', '0', (char)0, '0'}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '6', '0'})]
    [InlineData(new[]{'1', '3', '0', '0', '0', '0'}, new[] {'6'}, new[]{'1', '3', '6', '0', '0', '0'})]
    [InlineData(new[]{'1', '3', '0', (char)0, '0', '0'}, new[] {'6'}, new[]{'1', '3', '6', (char)0, '0', '0'})]
    [InlineData(new[]{'1', '3', '0', '0', (char)0, '0'}, new[] {'6'}, new[]{'1', '3', '6', '0', (char)0, '0'})]
    [InlineData(new[]{'1', (char)0, ' ', '0', (char)0, '0'}, new[] {'6'}, new[]{'1', '6', ' ', '0', (char)0, '0'})]
    [InlineData(new[]{'1', '3', '0', ' ', (char)0, '0'}, new[] {'6'}, new[]{'1', '3', '6', ' ', (char)0, '0'})]
    public void Test(char[] a, char[] b, char[] expected)
    {
        var actual = Cassidoo20251110_Merge.Merge(a, b);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20251110
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.1s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.10)
    [xUnit.net 00:00:00.11]   Discovering: Tests
    [xUnit.net 00:00:00.19]   Discovered:  Tests
    [xUnit.net 00:00:00.19]   Starting:    Tests
    [xUnit.net 00:00:00.27]   Finished:    Tests
      Tests test succeeded (1.1s)

    Test summary: total: 9, failed: 0, succeeded: 9, skipped: 0, duration: 1.1s
    Build succeeded in 2.1s
    [rnelson@roto cassidoo]$
 */
