using Cassidoo;

namespace Tests;

public class Tests20261116
{
    [Theory]
    [InlineData("blossom", new[]{"flower", "bloom"}, new[]{"bloom"})]
    [InlineData("chocolate", new[]{"cocoa", "candy"}, new[]{"cocoa"})]
    [InlineData("cat", new[]{"feline"}, new string[]{})]
    public void Test(string word, IEnumerable<string> synonyms, IEnumerable<string> expected)
    {
        var actual = Cassidoo20261116_FindJoeys.FindJoeys(word, synonyms);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20261116
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo net10.0 succeeded (0.2s) → Cassidoo/bin/Debug/net10.0/Cassidoo.dll
      Tests net10.0 succeeded (0.1s) → Tests/bin/Debug/net10.0/Tests.dll

    Build succeeded in 1.0s
    Running tests from Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64)
    Tests/bin/Debug/net10.0/Tests.dll (net10.0|x64) passed (1s 012ms)

    Test run summary: Passed!
      total: 3
      failed: 0
      succeeded: 3
      skipped: 0
      duration: 1s 267ms
    [rnelson@roto cassidoo]$
*/
