using Cassidoo;

namespace Tests;

public class Tests20260928
{
    [Theory]
    [InlineData(new[]{70, 68, 72, 60, 65, 55}, 5, new[]{3, 2, 1, 2, 1, 0})]
    [InlineData(new[]{50, 49, 48}, 5, new[]{0, 0, 0})]
    [InlineData(new[]{40, 30, 45, 20}, 10, new[]{1, 2, 1, 0})]
    public void Test(int[] temperatures, int drop, int[] expected)
    {
        var actual = Cassidoo20260928_FirstFrost.FirstFrost(temperatures, drop);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260928
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll

    Build succeeded in 1.0s
    Running tests from Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64)
    Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64) passed (818ms)

    Test run summary: Passed!
      total: 3
      failed: 0
      succeeded: 3
      skipped: 0
      duration: 1s 033ms
    [rnelson@roto cassidoo]$
 */