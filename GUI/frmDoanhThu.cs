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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private BLL_Financial bllFinancial = new BLL_Financial();
        private Employee currentEmployee = new Employee();

        private void LoadDoanhTHu()
        {
            var doanhthus = bllFinancial.GetAll().Where(f => f.BranchId == currentEmployee.BranchId);
            if (doanhthus.Any()) 
                dgvDoanhThu.DataSource = doanhthus.ToList();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }

            LoadDoanhTHu();
        }

        // Khi nhấn vào một doanh thu, tìm kiếm các tất cả các hóa đơn theo tháng trong CreateDate, Hiển thị: mã hóa đơn, tên và giá các sản phẩm (lấy từ bảng Product), số lượng sp (BillInfo), thời gian lập bill
        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin doanh thu đã chọn
                Financial selectedDoanhThu = dgvDoanhThu.SelectedRows[0].DataBoundItem as Financial;
                // Hiển thị thông tin chi tiết doanh thu
                if (selectedDoanhThu == null) return;
                frmChiTietDoanhThu fr = new frmChiTietDoanhThu(selectedDoanhThu);
                fr.ShowDialog();
            }
        }
    }
}
