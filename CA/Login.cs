using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;


namespace CA
{
    public partial class Login : Form
    {
        public LoginUser loginUser = new LoginUser();
        public Operations operations = new Operations();
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginUser.Username = txtUsername.Text;
            loginUser.Password = txtPassword.Text;

            dt = operations.login(loginUser);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome, " + loginUser.Username.ToUpperInvariant());
                this.Hide();
                MainStudentForm landingPage = new MainStudentForm();
                landingPage.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
