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
        public void SimpleTest1()
        {
            var puzzle = new Puzzle(Puzzles.Puzzle1Solution)
                .WithValue(0,0,0)
                .WithValue(1,0,0)
                .WithValue(2,0,0)
                .WithValue(3,0,0)
                .WithValue(4,0,0)
                .WithValue(5,0,0)
                .WithValue(6,0,0)
                .WithValue(7,0,0)
                .WithValue(8,0,0);
            List<List<int>> result = puzzle.Solve().data;
            CollectionAssert.AreEqual(Puzzles.Puzzle1Solution, result);
        }


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