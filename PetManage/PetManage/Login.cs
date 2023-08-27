using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for the database......
using System.Configuration;
using Microsoft.Identity.Client;

namespace PetManage
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void clearButton_Click_1(object sender, EventArgs e)
        {
            selectRoleComboBox.SelectedIndex = -1;
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (selectRoleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a role");
                return;
            }
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and Password are compulsory");
                return;
            }
            string uName = userNameTextBox.Text;
            string pw = passwordTextBox.Text;

            User userObj = new User();
            bool authenticationResult = userObj.isAuthenticated(uName, pw, selectRoleComboBox.SelectedIndex);
            if (authenticationResult)
            {
                if (selectRoleComboBox.SelectedIndex == 0)
                {
                    FormHome formHome = new FormHome();
                    formHome.Show();
                    this.Hide();
                }
                else
                {
                    FormBilling formBilling = new FormBilling();
                    formBilling.Show();
                    this.Hide();
                }
            }
        }
    }
}
