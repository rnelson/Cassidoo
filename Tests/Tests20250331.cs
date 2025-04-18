﻿using Cassidoo;

namespace Tests;

public class Tests20250331
{
    /// <remarks>
    /// Regarding the third sample, this is ambiguous. The problem states that you should
    /// find the largest time between two consecutive timestamps, but it does not state if
    /// consecutive is based on how we order timestamps (9a, 10:30a, 2p, 3p) or based on the
    /// order they are presented (2p, 9a, 3p, 10:30a). Since "consecutive" relates to
    /// ordering and there was no instruction to reorder the values, I am leaving them ordered
    /// as presented, which makes the largest gap 360 minutes, not 210 minutes.
    /// </remarks>
    [Theory]
    [InlineData(0, new[] {"12:00"})]
    [InlineData(120, new[] {"09:00", "11:00"})]
    [InlineData(360, new[] {"14:00", "09:00", "15:00", "10:30"})]
    [InlineData(240, new[] {"08:00", "10:00", "10:00", "14:00"})]
    public void Test(int expected, IEnumerable<string> times)
    {
        var actual = Cassidoo20250331_FindLongestTimeGap.FindLongestTimeGap(times);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestExceptions()
    {
        Assert.Throws<ArgumentNullException>(() => Cassidoo20250331_FindLongestTimeGap.FindLongestTimeGap(null!));
        Assert.Throws<ArgumentOutOfRangeException>(() => Cassidoo20250331_FindLongestTimeGap.FindLongestTimeGap(Array.Empty<string>()));
    }
}

/*
    rnelson@flux:~/dev/cassidoo $ ./test.sh Tests20250331
    Restore complete (1.3s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (3.5s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (1.2s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.3)
    [xUnit.net 00:00:00.09]   Discovering: Tests
    [xUnit.net 00:00:00.16]   Discovered:  Tests
    [xUnit.net 00:00:00.17]   Starting:    Tests
    [xUnit.net 00:00:00.26]   Finished:    Tests
      Tests test succeeded (1.6s)

    Test summary: total: 5, failed: 0, succeeded: 5, skipped: 0, duration: 1.5s
    Build succeeded in 8.2s
    rnelson@flux:~/dev/cassidoo $
*/