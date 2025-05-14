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
using static GUI.frmLichSuHoaDon;

namespace GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        private int billId;
        BLL_BillInfo billInfo = new BLL_BillInfo();

        public frmChiTietHoaDon(int billId)
        {
            InitializeComponent();
            this.billId = billId;
        }


        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");
            this.BackColor = ColorTranslator.FromHtml("#52362A");

            var details = billInfo.GetDetailsByBillId(billId);
            dgvBillInfo.DataSource = details;

            // Đặt tên cột
            dgvBillInfo.Columns["BillInfoId"].HeaderText = "Mã chi tiết hóa đơn";
            dgvBillInfo.Columns["BillId"].HeaderText = "Mã hóa đơn";
            dgvBillInfo.Columns["ProductId"].HeaderText = "Mã sản phẩm";
            dgvBillInfo.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgvBillInfo.Columns["Quantity"].HeaderText = "Số lượng";
            dgvBillInfo.Columns["Price"].HeaderText = "Đơn giá";
            dgvBillInfo.Columns["Total"].HeaderText = "Thành tiền";
        }
    }
}
