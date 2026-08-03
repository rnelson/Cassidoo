using Cassidoo;

namespace Tests;

public class Tests20260803
{
    [Theory]
    [InlineData(new[]{"C", "D", "E", "F", "G", "H"},
        new uint[]{3, 0, 4, 1, 2, 5},
        new[]{"D", "F", "G", "C", "E", "H"})]
    public void Test(string[] values, uint[] indexes, string[] expected)
    {
        var actual = Cassidoo20260803_Reorder.Reorder(values, indexes).ToArray();
        Assert.Equal(expected, actual);
    }
}
