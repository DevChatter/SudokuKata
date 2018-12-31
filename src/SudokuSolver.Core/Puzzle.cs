using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SudokuSolver.Core
{
    public class Puzzle
    {
        private readonly List<List<int>> _data = new List<List<int>>();
        private static readonly List<int> AllNumbers 
            = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public Puzzle(List<List<int>> data)
        {
            for (int y = 0; y < 9; y++)
            {
                _data.Add(new List<int>());
                for (int x = 0; x < 9; x++)
                {
                    _data[y].Add(data[y][x]);
                }
            }
        }

        public Puzzle WithValue(int x, int y, int number)
        {
            _data[y][x] = number;
            return this;
        }

        public List<int> GetValidOptions(int x, int y)
        {
            if (_data[y][x] > 0)
            {
                return new List<int>();
            }

            return AllNumbers
                .Except(GetColumnValues(x))
                .Except(GetRowValues(y))
                .Except(GetBlockValues(x, y))
                .ToList();
        }

        private IEnumerable<int> GetBlockValues(int x, int y)
        {
            int blockX = (x / 3) * 3;
            int blockY = (y / 3) * 3;
            for (int rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                for (int colIndex = 0; colIndex < 3; colIndex++)
                {
                    yield return _data[blockY + rowIndex][blockX + colIndex];
                }
            }
        }

        private IEnumerable<int> GetRowValues(int y)
        {
            return _data[y];
        }

        private IEnumerable<int> GetColumnValues(int x)
        {
            for (int i = 0; i < 9; i++)
            {
                yield return _data[i][x];
            }
        }

        public (bool success, List<List<int>> data) Solve()
        {
            Debug.Print("\n\nSolving Puzzle:\n");
            Debug.Print(ToString());

            if (IsComplete())
            {
                return (true, _data);
            }

            for (int y = 0; y < 9; y++)
            {
                if (GetRowValues(y).All(cell => cell > 0))
                {
                    continue;
                }
                for (int x = 0; x < 9; x++)
                {
                    if (_data[y][x] > 0)
                    {
                        continue;
                    }
                    List<int> options = GetValidOptions(x, y);
                    foreach (int option in options)
                    {
                        var puzzle = new Puzzle(_data).WithValue(x,y, option);
                        var attempt = puzzle.Solve();
                        if (attempt.success)
                        {
                            return attempt;
                        }
                    }
                    if (!options.Any())
                    {
                        break;
                    }
                }

                if (GetRowValues(y).Any(cell => cell == 0))
                {
                    break;
                }
            }

            return (false, null);
        }

        public bool IsComplete()
        {
            foreach (List<int> row in _data)
            {
                if (!IsSetComplete(row))
                {
                    return false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                var column = GetColumnValues(i);
                if (!IsSetComplete(column))
                {
                    return false;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    var block = GetBlockValues(x * 3, y * 3);
                    if (!IsSetComplete(block))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsSetComplete(IEnumerable<int> column)
        {
            return column.Where(x => x > 0 && x < 10).Distinct().Count() == 9;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (List<int> row in _data)
            {
                sb.AppendLine(string.Join(" ", row));
            }

            return sb.ToString();
        }
    }
}