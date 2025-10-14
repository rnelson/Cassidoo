using Cassidoo;

namespace Tests;

public class Tests20251013
{
    [Theory]
    [InlineData("name,age,city\\n\"Ryu, Mi-yeong\",30,\"Seoul\"\\nZoey,24,\"Burbank\"", new[] {"Ryu, Mi-yeong, age 30, from Seoul", "Zoey, age 24, from Burbank"})]
    public void Test(string input, IEnumerable<string> expected)
    {
        var actual = Cassidoo20251013_CsvToList.CsvToList(input);
        Assert.Equal(expected, actual);
    }
}
