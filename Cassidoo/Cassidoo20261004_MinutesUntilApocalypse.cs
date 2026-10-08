using CsvHelper.Configuration.Attributes;

namespace Cassidoo;

public static class Cassidoo20261004_MinutesUntilApocalypse
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20261004.cs
    public static int MinutesUntilApocalypse(IEnumerable<IEnumerable<int>> map)
    {
        /*
            On Halloween night, a town is represented by a grid where 0 is an
            empty lot, 1 is a living person, and 2 is an infected zombie. Every
            minute, infection spreads to any living person directly above, below,
            left, or right of an infected zombie. Return the minimum number of
            minutes until no living people remain, or -1 if some people can never
            be reached.
         */
        
        var neighborhood = EnumerableToIntArray(map);
        var bounds = new Bounds(0, neighborhood.Length, 0, neighborhood[0].Length);
        
        // Check for the unreachables
        for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
                if (!IsReachable(neighborhood, bounds, x, y))
                    return -1;

        var minute = 0;
        var humans = true;
        
        while (humans)
        {
            // See if there are still humans around
            humans = false;
            for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
                if (!humans && IsHuman(neighborhood, bounds, x, y))
                    humans = true;
            
            for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
            {
                // Skip over anything that isn't a zombie
                if (neighborhood[x][y] != 2)
                    continue;
                
                var neighbors = new List<Tuple<int, int>>
                {
                    new(x, y+1),
                    new(x+1, y),
                    new(x, y-1),
                    new(x-1, y),
                };

                // Infect nearby humans, but set them to a new value
                foreach (var neighbor in neighbors.Where(neighbor => neighbor.Item1 >= bounds.MinX &&
                                                                     neighbor.Item1 < bounds.MaxX &&
                                                                     neighbor.Item2 >= bounds.MinY &&
                                                                     neighbor.Item2 < bounds.MaxY &&
                                                                     neighborhood[neighbor.Item1][neighbor.Item2] == 1))
                {
                    neighborhood[neighbor.Item1][neighbor.Item2] = 3;
                }
            }
            
            // Update those 3s to 2s -- we have to do it here so they don't instantly spread everywhere
            for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
                if (neighborhood[x][y] == 3)
                    neighborhood[x][y] = 2;

            minute++;
        }
        
        return minute;
    }

    private static int[][] EnumerableToIntArray(IEnumerable<IEnumerable<int>> map)
    {
        var mapArray = map.ToArray();
        var neighborhood = new int[mapArray.Length][];
        
        for (var i = 0; i < mapArray.Length; i++)
            neighborhood[i] = [.. mapArray[i]];
        
        return neighborhood;
    }

    private static bool IsReachable(int[][] map, Bounds bounds, int x, int y) =>
        CheckNeighbors(map, bounds, x, y, 0);
    
    private static bool IsHuman(int[][] map, Bounds bounds, int x, int y) =>
        CheckNeighbors(map, bounds, x, y, 1);
    
    private static bool CheckNeighbors(int[][] map, Bounds bounds, int x, int y, int check)
    {
        var neighbors = new List<Tuple<int, int>>
        {
            new(x, y+1),
            new(x+1, y),
            new(x, y-1),
            new(x-1, y),
        };

        return neighbors
            .Where(neighbor => 
                neighbor.Item1 >= bounds.MinX &&
                neighbor.Item1 < bounds.MaxX &&
                neighbor.Item2 >= bounds.MinY &&
                neighbor.Item2 < bounds.MaxY)
            .Any(neighbor => map[neighbor.Item1][neighbor.Item2] != check);
    }
    
    private record Bounds(int MinX, int MaxX, int MinY, int MaxY);
}
