using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanResources.Models;
using HumanResources.Database;

namespace HumanResources.Forms
{
    public partial class DepartmentDetails : Form
    {
        private Department department;
        private List<Department> departments;
        private Employee employee = new Employee();

        public Department Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;

                comboBoxDepartment.SelectedIndex = getIndexOfDepartment(department);
            }
        }
        private int getIndexOfDepartment(Department department)
        {
            int i = 0;
            foreach (var item in comboBoxDepartment.Items)
            {
                if ((item as Department).DepartmentID == department.DepartmentID)
                {
                    return i;
                }
                i++;
            }
            return i;
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Selected value = {comboBoxDepartment.SelectedValue}");
        }
        public EmployeeDetail()
        {
            InitializeComponent();
            departments = Database.GetInstance().GetAllDepartments();
            comboBoxDepartment.DataSource = departments;
            comboBoxDepartment.DisplayMember = "DepartmentName";
            comboBoxDepartment.SelectedIndexChanged += this.comboBoxDepartment_SelectedIndexChanged;
            radioButtonFemale.CheckedChanged += this.radioButtonGender_CheckedChanged;
            radioButtonMale.CheckedChanged += this.radioButtonGender_CheckedChanged;
        }
        private void radioButtonGender_CheckedChanged(object sender, EventArgs e)
        {

            if ((sender as RadioButton).Name.Equals("radioButtonMale"))
            {
                radioButtonFemale.Checked = false;
            }
            else
            {
                radioButtonMale.Checked = false;
            }

        }


        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            employee.EmployeeName = txtEmployeeName.Text ?? "";
            employee.BirthDate = dateTimePickerBirthDate.Value;
            employee.Address = txtAddress.Text;
            employee.Telephone = txtTelephone.Text;
            employee.DepartmentID = (comboBoxDepartment.SelectedItem as Department).DepartmentID;
            employee.Gender = radioButtonMale.Checked ? "Male" : "Female";
            if (employee.EmployeeName.Length == 0 ||
                DateTime.Now.Subtract(employee.BirthDate).Days < 18 * 365 ||
                employee.Address.Length == 0 ||
                employee.DepartmentID == 0
                )
            {
                MessageBox.Show("Invalid input data");
                return;
            }
            Database.GetInstance().insertEmployee(employee);
        }
    }
}
