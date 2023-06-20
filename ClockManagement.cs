using AttendanceManagementSystem.Features;
using AttendanceManagementSystem.Entities;
namespace AttendanceManagementSystem
{
    public partial class ClockManagement : Form
    {
        TimeSheet timeSheet;
        public ClockManagement(TimeSheet timeSheet)
        {

            this.timeSheet = timeSheet;
            InitializeComponent();
        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 0));
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void clockoutButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 1));
                ShowMessage("Time-out Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void ShowMessage(string message, bool Issucceed)
        { //Implement DRY Principle
            if (Issucceed)
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            { //Display Warrning Icon
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            cardnoTextBox.Clear();
            cardnoTextBox.Focus();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }

      
    }
}
