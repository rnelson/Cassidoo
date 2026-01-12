using Cassidoo;

namespace Tests;

public class Tests20260112
{
    [Fact]
    public void Test()
    {
        var expected = new[] { "Chicago", "Winnie" };
        var actual = Cassidoo20260112_HungryBears.HungryBears(Cassidoo20260112_HungryBears.TestBears).ToArray();
        Assert.Equal(expected, actual);
    }
}
