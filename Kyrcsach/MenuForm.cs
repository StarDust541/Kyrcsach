using System;
using System.Drawing;
using System.Windows.Forms;
using Kyrcsach;

namespace Kyrsach
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Створення форми вибору складності
            DifficultyForm difficultyForm = new DifficultyForm();

            // Відкриваємо вікно вибору складності
            if (difficultyForm.ShowDialog() == DialogResult.OK)
            {
                // Якщо вибір зроблений, передаємо складність у гру
                int difficulty = difficultyForm.Difficulty;

                // Створення нової форми гри з вибраним рівнем складності
                Form1 gameForm = new Form1(difficulty);
                this.Hide(); // Ховаємо меню
                gameForm.Show(); // Показуємо форму гри
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закриває додаток
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Можна додати анімацію або ефекти, якщо потрібно
        }
    }
}
