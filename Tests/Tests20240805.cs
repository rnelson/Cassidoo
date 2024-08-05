using Cassidoo;

namespace Tests;

public class Tests20240805
{
    [Theory]
    [InlineData(5, 55)]
    [InlineData(10, 385)]
    [InlineData(25, 5525)]
    [InlineData(100, 338350)]
    public void TestSquares(int n, int expected)
    {
        var actual = Cassidoo20240805_SumOfSquares.SumSquares(n);
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(-25)]
    [InlineData(-100)]
    public void TestSquaresThrowsArgumentOutOfRangeException(int n)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Cassidoo20240805_SumOfSquares.SumSquares(n));
    }
}

/*
   rnelson@splinter Cassidoo % ./test.sh Tests20240805
   Test run for /Users/rnelson/dev/Cassidoo/Tests/bin/Debug/net8.0/Tests.dll (.NETCoreApp,Version=v8.0)
   Starting test execution, please wait...
   A total of 1 test files matched the specified pattern.
   [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 8.0.4)
   [xUnit.net 00:00:00.28]   Discovering: Tests
   [xUnit.net 00:00:00.30]   Discovered:  Tests
   [xUnit.net 00:00:00.30]   Starting:    Tests
   [xUnit.net 00:00:00.33]   Finished:    Tests
     Passed Tests.Tests20240805.TestSquaresThrowsArgumentOutOfRangeException(n: -25) [1 ms]
     Passed Tests.Tests20240805.TestSquaresThrowsArgumentOutOfRangeException(n: -1) [< 1 ms]
     Passed Tests.Tests20240805.TestSquaresThrowsArgumentOutOfRangeException(n: -100) [< 1 ms]
     Passed Tests.Tests20240805.TestSquares(n: 100, expected: 338350) [1 ms]
     Passed Tests.Tests20240805.TestSquares(n: 10, expected: 385) [< 1 ms]
     Passed Tests.Tests20240805.TestSquares(n: 25, expected: 5525) [< 1 ms]
     Passed Tests.Tests20240805.TestSquares(n: 5, expected: 55) [< 1 ms]
   
   Test Run Successful.
   Total tests: 7
        Passed: 7
    Total time: 0.7704 Seconds
   rnelson@splinter Cassidoo %
 */