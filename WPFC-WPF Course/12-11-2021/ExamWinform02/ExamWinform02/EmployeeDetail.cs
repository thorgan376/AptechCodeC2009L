using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWinform02
{
    public partial class EmployeeDetail : Form
    {
        public MainForm MainForm;
        public EmployeeDetail()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text.Length <= 5) {
                MessageBox.Show("Employee name's length must be >= 5 characters");
                return;
            }
            if (dateTimePickerBirthdate.Value.Year > 1999) {
                MessageBox.Show("Birth's year must <= 1999");
                return;
            }
            if (txtTelephone.Text.Length <= 6)
            {
                MessageBox.Show("Telephone must > 6 characters");
                return;
            }
            else {                
                if (!txtTelephone.Text.Substring(0, 1).Equals("0")) {
                    MessageBox.Show("First character of telephone must be 0");
                    return;
                }
            }
            //insert to DB
            this.Hide();
            this.MainForm.Show();
            this.MainForm.GroupBoxMain.Show();
        }
    }
}
