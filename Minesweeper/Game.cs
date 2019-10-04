namespace Minesweeper
{
    public class Game
    {
        private const string Mine = "*";
        private readonly string[,] _mineArray;
        private readonly int _numRows;
        private readonly int _numCols;

        public Game(string[,] inputMineBoard)
        {
            _mineArray = inputMineBoard;
            _numRows = _mineArray.GetLength(0);
            _numCols = _mineArray.GetLength(1);
        }

        public string[,] GetMinesweeperBoard()
        {
            var result = new string[_numRows, _numCols];
            for (var row = 0; row < _numRows; row++)
            {
                for (var col = 0; col < _numCols; col++)
                {
                    result[row, col] = IsMine(row, col) ? Mine : GetMineCount(row, col).ToString();
                }
            }
            return result;
        }

        private int GetMineCount(int row, int col)
        {
            var count = 0;

            for (var r = row - 1; r <= row + 1; r++)
            {
                for (var c = col - 1; c <= col + 1; c++)
                {
                    if (IsMine( r, c))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private bool IsMine(int row, int col)
        {
            return IsOnBoard(row, col) && _mineArray[row, col] == Mine;
        }

        private bool IsOnBoard(int row, int col)
        {
            return row >= 0 && col >= 0 && row < _numRows && col < _numCols;
        }
    }
}
