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

namespace GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        // Tham chiếu dữ liệu lấy từ frmLichSuHoaDon
        //List<BillInfo> info = new List<BillInfo>();

        public frmChiTietHoaDon(/*List<BillInfo> billInfo*/)
        {
            InitializeComponent();
            //info = billInfo;
        }


        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            //dgvBillInfo.DataSource = info;
        }
    }
}
