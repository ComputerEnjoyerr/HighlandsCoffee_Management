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
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        public class DoanhThu
        {
            public string MaDoanhThu { get; set; }
            public DateTime NgayLap { get; set; }
            public double TongTien { get; set; }
            public double TongChi { get; set; }
            public double LoiNhuan { get; set; }
        }

        List<DoanhThu> doanhThus = new List<DoanhThu>
        {
            new DoanhThu { MaDoanhThu = "DT001", NgayLap = DateTime.Now, TongTien = 120000, TongChi = 50000, LoiNhuan = 70000 },
            new DoanhThu { MaDoanhThu = "DT002", NgayLap = DateTime.Now.AddDays(-1), TongTien = 120000, TongChi = 80000, LoiNhuan = 40000 },
            new DoanhThu { MaDoanhThu = "DT003", NgayLap = DateTime.Now.AddDays(-2), TongTien = 120000, TongChi = 60000, LoiNhuan = 60000 }
        };

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            dgvDoanhThu.DataSource = doanhThus;
        }

        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin doanh thu đã chọn
                DoanhThu selectedDoanhThu = doanhThus[e.RowIndex];
                // Hiển thị thông tin chi tiết doanh thu
                if (selectedDoanhThu == null) return;
                frmChiTietDoanhThu fr = new frmChiTietDoanhThu(selectedDoanhThu);
                fr.ShowDialog();
            }
        }
    }
}
