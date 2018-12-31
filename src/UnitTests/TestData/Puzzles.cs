using System.Collections.Generic;

namespace UnitTests.TestData
{
    public static class Puzzles
    {
        public static List<List<int>> Puzzle1 => new List<List<int>>
        {
            new List<int> { 0, 0, 0, 2, 6, 0, 7, 0, 1 },
            new List<int> { 6, 8, 0, 0, 7, 0, 0, 9, 0 },
            new List<int> { 1, 9, 0, 0, 0, 4, 5, 0, 0 },
            new List<int> { 8, 2, 0, 1, 0, 0, 0, 4, 0 },
            new List<int> { 0, 0, 4, 6, 0, 2, 9, 0, 0 },
            new List<int> { 0, 5, 0, 0, 0, 3, 0, 2, 8 },
            new List<int> { 0, 0, 9, 3, 0, 0, 0, 7, 4 },
            new List<int> { 0, 4, 0, 0, 5, 0, 0, 3, 6 },
            new List<int> { 7, 0, 3, 0, 1, 8, 0, 0, 0 }
        };

        public static List<List<int>> Puzzle1Solution => new List<List<int>>
        {
            new List<int> { 4, 3, 5, 2, 6, 9, 7, 8, 1 },
            new List<int> { 6, 8, 2, 5, 7, 1, 4, 9, 3 },
            new List<int> { 1, 9, 7, 8, 3, 4, 5, 6, 2 },
            new List<int> { 8, 2, 6, 1, 9, 5, 3, 4, 7 },
            new List<int> { 3, 7, 4, 6, 8, 2, 9, 1, 5 },
            new List<int> { 9, 5, 1, 7, 4, 3, 6, 2, 8 },
            new List<int> { 5, 1, 9, 3, 2, 6, 8, 7, 4 },
            new List<int> { 2, 4, 8, 9, 5, 7, 1, 3, 6 },
            new List<int> { 7, 6, 3, 4, 1, 8, 2, 5, 9 }
        };

        public static List<List<int>> Puzzle2 => new List<List<int>>
        {
            new List<int> {0, 0, 4, 0, 3, 0, 0, 2, 1},
            new List<int> {0, 7, 0, 0, 0, 5, 0, 0, 9},
            new List<int> {3, 8, 0, 6, 9, 0, 0, 0, 0},
            new List<int> {0, 3, 0, 0, 0, 0, 0, 0, 0},
            new List<int> {6, 0, 2, 1, 0, 0, 4, 5, 0},
            new List<int> {0, 1, 0, 9, 0, 7, 0, 0, 3},
            new List<int> {0, 0, 0, 8, 4, 6, 7, 0, 0},
            new List<int> {5, 6, 0, 0, 0, 1, 2, 4, 0},
            new List<int> {0, 0, 8, 2, 5, 0, 0, 3, 0}
        };

        public static List<List<int>> Puzzle2Solution => new List<List<int>>
        {
            new List<int> {9, 5, 4, 7, 3, 8, 6, 2, 1},
            new List<int> {2, 7, 6, 4, 1, 5, 3, 8, 9},
            new List<int> {3, 8, 1, 6, 9, 2, 5, 7, 4},
            new List<int> {8, 3, 7, 5, 6, 4, 9, 1, 2},
            new List<int> {6, 9, 2, 1, 8, 3, 4, 5, 7},
            new List<int> {4, 1, 5, 9, 2, 7, 8, 6, 3},
            new List<int> {1, 2, 3, 8, 4, 6, 7, 9, 5},
            new List<int> {5, 6, 9, 3, 7, 1, 2, 4, 8},
            new List<int> {7, 4, 8, 2, 5, 9, 1, 3, 6}
        };
    }
}