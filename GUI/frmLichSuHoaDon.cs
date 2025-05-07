using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmLichSuHoaDon : Form
    {
        public frmLichSuHoaDon(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            // Thêm dữ liệu hóa đơn vào dgvHoaDon
            //dgvHoaDon.DataSource = bills.Select(b => new
            //{
            //    b.BillID,
            //    b.TableID,
            //    b.Employee,
            //    Date = b.Date.ToString("dd/MM/yyyy"),
            //    TotalAmount = string.Format("{0:0,0}", b.TotalAmount) + " VNĐ"
            //}).ToList();
        }

        // Khi nhấn vào hóa đơn, tìm các chi tiết hóa đơn có mã hóa đơn khớp với mã hóa đơn của hóa đơn rồi truyền dl vào frmChiTietHoaDon
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex < 0) return; // Kiểm tra nếu không phải hàng dữ liệu
            //// Lấy thông tin hóa đơn từ dòng được chọn
            //string billID = dgvHoaDon.Rows[e.RowIndex].Cells["BillID"].Value.ToString();
            //// Hiển thị thông tin chi tiết hóa đơn
            //List<BillInfo> billInfo = billInfos.Where(b => b.BillID == billID).ToList();
            //// Bạn có thể sử dụng một form mới để hiển thị chi tiết hóa đơn
            //frmChiTietHoaDon fr = new frmChiTietHoaDon(billInfo);
            //fr.ShowDialog();
        }
    }
}
