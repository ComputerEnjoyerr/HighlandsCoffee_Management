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
            var filteredBills = bllBill.GetAll().Where(b => b.CreateDate.Date == doanhThu.ReportDate.Date).ToList();
            var filteredBillInfos = bllBillInfo.GetAll().Where(bi => filteredBills.Any(b => b.BillId == bi.BillId)).ToList();
            var products = bllProduct.GetAll().ToList();
            //MessageBox.Show("Filtered Bills Count: " + filteredBills.Count);
            //MessageBox.Show("Filtered BillInfos Count: " + filteredBillInfos.Count);
            var data = from b in filteredBills
                       join bi in filteredBillInfos on b.BillId equals bi.BillId
                       join p in products on bi.ProductId equals p.ProductId
                       select new
                       {
                           b.BillId,
                           b.TableId,
                           b.EmployeeId,
                           b.CreateDate,
                           p.ProductName,
                           p.Price,
                           bi.Quantity,
                           TotalPrice = p.Price * Convert.ToInt32(bi.Quantity)
                       };
            dgvChiTietDoanhThu.DataSource = data.ToList();
        }

        private void frmChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            //this.Icon = new Icon("icon-1.ico");
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
    }
}
