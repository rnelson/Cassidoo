using System.Diagnostics.CodeAnalysis;
using Cassidoo;

namespace Tests;

[SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible")]
public class Tests20261004
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int expected, IEnumerable<IEnumerable<int>> map)
    {
        var actual = Cassidoo20261004_MinutesUntilApocalypse.MinutesUntilApocalypse(map);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Tuple<int, IEnumerable<IEnumerable<int>>>> TestData = new List<Tuple<int, IEnumerable<IEnumerable<int>>>>
        {
            new(4, [[2, 1, 1], [1, 1, 0], [0, 1, 1]]),
            new(-1, [[2, 1, 1], [0, 1, 1], [1, 0, 1]]),
        };
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20261004
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll

    Build succeeded in 1.0s
    Running tests from Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64)
    Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64) passed (758ms)

    Test run summary: Passed!
      total: 2
      failed: 0
      succeeded: 2
      skipped: 0
      duration: 960ms
    [rnelson@roto cassidoo]$
 */
 