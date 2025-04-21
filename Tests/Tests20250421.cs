using Cassidoo;
using Xunit.Abstractions;

namespace Tests;

public class Tests20250421(ITestOutputHelper testOutputHelper)
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string recipeName, uint targetServings, IDictionary<string, uint> ingredients, IDictionary<string, uint> expected)
    {
        testOutputHelper.WriteLine($"Checking recipe {recipeName}");
        var actual =
            Cassidoo20250421_CalculateIngredients.CalculateIngredients(ingredients, targetServings);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                "Cassidoo Test Recipe",
                3,
                new Dictionary<string, uint> { { "flour", 200 }, { "sugar", 100 }, { "eggs", 2 } },
                new Dictionary<string, uint> {{"flour", 600}, {"sugar", 300}, {"eggs", 6}}
            },
            new object[]
            {
                /* This is based on the Urban Legend about Neiman Marcus charging $25,000 for
                 their cookie recipe.  No one knows the source, but the recipe does make good
                 cookies and a LOT of them.  Recipe is in Public Domain. */
                "ioccc.org $25,000 cookies",
                1,
                new Dictionary<string, uint>
                {
                    {"butter", 2 /* cup */},
                    {"salt", 1 /* tsp */},
                    {"sugar", 2 /* cup */},
                    {"baking powder", 2 /* tsp */},
                    {"brown sugar", 2 /* cup */},
                    {"baking soda", 2 /* tsp */},
                    {"eggs", 4},
                    {"chocolate chips", 4 /* oz */},
                    {"vanilla", 2 /* tsp */},
                    {"Hershey bar, grated", 1 /* 8oz bar */},
                    {"flour", 4 /* cup */},
                    {"chopped nuts", 3 /* cup */},
                    {"blended oatmeal", 5 /* cup */ /* Measure and blend in a blender to a fine powder. */ }
                },
                new Dictionary<string, uint>
                {
                    {"butter", 2 /* cup */},
                    {"salt", 1 /* tsp */},
                    {"sugar", 2 /* cup */},
                    {"baking powder", 2 /* tsp */},
                    {"brown sugar", 2 /* cup */},
                    {"baking soda", 2 /* tsp */},
                    {"eggs", 4},
                    {"chocolate chips", 4 /* oz */},
                    {"vanilla", 2 /* tsp */},
                    {"Hershey bar, grated", 1 /* 8oz bar */},
                    {"flour", 4 /* cup */},
                    {"chopped nuts", 3 /* cup */},
                    {"blended oatmeal", 5 /* cup */ /* Measure and blend in a blender to a fine powder. */ }
                }
            },
            new object[]
            {
                /* This is based on the Urban Legend about Neiman Marcus charging $25,000 for
                 their cookie recipe.  No one knows the source, but the recipe does make good
                 cookies and a LOT of them.  Recipe is in Public Domain. */
                "ioccc.org $25,000 cookies",
                6,
                new Dictionary<string, uint>
                {
                    {"butter", 2 /* cup */},
                    {"salt", 1 /* tsp */},
                    {"sugar", 2 /* cup */},
                    {"baking powder", 2 /* tsp */},
                    {"brown sugar", 2 /* cup */},
                    {"baking soda", 2 /* tsp */},
                    {"eggs", 4},
                    {"chocolate chips", 4 /* oz */},
                    {"vanilla", 2 /* tsp */},
                    {"Hershey bar, grated", 1 /* 8oz bar */},
                    {"flour", 4 /* cup */},
                    {"chopped nuts", 3 /* cup */},
                    {"blended oatmeal", 5 /* cup */ /* Measure and blend in a blender to a fine powder. */ }
                },
                new Dictionary<string, uint>
                {
                    {"butter", 12 /* cup */},
                    {"salt", 6 /* tsp */},
                    {"sugar", 12 /* cup */},
                    {"baking powder", 12 /* tsp */},
                    {"brown sugar", 12 /* cup */},
                    {"baking soda", 12 /* tsp */},
                    {"eggs", 24},
                    {"chocolate chips", 24 /* oz */},
                    {"vanilla", 12 /* tsp */},
                    {"Hershey bar, grated", 6 /* 8oz bar */},
                    {"flour", 24 /* cup */},
                    {"chopped nuts", 18 /* cup */},
                    {"blended oatmeal", 30 /* cup */ /* Measure and blend in a blender to a fine powder. */ }
                }
            },
        };
}

/*
    [rnelson@roto cassidoo]$ ./test.sh Tests20250421
    Restore complete (0.6s)
        Determining projects to restore...
        All projects are up-to-date for restore.
      Cassidoo succeeded (0.2s) → Cassidoo/bin/Debug/net9.0/Cassidoo.dll
      Tests succeeded (0.1s) → Tests/bin/Debug/net9.0/Tests.dll
    [xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.8.2+699d445a1a (64-bit .NET 9.0.4)
    [xUnit.net 00:00:00.06]   Discovering: Tests
    [xUnit.net 00:00:00.11]   Discovered:  Tests
    [xUnit.net 00:00:00.12]   Starting:    Tests
    [xUnit.net 00:00:00.20]   Finished:    Tests
      Tests test succeeded (1.0s)

    Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0, duration: 1.0s
    Build succeeded in 2.2s
    [rnelson@roto cassidoo]$
*/