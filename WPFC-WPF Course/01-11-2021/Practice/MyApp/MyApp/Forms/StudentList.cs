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
    public partial class StudentList : Form
    {
        public Login Login { get; set; }
        public StudentList()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                MessageBox.Show("Fuck you man");
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export successfully");
        }

    }
}
