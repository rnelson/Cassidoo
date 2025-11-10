using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20251110_Merge
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20251110.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static char[] Merge(char[] a, char[] b)
    {
        var pt = FindEnd(a);
        var newLen = pt + b.Length;
        
        return newLen > a.Length
            ? throw new ArgumentOutOfRangeException(nameof(b))
            : Sort(Merge(a, b, pt), newLen);
    }

    private static int FindEnd(char[] array, char?[]? options = null)
    {
        options ??= [(char)0, '0', null, ' '];
        if (array.Length == 0) return -1;

        var result = array.Length - 1;
        while (options.Contains(array[result]) && result >= -1)
            result--;
        
        return result + 1;
    }

    private static char[] Merge(char[] a, char[] b, int start)
    {
        var result = a.Clone() as char[];
        for (int i = start, j = 0; j < b.Length; i++, j++)
            result![i] = b[j];

        return result!;
    }

    private static char[] Sort(char[] array, int? end = null)
    {
        end ??= -1;

        // Grab the elements we actually care about and sort them
        var elements = array
            .Take(end ?? 0)
            .ToArray();
        Array.Sort(elements);

        if (end < 0 || end >= array.Length)
            return elements;
        
        // If there are 0/'0'/null/' ' characters at the end, put them back
        var theEnd = array.TakeLast(array.Length - (end ?? 0)).ToArray();
        return elements.Concat(theEnd).ToArray();
    }
}
