using System.Diagnostics.CodeAnalysis;
using Cassidoo;

namespace Tests;

[SuppressMessage("Performance", "CA1861:Avoid constant arrays as arguments")]
public class Tests20240603
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 2}, new[] {2, 2, 4})]
    [InlineData(new[] { 7, 8, 1, 0, 2, 5 }, new[] {0, 2, 8})]
    [InlineData(new[] { 11, 13, 15 }, new int[] {})]
    public void TestSquares(int[] numbers, int[] expected)
    {
        var actual = Cassidoo20240603_OnlyEvens.onlyEvens(numbers);
        Assert.Equal(expected, actual);
    }
}

/*
    rnelson@reject:/home/rnelson/dev/cassidoo $ ./test.sh Tests20240603
    Test run for /usr/home/rnelson/dev/cassidoo/Tests/bin/Debug/net8.0/Tests.dll (.NETCoreApp,Version=v8.0)
    Starting test execution, please wait...
    A total of 1 test files matched the specified pattern.
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 8.0.6)
    [xUnit.net 00:00:00.28]   Discovering: Tests
    [xUnit.net 00:00:00.33]   Discovered:  Tests
    [xUnit.net 00:00:00.33]   Starting:    Tests
    [xUnit.net 00:00:00.39]   Finished:    Tests
      Passed Tests.Tests20240603.TestSquares(numbers: [11, 13, 15], expected: []) [6 ms]
      Passed Tests.Tests20240603.TestSquares(numbers: [1, 2, 3, 4, 5, ...], expected: [2, 2, 4]) [1 ms]
      Passed Tests.Tests20240603.TestSquares(numbers: [7, 8, 1, 0, 2, ...], expected: [0, 2, 8]) [< 1 ms]

    Test Run Successful.
    Total tests: 3
         Passed: 3
     Total time: 0.9217 Seconds
    rnelson@reject:/home/rnelson/dev/cassidoo $
 */