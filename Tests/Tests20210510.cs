using Cassidoo;

namespace Tests;

public class Tests20210510
{
    [Theory]
    [InlineData(1, true)]
    [InlineData(10, true)]
    [InlineData(251894, true)]
    [InlineData(251895, false)]
    public void TestSameDigits(int n, bool expected)
    {
        var actual = Cassidoo20210510_SameDigits.SameDigits(n);
        Assert.Equal(expected, actual);
    }
}

/*
    rnelson@reject:/home/rnelson/dev/cassidoo $ ./test.sh Tests20210510
    Test run for /usr/home/rnelson/dev/cassidoo/Tests/bin/Debug/net8.0/Tests.dll (.NETCoreApp,Version=v8.0)
    Starting test execution, please wait...
    A total of 1 test files matched the specified pattern.
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 8.0.6)
    [xUnit.net 00:00:00.25]   Discovering: Tests
    [xUnit.net 00:00:00.29]   Discovered:  Tests
    [xUnit.net 00:00:00.29]   Starting:    Tests
    [xUnit.net 00:00:00.34]   Finished:    Tests
      Passed Tests.Tests20210510.TestSameDigits(n: 1, expected: True) [8 ms]
      Passed Tests.Tests20210510.TestSameDigits(n: 251895, expected: False) [< 1 ms]
      Passed Tests.Tests20210510.TestSameDigits(n: 10, expected: True) [< 1 ms]
      Passed Tests.Tests20210510.TestSameDigits(n: 251894, expected: True) [< 1 ms]

    Test Run Successful.
    Total tests: 4
         Passed: 4
     Total time: 0.8423 Seconds
    rnelson@reject:/home/rnelson/dev/cassidoo $
 */