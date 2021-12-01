using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class EmployeeList : Form
    {
        public Department Department { get; set; }
        public EmployeeList()
        {
            this.AutoSize = true;
            InitializeComponent();
            createListView();
            List<Department> allDepartments = Database.GetInstance().GetAllDepartments();
            if (allDepartments.Count > 0) {
                this.Department = allDepartments.First();
                fetchEmployees(
                    allDepartments.First().DepartmentID                    
                    );
            }
            
        }
        private void createListView() {
            
            listViewEmployees.View = View.Details;
            listViewEmployees.Columns.Add("Employee's ID");
            listViewEmployees.Columns.Add("Employee's Name");
            listViewEmployees.Columns.Add("Department");
            listViewEmployees.Columns.Add("Gender");
            listViewEmployees.Columns.Add("BirthDate");
            listViewEmployees.Columns.Add("Tel");
            listViewEmployees.Columns.Add("Address");
            

            listViewEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);            
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopulateDataToTreeView() {
            List<Department> departments = Database.GetInstance().GetAllDepartments();
            foreach (var department in departments) {
                treeViewDepartments.Nodes.Add($"{department.DepartmentName}:{department.DepartmentID}");
            }
            treeViewDepartments.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView_NodeMouseClick);
            
        }
        void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {            
            int departmentId = Convert.ToInt32(e.Node.Text.Split(':')[1]);
            this.Department = Database.GetInstance().GetDepartmentById(departmentId);
            fetchEmployees(departmentId);
        }
        private void fetchEmployees(int departmentId) {
            List<Employee> employees = Database.GetInstance().GetEmployees(departmentId);            
            listViewEmployees.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem listViewItem = new ListViewItem(employee.EmployeeID.ToString());
                listViewItem.SubItems.Add(employee.EmployeeName);
                listViewItem.SubItems.Add(Database.GetInstance()
                    .GetDepartmentById(departmentId).DepartmentName);
                listViewItem.SubItems.Add(employee.Gender);
                listViewItem.SubItems.Add(employee.BirthDate.ToString());
                listViewItem.SubItems.Add(employee.Telephone);
                listViewItem.SubItems.Add(employee.Address);
                listViewEmployees.Items.Add(listViewItem);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        { 
            PopulateDataToTreeView();           
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeesProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeDetail detailEmployeeForm = new EmployeeDetail();
            detailEmployeeForm.Department = this.Department;
            mainPanel.Hide();
            detailEmployeeForm.MdiParent = this;
            detailEmployeeForm.Show();
            detailEmployeeForm.BringToFront();
            detailEmployeeForm.FormClosing += DetailEmployeeForm_FormClosing;
        }

        private void DetailEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainPanel.Show();
        }
    }
}
