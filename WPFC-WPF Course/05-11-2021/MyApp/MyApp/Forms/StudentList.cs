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
    public partial class StudentList : Form
    {
        private StudentRepository studentRepository = new StudentRepository();        
        public Login Login { get; set; }
        public StudentList()
        {
            InitializeComponent();
            FillDataToGridView();
        }   
        private void FillDataToGridView() {
            DataSet dataSet = studentRepository.GetStudentsDataSet();
            
            //Set AutoGenerateColumns False
            dataGridView.AutoGenerateColumns = false;

            //Set Columns Count
            dataGridView.ColumnCount = 4;            
            //Add Columns
            dataGridView.Columns[0].Name = "TenLop";
            dataGridView.Columns[0].HeaderText = "Ten lop";
            dataGridView.Columns[0].DataPropertyName = "TenLop";

            dataGridView.Columns[1].Name = "TenSV";
            dataGridView.Columns[1].HeaderText = "Ten SV";
            dataGridView.Columns[1].DataPropertyName = "TenSV";

            dataGridView.Columns[2].Name = "UserNm";
            dataGridView.Columns[2].HeaderText = "UserNm";
            dataGridView.Columns[2].DataPropertyName = "UserNm";

            dataGridView.Columns[3].Name = "DiaChi";
            dataGridView.Columns[3].HeaderText = "Dia chi";
            dataGridView.Columns[3].DataPropertyName = "DiaChi";

            dataGridView.DataSource = dataSet.Tables[0];            
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedItem = dataGridView.SelectedRows.Count > 0 ? dataGridView.SelectedRows[0] : null;
            if (selectedItem != null) {
                txtClassName.Text = selectedItem.Cells[0].ToString();
                txtStudentName.Text = selectedItem.Cells[1].ToString();
                txtUsername.Text = selectedItem.Cells[2].ToString();
                txtAddress.Text = selectedItem.Cells[3].ToString();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
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
