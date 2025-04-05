using Cassidoo;

namespace Tests;

public class Tests20250331
{
    [Theory]
    [InlineData(0, new[] {"12:00"})]
    [InlineData(120, new[] {"09:00", "11:00"})]
    [InlineData(360, new[] {"14:00", "09:00", "15:00", "10:30"})] // 210?
    [InlineData(240, new[] {"08:00", "10:00", "10:00", "14:00"})]
    public void Test(int expected, IEnumerable<string> times)
    {
        var actual = Cassidoo20250331_FindLongestTimeGap.FindLongestTimeGap(times);
        
        Assert.Equal(expected, actual);
    }
}