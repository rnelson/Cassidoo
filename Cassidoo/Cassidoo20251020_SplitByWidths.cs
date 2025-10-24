using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20251020_SplitByWidths
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20251020.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static IEnumerable<string> SplitByWidths(string input, IEnumerable<int> widths)
    {
        if (!widths.Any())
            throw new ArgumentOutOfRangeException(nameof(widths), widths, "Must have at least one width");
        
        if (string.IsNullOrWhiteSpace(input))
            return [];

        var result = new List<string>();
        
        var w = new Stack<int>(widths.Reverse());
        var remaining = input;
        var currentWidth = w.Pop();

        while (!string.IsNullOrEmpty(remaining))
        {
            if (remaining.Length <= currentWidth)
            {
                result.Add(remaining);
                break;
            }
            
            result.Add(remaining.Substring(0, currentWidth));
            remaining = remaining.Substring(currentWidth);

            // We don't care about the success here; either it's updated or it stays the same.
            if (w.TryPop(out var newWidth))
                currentWidth = newWidth;
        }

        return result;
    }
}
