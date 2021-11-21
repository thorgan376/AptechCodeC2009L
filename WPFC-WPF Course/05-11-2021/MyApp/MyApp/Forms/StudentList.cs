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
            HideButton();
        }
        private void HideButton()
        {
            btnSave.Enabled = false;
            btnExportXML.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
        }
        
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FillDataToGridView();
            btnExportXML.Enabled = true;
            btnInsert.Enabled=true;
            btnUpdate.Enabled=true;
        }
        private void FillDataToGridView() {
            DataSet dataSet = studentRepository.GetStudentsDataSet();

            //Set AutoGenerateColumns False Because We only need 4 Columns not all the columns

            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            //Set Columns Count: Tạo các cột trước để fetch dữ liệu vào, ko có nó sẽ lỗi
            dataGridView.DataSource = null;
            dataGridView.ColumnCount = 4 ;
            
            //Add Columns Down Here
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

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView.DataSource = dataSet.Tables[0];
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedItem = dataGridView.SelectedRows.Count > 0 ? dataGridView.SelectedRows[0] : null;
            btnDelete.Enabled = selectedItem != null;
            if (selectedItem != null) {
                txtClassCode.Text = selectedItem.Cells[0].FormattedValue.ToString();
                txtStudentName.Text = selectedItem.Cells[1].FormattedValue.ToString();
                txtUsername.Text = selectedItem.Cells[2].FormattedValue.ToString();
                txtAddress.Text = selectedItem.Cells[3].FormattedValue.ToString(); 
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in dataGridView.SelectedRows)
                    {
                        dataGridView.Rows.RemoveAt(item.Index);
                        //studentRepository.DeleteStudentByID();
                        btnSave.Enabled = true;
                    }
                }
                else if (confirmResult == DialogResult.No)
                {
                    // If 'No', do nothing.
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.DataSource == null)
                {
                    MessageBox.Show("No data to export", "Export XML Information", MessageBoxButtons.OK);
                }
                else if (dataGridView.DataSource != null)
                {
                    MessageBox.Show("Export Successfully", "Export XML Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                studentRepository.InsertStudent(txtClassCode.Text, txtStudentName.Text, txtUsername.Text, txtAddress.Text);
                txtClassCode.Text = "";
                txtStudentName.Text = "";
                txtUsername.Text = "";
                txtAddress.Text = "";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtClassCode.Text) ||
                string.IsNullOrEmpty(this.txtAddress.Text) ||
                string.IsNullOrEmpty(this.txtStudentName.Text) ||
                string.IsNullOrEmpty(this.txtUsername.Text))
            {
                MessageBox.Show("All field is required","Remmember ?!");
            }
            else
            {
                btnSave.Enabled = true;
            }  
        }

        private void btnExitStudentList_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
