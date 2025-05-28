using System;
using System.Collections.Generic;
using System.Linq;

namespace Kyrsach
{
    public class SudokuBoard
    {
        public int[,] Solution { get; private set; } = new int[9, 9];
        private Random rand = new();

        public SudokuBoard()
        {
            GenerateSolution();
        }

        private void GenerateSolution()
        {
            int[,] grid = new int[9, 9];
            FillDiagonalBoxes(grid);
            SolveSudoku(grid);
            Array.Copy(grid, Solution, grid.Length);
        }

        private void FillDiagonalBoxes(int[,] grid)
        {
            for (int k = 0; k < 9; k += 3)
            {
                List<int> nums = Enumerable.Range(1, 9).ToList();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int index = rand.Next(nums.Count);
                        grid[k + i, k + j] = nums[index];
                        nums.RemoveAt(index);
                    }
                }
            }
        }

        public bool SolveSudoku(int[,] grid)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (grid[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsSafe(grid, row, col, num))
                            {
                                grid[row, col] = num;
                                if (SolveSudoku(grid)) return true;
                                grid[row, col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsSafe(int[,] grid, int row, int col, int num)
        {
            for (int x = 0; x < 9; x++)
                if (grid[row, x] == num || grid[x, col] == num)
                    return false;

            int startRow = row / 3 * 3;
            int startCol = col / 3 * 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (grid[startRow + i, startCol + j] == num)
                        return false;

            return true;
        }

        public bool IsValid(string[,] currentGrid)
        {
            // Перевірка рядків, колонок і блоків (3х3)
            for (int i = 0; i < 9; i++)
            {
                var rowSet = new HashSet<string>();
                var colSet = new HashSet<string>();
                for (int j = 0; j < 9; j++)
                {
                    string rowVal = currentGrid[i, j];
                    if (!string.IsNullOrWhiteSpace(rowVal))
                    {
                        if (rowSet.Contains(rowVal)) return false;
                        rowSet.Add(rowVal);
                    }

                    string colVal = currentGrid[j, i];
                    if (!string.IsNullOrWhiteSpace(colVal))
                    {
                        if (colSet.Contains(colVal)) return false;
                        colSet.Add(colVal);
                    }
                }
            }

            for (int blockRow = 0; blockRow < 9; blockRow += 3)
            {
                for (int blockCol = 0; blockCol < 9; blockCol += 3)
                {
                    var blockSet = new HashSet<string>();
                    for (int r = blockRow; r < blockRow + 3; r++)
                    {
                        for (int c = blockCol; c < blockCol + 3; c++)
                        {
                            string val = currentGrid[r, c];
                            if (!string.IsNullOrWhiteSpace(val))
                            {
                                if (blockSet.Contains(val)) return false;
                                blockSet.Add(val);
                            }
                        }
                    }
                }
            }
            return true;
        }

        // Новий метод для перевірки окремої клітинки (для підсвітки помилок)
        public bool IsCellValid(string[,] currentGrid, int row, int col)
        {
            string val = currentGrid[row, col];
            if (string.IsNullOrWhiteSpace(val)) return true;

            // Перевірка рядка
            for (int c = 0; c < 9; c++)
            {
                if (c != col && currentGrid[row, c] == val)
                    return false;
            }

            // Перевірка стовпця
            for (int r = 0; r < 9; r++)
            {
                if (r != row && currentGrid[r, col] == val)
                    return false;
            }

            // Перевірка 3x3 блока
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int r = startRow; r < startRow + 3; r++)
            {
                for (int c = startCol; c < startCol + 3; c++)
                {
                    if ((r != row || c != col) && currentGrid[r, c] == val)
                        return false;
                }
            }

            return true;
        }
    }
}
