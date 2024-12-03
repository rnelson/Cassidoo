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
}