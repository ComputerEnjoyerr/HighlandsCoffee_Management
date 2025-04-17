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
        // Tham chiếu dữ liệu từ frmDoanhThu
        //List<DoanhThu> dt = new List<DoanhThu>();
        public frmChiTietDoanhThu(/*DoanhThu*/)
        {
            InitializeComponent();
            //doanhThu = dt;
        }

        // Lọc dữ liệu theo yêu cầu để hiển thị vào dgv
        private void LoadData()
        {
            //var filteredBills = bills.Where(b => b.Date.Date == doanhThu.NgayLap.Date).ToList();
            //var filteredBillInfos = billInfos.Where(bi => filteredBills.Any(b => b.BillID == bi.BillID)).ToList();
            ////MessageBox.Show("Filtered Bills Count: " + filteredBills.Count);
            ////MessageBox.Show("Filtered BillInfos Count: " + filteredBillInfos.Count);
            //var data = from b in filteredBills
            //           join bi in filteredBillInfos on b.BillID equals bi.BillID
            //           select new
            //           {
            //               b.BillID,
            //               b.TableID,
            //               b.Employee,
            //               b.Date,
            //               bi.ProductName,
            //               bi.Quantity,
            //               bi.Price,
            //               TotalPrice = bi.Price * Convert.ToInt32(bi.Quantity)
            //           };
            //dgvChiTietDoanhThu.DataSource = data.ToList();
        }

        private void frmChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");
            //this.BackColor = ColorTranslator.FromHtml("#52362A");
            //pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            //LoadData();
            //int tongTien = 0;
            //for (int  i = 0;  i < dgvChiTietDoanhThu.Rows.Count;  i++)
            //{
            //    tongTien += int.Parse(dgvChiTietDoanhThu.Rows[i].Cells["TotalPrice"].Value.ToString());
            //}
            //txtTongTien.Text = string.Format("{0:0,0}", tongTien) + " VNĐ";
        }
    }
}
