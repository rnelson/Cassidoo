using System.Diagnostics.CodeAnalysis;
using Cassidoo;

namespace Tests;

[SuppressMessage("Performance", "CA1861:Avoid constant arrays as arguments")]
public class Tests20240603
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 2}, new[] {2, 2, 4})]
    [InlineData(new[] { 7, 8, 1, 0, 2, 5 }, new[] {0, 2, 8})]
    [InlineData(new[] { 11, 13, 15 }, new int[] {})]
    public void TestSquares(int[] numbers, int[] expected)
    {
        var actual = Cassidoo20240603_OnlyEvens.onlyEvens(numbers);
        Assert.Equal(expected, actual);
    }
}