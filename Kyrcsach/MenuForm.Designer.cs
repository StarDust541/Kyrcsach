using System.ComponentModel;

namespace Kyrsach
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        public MenuForm(IContainer components)
        {
            this.components = components;
        }

        private Button startBtn;
        private Button exitBtn;
        private Label gameTitleLabel;

        private void InitializeComponent()
        {
            this.startBtn = new Button();
            this.exitBtn = new Button();
            this.gameTitleLabel = new Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = Color.MediumSeaGreen;
            this.startBtn.Cursor = Cursors.Hand;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = FlatStyle.Flat;
            this.startBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.startBtn.ForeColor = Color.White;
            this.startBtn.Location = new Point(100, 120);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new Size(200, 60);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "▶ Почати гру";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new EventHandler(this.startBtn_Click); // 🔧 Обробник події
                                                                          // 
                                                                          // exitBtn
                                                                          // 
            this.exitBtn.BackColor = Color.IndianRed;
            this.exitBtn.Cursor = Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = FlatStyle.Flat;
            this.exitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.exitBtn.ForeColor = Color.White;
            this.exitBtn.Location = new Point(100, 200);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new Size(200, 60);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "⛔ Вийти";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new EventHandler(this.exitBtn_Click); // 🔧 Обробник події
                                                                        // 
                                                                        // gameTitleLabel
                                                                        // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            this.gameTitleLabel.ForeColor = Color.MediumSlateBlue;
            this.gameTitleLabel.Location = new Point(124, 26);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new Size(152, 51);
            this.gameTitleLabel.TabIndex = 2;
            this.gameTitleLabel.Text = "Судоку";
            this.gameTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.BackColor = Color.FromArgb(240, 248, 255);
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.gameTitleLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Меню гри";
            this.Load += new EventHandler(this.MenuForm_Load); // опційно, якщо потрібен
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
