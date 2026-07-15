using Cassidoo;

namespace Tests;

public class Tests20260713
{
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "0 1")]
    [InlineData(30, " 0  1  2  3  4  5\n19 20 21 22 23  6\n18          24  7\n17 30       25  8\n16 29 28 27 26  9\n15 14 13 12 11 10")]
    [InlineData(99, " 0  1  2  3  4  5  6  7  8  9\n35 36 37 38 39 40 41 42 43 10\n34 63 64 65 66 67 68 69 44 11\n33 62 83 84 85 86 87 70 45 12\n32 61 82 95 96 97 88 71 46 13\n31 60 81 94 99 98 89 72 47 14\n30 59 80 93 92 91 90 73 48 15\n29 58 79 78 77 76 75 74 49 16\n28 57 56 55 54 53 52 51 50 17\n27 26 25 24 23 22 21 20 19 18")]
    public void Test(int n, string expected)
    {
        var actual = Cassidoo20260713_SpiralGrid.SpiralGrid(n);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20260713
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.9)
    [xUnit.net 00:00:00.06]   Discovering: Tests
    [xUnit.net 00:00:00.14]   Discovered:  Tests
    [xUnit.net 00:00:00.16]   Starting:    Tests
    [xUnit.net 00:00:00.20]   Finished:    Tests
      Tests test net10.0 succeeded (0.8s)

    Test summary: total: 4, failed: 0, succeeded: 4, skipped: 0, duration: 0.8s
    Build succeeded in 1.8s
    [rnelson@roto cassidoo]$
 */