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
    public partial class Register : MaterialForm
    {
        long nationalID, salary;
        string fullName, gender, dateOfBirth, job, password;

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDatabaseDataSet.emplyee' table. You can move, or remove it, as needed.
            this.emplyeeTableAdapter.Fill(this.employeeDatabaseDataSet.emplyee);

        }


        public Register()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogInForm formLogin = new LogInForm();
            this.Hide();
            formLogin.FormClosed += (s, args) => this.Close();
            formLogin.Show();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            nationalID = long.Parse(nationalIdTextBox.Text);
            fullName = fullNameTextBox.Text;

            if (maleRadioBox.Checked) gender = "Male";
            if (femaleRadioBox.Checked) gender = "Female";

            dateOfBirth = DOBBicker.Value.ToString("yyyy-MM-dd");

            job = jobComboBox.SelectedItem.ToString();

            password = passwordTextBox.Text;

            salary = (long)salaryUpDown.Value;


            if (this.tableAdapterManager.emplyeeTableAdapter.AcceptedAccountRegister(nationalID).ToString() == "1")
            {
                MessageBox.Show("Enter Valid nationalID");
                return;
            } 

            this.tableAdapterManager.emplyeeTableAdapter.InsertNewAccount(nationalID, fullName, gender, dateOfBirth, job,
                password, salary);

            LogInForm formLogin = new LogInForm();
            this.Hide();
            formLogin.FormClosed += (s, args) => this.Close();
            formLogin.Show();
        }
    }
}
