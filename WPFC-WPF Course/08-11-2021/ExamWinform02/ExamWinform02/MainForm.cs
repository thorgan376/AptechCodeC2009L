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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Human management system";
            LoadDepartmentsToTreeView();
        }
        private void LoadDepartmentsToTreeView() {

            treeView.BeginUpdate();
            treeView.Nodes.Add("Employees");
            treeView.Nodes[0].Nodes.Add("Child 1");
            treeView.Nodes[0].Nodes.Add("Child 2");            
            treeView.EndUpdate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
