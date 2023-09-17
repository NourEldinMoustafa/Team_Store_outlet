using Login.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = username_textBox.Text;
                string password = password_textBox.Text;

                if(username == "admin" && password == "admin")
                {
                    this.Hide();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.ShowDialog();
                }
                else
                    MessageBox.Show("Wrong Password or Username","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
