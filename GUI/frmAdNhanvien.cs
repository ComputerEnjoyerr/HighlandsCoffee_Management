using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmAdNhanvien : Form
    {
        public frmAdNhanvien()
        {
            InitializeComponent();
        }
        private BLL_Employee bllEmployee = new BLL_Employee();
        private BLL_Branch bllBranch = new BLL_Branch();
        private void frmAdNhanvien_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvNhanVien.DataSource = bllEmployee.GetDataEmployee();
            LoadComboBoxRole();
            LoadComboBox();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                cbBranchId.SelectedValue = row.Cells[1].Value;
                txtHoTen.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                cbChucVu.Text = row.Cells[6].Value.ToString();
                dtNgayVaoLam.Text = row.Cells[7].Value.ToString();
                txtGioLamThem.Text = row.Cells[2].Value.ToString();
                txtLuongCB.Text = row.Cells[8].Value.ToString();
                txtTongThuNhap.Text = row.Cells[9].Value.ToString();
               

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGioLamThem.Text, out int overTimeHour))
            {
                MessageBox.Show("Giờ làm không hợp lệ!");
                return;
            }
            if (!double.TryParse(txtLuongCB.Text, out double baseSalary))
            {
                MessageBox.Show("Lương CB không hợp lệ!");
                return;
            }

            if (!double.TryParse(txtLuongCB.Text, out double totalSalary))
            {
                MessageBox.Show("Tổng lương không hợp lệ!");
                return;
            }

            //if (!double.TryParse(txtSoLuong.Text, out double quantity) || quantity < 0)
            //{
            //    MessageBox.Show("Số lượng phải là một số không âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            var emp = new Employee
            {

                
                EmployeeName = txtHoTen.Text,
                Address = txtDiaChi.Text,
                PhoneNumber = txtPhone.Text,
                Role = cbChucVu.Text,
                HireDate = dtNgayVaoLam.Value,
                OverTimeHour = overTimeHour,
                BaseSalary = baseSalary,
                TotalSalary = totalSalary,
                BranchId = (int)cbBranchId.SelectedValue//ép kiểu int
                

            };

            bllEmployee.AddEmployee(emp);
            MessageBox.Show("Thêm thành công!");
            dgvNhanVien.DataSource = bllEmployee.GetDataEmployee();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtPhone.Clear();
            txtGioLamThem.Clear();
            txtHoTen.Clear();
            txtLuongCB.Clear();
            txtMaNV.Clear();
            txtTongThuNhap.Clear();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaNV.Text);
                bllEmployee.DeleteEmployee(id);
                MessageBox.Show("Xóa thành công!");
                dgvNhanVien.DataSource = bllEmployee.GetDataEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGioLamThem.Text, out int overTimeHour))
            {
                MessageBox.Show("Giờ làm không hợp lệ!");
                return;
            }
            if (!double.TryParse(txtLuongCB.Text, out double baseSalary))
            {
                MessageBox.Show("Lương CB không hợp lệ!");
                return;
            }

            if (!double.TryParse(txtLuongCB.Text, out double totalSalary))
            {
                MessageBox.Show("Tổng lương không hợp lệ!");
                return;
            }
            if (!int.TryParse(txtMaNV.Text, out int id))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
                return;
            }
            var emp = new Employee
            {

                EmployeeId = id,
                EmployeeName = txtHoTen.Text,
                Address = txtDiaChi.Text,
                PhoneNumber = txtPhone.Text,
                Role = cbChucVu.Text,
                HireDate = dtNgayVaoLam.Value,
                OverTimeHour = overTimeHour,
                BaseSalary = baseSalary,
                TotalSalary = totalSalary,
                BranchId = (int)cbBranchId.SelectedValue,
            };

            bllEmployee.UpdateEmployee(emp);
            MessageBox.Show("Sửa thành công!");
            dgvNhanVien.DataSource = bllEmployee.GetDataEmployee();
        }

        private void LoadComboBoxRole()
        {
            cbChucVu.DataSource = bllEmployee.GetRole();
           
        }

        private void LoadComboBox()
        {
            ////cbBranchId.DataSource = bll.GetBranchList(); // hoặc GetBranchComboData()
            //cbBranchId.DisplayMember = "BranchName"; // hoặc "Display" nếu dùng anonymous
            //cbBranchId.ValueMember = "BranchId";     // hoặc "Id" nếu dùng anonymous

            var branches = bllBranch.GetDataBranch().ToList();
            cbBranchId.DataSource = branches;
            cbBranchId.DisplayMember = "BranchName";
            cbBranchId.ValueMember = "BranchId";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var data = bllEmployee.GetDataEmployee().Where(em => em.EmployeeName.ToLower().Contains(txtTim.Text.ToLower())).ToList();
            dgvNhanVien.DataSource = data;
        }
    }
}
