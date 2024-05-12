using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Department : MaterialForm
    {
        long nationalID;

        public Department(long nationalID)
        {
            this.nationalID = nationalID;
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDatabaseDataSet);

        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDatabaseDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.employeeDatabaseDataSet.department);

            this.departmentTableAdapter.GetAllDepartment(this.employeeDatabaseDataSet.department, nationalID);


            departmentComboBox.Items.Clear();
            foreach (EmployeeDatabaseDataSet1.departmentRow row in employeeDatabaseDataSet.department.Rows)
            {
                if (row.nationalID == nationalID)
                {
                    string departmentName = row.department;
                    departmentComboBox.Items.Add(departmentName);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string selectedItem=departmentComboBox.SelectedItem.ToString();
            this.departmentTableAdapter.DeleteDepartment(this.employeeDatabaseDataSet.department, nationalID, departmentComboBox.SelectedItem.ToString());

            Department formLogin = new Department(nationalID);
            this.Hide();
            formLogin.FormClosed += (s, args) => this.Close();
            formLogin.Show();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string department = departmentTextBox1.Text;
            this.departmentTableAdapter.InsertDepartment(nationalID, department);
            departmentTextBox1.Clear();
            departmentComboBox.Items.Add(department);


        }

    }
}
