using Cassidoo;

namespace Tests;

public class Tests20251110
{
    [Theory]
    [InlineData(new[]{'1', '3', '5', '0', '0', '0'}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '5', '6'})]
    [InlineData(new[]{'1', '3', '0', '0', '0', '0'}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '6', '0'})]
    [InlineData(new[]{'1', '3', '0', '0', '0', (char)0}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '6', (char)0})]
    [InlineData(new[]{'1', '3', '0', '0', (char)0, '0'}, new[] {'2', '4', '6'}, new[]{'1', '2', '3', '4', '6', '0'})]
    [InlineData(new[]{'1', '3', '0', '0', '0', '0'}, new[] {'6'}, new[]{'1', '3', '6', '0', '0', '0'})]
    [InlineData(new[]{'1', '3', '0', (char)0, '0', '0'}, new[] {'6'}, new[]{'1', '3', '6', (char)0, '0', '0'})]
    [InlineData(new[]{'1', '3', '0', '0', (char)0, '0'}, new[] {'6'}, new[]{'1', '3', '6', '0', (char)0, '0'})]
    [InlineData(new[]{'1', (char)0, ' ', '0', (char)0, '0'}, new[] {'6'}, new[]{'1', '6', ' ', '0', (char)0, '0'})]
    [InlineData(new[]{'1', '3', '0', ' ', (char)0, '0'}, new[] {'6'}, new[]{'1', '3', '6', ' ', (char)0, '0'})]
    public void Test(char[] a, char[] b, char[] expected)
    {
        var actual = Cassidoo20251110_Merge.Merge(a, b);
        Assert.Equal(expected, actual);
    }
}
