using System.Collections.Generic;

namespace SudokuSolver.Core
{
    public class Solver
    {
        public List<List<int>> Solve(List<List<int>> input)
        {
            var puzzle = new Puzzle(input);
            return puzzle.Solve().data;
        }
    }
}
