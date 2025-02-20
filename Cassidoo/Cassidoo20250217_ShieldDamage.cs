using System.Diagnostics.CodeAnalysis;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Cassidoo20250217_ShieldDamage
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20250217.cs
    public static int FindShieldBreak(IEnumerable<int> hits, int shieldTotal)
    {
        var sum = 0;
        
        foreach (var (hit, index) in hits.Select((v, i) => (v, i)))
        {
            sum += hit;
            
            if (sum >= shieldTotal)
                return index;
        }

        return -1;
    }
}