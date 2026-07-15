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
        _grid = new string[_columns, _rows];
        
        for (var row = 0; row < _rows; row++)
        for (var col = 0; col < _columns; col++)
            _grid[col, row] = null;
    }

    public string? this[int x, int y]
    {
        get => _grid[y, x];
        set => _grid[y, x] = value;
    }
    
    public bool ContainsPoint(int x, int y) => y < _rows && x < _columns && _grid[y, x] != null;

    public override string ToString()
    {
        var largest = 0;
        for (var row = 0; row < _rows; row++)
        for (var col = 0; col < _columns; col++)
            if (_grid[col, row] is not null && _grid[col, row]?.Length > largest)
                largest = _grid[col, row]!.Length;

        var size = largest > 0 ? largest + 1 : 0;

        var sb = new StringBuilder();

        for (var row = 0; row < _rows; row++)
        {
            for (var col = 0; col < _columns; col++)
                if (_grid[row, col] is not null)
                {
                    sb.Append(_grid[row, col]!.PadLeft(size));
                    sb.Append(' ');
                }
            
            var temp = sb.ToString().TrimEnd() + "\n";
            sb.Clear();
            sb.Append(temp);
        }

        return sb.ToString().TrimEnd();
    }
}

public class SquareStringGrid(uint gridSize) : StringGrid(gridSize, gridSize)
{
    private readonly uint _gridSize = gridSize;
}