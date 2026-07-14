using System.Diagnostics.CodeAnalysis;
using Cassidoo.Collections;

namespace Cassidoo;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Local")]
public static class Cassidoo20260713_SpiralGrid
{
    // Tests: https://github.com/rnelson/Cassidoo/blob/main/Tests/Tests20260713.cs
    public static string SpiralGrid(int n)
    {
        var dim = (uint)Math.Ceiling(Math.Sqrt(n + 1));
        var grid = new SquareStringGrid(dim);

        var location = (0, 0);
        var direction = Direction.Right;

        for (var i = 0; i <= n; i++)
        {
            if (location.Item1 > dim || location.Item2 > dim || grid[location.Item1, location.Item2] is not null)
            {
                direction = direction.CollisionChange;
                location = (location.Item1 + direction!.XInc, location.Item2 + direction.YInc);
            }
            
            grid[location.Item1, location.Item2] = i.ToString();
            location = (location.Item1 + direction!.XInc, location.Item2 + direction.YInc);
        }

        return grid.ToString();
    }

    private class DirectionalDetail(short xInc, short yInc, DirectionalDetail? collisionChange = null)
    {
        public short XInc { get; set; } = xInc;
        public short YInc { get; set; } = yInc;
        public DirectionalDetail? CollisionChange { get; set; } = collisionChange;
    }

    private class Direction
    {
        public static readonly DirectionalDetail Right = new(1, 0);
        public static readonly DirectionalDetail Down = new(0, 1);
        public static readonly DirectionalDetail Left = new(-1, 0);
        public static readonly DirectionalDetail Up = new(0, -1);

        public Direction()
        {
            Right.CollisionChange = Down;
            Down.CollisionChange = Left;
            Left.CollisionChange = Up;
            Up.CollisionChange = Right;
        }
    }
}