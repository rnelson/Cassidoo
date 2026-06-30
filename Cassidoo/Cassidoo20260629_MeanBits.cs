using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20260629_MeanBits
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260629.cs
    public static double NiceBits(int n) => MeanBits(n);
    
    public static double MeanBits(int n)
    {
        var sum = 1;
        
        for (var i = 1; i < n; i++)
        {
            sum += Convert.ToString(i, 2).Length;
        }

        return (double)sum / n;
    }
}

/*

This week's question:
Given a positive integer n, calculate the mean number of bits required to represent all integers from 0 to n-1 (where the bit count of 0 is 1). Return the result rounded to two decimal places.

Example:

> meanBits(6)
> 2.00

// Explanation
// 0: 1 bit, 1: 1 bit, 2: 2 bits, 3: 2 bits, 4: 3 bits, 5: 3 bits
// Mean = (1 + 1 + 2 + 2 + 3 + 3) / 6 = 2.00


*/