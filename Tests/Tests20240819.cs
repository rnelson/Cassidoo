using Cassidoo;

namespace Tests;

public class Tests20240819
{
    [Fact]
    public void Test()
    {
        var events = new List<Cassidoo20240819_CalculateExecutionTimes.Cassidoo20240819_Event>
        {
            new("main", 0, "start"),
            new("subTask1", 5, "start"),
            new("subTask1", 10, "end"),
            new("subTask2", 15, "start"),
            new("subTask2", 20, "end"),
            new("main", 25, "end"),
        };
        
        var expected = new[]
        {
            new Tuple<string, int>("main", 25),
            new Tuple<string, int>("subTask1", 5),
            new Tuple<string, int>("subTask2", 5),
        };

        var actual = Cassidoo20240819_CalculateExecutionTimes.CalculateExecutionTimes(events);

        Assert.Equal(expected.Length, actual.Count);
        foreach (var expectedTuple in expected)
        {
            Assert.Contains(actual, tuple =>
                tuple.Item1.Equals(expectedTuple.Item1) &&
                tuple.Item2 == expectedTuple.Item2);
        }
    }
}

/*
   rnelson@splinter Cassidoo % ./test.sh Tests20240819
   Test run for /Users/rnelson/dev/Cassidoo/Tests/bin/Debug/net8.0/Tests.dll (.NETCoreApp,Version=v8.0)
   Starting test execution, please wait...
   A total of 1 test files matched the specified pattern.
   [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 8.0.4)
   [xUnit.net 00:00:01.51]   Discovering: Tests
   [xUnit.net 00:00:01.54]   Discovered:  Tests
   [xUnit.net 00:00:01.54]   Starting:    Tests
   [xUnit.net 00:00:01.57]   Finished:    Tests
     Passed Tests.Tests20240819.Test [3 ms]
   
   Test Run Successful.
   Total tests: 1
        Passed: 1
    Total time: 2.1005 Seconds
   rnelson@splinter Cassidoo %
 */