using Cassidoo;

namespace Tests;

public class Tests20241202
{
    [Theory]
    [InlineData(
        new[] { "Amine","Cassidy","Tenzy" },
        new[] { "yzneT","ydissaC","enimA" })]
    [InlineData(
        new[] { "Blitzen","Comet","Cupid","Dancer","Dasher","Donner","Prancer","Rudolph","Vixen" },
        new[] { "rennoD","nexiV","recnarP","temoC","neztilB","recnaD","dipuC","rehsaD","hploduR" })]
    [InlineData(
        new[] { "A","B","C" }, 
        new[] { "A","B","C" })]
    public void Test(IEnumerable<string> expected, IEnumerable<string> input)
    {
        var real = expected.ToArray();
        var actual = Cassidoo20241202_ReindeerNames.RollCall(input).ToArray();
        
        Assert.Equal(real.Length, actual.Length);
        
        for (var i = 0; i < real.Length; i++)
            Assert.Equal(real[i], actual[i]);
    }

/*
    rnelson@krang:~/dev/cassidoo $ ./test.sh Tests20241202
    Restore complete (6.2s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (3.0s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (1.2s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.03] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.0)
    [xUnit.net 00:00:00.83]   Discovering: Tests
    [xUnit.net 00:00:01.33]   Discovered:  Tests
    [xUnit.net 00:00:01.39]   Starting:    Tests
    [xUnit.net 00:00:02.03]   Finished:    Tests
      Tests test succeeded (9.9s)

    Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0, duration: 9.8s
    Build succeeded in 23.7s
    rnelson@krang:~/dev/cassidoo $
*/
}