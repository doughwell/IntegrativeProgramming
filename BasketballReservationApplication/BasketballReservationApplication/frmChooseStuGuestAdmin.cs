using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballReservationApplication
{
    public partial class frmChooseStuGuestAdmin : Form
    {
        public frmChooseStuGuestAdmin()
        {
            InitializeComponent();
        }
        private void studentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginStudent showfrmLogin = new frmLoginStudent();
            showfrmLogin.Show();
        }
        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginStudent showfrmLogin = new frmLoginStudent();
            showfrmLogin.Show();
        }
        private void guestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginGuest showfrmLogin = new frmLoginGuest();
            showfrmLogin.Show();
        }
    }
}
