using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginNamespace;

namespace BasketballReservationApplication
{
    public partial class frmLoginStudent : Form
    {
        private UserAccount userAcc;
        public frmLoginStudent()
        {
            InitializeComponent();
            userAcc = new UserAccount("Dowell Butiong", "butiong.308761@munoz.sti.edu.ph", "password12345");
            userAcc = new UserAccount("Kean Quitoriano", "quitoriano.123456@munoz.sti.edu.ph", "password456");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = schoolEmailTextBox.Text;
            string password = passwordTextBox.Text;
            if (userAcc.validateLogin(email, password))
            {
                MessageBox.Show("Successful login for " + userAcc.getName() + ".");
                this.Close();

                frmScheduleReservation schedReservation = new frmScheduleReservation();
                schedReservation.setStuEmail(email);
                schedReservation.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login information or empty fields. Please check again.");
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChooseStuGuestAdmin showfrmLogin = new frmChooseStuGuestAdmin();
            showfrmLogin.Show();
        }
    }
}
