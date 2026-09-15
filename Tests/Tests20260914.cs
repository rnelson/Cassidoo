using Cassidoo;

namespace Tests;

public class Tests20260914
{
    [Theory]
    [InlineData("The autumn leaves almost glow.", "almost")]
    [InlineData("The autumn leaves almost glow. Hello", "almost")]
    [InlineData("A cool sheep sleeps.", "A")] // "A" is a word, is it not?
    public void Test(string s, string expected)
    {
        var actual = Cassidoo20260914_LongestSorted.LongestSorted(s);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ dotnet test --filter FullyQualifiedName~Tests20260914 -v:detailed
    Restore complete (0.6s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) ? Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) ? Tests/bin/Debug/net10.0/Tests.dll

    Build succeeded in 1.1s
    Running tests from Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64)
    Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64) passed (759ms)

    Test run summary: Passed!
      total: 3
      failed: 0
      succeeded: 3
      skipped: 0
      duration: 972ms
    [rnelson@roto cassidoo]$
*/