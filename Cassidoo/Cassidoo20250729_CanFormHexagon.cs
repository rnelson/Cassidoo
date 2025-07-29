using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250729_CanFormHexagon
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250729.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static bool CanFormHexagon(IEnumerable<int> input)
    {
        var numbers = input.ToArray();
        var used = new int[numbers.Length];
        
        if (numbers.Length != 6)
            return false;

        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] != numbers[j])
                    continue;
                
                used[i] = 1;
                used[j] = 1;
                break;
            }
        }

        return used.All(n => n == 1);
    }
}
