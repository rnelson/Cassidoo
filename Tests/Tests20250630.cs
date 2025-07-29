using Cassidoo;

namespace Tests;

public class Tests20250630
{
    [Theory]
    [InlineData("candy canes do taste yummy", 'u')]
    [InlineData("abcdefg", 'g')]
    [InlineData("Cassidoo", 'd')]
    public void Test(string input, char expected)
    {
        var actual = Cassidoo20250630_NonRepeat.NonRepeat(input);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20250630
    Restore complete (1.7s)
        Determining projects to restore...
        Restored /home/rnelson/dev/cassidoo/Cassidoo/Cassidoo.csproj (in 753 ms).
        Restored /home/rnelson/dev/cassidoo/Tests/Tests.csproj (in 835 ms).
      Cassidoo succeeded (4.5s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (1.7s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.6)
    [xUnit.net 00:00:00.13]   Discovering: Tests
    [xUnit.net 00:00:00.21]   Discovered:  Tests
    [xUnit.net 00:00:00.22]   Starting:    Tests
    [xUnit.net 00:00:00.33]   Finished:    Tests
      Tests test succeeded (1.8s)

    Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0, duration: 1.8s
    Build succeeded in 10.3s
    [rnelson@roto cassidoo]$
*/
