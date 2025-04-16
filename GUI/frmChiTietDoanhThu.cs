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
        DoanhThu doanhThu = new DoanhThu();
        public frmChiTietDoanhThu(DoanhThu dt)
        {
            InitializeComponent();
            doanhThu = dt;
        }

        public class Bill
        {
            public string BillID { get; set; }
            public string TableID { get; set; }
            public string Employee { get; set; }
            public DateTime Date { get; set; }
            public double TotalPrice { get; set; }
        }

        public class BillInfo
        {
            public string BillID { get; set; }
            public string ProductName { get; set; }
            public string Quantity { get; set; }
            public int Price { get; set; }
        }

        List<Bill> bills = new List<Bill>
        {
            new Bill { BillID = "1", TableID = "1", Date = DateTime.Now, Employee = "Phu", TotalPrice = 123421.21},
            new Bill { BillID = "2", TableID = "2", Date = DateTime.Now.AddDays(-1), Employee = "Chuong", TotalPrice = 44444},
            new Bill { BillID = "3", TableID = "1", Date = DateTime.Now.AddDays(-1), Employee = "Huy", TotalPrice = 532141.22},
            new Bill { BillID = "4", TableID = "3", Date = DateTime.Now.AddDays(-2), Employee = "Phu", TotalPrice = 421.123},

        };

        List<BillInfo> billInfos = new List<BillInfo>
        {
            new BillInfo { BillID = "1", ProductName = "Tra sua", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "1", ProductName = "Ca Phe", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "1", ProductName = "Tra dao", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "2", ProductName = "Tra sua", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "3", ProductName = "Tra sua", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "3", ProductName = "Ca Phe", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "4", ProductName = "Tra sua", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "4", ProductName = "Ca Phe", Quantity = "2", Price = 20000},
            new BillInfo { BillID = "4", ProductName = "Tra dao", Quantity = "2", Price = 20000},
        };

        private void LoadData()
        {
            var filteredBills = bills.Where(b => b.Date.Date == doanhThu.NgayLap.Date).ToList();
            var filteredBillInfos = billInfos.Where(bi => filteredBills.Any(b => b.BillID == bi.BillID)).ToList();
            //MessageBox.Show("Filtered Bills Count: " + filteredBills.Count);
            //MessageBox.Show("Filtered BillInfos Count: " + filteredBillInfos.Count);
            var data = from b in filteredBills
                       join bi in filteredBillInfos on b.BillID equals bi.BillID
                       select new
                       {
                           b.BillID,
                           b.TableID,
                           b.Employee,
                           b.Date,
                           bi.ProductName,
                           bi.Quantity,
                           bi.Price,
                           TotalPrice = bi.Price * Convert.ToInt32(bi.Quantity)
                       };
            dgvChiTietDoanhThu.DataSource = data.ToList();
        }

        private void frmChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            this.Icon = new Icon("icon-1.ico");

            LoadData();
            int tongTien = 0;
            for (int  i = 0;  i < dgvChiTietDoanhThu.Rows.Count;  i++)
            {
                tongTien += int.Parse(dgvChiTietDoanhThu.Rows[i].Cells["TotalPrice"].Value.ToString());
            }
            txtTongTien.Text = string.Format("{0:0,0}", tongTien) + " VNĐ";
        }
    }
}
