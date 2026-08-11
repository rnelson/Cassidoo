using System.Text.RegularExpressions;

namespace Cassidoo;

public static class Cassidoo20260810_Trim
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260810.cs
    public static string Trim(string type, string s) =>
        type.Trim().ToLower() switch
        {
            "leading" => s.TrimStart(),
            "trailing" => s.TrimEnd(),
            "both" => s.Trim(),
            "compress" => Regex.Replace(s, @"\s+", " "),
            _ => s
        };
}
