namespace BasketballReservationApplication
{
    partial class frmLoginGuest
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
            guestContactTextBox = new TextBox();
            label12 = new Label();
            emailGuestTextBox = new TextBox();
            label11 = new Label();
            fullNameGuestTextBox = new TextBox();
            label10 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            loginButton = new Button();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            warningMessageLabel = new Label();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // guestContactTextBox
            // 
            guestContactTextBox.Font = new Font("Microsoft JhengHei UI", 10F);
            guestContactTextBox.Location = new Point(79, 220);
            guestContactTextBox.Name = "guestContactTextBox";
            guestContactTextBox.Size = new Size(322, 24);
            guestContactTextBox.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 10F);
            label12.Location = new Point(79, 199);
            label12.Name = "label12";
            label12.Size = new Size(122, 18);
            label12.TabIndex = 35;
            label12.Text = "Contact Number:";
            // 
            // emailGuestTextBox
            // 
            emailGuestTextBox.Font = new Font("Microsoft JhengHei UI", 10F);
            emailGuestTextBox.Location = new Point(79, 156);
            emailGuestTextBox.Name = "emailGuestTextBox";
            emailGuestTextBox.Size = new Size(322, 24);
            emailGuestTextBox.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 10F);
            label11.Location = new Point(79, 133);
            label11.Name = "label11";
            label11.Size = new Size(111, 18);
            label11.TabIndex = 33;
            label11.Text = "E-mail Address:";
            // 
            // fullNameGuestTextBox
            // 
            fullNameGuestTextBox.Font = new Font("Microsoft JhengHei UI", 10F);
            fullNameGuestTextBox.Location = new Point(79, 95);
            fullNameGuestTextBox.Name = "fullNameGuestTextBox";
            fullNameGuestTextBox.Size = new Size(322, 24);
            fullNameGuestTextBox.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 10F);
            label10.Location = new Point(79, 72);
            label10.Name = "label10";
            label10.Size = new Size(79, 18);
            label10.TabIndex = 31;
            label10.Text = "Full Name:";
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
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-317, -14);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 72);
            panel2.TabIndex = 44;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.HotTrack;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.ImageAlign = ContentAlignment.TopLeft;
            loginButton.Location = new Point(173, 278);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(139, 38);
            loginButton.TabIndex = 45;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(485, 24);
            menuStrip1.TabIndex = 46;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 9F);
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(45, 20);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // warningMessageLabel
            // 
            warningMessageLabel.AutoSize = true;
            warningMessageLabel.Font = new Font("Microsoft JhengHei UI", 9F);
            warningMessageLabel.ForeColor = Color.Red;
            warningMessageLabel.Location = new Point(133, 248);
            warningMessageLabel.Name = "warningMessageLabel";
            warningMessageLabel.Size = new Size(0, 15);
            warningMessageLabel.TabIndex = 47;
            warningMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            warningMessageLabel.Click += warningMessageLabel_Click;
            // 
            // frmLoginGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 328);
            Controls.Add(warningMessageLabel);
            Controls.Add(loginButton);
            Controls.Add(guestContactTextBox);
            Controls.Add(label12);
            Controls.Add(emailGuestTextBox);
            Controls.Add(label11);
            Controls.Add(fullNameGuestTextBox);
            Controls.Add(label10);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            Name = "frmLoginGuest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest Login";
            Load += frmLoginGuest_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox guestContactTextBox;
        private Label label12;
        private TextBox emailGuestTextBox;
        private Label label11;
        private TextBox fullNameGuestTextBox;
        private Label label10;
        private Label label3;
        private Panel panel2;
        private Button loginButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private Label warningMessageLabel;
    }
}