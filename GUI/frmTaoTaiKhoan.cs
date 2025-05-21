using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();

        private BLL_Account bllAccount = new BLL_Account();
        private BLL_Employee bllEmployee = new BLL_Employee();

        private void ClearDuLieuNhap()
        {
            txtTen.Clear();
            txtMK.Clear();
            txtXacNhanMK.Clear();
            txtTen.Focus();
        }

        private void LoadNhanVien()
        {
            //MessageBox.Show(currentEmployee.BranchId.ToString());
            var employees = from e in bllEmployee.GetDataEmployee()
                            where e.BranchId == currentEmployee.BranchId && e.EmployeeId != 1
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
            var account = bllAccount.GetAll().FirstOrDefault(a => a.EmployeeId == currentEmployee.EmployeeId);

            if (account != null)
            {
                if (account.AccountId == 1)
                {
                    employees = from e in bllEmployee.GetDataEmployee()
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
                }
            }

            dgvNhanVien.DataSource = employees.ToList();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                string maNV = row.Cells["EmployeeId"].Value.ToString();

                var account = bllAccount.GetAll().FirstOrDefault(a => a.EmployeeId == int.Parse(maNV));
                if (account != null)
                {
                    txtTen.Text = account.AccountName;
                    txtMK.Text = account.Password;
                }
                else
                {
                    ClearDuLieuNhap();
                }
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            ClearDuLieuNhap();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtMK.Text) || string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var account = new Account
                {
                    AccountName = txtTen.Text,
                    Password = txtMK.Text,
                    EmployeeId = int.Parse(dgvNhanVien.CurrentRow.Cells["EmployeeId"].Value.ToString())
                };
                bllAccount.Add(account);
                ClearDuLieuNhap();
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            try
            {
                var account = bllAccount.GetAll().FirstOrDefault(a => a.EmployeeId == int.Parse(dgvNhanVien.CurrentRow.Cells["EmployeeId"].Value.ToString()));
                int accountId = account.AccountId;
                bllAccount.Delete(accountId);
                ClearDuLieuNhap();
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtMK.Text) || string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMK.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Tìm tài khoản của nhân viên được chọn để cập nhật
                var account = bllAccount.GetAll().FirstOrDefault(a => a.EmployeeId == int.Parse(dgvNhanVien.CurrentRow.Cells["EmployeeId"].Value.ToString()));
                if (account != null) {
                    account.AccountName = txtTen.Text;
                    account.Password = txtMK.Text;

                    bllAccount.Update(account);
                    ClearDuLieuNhap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }
        }
    }
}
