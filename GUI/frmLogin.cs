using BLL;
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

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BLL_Account bllAccount = new BLL_Account();
        BLL_Employee bllEmployee = new BLL_Employee();
        public Form NextForm { get; private set; } // Lưu form tiếp theo

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlLogo.BackColor = ColorTranslator.FromHtml("#AF262E");

            label1.ForeColor = ColorTranslator.FromHtml("#52362A");
            label2.ForeColor = ColorTranslator.FromHtml("#52362A");
            label3.ForeColor = ColorTranslator.FromHtml("#52362A");

            btnLogin.BackColor = ColorTranslator.FromHtml("#52362A");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.BackColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.ForeColor = ColorTranslator.FromHtml("#AF262E");

            this.Icon = new Icon("icon-1.ico");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            // Kiểm tra thông tin đăng nhập
            var account = bllAccount.GetAll().FirstOrDefault(a => a.AccountName.ToLower() == username.ToLower() && a.Password == password);
            if (account != null)
            {
                var employee = bllEmployee.GetDataEmployee().FirstOrDefault(em => em.EmployeeId == account.EmployeeId);
                if (employee != null)
                {
                    if (account.AccountId == 1)
                    {
                        NextForm = new frmAdMain(employee);
                    }
                    else if (employee.Role == "Quản lý" || employee.Role == "Nhân viên")
                    {
                        NextForm = new frmMain(employee);
                    }
                }


                // Đăng nhập thành công
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Vui lòng nhập đúng tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();
            }
            //var employee = bllEmployee.GetDataEmployee().First(em => em.EmployeeId == 1);
            //NextForm = new frmMain(employee);

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
