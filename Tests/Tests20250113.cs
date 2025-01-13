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
}