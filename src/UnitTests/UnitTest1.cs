using NUnit.Framework;
using SudokuSolver.Core;
using System.Collections.Generic;
using UnitTests.TestData;

namespace UnitTests
{
    public class Tests
    {
        private static readonly Solver Solver = new Solver();

        [Test]
        public void Test1()
        {
            List<List<int>> result = Solver.Solve(Puzzles.Puzzle1);
            CollectionAssert.AreEqual(Puzzles.Puzzle1Solution, result);
        }

        [Test]
        public void Test2()
        {
            List<List<int>> result = Solver.Solve(Puzzles.Puzzle2);
            CollectionAssert.AreEqual(Puzzles.Puzzle2Solution, result);
        }
    }
}