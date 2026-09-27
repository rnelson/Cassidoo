using Cassidoo;

namespace Tests;

public class Tests20260921
{
    [Theory]
    [InlineData(2026, 9, new[]{"2026-09-06", "2026-09-13", "2026-09-20", "2026-09-27"})]
    [InlineData(2024, 2, new[]{"2024-02-04", "2024-02-11", "2024-02-18", "2024-02-25"})]
    public void Test(int year, int month, string[] expected)
    {
        var actual = Cassidoo20260921_GetSundays.GetSundays(year, month);
        Assert.Equal(expected, actual);
    }
}
