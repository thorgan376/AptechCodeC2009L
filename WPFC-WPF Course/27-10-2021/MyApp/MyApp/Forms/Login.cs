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
        public Login()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"username: {txtUsername.Text}, address = {txtPassword.Text}");
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
