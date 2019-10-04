using Minesweeper;
using NUnit.Framework;

namespace MinesweeperTests
{
    public class GameTests
    {
        [Test]
        public void EmptyMineBoard_ReturnsAZero_GivenOneSquare()
        {
            var mineBoard = new[,] {{"."}};
            var game = new Game(mineBoard);

            var resultBoard = game.GetMinesweeperBoard();
            Assert.That(resultBoard, Is.EquivalentTo(new [,] {{ "0" }}));
        }

        [Test]
        public void EmptyMineBoard_ReturnsAllZeros_GivenMultipleSquares()
        {
            var mineBoard = new[,] {{".", ".", "."}, {".", ".", "."}};
            var game = new Game(mineBoard);

            var resultBoard = game.GetMinesweeperBoard();
            Assert.That(resultBoard, Is.EquivalentTo(new [,] {{"0", "0", "0"}, {"0", "0","0"}}));
        }

        [Test]
        public void FullMineBoard_ReturnsAMine_GivenOneSquare()
        {
            var mineBoard = new[,] {{"*"}};
            var game = new Game(mineBoard);

            var resultBoard = game.GetMinesweeperBoard();
            Assert.That(resultBoard, Is.EquivalentTo(new [,] {{ "*" }}));
        }

        [Test]
        public void FullMineBoard_ReturnsAllMines_GivenMultipleSquares()
        {
            var mineBoard = new[,] {{"*", "*", "*"}, {"*", "*", "*"}};
            var game = new Game(mineBoard);

            var resultBoard = game.GetMinesweeperBoard();
            Assert.That(resultBoard, Is.EquivalentTo(new [,] {{"*", "*", "*"}, {"*", "*", "*"}}));
        }

        [Test]
        public void SmallMixedBoard_ReturnsMineAndCountsWithNoZeros()
        {
            var mineBoard = new[,] {{"*", "."}, {".", "."}};
            var game = new Game(mineBoard);

            var resultBoard = game.GetMinesweeperBoard();
            Assert.That(resultBoard, Is.EquivalentTo(new [,] {{ "*", "1" }, {"1", "1"}}));
        }

        [Test]
        public void LargeMixedBoard_ReturnsMineAndCounts()
        {
            var mineBoard = new[,] {{"*", ".", ".", "."}, {".", "*", ".", "."}, {".", ".", ".", "."}};
            var game = new Game(mineBoard);

            var resultBoard = game.GetMinesweeperBoard();
            Assert.That(resultBoard, Is.EquivalentTo(new [,] {{ "*", "2", "1", "0" }, {"2", "*", "1", "0"}, {"1", "1", "1", "0"}}));
        }

    }
}
