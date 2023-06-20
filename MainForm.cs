using AttendanceManagementSystem.Features;

namespace AttendanceManagementSystem
{
    public partial class MainForm : Form
    {
        public TimeSheet AppTimeSheet = new TimeSheet();
        public MainForm()
        {
            InitializeComponent();


            //Load the data from timesheet.jos
            AppTimeSheet = TimeSheetDataStorage.LoadTimeSheetFromStorage();

        }

        private void timeRecordButton_Click(object sender, EventArgs e)
        {
            ClockManagement cfrm = new ClockManagement(AppTimeSheet);
            cfrm.ShowDialog();
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(AppTimeSheet);
            form.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSheetDataStorage.SaveTimeSheetToStorage(AppTimeSheet);
        }
    }
}