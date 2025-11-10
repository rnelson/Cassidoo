using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

/*
This week's question:
You are given two sorted arrays, a and b, where a has a large enough size buffer at the end to 
hold b (which can be spaces, zeroes, or nulls). Write a function to merge b into a in sorted order.

Example:

let a = [1, 3, 5, 0, 0, 0];
let b = [2, 4, 6];

> merge(a, b)
> [1, 2, 3, 4, 5, 6]

 */

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20251110_Merge
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20251110.cs
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static char[] Merge(char[] a, char[] b)
    {
        var pt = FindEnd(a);
        return pt + b.Length > a.Length
            ? throw new ArgumentOutOfRangeException(nameof(b))
            : Sort(Merge(a, b, pt), pt + b.Length);
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

        var elements = array
            .Take(end ?? 0)
            .ToArray();
        Array.Sort(elements);

        if (end >= 0 && end < array.Length)
        {
            var theEnd = array.TakeLast(array.Length - (end ?? 0)).ToArray();
            return elements.Concat(theEnd).ToArray();
        }
        
        return elements;
    }
}
