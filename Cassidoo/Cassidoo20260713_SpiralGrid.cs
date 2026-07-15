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

        var location = new { Row = (uint)0, Col = (uint)0 };
        var direction = Direction.Right;

        for (var i = 0; i <= n; i++)
        {
            // Add the number to the grid
            grid[location.Row, location.Col] = i.ToString();
            
            // Continue along the path
            location = new {
                Row = (uint) (location.Row + direction.YInc),
                Col = (uint) (location.Col + direction.XInc)
            };
            
            // If we're out of bounds or the new location is already in use, undo that last move then change direction
            if (location.Row >= dim ||
                location.Col >= dim ||
                !grid.ContainsPoint(location.Row, location.Col) ||
                grid[location.Row, location.Col] is not null)
            {
                location = new {
                    Row = (uint) (location.Row - direction.YInc),
                    Col = (uint) (location.Col - direction.XInc)
                };
                
                direction = direction.CollisionChange;
                location = new {
                    Row = (uint) (location.Row + direction!.YInc),
                    Col = (uint) (location.Col + direction.XInc)
                };
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