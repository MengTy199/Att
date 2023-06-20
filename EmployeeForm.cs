using AttendanceManagementSystem.Entities;
using AttendanceManagementSystem.Features;
namespace AttendanceManagementSystem
{
    public partial class EmployeeForm : Form
    {
        TimeSheet timeSheet;
        public EmployeeForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
            LoadToGrid();
            //disable update button
            updateButton.Enabled = false;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
        }
        public void ClearAll()
        {
            fullnameTextBox.Clear();
            positionTextBox.Clear();
            cardnoTextBox.Clear();
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            fullnameTextBox.Focus();
            saveButton.Enabled = true;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee(
                    fullnameTextBox.Text.Trim(),
                    positionTextBox.Text.Trim(),
                    cardnoTextBox.Text.Trim()
                    );

                timeSheet.AddEmployee(emp, cardnoTextBox.Text);
                LoadToGrid();// update the gridview 
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.UpdateEmployee(identityTextBox.Text, fullnameTextBox.Text, positionTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = true;
                updateButton.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                identityTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();

                addnewButton.Enabled = false;
                saveButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }


        public void LoadToGrid()
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee();
            dataGridView1.Refresh();//show the lastest data
        }
        public void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView1.DataSource = timeSheet.GetAllEmployee(isSimpleVersion);
            dataGridView1.Refresh();//show the lastest data
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                /* throw new ArgumentException("Did you went to delete!")*/
                if (MessageBox.Show("Do you went to delete or not? ",
               "Employee Form",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information
               ) == DialogResult.Yes)
                {
                      timeSheet.DeleteEmployee(identityTextBox.Text, fullnameTextBox.Text, positionTextBox.Text);
                }
                LoadToGrid();
                identityTextBox.Clear();
                ClearAll();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = true;
            }
        }
    }
}
