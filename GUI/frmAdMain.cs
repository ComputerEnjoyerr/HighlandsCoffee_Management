using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private int index = 0;

        // Biến tạm
        Form currentForm = new Form();
        private void OpenMain(Form childForm)
        {
            // Tắt form hiện tại để chuyển form mới
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            // Chỉnh sửa thuộc tính của form mới
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Đưa form mới vào main menu
            childForm.Show();
            currentForm = childForm;
            // Tắt banner, tránh chạy ngầm
            tmrBannerLoop.Stop();
            picBanner.Visible = false;
        }

        private void frmAdMain_Load(object sender, EventArgs e)
        {
            mnuMain.BackColor = ColorTranslator.FromHtml("#B12830");
            mnuMain.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            this.BackColor = ColorTranslator.FromHtml("#DED4CA");

            this.Icon = new Icon("icon-1.ico");

            tmrBannerLoop.Interval = 6000;
            tmrBannerLoop.Start();
            picBanner.BackgroundImage = Image.FromFile("Banners/" + imgListBanners.Images.Keys[index]);
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

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTLuongNhanVIen fr = new frmRPTLuongNhanVIen();
            OpenMain(fr);
        }

        private void khuyếnMãiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRPTKhuyenMaiCuaKH fr = new frmRPTKhuyenMaiCuaKH();
            OpenMain(fr);
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            tmrBannerLoop.Start();
            picBanner.Visible = true;
        }

        private void tmrBannerLoop_Tick(object sender, EventArgs e)
        {
            // Chạy banner theo vòng lặp
            index++;
            if (index >= imgListBanners.Images.Count)
                index = 0;
            picBanner.BackgroundImage = Image.FromFile("Banners/" + imgListBanners.Images.Keys[index]);
        }

        private void doanhThuCácChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTDoanhThuTheoThang fr = new frmRPTDoanhThuTheoThang();
            OpenMain(fr);
        }

        private void khoHàngCácChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPTKhoHangMoiChiNhanh fr = new frmRPTKhoHangMoiChiNhanh();
            OpenMain(fr);
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }


    }
}
