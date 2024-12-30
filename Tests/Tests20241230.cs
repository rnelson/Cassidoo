using Cassidoo;

namespace Tests;

public class Tests20241230
{
    [Theory]
    [InlineData("Wednesday", 2025)]
    [InlineData("Monday", 2024)]
    public void Test(string expected, int year)
    {
        var actual = Cassidoo20241230_NewYearsDay.NewYearsDay(year);
        
        Assert.Equal(expected, actual);
    }

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20241230
    Restore complete (3.5s)
        Determining projects to restore...
        Restored /home/rnelson/dev/cassidoo/Cassidoo/Cassidoo.csproj (in 967 ms).
        Restored /home/rnelson/dev/cassidoo/Tests/Tests.csproj (in 2.01 sec).
      Cassidoo succeeded (5.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (1.0s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
    [xUnit.net 00:00:00.08]   Discovering: Tests
    [xUnit.net 00:00:00.14]   Discovered:  Tests
    [xUnit.net 00:00:00.15]   Starting:    Tests
    [xUnit.net 00:00:00.20]   Finished:    Tests
      Tests test succeeded (1.7s)

    Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 1.7s
    Build succeeded in 11.9s
    [rnelson@roto cassidoo]$
*/
}