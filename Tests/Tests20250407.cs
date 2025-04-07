using Cassidoo;

namespace Tests;

public class Tests20250407
{
    [Theory]
    [InlineData(1, new[] {8L})]
    [InlineData(5, new[] {8L, 17L, 32L, 54L, 57L})]
    [InlineData(14, new[] {8L, 17L, 32L, 54L, 57L, 100L, 145L, 177L, 320L, 368L, 512L, 593L, 945L, 1124L})]
    [InlineData(41, new[]
    {
        8L, 17L, 32L, 54L, 57L, 100L, 145L, 177L, 320L, 368L, 512L, 593L, 945L, 1124L,
        1649L, 2169L, 2530L, 4240L, 5392L, 6250L, 7073L, 8361L, 16580L, 18785L, 20412L,
        23401L, 32993L, 60049L, 65792L, 69632L, 93312L, 94932L, 131361L, 178478L, 262468L,
        268705L, 397585L, 423393L, 524649L, 533169L, 1048976L
    })]
    public void Test(int size, IEnumerable<long> expected)
    {
        var expectedSpan = new ReadOnlySpan<long>(expected.ToArray());
        var actual = Cassidoo20250407_GetLelandNumbers
            .GetLelandNumbers()
            .Take(size)
            .Order()
            .ToArray();
        
        Assert.Equal(expectedSpan, actual);
    }
}