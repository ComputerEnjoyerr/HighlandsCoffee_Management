using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private BLL_Employee bllEmployee = new BLL_Employee();

        public void LoadNhanVien()
        {
            var employees = from e in bllEmployee.GetDataEmployee()
                            where e.BranchId == currentEmployee.BranchId
                            select new
                            {
                                e.EmployeeId,
                                e.EmployeeName,
                                e.PhoneNumber,
                                e.Address,
                                e.HireDate,
                                e.BaseSalary,
                                e.OverTimeHour,
                                e.TotalSalary,
                                e.Role
                            };
            dgvNhanVien.DataSource = employees.ToList();

            //Đặt tên cột
            dgvNhanVien.Columns["EmployeeId"].HeaderText = "Mã NV";
            dgvNhanVien.Columns["EmployeeName"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns["Address"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["HireDate"].HeaderText = "Ngày Vào Làm";
            dgvNhanVien.Columns["BaseSalary"].HeaderText = "Lương Cơ Bản";
            dgvNhanVien.Columns["OverTimeHour"].HeaderText = "Giờ Làm Thêm";
            dgvNhanVien.Columns["TotalSalary"].HeaderText = "Tổng Thu Nhập";
            dgvNhanVien.Columns["Role"].HeaderText = "Chức Vụ";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            txtTongThuNhap.Text = "0";
            txtLuongCB.Text = "0";
            txtGioLamThem.Text = "0";

            LoadNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["EmployeeId"].Value.ToString();
                txtHoTen.Text = row.Cells["EmployeeName"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtDiaChi.Text = row.Cells["Address"].Value.ToString();
                dtNgayVaoLam.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
                txtLuongCB.Text = row.Cells["BaseSalary"].Value.ToString();
                txtTongThuNhap.Text = row.Cells["TotalSalary"].Value.ToString();
                txtGioLamThem.Text = row.Cells["OverTimeHour"].Value.ToString();
                cbChucVu.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtLuongCB.Text) || string.IsNullOrEmpty(txtGioLamThem.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                if (!double.TryParse(txtLuongCB.Text, out double baseSalary) || !double.TryParse(txtTongThuNhap.Text, out double totalSalary) || !int.TryParse(txtGioLamThem.Text, out int overTimeHour))
                {
                    MessageBox.Show("Vui lòng nhập số tiền và giờ làm thêm hợp lệ.");
                    return;
                }
                Employee newEmployee = new Employee
                {
                    EmployeeName = txtHoTen.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtDiaChi.Text,
                    HireDate = dtNgayVaoLam.Value,
                    BaseSalary = baseSalary,
                    TotalSalary = totalSalary,
                    OverTimeHour = overTimeHour,
                    Role = cbChucVu.Text,
                    BranchId = currentEmployee.BranchId
                };
                if (bllEmployee.TestEmployee(newEmployee.EmployeeName, newEmployee.PhoneNumber))
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo");
                    return;
                }
                bllEmployee.AddEmployee(newEmployee);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                    return;
                }
                int employeeId = int.Parse(txtMaNV.Text);
                bllEmployee.DeleteEmployee(employeeId);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật thông tin nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtLuongCB.Text) || string.IsNullOrEmpty(txtGioLamThem.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }
                if (!double.TryParse(txtLuongCB.Text, out double baseSalary) || !double.TryParse(txtTongThuNhap.Text, out double totalSalary) || !int.TryParse(txtGioLamThem.Text, out int overTimeHour))
                {
                    MessageBox.Show("Vui lòng nhập số tiền và giờ làm thêm hợp lệ.");
                    return;
                }
                Employee updatedEmployee = new Employee
                {
                    EmployeeId = int.Parse(txtMaNV.Text),
                    EmployeeName = txtHoTen.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtDiaChi.Text,
                    HireDate = dtNgayVaoLam.Value,
                    BaseSalary = baseSalary,
                    TotalSalary = totalSalary,
                    OverTimeHour = overTimeHour,
                    Role = cbChucVu.Text,
                    BranchId = currentEmployee.BranchId
                };
                bllEmployee.UpdateEmployee(updatedEmployee);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtLuongCB.Text, out double baseSalary) && int.TryParse(txtGioLamThem.Text, out int overTimeHour))
            {
                double totalSalary = baseSalary + (overTimeHour * 200000); 
                txtTongThuNhap.Text = totalSalary.ToString();
            }
            else
            {
                txtTongThuNhap.Text = "0";
            }
        }

        private void txtGioLamThem_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtLuongCB.Text, out double baseSalary) && int.TryParse(txtGioLamThem.Text, out int overTimeHour))
            {
                double totalSalary = baseSalary + (overTimeHour * 200000);
                txtTongThuNhap.Text = totalSalary.ToString();
            }
            else
            {
                txtTongThuNhap.Text = "0";
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Clear();
            LoadNhanVien();
        }

        private void Clear()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtPhone.Clear();
            txtDiaChi.Clear();
            txtLuongCB.Text = "0";
            txtTongThuNhap.Text = "0";
            txtGioLamThem.Text = "0";
            cbChucVu.SelectedIndex = -1;
            dtNgayVaoLam.Value = DateTime.Now;
            txtHoTen.Focus();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var data = bllEmployee.GetDataEmployee()
            .Where(em => em.EmployeeName.Contains(txtTim.Text) && em.BranchId == currentEmployee.BranchId)
            .Select(em => new
            {
                em.EmployeeId,
                em.EmployeeName,
                em.PhoneNumber,
                em.Address,
                em.HireDate,
                em.BaseSalary,
                em.OverTimeHour,
                em.TotalSalary,
                em.Role
            }).ToList();
            dgvNhanVien.DataSource = data;

            //Đặt tên cột
            dgvNhanVien.Columns["EmployeeId"].HeaderText = "Mã NV";
            dgvNhanVien.Columns["EmployeeName"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["PhoneNumber"].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns["Address"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["HireDate"].HeaderText = "Ngày Vào Làm";
            dgvNhanVien.Columns["BaseSalary"].HeaderText = "Lương Cơ Bản";
            dgvNhanVien.Columns["OverTimeHour"].HeaderText = "Giờ Làm Thêm";
            dgvNhanVien.Columns["TotalSalary"].HeaderText = "Tổng Thu Nhập";
            dgvNhanVien.Columns["Role"].HeaderText = "Chức Vụ";
        }
    }
}
