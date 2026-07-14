using System.Text;

namespace Cassidoo.Collections;

public class StringGrid
{
    private readonly string?[,] _grid;
    private readonly uint _rows;
    private readonly uint _columns;

    public StringGrid(uint rows, uint columns)
    {
        _rows = rows;
        _columns = columns;
        _grid = new string[_rows, _columns];
        
        for (var row = 0; row < _rows; row++)
        for (var col = 0; col < _columns; col++)
            _grid[row, col] = null;
    }

    public string? this[int x, int y]
    {
        get => _grid[x, y];
        set => _grid[x, y] = value;
    }

    public override string ToString()
    {
        var largest = 0;
        for (var row = 0; row < _rows; row++)
        for (var col = 0; col < _columns; col++)
            if (_grid[row, col] is not null && _grid[row, col]?.Length > largest)
                largest = _grid[row, col]!.Length;

        var size = largest > 0 ? largest + 1 : 0;

        var sb = new StringBuilder();
        
        for (var row = 0; row < _rows; row++)
        for (var col = 0; col < _columns; col++)
            if (_grid[row, col] is null)
            {
                for (var i = 0; i < size; i++) sb.Append(' ');
            }
            else
            {
                sb.Append(' ');
                sb.Append(_grid[row, col]);
            }
        
        return sb.ToString().TrimEnd();
    }
}

public class SquareStringGrid(uint gridSize) : StringGrid(gridSize, gridSize)
{
    private readonly uint _gridSize = gridSize;
}