using MyApp.Models;
using MyApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //MessageBox.Show($"username: {txtUsername.Text}, address = {txtPassword.Text}");
            //Login success
            try {
                Student student = userRepository.Login(txtUsername.Text,
                    txtPassword.Text);
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
                else {
                    MessageBox.Show("Incorrect username and password");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Internal error: {ex.Message}");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
