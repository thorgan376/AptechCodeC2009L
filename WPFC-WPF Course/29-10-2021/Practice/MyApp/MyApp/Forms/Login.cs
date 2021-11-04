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
        public Login()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"username: {txtUsername.Text}, address = {txtPassword.Text}");
            if (this.StudentList == null)
            {
                this.StudentList = new StudentList();
                this.StudentList.Login = this;
                this.StudentList.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
