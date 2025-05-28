using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsach
{
    public partial class Form1 : Form
    {
        private TextBox[,] cells = new TextBox[9, 9];
        private Stack<(int row, int col, string prevValue)> history = new();
        private int difficulty;
        private SudokuBoard sudokuBoard;

        public Form1(int difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            sudokuBoard = new SudokuBoard();

            GenerateSudokuGrid();
            AddRandomNumbers();
        }

        private void GenerateSudokuGrid()
        {
            TableLayoutPanel grid = new TableLayoutPanel
            {
                RowCount = 9,
                ColumnCount = 9,
                Dock = DockStyle.Top,
                Height = 360
            };

            for (int i = 0; i < 9; i++)
            {
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11f));
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11f));
            }

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    TextBox tb = new TextBox
                    {
                        MaxLength = 1,
                        TextAlign = HorizontalAlignment.Center,
                        Font = new Font("Segoe UI", 14),
                        Dock = DockStyle.Fill
                    };

                    string previousText = "";

                    tb.Enter += (sender, args) =>
                    {
                        if (sender is TextBox textbox)
                            previousText = textbox.Text;
                    };

                    tb.Leave += (sender, args) =>
                    {
                        if (sender is TextBox textbox && !textbox.ReadOnly && textbox.Text != previousText)
                        {
                            for (int r = 0; r < 9; r++)
                            {
                                for (int c = 0; c < 9; c++)
                                {
                                    if (cells[r, c] == textbox)
                                    {
                                        history.Push((r, c, previousText));
                                        return;
                                    }
                                }
                            }
                        }
                    };

                    tb.Click += (sender, args) =>
                    {
                        if (sender is TextBox textbox)
                        {
                            for (int r = 0; r < 9; r++)
                            {
                                for (int c = 0; c < 9; c++)
                                {
                                    if (cells[r, c] == textbox)
                                    {
                                        HighlightCell(r, c);
                                        return;
                                    }
                                }
                            }
                        }
                    };

                    cells[row, col] = tb;
                    grid.Controls.Add(tb, col, row);
                }
            }

            this.Controls.Add(grid);
        }

        private void AddRandomNumbers()
        {
            var solution = sudokuBoard.Solution;
            Random rand = new();
            int count = difficulty;
            HashSet<(int, int)> used = new();

            while (count > 0)
            {
                int row = rand.Next(9);
                int col = rand.Next(9);
                if (used.Contains((row, col))) continue;

                cells[row, col].Text = solution[row, col].ToString();
                cells[row, col].ReadOnly = true;
                cells[row, col].BackColor = Color.LightGray;
                used.Add((row, col));
                count--;
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string[,] currentGrid = new string[9, 9];
            for (int r = 0; r < 9; r++)
                for (int c = 0; c < 9; c++)
                    currentGrid[r, c] = cells[r, c].Text;

            bool allValid = true;

            ClearHighlights();

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (!string.IsNullOrWhiteSpace(currentGrid[r, c]) && !cells[r, c].ReadOnly &&
                        !sudokuBoard.IsCellValid(currentGrid, r, c))
                    {
                        cells[r, c].BackColor = Color.LightCoral; 
                        allValid = false;
                    }
                    else
                    {
                        cells[r, c].BackColor = cells[r, c].ReadOnly ? Color.LightGray : Color.White;
                    }
                }
            }

            if (allValid)
                MessageBox.Show("Все правильно!", "Перевірка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Є помилки!", "Перевірка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (var tb in cells)
            {
                if (!tb.ReadOnly)
                    tb.Text = "";
                tb.BackColor = tb.ReadOnly ? Color.LightGray : Color.White;
            }
            history.Clear();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (var tb in cells)
            {
                tb.Text = "";
                tb.ReadOnly = false;
                tb.BackColor = Color.White;
            }

            history.Clear();
            sudokuBoard = new SudokuBoard();
            AddRandomNumbers();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                var (row, col, prevVal) = history.Pop();
                if (!cells[row, col].ReadOnly)
                {
                    cells[row, col].Text = prevVal;
                }
            }
        }

        private void HighlightCell(int clickedRow, int clickedCol)
        {
            ClearHighlights();
            for (int i = 0; i < 9; i++)
            {
                cells[clickedRow, i].BackColor = Color.LightBlue;
                cells[i, clickedCol].BackColor = Color.LightBlue;
            }

            int startRow = (clickedRow / 3) * 3;
            int startCol = (clickedCol / 3) * 3;
            for (int r = startRow; r < startRow + 3; r++)
                for (int c = startCol; c < startCol + 3; c++)
                    cells[r, c].BackColor = Color.LightYellow;

            cells[clickedRow, clickedCol].BackColor = Color.Orange;
        }

        private void ClearHighlights()
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (cells[r, c].BackColor == Color.LightCoral)
                        cells[r, c].BackColor = cells[r, c].ReadOnly ? Color.LightGray : Color.White;
                    else if (cells[r, c].BackColor == Color.LightBlue || cells[r, c].BackColor == Color.LightYellow || cells[r, c].BackColor == Color.Orange)
                        cells[r, c].BackColor = cells[r, c].ReadOnly ? Color.LightGray : Color.White;
                }
            }
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
