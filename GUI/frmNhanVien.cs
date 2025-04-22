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
    public partial class frmNhanVien : Form
    {
        private BLL_Employee bll = new BLL_Employee();
        private int branchId;
        private int currentManagerId;
        public frmNhanVien(int branchId, int currentManagerId)
        {
            InitializeComponent();
            this.branchId = branchId;
            this.currentManagerId = currentManagerId;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            LoadData();
        }

        public void LoadData()
        {
            List<Employee> list = bll.GetEmployeesForManager(branchId, currentManagerId);
            dgvEmp.DataSource = list;
            //Lấy danh sách các vai trò
            cboRole.DataSource = bll.GetRoles();
            //Tính tổng lương
            txtOur.TextChanged += TinhTongLuong;
            txtSalary.TextChanged += TinhTongLuong;
        }

        private void TinhTongLuong(object sender, EventArgs e)
        {
            if (int.TryParse(txtOur.Text, out int overTimeHour) && double.TryParse(txtSalary.Text, out double baseSalary))
            {
                double totalSalary = baseSalary * overTimeHour;
                txtTotal.Text = totalSalary.ToString("0.##");
            }
            else
            {
                txtTotal.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOur.Text, out int overTimeHour))
            {
                MessageBox.Show("Giờ làm không hợp lệ!");
                return;
            }
            if (!double.TryParse(txtSalary.Text, out double baseSalary))
            {
                MessageBox.Show("Lương CB không hợp lệ!");
                return;
            }

            if (!double.TryParse(txtTotal.Text, out double totalSalary))
            {
                MessageBox.Show("Tổng lương không hợp lệ!");
                return;
            }

            Employee em = new Employee
            {
                EmployeeName = txtName.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text,
                Role = cboRole.Text,
                HireDate = dtpHire.Value,
                BranchId = int.Parse(txtId.Text),
                OverTimeHour = int.Parse(txtOur.Text),
                BaseSalary = double.Parse(txtSalary.Text),
                TotalSalary = double.Parse(txtTotal.Text)
            };

            if (bll.Add(em))
                MessageBox.Show("Thêm thành công", "Thông Báo");
            else
                MessageBox.Show("Thêm thất bại", "Thông Báo");

            LoadData();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmp.Rows[e.RowIndex];

                txtId.Text = row.Cells["EmployeeId"].Value?.ToString();
                txtName.Text = row.Cells["EmployeeName"].Value?.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                cboRole.Text = row.Cells["Role"].Value?.ToString();
                txtOur.Text = row.Cells["OverTimeHour"].Value?.ToString();
                txtSalary.Text = row.Cells["BaseSalary"].Value?.ToString();
                txtTotal.Text = row.Cells["TotalSalary"].Value?.ToString();

                if (row.Cells["HireDate"].Value != null)
                {
                    dtpHire.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cboRole.SelectedIndex = -1;
            dtpHire.Value = DateTime.Now;
            txtOur.Clear();
            txtSalary.Clear();
            txtTotal.Clear();
            txtAccount.Clear();
            txtPassword.Clear();
            txtPasswords.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                    "Xác Nhận Xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                if (bll.Delete(id))
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                else
                    MessageBox.Show("Xóa thất bại", "Thông Báo");

                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee em = new Employee
            {
                EmployeeId = int.Parse(txtId.Text),
                EmployeeName = txtName.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text,
                Role = cboRole.Text,
                HireDate = dtpHire.Value,
                BranchId = int.Parse(txtId.Text),
                OverTimeHour = int.Parse(txtOur.Text),
                BaseSalary = double.Parse(txtSalary.Text),
                TotalSalary = double.Parse(txtTotal.Text)
            };

            if (bll.Update(em))
                MessageBox.Show("Cập nhật thành công", "Thông Báo");
            else
                MessageBox.Show("Cập nhật thất bại", "Thông Báo");

            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create account
            string username = txtAccount.Text.Trim();
            string password = txtPassword.Text.Trim();
            string rePassword = txtPasswords.Text.Trim();

            if (password != rePassword)
            {
                MessageBox.Show("Mật khẩu và Nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedEmployeeId = Convert.ToInt32(txtId.Text);

            Account acc = new Account
            {
                AccountName = username,
                Password = password,
                EmployeeId = selectedEmployeeId,
                CreateDate = DateTime.Now
            };

            bool result = bll.AddAccount(acc);

            if (result)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
                LoadData();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại. Có thể tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clear input
        private void ClearInput()
        {
            txtAccount.Clear();
            txtPassword.Clear();
            txtPasswords.Clear();
        }
    }
}
