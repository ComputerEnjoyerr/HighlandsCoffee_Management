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
using static GUI.frmDoanhThu;

namespace GUI
{
    public partial class frmChiTietDoanhThu : Form
    {
        public frmChiTietDoanhThu(Financial dt)
        {
            InitializeComponent();
            doanhThu = dt;
        }

        private Financial doanhThu = new Financial();
        private BLL_Bill bllBill = new BLL_Bill();
        private BLL_BillInfo bllBillInfo = new BLL_BillInfo();
        private BLL_Product bllProduct = new BLL_Product();

        // Lọc dữ liệu theo yêu cầu để hiển thị vào dgv
        private void LoadData()
        {
            // Lọc các hóa đơn theo ngày lập hóa đơn và đã được thanh toán (status = 1)
            var filteredBills = bllBill.GetAll().Where(b => b.CreateDate.Date == doanhThu.ReportDate.Date && b.Status == 1).ToList();
            // Tìm các chi tiết hóa đơn trong filteredBills
            var filteredBillInfos = bllBillInfo.GetAll().Where(bi => filteredBills.Any(b => b.BillId == bi.BillId)).ToList();
            var products = bllProduct.GetAll().ToList();
            //MessageBox.Show("Filtered Bills Count: " + filteredBills.Count);
            //MessageBox.Show("Filtered BillInfos Count: " + filteredBillInfos.Count);

            // Lọc dữ liệu để hiển thị vào dgv
            var data = filteredBillInfos
                .Join(products, bi => bi.ProductId, p => p.ProductId, (bi, p) => new { bi.ProductId, bi.Quantity })
                .GroupBy(x => x.ProductId)
                .Select(g => new
                {
                    ProductId = g.Key,
                    ProductName = products.FirstOrDefault(p => p.ProductId == g.Key).ProductName,
                    Price = products.FirstOrDefault(p => p.ProductId == g.Key)?.Price,
                    Quantity = g.Sum(x => x.Quantity),
                    TotalPrice = g.Sum(x => x.Quantity) * products.FirstOrDefault(p => p.ProductId == g.Key)?.Price
                })
                .OrderBy(x => x.ProductId) // Sắp xếp sản phẩm tăng theo id
                .ToList();
            if (data.Any())
                dgvChiTietDoanhThu.DataSource = data;
        }

        private void frmChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            

            LoadData();
            int tongTien = 0;
            for (int i = 0; i < dgvChiTietDoanhThu.Rows.Count; i++)
            {
                tongTien += int.Parse(dgvChiTietDoanhThu.Rows[i].Cells["TotalPrice"].Value.ToString());
            }
            txtTongTien.Text = string.Format("{0:0,0}", tongTien) + " VNĐ";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
