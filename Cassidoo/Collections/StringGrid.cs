using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cassidoo.Collections;

public class StringGrid
{
    private readonly string?[] _grid;
    private readonly uint _rows;
    private readonly uint _columns;

    public StringGrid(uint rows, uint columns)
    {
        _rows = rows;
        _columns = columns;
        _grid = new string[_rows * _columns];
        
        for (uint row = 0; row < _rows; row++)
        for (uint col = 0; col < _columns; col++)
            _grid[GetIndex(row, col)] = null;
    }

    public string? this[uint row, uint col]
    {
        get => _grid[GetIndex(row, col)];
        set => _grid[GetIndex(row, col)] = value;
    }
    
    public bool ContainsPoint(uint row, uint col) => row < _columns && col < _rows;

    public override string ToString()
    {
        var largest = 0;
        for (uint row = 0; row < _rows; row++)
        for (uint col = 0; col < _columns; col++)
            if (_grid[GetIndex(row, col)] is not null && _grid[GetIndex(row, col)]?.Length > largest)
                largest = _grid[GetIndex(row, col)]!.Length;

        var size = largest > 0 ? largest : 0;
        var sb = new StringBuilder();

        for (uint row = 0; row < _rows; row++)
        {
            for (uint col = 0; col < _columns; col++)
            {
                if (_grid[GetIndex(row, col)] is not null)
                {
                    sb.Append(_grid[GetIndex(row, col)]!.PadLeft(size));

                    if (col + 1 < _columns)
                        sb.Append(' ');
                }
                else
                {
                    for (var i = 0; i < size + 1; i++)
                        sb.Append(' ');
                }
            }

            sb.Append('\n');
        }

        return sb.ToString().TrimEnd();
    }

    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    protected uint GetIndex(uint row, uint col) => row * _columns + col;
}

public class SquareStringGrid(uint gridSize) : StringGrid(gridSize, gridSize)
{
    private readonly uint _gridSize = gridSize;
}