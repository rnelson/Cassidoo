using Cassidoo.Extensions;

namespace Cassidoo;

public static class Cassidoo20261004_MinutesUntilApocalypse
{
    private record Bounds(int MinX, int MaxX, int MinY, int MaxY);

    private enum CellCreatureType
    {
        Human = 1,
        Zombie = 2,
        InfectedHuman = 3
    }
    
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20261004.cs
    public static int MinutesUntilApocalypse(IEnumerable<IEnumerable<int>> map)
    {
        var neighborhood = map.ToTwoDimensionalNumericArray();
        var bounds = new Bounds(0, neighborhood.Length, 0, neighborhood[0].Length);
        var minute = 0;
        var humans = true;
        
        // Check for the unreachables. If a single cell has a moat of empty locations, that human
        // will never be infected.
        for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
                if (!IsReachable(neighborhood, bounds, x, y) && neighborhood[x][y] == (int)CellCreatureType.Human)
                    return -1;
        
        while (humans)
        {
            // See if there are still humans around. No humans = done.
            humans = AreThereHumans(neighborhood, bounds);
            if (!humans)
                break;
            
            // Sort out this minute's infections.
            for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
            {
                // Skip over anything that isn't a zombie.
                if (neighborhood[x][y] != (int)CellCreatureType.Zombie)
                    continue;

                // Infect nearby humans, but set them to a temporary unused value.
                foreach (var neighbor in GetNeighbors(x, y)
                             .Where(neighbor => neighbor.Item1 >= bounds.MinX &&
                                                neighbor.Item2 >= bounds.MinY &&
                                                neighbor.Item2 < bounds.MaxY &&
                                                neighborhood[neighbor.Item1][neighbor.Item2] == (int)CellCreatureType.Human))
                    neighborhood[neighbor.Item1][neighbor.Item2] = (int)CellCreatureType.InfectedHuman;
            }
            
            // Update those infected humans to zombies.
            for (var x = bounds.MinX; x < bounds.MaxX; x++)
            for (var y = bounds.MinY; y < bounds.MaxY; y++)
                if (neighborhood[x][y] == (int)CellCreatureType.InfectedHuman)
                    neighborhood[x][y] = (int)CellCreatureType.Zombie;

            minute++;
        }
        
        return minute;
    }

    private static bool AreThereHumans(int[][] neighborhood, Bounds bounds)
    {
        var humans = false;
        
        for (int x = bounds.MinX, y = bounds.MinY; x < bounds.MaxX && y < bounds.MaxY; x++, y++)
            if (!humans && neighborhood[x][y] == 1)
                humans = true;

        return humans;
    }
    
    private static List<Tuple<int, int>> GetNeighbors(int x, int y) =>
    [
        new(x, y + 1),
        new(x + 1, y),
        new(x, y - 1),
        new(x - 1, y)
    ];
    
    private static bool IsReachable(int[][] map, Bounds bounds, int x, int y)
    {
        return GetNeighbors(x, y)
            .Where(neighbor => 
                neighbor.Item1 >= bounds.MinX &&
                neighbor.Item1 < bounds.MaxX &&
                neighbor.Item2 >= bounds.MinY &&
                neighbor.Item2 < bounds.MaxY)
            .Any(neighbor => map[neighbor.Item1][neighbor.Item2] != (int)CellCreatureType.Human);
    }
}
