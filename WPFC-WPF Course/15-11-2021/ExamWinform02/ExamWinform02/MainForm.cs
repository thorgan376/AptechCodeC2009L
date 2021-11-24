using ExamWinform02.Models;
using ExamWinform02.Repositories;
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
        private EmployeeDetail employeeDetail = new EmployeeDetail();
        private List<Department> departments = new List<Department>();
        private DepartmentRepository departmentRepository = new DepartmentRepository();
        private EmployeeRepository employeeRepository = new EmployeeRepository();
        private Department selectedDepartment;
        public GroupBox GroupBoxMain
        {
            get => groupBoxMain;
        }
        public MainForm()
        {
            InitializeComponent();
            treeView.AfterSelect += TreeView_AfterSelect;
            this.Text = "Human management system";
            LoadDepartmentsToTreeView();            
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.Write("haha");
            //Get selected department here
            List<Employee> filteredEmployees =  employeeRepository.GetEmployeesFromDepartmentId(selectedDepartment.DeptID);
            //fetch employees to the ListView            

        }

        private void LoadDepartmentsToTreeView() {

            departments = departmentRepository.GetAllDepartments();
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            treeView.Nodes.Add("Employees");
            foreach (Department department in departments) {
                treeView.Nodes[0].Nodes.Add(department.DeptName);
            }                     
            treeView.EndUpdate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {            
            employeeDetail.MdiParent = this;
            employeeDetail.WindowState = FormWindowState.Maximized;
            employeeDetail.MainForm = this;
            employeeDetail.Show();
            groupBoxMain.Hide();
        }
    }
}
