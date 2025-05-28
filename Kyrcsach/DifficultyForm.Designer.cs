namespace Kyrcsach
{
    partial class DifficultyForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.easyBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(50, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 50);
            this.titleLabel.Text = "Вибір рівня складності";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;  

            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(100, 100);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(200, 60);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Легкий";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.BackColor = System.Drawing.Color.LightGreen;  
            this.easyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyBtn.FlatAppearance.BorderSize = 0;
            this.easyBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.easyBtn.ForeColor = System.Drawing.Color.Black;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);

            // 
            // mediumBtn
            // 
            this.mediumBtn.Location = new System.Drawing.Point(100, 180);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(200, 60);
            this.mediumBtn.TabIndex = 1;
            this.mediumBtn.Text = "Середній";
            this.mediumBtn.UseVisualStyleBackColor = true;
            this.mediumBtn.BackColor = System.Drawing.Color.Yellow; 
            this.mediumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumBtn.FlatAppearance.BorderSize = 0;
            this.mediumBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.mediumBtn.ForeColor = System.Drawing.Color.Black;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);

            // 
            // hardBtn
            // 
            this.hardBtn.Location = new System.Drawing.Point(100, 260);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(200, 60);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Важкий";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.BackColor = System.Drawing.Color.IndianRed;  
            this.hardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardBtn.FlatAppearance.BorderSize = 0;
            this.hardBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.hardBtn.ForeColor = System.Drawing.Color.Black;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);

            // 
            // DifficultyForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.easyBtn);
            this.Controls.Add(this.mediumBtn);
            this.Controls.Add(this.hardBtn);
            this.Name = "DifficultyForm";
            this.Text = "Вибір складності";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 255);  
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Label titleLabel;
    }
}
