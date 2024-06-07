namespace BasketballReservationApplication
{
    partial class frmLoginStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passwordTextBox = new TextBox();
            label11 = new Label();
            schoolEmailTextBox = new TextBox();
            label10 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Microsoft JhengHei UI", 8F);
            passwordTextBox.Location = new Point(78, 147);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new Size(322, 21);
            passwordTextBox.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 10F);
            label11.Location = new Point(78, 124);
            label11.Name = "label11";
            label11.Size = new Size(73, 18);
            label11.TabIndex = 39;
            label11.Text = "Password:";
            // 
            // schoolEmailTextBox
            // 
            schoolEmailTextBox.Font = new Font("Microsoft JhengHei UI", 8F);
            schoolEmailTextBox.Location = new Point(78, 94);
            schoolEmailTextBox.Name = "schoolEmailTextBox";
            schoolEmailTextBox.Size = new Size(322, 21);
            schoolEmailTextBox.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 10F);
            label10.Location = new Point(78, 71);
            label10.Name = "label10";
            label10.Size = new Size(161, 18);
            label10.TabIndex = 37;
            label10.Text = "School E-mail Address:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(174, 200);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 41;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-622, -12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 72);
            panel2.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(30, 21);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 4;
            label3.Text = "Reservation";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(485, 24);
            menuStrip1.TabIndex = 44;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // frmLoginStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(485, 250);
            Controls.Add(button1);
            Controls.Add(passwordTextBox);
            Controls.Add(label11);
            Controls.Add(schoolEmailTextBox);
            Controls.Add(label10);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Name = "frmLoginStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label11;
        private TextBox schoolEmailTextBox;
        private Label label10;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}