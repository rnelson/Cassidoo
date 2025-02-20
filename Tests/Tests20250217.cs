using Cassidoo;

namespace Tests;

public class Tests20250217
{
    [Theory]
    [InlineData(2, new[] {10, 20, 30, 40}, 50)]
    [InlineData(-1, new[] {1, 2, 3, 4}, 20)]
    [InlineData(0, new[] {50}, 30)]
    public void Test(int expected, IEnumerable<int> hits, int shieldTotal)
    {
        var actual = Cassidoo20250217_ShieldDamage.FindShieldBreak(hits, shieldTotal);
        
        Assert.Equal(expected, actual);
    }
}