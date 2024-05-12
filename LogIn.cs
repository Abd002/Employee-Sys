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
    public partial class LogInForm : MaterialForm
    {
        long nationalID;
        string password;

        private void LogInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDatabaseDataSet.emplyee' table. You can move, or remove it, as needed.
            this.emplyeeTableAdapter.Fill(this.employeeDatabaseDataSet.emplyee);
        }
        public LogInForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register formLogin = new Register();
            this.Hide();
            formLogin.FormClosed += (s, args) => this.Close();
            formLogin.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            nationalID = long.Parse(nationalIdTextBox.Text);

            password = passwordTextBox.Text;

            
            if(this.emplyeeTableAdapter.AcceptedAccountLogin(nationalID, password).ToString() == "0")
            {
                MessageBox.Show("enter valid nationalID & Password");
                return;
            }

            Department formLogin = new Department(nationalID);
            this.Hide();
            formLogin.FormClosed += (s, args) => this.Close();
            formLogin.Show();

        }
    }
}
