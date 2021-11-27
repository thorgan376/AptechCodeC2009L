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
enum InsertOrUpdate {
    Insert,
    Update
}
namespace MyApp.Forms
{

    public partial class StudentList : Form
    {
        private StudentRepository studentRepository = new StudentRepository();
        private InsertOrUpdate insertOrUpdate = InsertOrUpdate.Update;
        string selectedUserName = "";
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

            //Set AutoGenerateColumns False bởi vì chỉ cần 4 cột, không cần tất cả các cột

            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;

            dataGridView.BackgroundColor = Color.White;
            dataGridView.RowHeadersVisible = false;
            //Set Columns Count: Tạo các cột trước để fetch dữ liệu vào, ko có nó sẽ lỗi
            dataGridView.DataSource = null;
            dataGridView.ColumnCount = 4 ;
            
            //Đặt thông tin của các column trong dataGridView dưới đây
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

            //cách cũ: chia các cột nhưng ko đều
            //dataGridView.AutoSizeColuzmnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                // Store Auto Sized Widths:
                //int colw = dataGridView.Columns[i].Width;

                // Remove AutoSizing:
                //dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                // Cách trên đúng nhất vì các cột sẽ tự chia đúng với độ dài của dữ liệu trong ô,
                // còn cách dưới thì chia đều khoảng cách giữa các cột
                column.Width = dataGridView.Width / dataGridView.Columns.Count;
            }

            dataGridView.DataSource = dataSet.Tables[0];
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedItem = dataGridView.SelectedRows.Count > 0 ? dataGridView.SelectedRows[0] : null;
            btnDelete.Enabled = selectedItem != null;
            if (selectedItem != null) {
                insertOrUpdate = InsertOrUpdate.Update;
                txtClassCode.Text = selectedItem.Cells[0].FormattedValue.ToString();
                txtStudentName.Text = selectedItem.Cells[1].FormattedValue.ToString();
                txtUsername.Text = selectedItem.Cells[2].FormattedValue.ToString();
                // vì sao phải để một biến bằng cái này vì để tránh trg hợp ng dùng chưa chọn hàng mà đã ấn nút xóa
                this.selectedUserName = selectedItem.Cells[2].FormattedValue.ToString();
                txtAddress.Text = selectedItem.Cells[3].FormattedValue.ToString(); 
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserName == "")
            {
                MessageBox.Show("You must select 1 person to delete","Delete",
                                         MessageBoxButtons.OK);
                return;
            }
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {                    
                    studentRepository.DeleteStudentByID(selectedUserName);
                    selectedUserName = "";
                    FillDataToGridView();
                }
                else {
                    // If 'No' or anything else, do nothing.
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
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export", "Export XML Information", MessageBoxButtons.OK);
                }
                else if (dataGridView.Rows.Count != 0)
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
            if (insertOrUpdate == InsertOrUpdate.Insert) {
                studentRepository.InsertStudent(txtClassCode.Text, txtStudentName.Text, txtUsername.Text, txtAddress.Text);
            }
                txtClassCode.Text = "";
                txtStudentName.Text = "";
                txtUsername.Text = "";
                txtAddress.Text = "";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertOrUpdate = InsertOrUpdate.Insert;

            if (string.IsNullOrEmpty(this.txtClassCode.Text) ||
                string.IsNullOrEmpty(this.txtAddress.Text) ||
                string.IsNullOrEmpty(this.txtStudentName.Text) ||
                string.IsNullOrEmpty(this.txtUsername.Text))
            {
                MessageBox.Show("All field is required","Remmember");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this is not in the test so I just use it for fun
            txtClassCode.Text = "";
            txtStudentName.Text = "";
            txtUsername.Text = "";
            txtAddress.Text = "";
        }
    }
}
