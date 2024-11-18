using Cassidoo;

namespace Tests;

public class Tests20241118
{
    [Theory]
    [InlineData(5, new[] {7, 1, 5, 3, 6, 4})]
    [InlineData(0, new[] {7, 6, 4, 3, 1})]
    public void Test(int expected, IEnumerable<int> prices)
    {
        var actual = Cassidoo20241118_MaxTheStock.MaxTheStock(prices);
        Assert.Equal(expected, actual);
    }
}

/*
   rnelson@splinter Cassidoo % ./test.sh Tests20241118
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