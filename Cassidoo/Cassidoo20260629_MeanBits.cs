using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
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