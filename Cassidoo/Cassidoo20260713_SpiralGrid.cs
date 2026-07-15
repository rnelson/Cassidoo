using System.Diagnostics.CodeAnalysis;
using Cassidoo.Collections;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Local")]
[SuppressMessage("ReSharper", "InvertIf")]
public static class Cassidoo20260713_SpiralGrid
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260713.cs
    public static string SpiralGrid(int n)
    {
        Direction.Right.CollisionChange = Direction.Down;
        Direction.Down.CollisionChange = Direction.Left;
        Direction.Left.CollisionChange = Direction.Up;
        Direction.Up.CollisionChange = Direction.Right;
        
        var dim = (uint)Math.Ceiling(Math.Sqrt(n + 1));
        var grid = new SquareStringGrid(dim);

        var location = new { Row = 0, Col = 0 };
        var direction = Direction.Right;

        for (var i = 0; i <= n; i++)
        {
            // Add the new value to the grid and set our next coordinates
            grid[location.Row, location.Col] = i.ToString();
            location = new { Row = location.Row + direction.YInc, Col = location.Col + direction.XInc };
            
            // Check grid bounds and new location in use
            if (!grid.ContainsPoint(location.Row, location.Col) ||
                grid[location.Row, location.Col] is not null)
            {
                // Undo that last move
                location = new { Row = location.Row - direction.YInc, Col = location.Col - direction.XInc };
                
                // Change direction, following the spiral
                direction = direction.CollisionChange;
                
                // Make a new move in the right direction
                location = new { Row = location.Row + direction!.YInc, Col = location.Col + direction.XInc };
            }
        }

        return grid.ToString();
    }

    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    private class DirectionalDetail(short xInc, short yInc, DirectionalDetail? collisionChange = null)
    {
        public short XInc { get; set; } = xInc;
        public short YInc { get; set; } = yInc;
        public DirectionalDetail? CollisionChange { get; set; } = collisionChange;
    }

    private static class Direction
    {
        public static readonly DirectionalDetail Right = new(1, 0);
        public static readonly DirectionalDetail Down = new(0, 1);
        public static readonly DirectionalDetail Left = new(-1, 0);
        public static readonly DirectionalDetail Up = new(0, -1);
    }
}