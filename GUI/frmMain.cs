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
    public partial class frmMain : Form
    {
        public frmMain(string role)
        {
            InitializeComponent();
            this.userRole = role;
        }
        private string userRole;
        // Biến tạm
        Form currentForm = new Form();
        int index = 0;
        private void OpenMain(Form childForm)
        {
            // Tắt form hiện tại để chuyển form mới
            if (currentForm != null)
                currentForm.Close();
            // Chỉnh sửa thuộc tính của form mới
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Đưa form mới vào main menu
            childForm.Show();
            currentForm = childForm;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");

            this.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlMenu.BackColor = ColorTranslator.FromHtml("#B12830");
            
            btnThoat.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.BackColor = ColorTranslator.FromHtml("#B12830");

            btnDatMon.BackColor = ColorTranslator.FromHtml("#52362A");
            btnDatMon.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnThanhToan.BackColor = ColorTranslator.FromHtml("#52362A");
            btnThanhToan.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnLichSu.BackColor = ColorTranslator.FromHtml("#52362A");
            btnLichSu.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            
            btnThuNhap.BackColor = ColorTranslator.FromHtml("#52362A");
            btnThuNhap.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnThemNV.BackColor = ColorTranslator.FromHtml("#52362A");
            btnThemNV.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnDangXuat.BackColor = ColorTranslator.FromHtml("#52362A");
            btnDangXuat.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnKho.BackColor = ColorTranslator.FromHtml("#52362A");
            btnKho.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            if (userRole == "Nhân viên")
            {
                btnThemNV.Enabled = false;
                btnThuNhap.Enabled = false;
                btnKho.Enabled = false;

                btnThemNV.BackColor = ColorTranslator.FromHtml("#812F2D");
                btnThuNhap.BackColor = ColorTranslator.FromHtml("#812F2D");
                btnKho.BackColor = ColorTranslator.FromHtml("#812F2D");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            frmDatMon fr = new frmDatMon();
            OpenMain(fr);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan fr = new frmThanhToan();
            OpenMain(fr);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmNhanVien fr = new frmNhanVien();
            OpenMain(fr);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSuHoaDon fr = new frmLichSuHoaDon();
            OpenMain(fr);
        }

        private void btnThuNhap_Click(object sender, EventArgs e)
        {
            frmDoanhThu fr = new frmDoanhThu();
            OpenMain(fr);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmKhoHang fr = new frmKhoHang();
            OpenMain(fr);
        }

        private void phóngToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void thuNhỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
