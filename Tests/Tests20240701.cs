using Cassidoo;

namespace Tests;

public class Tests20240701
{
    [Fact]
    public void TestSample()
    {
        var stand = new Cassidoo20240701_FruitStand();

        // Add fruits to the stand
        stand.addFruit("apple", 10, 0.5);
        stand.addFruit("banana", 5, 0.2);
        stand.addFruit("cherry", 20, 0.1);

        // Update the quantity of an existing fruit
        stand.updateQuantity("banana", 10);

        // Calculate the total value of all fruits in the stand
        Assert.Equal(9, stand.totalValue());
    }
}