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
    public partial class frmAdMain : Form
    {
        public frmAdMain(Employee em)
        {
            InitializeComponent();
            admin = em;
        }

        private Employee admin = new Employee();

        // Biến tạm
        Form currentForm = new Form();
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

        private void frmAdMain_Load(object sender, EventArgs e)
        {
            mnuMain.BackColor = ColorTranslator.FromHtml("#B12830");
            mnuMain.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            this.BackColor = ColorTranslator.FromHtml("#DED4CA");

            //this.Icon = new Icon("icon-1.ico");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdNhanvien fr = new frmAdNhanvien();
            OpenMain(fr);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdKhachHang fr = new frmAdKhachHang();
            OpenMain(fr);
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdNhaCungCap fr = new frmAdNhaCungCap();
            OpenMain(fr);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdSanPham fr = new frmAdSanPham();
            OpenMain(fr);
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdKhuyenMai fr = new frmAdKhuyenMai();
            OpenMain(fr);
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdChiNhanh fr = new frmAdChiNhanh();
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

        private void khuyếnMãiCủaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptViewKhuyenMai rpt = new rptViewKhuyenMai();
            rpt.ShowDialog();
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptViewLuongNV rptViewLuongNV = new rptViewLuongNV();
            rptViewLuongNV.ShowDialog();
        }
    }
}
