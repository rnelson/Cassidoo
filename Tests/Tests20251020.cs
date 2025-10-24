using Cassidoo;

namespace Tests;

public class Tests20251020
{
    [Theory]
    [InlineData("Supercalifragilisticexpialidocious", new[] { 5, 9, 4 }, new[] { "Super", "califragi", "list", "icex", "pial", "idoc", "ious" })]
    [InlineData("I'm just an adult and life is a nightmare", new[] { 4, 5, 3, 6, 4 }, new[] { "I'm ", "just ", "an ", "adult ", "and ", "life", " is ", "a ni", "ghtm", "are" })]
    public void Test(string input, IEnumerable<int> widths, IEnumerable<string> expected)
    {
        var actual = Cassidoo20251020_SplitByWidths.SplitByWidths(input, widths);
        Assert.Equal(expected, actual);
    }
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20251020
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.1s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.10)
    [xUnit.net 00:00:00.09]   Discovering: Tests
    [xUnit.net 00:00:00.15]   Discovered:  Tests
    [xUnit.net 00:00:00.15]   Starting:    Tests
    [xUnit.net 00:00:00.20]   Finished:    Tests
      Tests test succeeded (0.9s)

    Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 0.9s
    Build succeeded in 1.9s
    [rnelson@roto cassidoo]$
*/
