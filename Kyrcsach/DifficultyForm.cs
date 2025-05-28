using System;
using System.Windows.Forms;

namespace Kyrcsach
{
    public partial class DifficultyForm : Form
    {
        public int Difficulty { get; private set; }

        public DifficultyForm()
        {
            InitializeComponent();
            Difficulty = 30; 
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            Difficulty = 30; // Легкий рівень
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            Difficulty = 25; // Середній рівень
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            Difficulty = 20; // Важкий рівень
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
