namespace BasketballReservationApplication
{
    partial class frmChooseStuGuestAdmin
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
            studentButton = new Button();
            adminButton = new Button();
            guestButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // studentButton
            // 
            studentButton.BackColor = Color.OrangeRed;
            studentButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentButton.ForeColor = SystemColors.ControlLightLight;
            studentButton.Location = new Point(79, 86);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(176, 41);
            studentButton.TabIndex = 0;
            studentButton.Text = "Student";
            studentButton.UseVisualStyleBackColor = false;
            studentButton.Click += studentButton_Click;
            // 
            // adminButton
            // 
            adminButton.BackColor = SystemColors.HotTrack;
            adminButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminButton.ForeColor = SystemColors.ControlLightLight;
            adminButton.Location = new Point(79, 166);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(176, 41);
            adminButton.TabIndex = 1;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // guestButton
            // 
            guestButton.BackColor = SystemColors.ControlDarkDark;
            guestButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestButton.ForeColor = SystemColors.ControlLightLight;
            guestButton.Location = new Point(79, 246);
            guestButton.Name = "guestButton";
            guestButton.Size = new Size(176, 41);
            guestButton.TabIndex = 2;
            guestButton.Text = "Guest";
            guestButton.UseVisualStyleBackColor = false;
            guestButton.Click += guestButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(130, 54);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Login as:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-392, -34);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 72);
            panel2.TabIndex = 45;
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
            // frmChooseStuGuestAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 324);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(guestButton);
            Controls.Add(adminButton);
            Controls.Add(studentButton);
            Name = "frmChooseStuGuestAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button studentButton;
        private Button adminButton;
        private Button guestButton;
        private Label label1;
        private Panel panel2;
        private Label label3;
    }
}