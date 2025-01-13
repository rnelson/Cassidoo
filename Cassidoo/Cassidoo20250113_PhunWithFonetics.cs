using System.Diagnostics.CodeAnalysis;

/*
 * Extra credit is to do the variants, but I chose another route. I've been meaning to really learn the
 * NATO alphabet for years. I switch between words used in different alphabets or just making up my own
 * every time I have to use phonetics. Also I'm on year, uh, 4 of wanting to get an amateur radio license
 * and even though Morse code is no longer a requirement in the US it'd be good to know.
 *
 * So instead of making up another alphabet, I added Morse code (and also pronunciation helpers).
 *
 * Check out the unit test! https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250113.cs
 */

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class Cassidoo20250113_PhunWithFonetics
{
    private const string _dit = "\u2584";
    private const string _dah = "\u2584\u2584\u2584";

    private static readonly Dictionary<char, (string, string, string)> _dict = new()
    {
        { 'A', ($"{_dit} {_dah}", "Alfa", "AL-fah") },
        { 'B', ($"{_dah} {_dit} {_dit} {_dit}", "Bravo", "BRAH-voh") },
        { 'C', ($"{_dah} {_dit} {_dah} {_dit}", "Charlie", "CHAR-lee") },
        { 'D', ($"{_dah} {_dit} {_dit}", "Delta", "DELL-tah") },
        { 'E', ($"{_dit}", "Echo", "ECK-oh") },
        { 'F', ($"{_dit} {_dit} {_dah} {_dit}", "Foxtrot", "FOKS-trot") },
        { 'G', ($"{_dah} {_dah} {_dit}", "Golf", "GOLF") },
        { 'H', ($"{_dit} {_dit} {_dit} {_dit}", "Hotel", "hoh-TEL") },
        { 'I', ($"{_dit} {_dit}", "India", "IN-dee-ah") },
        { 'J', ($"{_dit} {_dah} {_dah} {_dah}", "Juliet", "jew-lee-ETT") },
        { 'K', ($"{_dah} {_dit} {_dah}", "Kilo", "KEY-loh") },
        { 'L', ($"{_dit} {_dah} {_dit} {_dit}", "Lima", "LEE-mah") },
        { 'M', ($"{_dah} {_dah}", "Mike", "MIKE") },
        { 'N', ($"{_dah} {_dit}", "November", "no-VEM-ber") },
        { 'O', ($"{_dah} {_dah} {_dah}", "Oscar", "OSS-cah") },
        { 'P', ($"{_dit} {_dah} {_dah} {_dit}", "Papa", "PAH-pah") },
        { 'Q', ($"{_dah} {_dah} {_dit} {_dah}", "Quebec", "keh-BECK") },
        { 'R', ($"{_dit} {_dah} {_dit}", "Romeo", "ROW-me-oh") },
        { 'S', ($"{_dit} {_dit} {_dit}", "Sierra", "see-AIR-rah") },
        { 'T', ($"{_dah}", "Tango", "TANG-go") },
        { 'U', ($"{_dit} {_dit} {_dah}", "Uniform", "YOU-nee-form") },
        { 'V', ($"{_dit} {_dit} {_dit} {_dah}", "Victor", "VIK-tah") },
        { 'W', ($"{_dit} {_dah} {_dah}", "Whiskey", "WISS-key") },
        { 'X', ($"{_dah} {_dit} {_dit} {_dah}", "Xray", "ECKS-ray") },
        { 'Y', ($"{_dah} {_dit} {_dah} {_dah}", "Yankee", "YANG-key") },
        { 'Z', ($"{_dah} {_dah} {_dit} {_dit}", "Zulu", "ZOO-loo") },
        { '1', ($"{_dit} {_dah} {_dah} {_dah} {_dah}", "One", "WUN") },
        { '2', ($"{_dit} {_dit} {_dah} {_dah} {_dah}", "Two", "TOO") },
        { '3', ($"{_dit} {_dit} {_dit} {_dah} {_dah}", "Three", "TREE") },
        { '4', ($"{_dit} {_dit} {_dit} {_dit} {_dah}", "Four", "FOW-er") },
        { '5', ($"{_dit} {_dit} {_dit} {_dit} {_dit}", "Five", "FIFE") },
        { '6', ($"{_dah} {_dit} {_dit} {_dit} {_dit}", "Six", "SIX") },
        { '7', ($"{_dah} {_dah} {_dit} {_dit} {_dit}", "Seven", "SEV-en") },
        { '8', ($"{_dah} {_dah} {_dah} {_dit} {_dit}", "Eight", "AIT") },
        { '9', ($"{_dah} {_dah} {_dah} {_dah} {_dit}", "Nine", "NIN-er") },
        { '0', ($"{_dah} {_dah} {_dah} {_dah} {_dah}", "Zero", "ZEE-ro") }
    };

    private static readonly Dictionary<char, string> _extraDict = new()
    {
        { ' ', "(space)" },
        { '.', "(period)" },
        { '!', "(exclamation point)" },
        { '?', "(question mark)" },
        { '-', "(hyphen)" },
        { ':', "(colon)" },
        { ';', "(semicolon)" }
    };

    public static Cassidoo20250113_Representation Convert(string s, bool extras = false)
    {
        var tuples = new List<(string, string, string)>();
        
        foreach (var c in s.ToCharArray())
        {
            if (_dict.TryGetValue(char.ToUpper(c), out var value))
                tuples.Add(value);
            else if (extras && _extraDict.TryGetValue(c, out var extra))
                tuples.Add(("", extra, ""));
        }

        return new(
            string.Join(" ", tuples.Select(t => t.Item2)),
            string.Join(" ", tuples.Select(t => t.Item3)),
            string.Join("     ", tuples.Select(t => t.Item1))
        );
    }
}

public record Cassidoo20250113_Representation(string NatoTelephony, string NatoPronunciation, string MorseCode);