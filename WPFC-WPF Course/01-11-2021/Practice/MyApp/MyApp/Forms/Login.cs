using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.Models;
using MyApp.Repositories;

namespace MyApp.Forms
{
    public partial class Login : Form
    {
        public StudentList StudentList { get; set; }
        private UserRepository userRepository = new UserRepository(); 
        public Login()
        {
            InitializeComponent();
            txtUsername.Text = "hungnv";
            txtPassword.Text = "123456";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int check = 0;
            String userName = txtUsername.Text;
            String password = txtPassword.Text;
            if (userName.Equals("") || password.Equals(""))
            {
                check = 1;
                MessageBox.Show("Every Field Is Required");
            }
            else 
            {
                try
                {
                    Student student = userRepository.Login(userName, password);
                    if (student != null)
                    {
                        if (this.StudentList == null)
                        {
                            this.StudentList = new StudentList();
                            this.StudentList.Login = this;
                            this.StudentList.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Internal Error: {ex.Message}");
                    throw;
                }
            }
            //MessageBox.Show($"username: {txtUsername.Text}, address = {txtPassword.Text}");
            //Login success

            if (check == 0)
            {
                MessageBox.Show("Incorrect UserName or Password");
            }        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
