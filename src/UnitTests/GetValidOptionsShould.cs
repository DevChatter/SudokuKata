using NUnit.Framework;
using SudokuSolver.Core;
using System.Collections.Generic;
using System.Linq;
using UnitTests.TestData;

namespace UnitTests
{
    [TestFixture]
    public class GetValidOptionsShould
    {
        [Test]
        public void ReturnAll_GivenEmptyPuzzle()
        {
            var puzzle = new Puzzle(EmptyGrid);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.AllItemsAreUnique(result);
            Assert.AreEqual(9, result.Count);
            Assert.That(result.All(x => x < 10 && x > 0));
        }

        [Test]
        public void ReturnEmpty_GivenFilledCell()
        {
            var data = EmptyGrid;
            data[0][0] = 1;
            var puzzle = new Puzzle(data);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.IsEmpty(result);
        }

        [Test]
        public void ReturnOnlyOption_GivenOnlyEmptyCell()
        {
            var data = Puzzles.Puzzle1Solution;
            data[0][0] = 0;
            var puzzle = new Puzzle(data);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.Contains(result, Puzzles.Puzzle1Solution[0][0]);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void ReturnOnlyOption_GivenFullRow()
        {
            var data = EmptyGrid;
            for (int i = 1; i < 9; i++)
            {
                data[0][i] = i+1;
            }
            var puzzle = new Puzzle(data);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.Contains(result, 1);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void ReturnOnlyOption_GivenFullColumn()
        {
            var data = EmptyGrid;
            for (int i = 1; i < 9; i++)
            {
                data[i][0] = i+1;
            }
            var puzzle = new Puzzle(data);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.Contains(result, 1);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void ReturnOnlyOption_GivenCombinedRowColumnData()
        {
            var data = EmptyGrid;
            for (int i = 5; i < 9; i++)
            {
                data[0][i] = i + 1;
            }
            for (int i = 1; i < 5; i++)
            {
                data[i][0] = i + 1;
            }
            var puzzle = new Puzzle(data);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.Contains(result, 1);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void ReturnOnlyOption_GivenFullBlock()
        {
            var data = FilledBlock;
            var puzzle = new Puzzle(data);

            List<int> result = puzzle.GetValidOptions(0, 0);

            CollectionAssert.Contains(result, 1);
            Assert.AreEqual(1, result.Count);
        }

        private List<List<int>> FilledBlock => new List<List<int>>
        {
            new List<int> { 0, 2, 3,   0, 0, 0,   0, 0, 0 },
            new List<int> { 6, 5, 4,   0, 0, 0,   0, 0, 0 },
            new List<int> { 9, 7, 8,   0, 0, 0,   0, 0, 0 },

            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },

            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 }
        };

        public static List<List<int>> EmptyGrid => new List<List<int>>
        {
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },

            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },

            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 },
            new List<int> { 0, 0, 0,   0, 0, 0,   0, 0, 0 }
        };
    }
}