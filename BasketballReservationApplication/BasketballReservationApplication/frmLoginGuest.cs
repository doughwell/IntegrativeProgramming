using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BasketballReservationApplication
{
    public partial class frmLoginGuest : Form
    {
        public frmLoginGuest()
        {
            InitializeComponent();

            MessageBox.Show("To proceed, we must collect your information for you to book your own schedules.");

            loginButton.Enabled = false;
            fullNameGuestTextBox.TextChanged += fillOutCheck;
            emailGuestTextBox.TextChanged += fillOutCheck;
            guestContactTextBox.TextChanged += fillOutCheck;
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChooseStuGuestAdmin showfrmLogin = new frmChooseStuGuestAdmin();
            showfrmLogin.Show();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string guestName = fullNameGuestTextBox.Text;
            string guestEmail = emailGuestTextBox.Text;
            string guestContact = guestContactTextBox.Text;

            string guestEmailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            string guestContactPattern = @"^09\d{9}$";

            if (String.IsNullOrEmpty(guestName) || String.IsNullOrEmpty(guestEmail) || String.IsNullOrEmpty(guestContact))
            {
                warningMessageLabel.Text = "Please fill out the login credentials to proceed.";
                return;
            }
            if (!Regex.IsMatch(guestEmail, guestEmailPattern))
            {
                warningMessageLabel.Text = "Invalid email format.";
                return;
            }
            if (!Regex.IsMatch(guestContact, guestContactPattern))
            {
                warningMessageLabel.Text = "Invalid contact number format.";
                return;
            }
            MessageBox.Show("Now logging in as " + guestName + ".\n\nE-mail: " + guestEmail + "\nContact Number: " + guestContact);
                
                this.Close();
                frmScheduleReservation schedReservation = new frmScheduleReservation();
                schedReservation.setStuEmail(guestEmail);
                schedReservation.Show();      
        }
        private void fillOutCheck(object sender, EventArgs e) //reuires the user to press all radio buttons before reserving
        {
            bool allFieldsFilledOut = (!(String.IsNullOrEmpty(fullNameGuestTextBox.Text) && String.IsNullOrEmpty(emailGuestTextBox.Text) && String.IsNullOrEmpty(guestContactTextBox.Text)));
            loginButton.Enabled = allFieldsFilledOut;
        }
        private void frmLoginGuest_Load(object sender, EventArgs e)
        {

        }
        private void warningMessageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
