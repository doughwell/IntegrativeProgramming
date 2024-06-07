using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Text;
using System.Collections;
using RatesNamespace;
using LoginNamespace;

namespace BasketballReservationApplication
{
    public partial class frmScheduleReservation : Form
    {
        private string[] weekdayTimeS = { "8:00 PM", "9:00PM" };
        private string[] weekdayTimeE = { "9:00 PM", "10:00 PM" };
        private string[] weekendTimeS = { "6:00 AM", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM",
                                          "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", };
        private string[] weekendTimeE = { "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM",
                                          "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00PM"};
        private List<(DateTime sTime, DateTime eTime)> bookedScheds = new List<(DateTime sTime, DateTime eTime)>();
        public frmScheduleReservation()
        {
            InitializeComponent();
            InitializeDateTimePicker();
            PopulateComboBoxes(dateTimePicker.Value);
            /*
            ArrayList sports = new ArrayList();
            sports.Add("Basketball");
            sports.Add("Volleyball");               //cancelled part
            foreach (string sport in sports)
            {
                sportComboBox.Items.Add(sport);
            }
                                                */
            reserveButton.Enabled = false;
            onRadioButton.CheckedChanged += radioButtonsCheck;
            offRadioButton.CheckedChanged += radioButtonsCheck;
            yesRadioButton.CheckedChanged += radioButtonsCheck;
            noRadioButton.CheckedChanged += radioButtonsCheck;
            outaccomRButton.CheckedChanged += radioButtonsCheck;
        }
        public void setStuEmail(string email)
        {
            emailLabel.Text = email;
        }
        private void reserveButton_Click(object sender, EventArgs e)
        {
            

            if (!(onRadioButton.Checked || offRadioButton.Checked) ||
                !(yesRadioButton.Checked || noRadioButton.Checked || outaccomRButton.Checked))
            {
                warningMessageLabel.Text = "Unchecked buttons. Please enter or click the necessary reservation details.";
                return;
            }

            ReservationRates rates = new ReservationRates();
            bool onLights = onRadioButton.Checked;
            bool isStu = yesRadioButton.Checked || outaccomRButton.Checked;
            bool hasOuts = outaccomRButton.Checked || noRadioButton.Checked;

            string start = timeStartCombo.SelectedItem.ToString();
            string end = timeEndCombo.SelectedItem.ToString();

            DateTime dateStart = dateTimePicker.Value.Date;
            DateTime startTime = dateStart.Add(DateTime.Parse(start).TimeOfDay);
            DateTime endTime = dateStart.Add(DateTime.Parse(end).TimeOfDay);
            if (isBookingConflict(startTime, endTime))
            {
                MessageBox.Show("Your preferred time/schedule is conflicting with an existing booking. Choose a different time.");
                return;
            }

            double hoursPay = (endTime - startTime).TotalHours;
            double rateResult = rates.CalculateReserveRates(isStu, hasOuts, onLights) * hoursPay;
            ratesResultLabel.Text = "P" + rateResult.ToString("0.00");

            string ticket = getTicket();
            DateTime expiration = DateTime.Now.AddHours(24);
            generateTicketLabel.Text = ticket;

            bookedScheds.Add((startTime, endTime));
            updateScheduleList();

            MessageBox.Show("Schedule booked. Please pay to our cashier within 24 hours.");
        }
        private void radioButtonsCheck(object sender, EventArgs e) //reuires the user to press all radio buttons before reserving
        {
            bool allButtonsPressed = (onRadioButton.Checked || offRadioButton.Checked) && 
                                        (yesRadioButton.Checked || noRadioButton.Checked || outaccomRButton.Checked);
            reserveButton.Enabled = allButtonsPressed;
        }
        private string getTicket() //generates ticket
        {
            const string combination = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random randomTicket = new Random();
            return new string(Enumerable.Repeat(combination, 9).Select(s => s[randomTicket.Next(s.Length)]).ToArray());
        }
        private void ticketExpire() //handles ticket expiry
        {
            DateTime now = DateTime.Now;
            bookedScheds.RemoveAll(booking => now > booking.eTime.AddHours(24));
            updateScheduleList();
        }
        private bool isBookingConflict(DateTime sTime, DateTime eTime) //handles schedule conflict 
        {
            foreach (var bookedSchedules in bookedScheds)
            {
                if (sTime < bookedSchedules.eTime && eTime > bookedSchedules.sTime)
                {
                    return true;
                }
            }
            return false;
        }
        private void updateScheduleList()
        {
            scheduledBooksListBox.Items.Clear();

            foreach (var bookedSchedules in bookedScheds)
            {
                scheduledBooksListBox.Items.Add($"{bookedSchedules.sTime:dddd, MMM dd yyyy, hh:mm tt} - {bookedSchedules.eTime:hh:mm tt}");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer_clock.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GraphicsPath round = new GraphicsPath();
            round.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region rg = new Region(round);
            pictureBox1.Region = rg;
        }
        private void InitializeDateTimePicker()
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "  dddd ::    MM/dd/yyyy ";
            dateTimePicker.Value = DateTime.Now;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateComboBoxes(dateTimePicker.Value);
        }
        private void PopulateComboBoxes(DateTime selectedDate)
        {
            timeStartCombo.Items.Clear();
            timeEndCombo.Items.Clear();

            string[] start, end;
            if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                start = weekendTimeS;
                end = weekendTimeE;
            }
            else
            {
                start = weekdayTimeS;
                end = weekdayTimeE;
            }
            timeStartCombo.Items.AddRange(start);
            timeEndCombo.Items.AddRange(end);

            timeStartCombo.SelectedIndex = 0;
            timeEndCombo.SelectedIndex = 0;

        }
        private void nameLabelBar_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChooseStuGuestAdmin showfrmLogin = new frmChooseStuGuestAdmin();
            showfrmLogin.Show();
        }
        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
