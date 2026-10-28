using System.Diagnostics.CodeAnalysis;
using Cassidoo;

namespace Tests;

[SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible")]
public class Tests20261019
{
    [Theory]
    [InlineData("ghost", "ghost")]
    [InlineData("b", "a#~b")]
    [InlineData("abb", "ab~c#")]
    [InlineData("BOO", "BBB##O~")]
    public void Test(string expected, string input)
    {
        var actual = Cassidoo20261019_Ghostwriter.Ghostwriter(input);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20261019
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll

    Build succeeded in 1.0s
    Running tests from Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64)
    Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64) passed (769ms)

    Test run summary: Passed!
      total: 4
      failed: 0
      succeeded: 4
      skipped: 0
      duration: 977ms
    [rnelson@roto cassidoo]$
 */
