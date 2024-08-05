using Cassidoo;

namespace Tests;

public class Tests20240701
{
    [Fact]
    public void TestSample()
    {
        var stand = new Cassidoo20240701_FruitStand();

        // Add fruits to the stand
        stand.AddFruit("apple", 10, 0.5);
        stand.AddFruit("banana", 5, 0.2);
        stand.AddFruit("cherry", 20, 0.1);

        // Update the quantity of an existing fruit
        stand.UpdateQuantity("banana", 10);

        // Calculate the total value of all fruits in the stand
        Assert.Equal(9, stand.GetTotalValue());
    }
}

/*
    rnelson@reject:/home/rnelson/dev/cassidoo $ ./test.sh Tests20210510  
    Test run for /usr/home/rnelson/dev/cassidoo/Tests/bin/Debug/net8.0/Tests.dll (.NETCoreApp,Version=v8.0)
    Starting test execution, please wait...
    A total of 1 test files matched the specified pattern.
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 8.0.6)
    [xUnit.net 00:00:00.31]   Discovering: Tests
    [xUnit.net 00:00:00.37]   Discovered:  Tests
    [xUnit.net 00:00:00.38]   Starting:    Tests
    [xUnit.net 00:00:00.43]   Finished:    Tests
      Passed Tests.Tests20210510.TestSameDigits(n: 1, expected: True) [8 ms]
      Passed Tests.Tests20210510.TestSameDigits(n: 251895, expected: False) [< 1 ms]
      Passed Tests.Tests20210510.TestSameDigits(n: 10, expected: True) [< 1 ms]
      Passed Tests.Tests20210510.TestSameDigits(n: 251894, expected: True) [< 1 ms]

    Test Run Successful.
    Total tests: 4
         Passed: 4
     Total time: 0.9837 Seconds
    rnelson@reject:/home/rnelson/dev/cassidoo $
 */