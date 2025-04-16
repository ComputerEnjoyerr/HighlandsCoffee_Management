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
    public partial class frmLichSuHoaDon : Form
    {
        public frmLichSuHoaDon()
        {
            InitializeComponent();
        }
        // Dữ liệu tạm
        public class Bill
        {
            public string BillID { get; set; }
            public string TableID { get; set; }
            public string Employee { get; set; }
            public DateTime Date { get; set; }
            public double TotalAmount { get; set; }
        }

        public class BillInfo
        {
            public string BillID { get; set; }
            public string ProductName { get; set; }
            public string Quantity { get; set; }
            public string Price { get; set; }
            public string TotalPrice { get; set; }
        }

        List<Bill> bills = new List<Bill>
        {
            new Bill { BillID = "1", TableID = "1", Date = DateTime.Now, Employee = "Phu", TotalAmount = 123421.21},
            new Bill { BillID = "2", TableID = "2", Date = DateTime.Now, Employee = "Chuong", TotalAmount = 44444},
            new Bill { BillID = "3", TableID = "1", Date = DateTime.Now, Employee = "Huy", TotalAmount = 532141.22},
            new Bill { BillID = "4", TableID = "3", Date = DateTime.Now, Employee = "Phu", TotalAmount = 421.123},
        };

        List<BillInfo> billInfos = new List<BillInfo>
        {
            new BillInfo { BillID = "1", ProductName = "Tra sua", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "1", ProductName = "Ca Phe", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "1", ProductName = "Tra dao", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "2", ProductName = "Tra sua", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "3", ProductName = "Tra sua", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "3", ProductName = "Ca Phe", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "4", ProductName = "Tra sua", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "4", ProductName = "Ca Phe", Quantity = "2", Price = "20000", TotalPrice = "40000"},
            new BillInfo { BillID = "4", ProductName = "Tra dao", Quantity = "2", Price = "20000", TotalPrice = "40000"},
        };

        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            // Thêm dữ liệu vào dgvHoaDon
            dgvHoaDon.DataSource = bills.Select(b => new
            {
                b.BillID,
                b.TableID,
                b.Employee,
                Date = b.Date.ToString("dd/MM/yyyy"),
                TotalAmount = string.Format("{0:0,0}", b.TotalAmount) + " VNĐ"
            }).ToList();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Kiểm tra nếu không phải hàng dữ liệu
            // Lấy thông tin hóa đơn từ dòng được chọn
            string billID = dgvHoaDon.Rows[e.RowIndex].Cells["BillID"].Value.ToString();
            // Hiển thị thông tin chi tiết hóa đơn
            List<BillInfo> billInfo = billInfos.Where(b => b.BillID == billID).ToList();
            // Bạn có thể sử dụng một form mới để hiển thị chi tiết hóa đơn
            frmChiTietHoaDon fr = new frmChiTietHoaDon(billInfo);
            fr.ShowDialog();
        }
    }
}
