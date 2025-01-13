using Cassidoo;
using Xunit.Abstractions;

namespace Tests;

public class Tests20250113(ITestOutputHelper output)
{
    [Theory]
    [InlineData("hello world", "Hotel Echo Lima Lima Oscar (space) Whiskey Oscar Romeo Lima Delta", true)]
    [InlineData("3spooky5me", "Three Sierra Papa Oscar Oscar Kilo Yankee Five Mike Echo", true)]
    [InlineData("Super Mario Bros.", "Sierra Uniform Papa Echo Romeo Mike Alfa Romeo India Oscar Bravo Romeo Oscar Sierra", false)]
    [InlineData("Ross Nelson", "Romeo Oscar Sierra Sierra (space) November Echo Lima Sierra Oscar November", true)]
    [InlineData("needs a job", "November Echo Echo Delta Sierra (space) Alfa (space) Juliet Oscar Bravo", true)]
    [InlineData("looking for backend .NET work! ;)", 
        "Lima Oscar Oscar Kilo India November Golf (space) Foxtrot Oscar Romeo (space) " +
        "Bravo Alfa Charlie Kilo Echo November Delta (space) (period) " +
        "November Echo Tango (space) Whiskey Oscar Romeo Kilo (exclamation point) (space) (semicolon)",
        true)]
    public void Test(string message, string expectedPhonetic, bool useExtras)
    {
        var actual = Cassidoo20250113_PhunWithFonetics.Convert(message, useExtras);
        output.WriteLine(message);
        output.WriteLine($"Expected:      {expectedPhonetic}");
        output.WriteLine($"Actual:        {actual.NatoTelephony}");
        output.WriteLine($"Pronunciation: {actual.NatoPronunciation}");
        output.WriteLine(actual.MorseCode);
        output.WriteLine("");
        
        Assert.Equal(expectedPhonetic, actual.NatoTelephony);
    }

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20250113
    Restore complete (0.5s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.1s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
    [xUnit.net 00:00:00.08]   Discovering: Tests
    [xUnit.net 00:00:00.13]   Discovered:  Tests
    [xUnit.net 00:00:00.14]   Starting:    Tests
    [xUnit.net 00:00:00.25]   Finished:    Tests
      Tests test succeeded (1.4s)

    Test summary: total: 6, failed: 0, succeeded: 6, skipped: 0, duration: 1.4s
    Build succeeded in 2.4s
    [rnelson@roto cassidoo]$
*/
}