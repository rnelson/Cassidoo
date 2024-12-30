using Cassidoo;

namespace Tests;

public class Tests20241230
{
    [Theory]
    [InlineData("Wednesday", 2025)]
    [InlineData("Monday", 2024)]
    public void Test(string expected, int year)
    {
        var actual = Cassidoo20241230_NewYearsDay.NewYearsDay(year);
        
        Assert.Equal(expected, actual);
    }
}