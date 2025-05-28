namespace Kyrsach
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button mainMenuBtn;

        /// <summary>
        /// Очищення ресурсів
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonPanel = new Panel();
            buttonLayout = new FlowLayoutPanel();
            resetBtn = new Button();
            checkBtn = new Button();
            undoBtn = new Button();
            clearBtn = new Button();
            mainMenuBtn = new Button(); 

            buttonPanel.SuspendLayout();
            buttonLayout.SuspendLayout();
            SuspendLayout();

            // buttonPanel
            buttonPanel.BackColor = Color.FromArgb(220, 230, 240);
            buttonPanel.Controls.Add(buttonLayout);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 356);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(10);
            buttonPanel.Size = new Size(701, 140);
            buttonPanel.TabIndex = 0;

            // buttonLayout
            buttonLayout.Controls.Add(resetBtn);
            buttonLayout.Controls.Add(checkBtn);
            buttonLayout.Controls.Add(undoBtn);
            buttonLayout.Controls.Add(clearBtn);
            buttonLayout.Controls.Add(mainMenuBtn); 
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(10, 10);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(681, 120);
            buttonLayout.TabIndex = 0;

            // resetBtn
            resetBtn.BackColor = Color.LightSkyBlue;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            resetBtn.Location = new Point(10, 10);
            resetBtn.Margin = new Padding(10);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(150, 40);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Нова гра";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;

            // checkBtn
            checkBtn.BackColor = Color.LightGreen;
            checkBtn.FlatStyle = FlatStyle.Flat;
            checkBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            checkBtn.Location = new Point(180, 10);
            checkBtn.Margin = new Padding(10);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(150, 40);
            checkBtn.TabIndex = 0;
            checkBtn.Text = "Перевірити";
            checkBtn.UseVisualStyleBackColor = false;
            checkBtn.Click += checkBtn_Click;

            // undoBtn
            undoBtn.BackColor = Color.Khaki;
            undoBtn.FlatStyle = FlatStyle.Flat;
            undoBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            undoBtn.Location = new Point(350, 10);
            undoBtn.Margin = new Padding(10);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(150, 40);
            undoBtn.TabIndex = 3;
            undoBtn.Text = "Крок назад";
            undoBtn.UseVisualStyleBackColor = false;
            undoBtn.Click += undoBtn_Click;

            // clearBtn
            clearBtn.BackColor = Color.LightSalmon;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            clearBtn.Location = new Point(520, 10);
            clearBtn.Margin = new Padding(10);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(150, 40);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Очистити все";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;

            // mainMenuBtn
            mainMenuBtn.BackColor = Color.LightYellow;
            mainMenuBtn.FlatStyle = FlatStyle.Flat;
            mainMenuBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            mainMenuBtn.Location = new Point(10, 70);
            mainMenuBtn.Margin = new Padding(10);
            mainMenuBtn.Name = "mainMenuBtn";
            mainMenuBtn.Size = new Size(660, 40);
            mainMenuBtn.TabIndex = 4;
            mainMenuBtn.Text = "Головне меню";
            mainMenuBtn.UseVisualStyleBackColor = false;
            mainMenuBtn.Click += MainMenuButton;

            // Form1
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(701, 496);
            Controls.Add(buttonPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Судоку";
            buttonPanel.ResumeLayout(false);
            buttonLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private FlowLayoutPanel buttonLayout;

    
        private void MainMenuButton(object sender, EventArgs e)
        {
            this.Hide();
 
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
