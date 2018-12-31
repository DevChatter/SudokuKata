using NUnit.Framework;
using SudokuSolver.Core;
using UnitTests.TestData;

namespace UnitTests
{
    [TestFixture]
    public class IsCompleteShould
    {
        [Test]
        public void ReturnTrue_GivenSampleSolution()
        {
            var puzzle = new Puzzle(Puzzles.Puzzle1Solution);

            Assert.IsTrue(puzzle.IsComplete());
        }

        [Test]
        public void ReturnFalse_GivenInvalidSolution()
        {
            var puzzle = new Puzzle(Puzzles.Puzzle1Solution).WithValue(0,0,9);

            Assert.IsFalse(puzzle.IsComplete());
        }

        [Test]
        public void ReturnFalse_GivenSamplePuzzle()
        {
            var puzzle = new Puzzle(Puzzles.Puzzle1);

            Assert.IsFalse(puzzle.IsComplete());
        }
    }
}