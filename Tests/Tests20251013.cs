using Cassidoo;

namespace Tests;

public class Tests20251013
{
    [Theory]
    [InlineData("name,age,city\\n\"Ryu, Mi-yeong\",30,\"Seoul\"\\nZoey,24,\"Burbank\"", new[] {"Ryu, Mi-yeong, age 30, from Seoul", "Zoey, age 24, from Burbank"})]
    public void Test(string input, IEnumerable<string> expected)
    {
        var actual = Cassidoo20251013_CsvToList.CsvToList(input);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20251013
    Restore complete (0.8s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.3s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.9)
    [xUnit.net 00:00:00.12]   Discovering: Tests
    [xUnit.net 00:00:00.18]   Discovered:  Tests
    [xUnit.net 00:00:00.19]   Starting:    Tests
    [xUnit.net 00:00:00.36]   Finished:    Tests
      Tests test succeeded (1.9s)

    Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0, duration: 1.9s
    Build succeeded in 3.6s
    [rnelson@roto cassidoo]$
*/