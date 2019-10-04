using System;

namespace Minesweeper
{
    static class Program
    {
        static void Main(string[] args)
        {
            var mineBoard = new[,] {{"."}};
            var game = new Game(mineBoard);
            var board = game.GetMinesweeperBoard();
            Console.WriteLine(board);
        }
    }
}
