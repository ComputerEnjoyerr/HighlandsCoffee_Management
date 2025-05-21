using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.frmLichSuHoaDon;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon(List<BillInfo> bi)
        {
            InitializeComponent();
            billInfos = bi;
        }

        private List<BillInfo> billInfos = new List<BillInfo>();
        private BLL_Product bllProduct = new BLL_Product();

        private void LoadBillInfo()
        {
            var data = billInfos
                .Join(bllProduct.GetAll(),
                    bi => bi.ProductId,
                    p => p.ProductId,
                    (bi, p) => new
                    {
                        bi.BillInfoId,
                        p.ProductName,
                        bi.Quantity,
                        p.Price,
                        Total = bi.Quantity * p.Price
                    })
                .ToList();
            dgvBillInfo.DataSource = data;
            dgvBillInfo.Columns["BillInfoId"].Visible = false;
            dgvBillInfo.Columns["Total"].HeaderText = "Thành tiền";
            dgvBillInfo.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgvBillInfo.Columns["Quantity"].HeaderText = "Số lượng";
            dgvBillInfo.Columns["Price"].HeaderText = "Đơn giá";
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");
            this.BackColor = ColorTranslator.FromHtml("#52362A");

            LoadBillInfo();
        }
    }
}
