using System.Diagnostics.CodeAnalysis;

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
        var grid = new Grid<int>(dim);

        return grid.ToString();
    }

    private class Grid<T>(uint gridSize) where T : notnull
    {
        private readonly T[,] _grid = new T[gridSize, gridSize];

        public T this[int x, int y]
        {
            get => _grid[x, y];
            set => _grid[x, y] = value;
        }

        public override string ToString()
        {
            var largest = _grid
                .Cast<T>()
                .OrderByDescending(item => item.ToString().Length)
                .First()
                .ToString();
            var size = largest.Length + 1;
            
            // easier to do INumber
            // but might be worth Grid<T> and SquareGrid<T>:Grid<T> for future?
            
            return string.Empty;
        }
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