using System.Diagnostics.CodeAnalysis;
using Cassidoo;

namespace Tests;

[SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible")]
public class Tests20261004
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int expected, IEnumerable<IEnumerable<int>> map)
    {
        var actual = Cassidoo20261004_MinutesUntilApocalypse.MinutesUntilApocalypse(map);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<Tuple<int, IEnumerable<IEnumerable<int>>>> TestData = new List<Tuple<int, IEnumerable<IEnumerable<int>>>>
        {
            new(4, [[2, 1, 1], [1, 1, 0], [0, 1, 1]]),
            new(-1, [[2, 1, 1], [0, 1, 1], [1, 0, 1]]),
        };
}
