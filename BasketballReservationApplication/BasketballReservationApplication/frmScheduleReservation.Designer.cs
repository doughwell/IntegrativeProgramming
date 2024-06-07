namespace BasketballReservationApplication
{
    partial class frmScheduleReservation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleReservation));
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            timer_clock = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label10 = new Label();
            emailLabel = new Label();
            label3 = new Label();
            timeStartCombo = new ComboBox();
            timeEndCombo = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            reserveButton = new Button();
            label9 = new Label();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            outaccomRButton = new RadioButton();
            ratesResultLabel = new Label();
            groupBox1 = new GroupBox();
            onRadioButton = new RadioButton();
            offRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            labelResultIndicator = new Label();
            scheduledBooksListBox = new ListBox();
            label11 = new Label();
            generateTicketLabel = new Label();
            ticketLabel = new Label();
            label13 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            warningMessageLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Checked = false;
            dateTimePicker.CustomFormat = "HH:mm:ss";
            dateTimePicker.Font = new Font("Microsoft JhengHei UI", 12F);
            dateTimePicker.ImeMode = ImeMode.Off;
            dateTimePicker.Location = new Point(230, 222);
            dateTimePicker.MaxDate = new DateTime(2042, 12, 31, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(2024, 6, 5, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(277, 28);
            dateTimePicker.TabIndex = 0;
            dateTimePicker.Value = new DateTime(2024, 6, 5, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 204);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "00:00:00";
            label1.Click += label1_Click;
            // 
            // timer_clock
            // 
            timer_clock.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1748, 91);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 28);
            label2.Name = "label2";
            label2.Size = new Size(209, 30);
            label2.TabIndex = 1;
            label2.Text = "Book and Dribble";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(11, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(emailLabel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(1746, 72);
            panel2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 8F);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(630, 35);
            label10.Name = "label10";
            label10.Size = new Size(77, 14);
            label10.TabIndex = 6;
            label10.Text = "Logged in as:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft JhengHei UI", 10F);
            emailLabel.ForeColor = SystemColors.ControlLightLight;
            emailLabel.Location = new Point(713, 32);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 18);
            emailLabel.TabIndex = 5;
            emailLabel.TextAlign = ContentAlignment.MiddleRight;
            emailLabel.Click += nameLabelBar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(15, 22);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 4;
            label3.Text = "Reservation";
            label3.Click += label3_Click;
            // 
            // timeStartCombo
            // 
            timeStartCombo.Font = new Font("Microsoft JhengHei UI", 12F);
            timeStartCombo.FormattingEnabled = true;
            timeStartCombo.Location = new Point(230, 271);
            timeStartCombo.Name = "timeStartCombo";
            timeStartCombo.Size = new Size(121, 28);
            timeStartCombo.TabIndex = 5;
            // 
            // timeEndCombo
            // 
            timeEndCombo.Font = new Font("Microsoft JhengHei UI", 12F);
            timeEndCombo.FormattingEnabled = true;
            timeEndCombo.Location = new Point(357, 271);
            timeEndCombo.Name = "timeEndCombo";
            timeEndCombo.Size = new Size(121, 28);
            timeEndCombo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(51, 306);
            label4.Name = "label4";
            label4.Size = new Size(456, 15);
            label4.TabIndex = 7;
            label4.Text = "*Due to school hours, weekday schedules are only available during 8pm - 10pm.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 12F);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(66, 228);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 8;
            label5.Text = "Preferred Schedule:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F);
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(49, 277);
            label7.Name = "label7";
            label7.Size = new Size(173, 20);
            label7.TabIndex = 10;
            label7.Text = "Time start - Time end:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 12F);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(164, 343);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 13;
            label8.Text = "Lights:";
            // 
            // reserveButton
            // 
            reserveButton.BackColor = Color.RoyalBlue;
            reserveButton.FlatStyle = FlatStyle.Flat;
            reserveButton.Font = new Font("Microsoft JhengHei UI", 10F);
            reserveButton.ForeColor = SystemColors.ControlLightLight;
            reserveButton.Location = new Point(49, 454);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(158, 47);
            reserveButton.TabIndex = 16;
            reserveButton.Text = "Reserve Schedule";
            reserveButton.UseVisualStyleBackColor = false;
            reserveButton.Click += reserveButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 12F);
            label9.ImageAlign = ContentAlignment.MiddleRight;
            label9.Location = new Point(15, 394);
            label9.Name = "label9";
            label9.Size = new Size(207, 20);
            label9.TabIndex = 17;
            label9.Text = "Are you from the campus?";
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(6, 22);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(42, 19);
            yesRadioButton.TabIndex = 18;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(69, 23);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(41, 19);
            noRadioButton.TabIndex = 19;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // outaccomRButton
            // 
            outaccomRButton.AutoSize = true;
            outaccomRButton.Location = new Point(131, 23);
            outaccomRButton.Name = "outaccomRButton";
            outaccomRButton.Size = new Size(257, 19);
            outaccomRButton.TabIndex = 20;
            outaccomRButton.TabStop = true;
            outaccomRButton.Text = "I'm a Student with outsider accompaniment";
            outaccomRButton.UseVisualStyleBackColor = true;
            // 
            // ratesResultLabel
            // 
            ratesResultLabel.AutoSize = true;
            ratesResultLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ratesResultLabel.Location = new Point(397, 466);
            ratesResultLabel.Name = "ratesResultLabel";
            ratesResultLabel.Size = new Size(0, 20);
            ratesResultLabel.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(onRadioButton);
            groupBox1.Controls.Add(offRadioButton);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(228, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 55);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // onRadioButton
            // 
            onRadioButton.AutoSize = true;
            onRadioButton.Location = new Point(6, 26);
            onRadioButton.Name = "onRadioButton";
            onRadioButton.Size = new Size(41, 19);
            onRadioButton.TabIndex = 14;
            onRadioButton.TabStop = true;
            onRadioButton.Text = "On";
            onRadioButton.UseVisualStyleBackColor = true;
            // 
            // offRadioButton
            // 
            offRadioButton.AutoSize = true;
            offRadioButton.Location = new Point(70, 26);
            offRadioButton.Name = "offRadioButton";
            offRadioButton.Size = new Size(42, 19);
            offRadioButton.TabIndex = 15;
            offRadioButton.TabStop = true;
            offRadioButton.Text = "Off";
            offRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(yesRadioButton);
            groupBox2.Controls.Add(noRadioButton);
            groupBox2.Controls.Add(outaccomRButton);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(228, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 57);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            // 
            // labelResultIndicator
            // 
            labelResultIndicator.AutoSize = true;
            labelResultIndicator.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultIndicator.Location = new Point(260, 467);
            labelResultIndicator.Name = "labelResultIndicator";
            labelResultIndicator.Size = new Size(126, 20);
            labelResultIndicator.TabIndex = 24;
            labelResultIndicator.Text = "Total payment: ";
            // 
            // scheduledBooksListBox
            // 
            scheduledBooksListBox.BackColor = SystemColors.ControlLightLight;
            scheduledBooksListBox.Font = new Font("Microsoft JhengHei UI", 10F);
            scheduledBooksListBox.FormattingEnabled = true;
            scheduledBooksListBox.ItemHeight = 17;
            scheduledBooksListBox.Location = new Point(641, 213);
            scheduledBooksListBox.Name = "scheduledBooksListBox";
            scheduledBooksListBox.ScrollAlwaysVisible = true;
            scheduledBooksListBox.Size = new Size(310, 310);
            scheduledBooksListBox.Sorted = true;
            scheduledBooksListBox.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 12F);
            label11.Location = new Point(641, 190);
            label11.Name = "label11";
            label11.Size = new Size(166, 20);
            label11.TabIndex = 26;
            label11.Text = "Scheduled Bookings:";
            // 
            // generateTicketLabel
            // 
            generateTicketLabel.AutoSize = true;
            generateTicketLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold);
            generateTicketLabel.Location = new Point(397, 503);
            generateTicketLabel.Name = "generateTicketLabel";
            generateTicketLabel.Size = new Size(0, 20);
            generateTicketLabel.TabIndex = 27;
            // 
            // ticketLabel
            // 
            ticketLabel.AutoSize = true;
            ticketLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketLabel.Location = new Point(246, 503);
            ticketLabel.Name = "ticketLabel";
            ticketLabel.Size = new Size(136, 20);
            ticketLabel.TabIndex = 28;
            ticketLabel.Text = "Your ticket code:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(246, 526);
            label13.Name = "label13";
            label13.Size = new Size(583, 15);
            label13.TabIndex = 29;
            label13.Text = "*Proceed to the STI Munoz-EDSA's cashier as soon as possible within 48 hours or your ticket will expire. ";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(978, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 9F);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(38, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(161, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(161, 22);
            exitApplicationToolStripMenuItem.Text = "Exit application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // warningMessageLabel
            // 
            warningMessageLabel.AutoSize = true;
            warningMessageLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            warningMessageLabel.ForeColor = Color.Red;
            warningMessageLabel.Location = new Point(33, 433);
            warningMessageLabel.Name = "warningMessageLabel";
            warningMessageLabel.Size = new Size(0, 15);
            warningMessageLabel.TabIndex = 31;
            // 
            // frmScheduleReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(978, 624);
            Controls.Add(warningMessageLabel);
            Controls.Add(menuStrip1);
            Controls.Add(label13);
            Controls.Add(ticketLabel);
            Controls.Add(generateTicketLabel);
            Controls.Add(label11);
            Controls.Add(scheduledBooksListBox);
            Controls.Add(labelResultIndicator);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ratesResultLabel);
            Controls.Add(label9);
            Controls.Add(reserveButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(timeEndCombo);
            Controls.Add(timeStartCombo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            MainMenuStrip = menuStrip1;
            Name = "frmScheduleReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book and Dribble";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Label label1;
        private System.Windows.Forms.Timer timer_clock;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private ComboBox timeStartCombo;
        private ComboBox timeEndCombo;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button reserveButton;
        private Label label9;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
        private RadioButton outaccomRButton;
        private Label ratesResultLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton onRadioButton;
        private RadioButton offRadioButton;
        private Label labelResultIndicator;
        private Label emailLabel;
        private Label label10;
        private ListBox scheduledBooksListBox;
        private Label label11;
        private Label generateTicketLabel;
        private Label ticketLabel;
        private Label label13;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private Label warningMessageLabel;
    }
}
