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
    public partial class frmRPTKhuyenMaiCuaKH : Form
    {
        public frmRPTKhuyenMaiCuaKH()
        {
            InitializeComponent();
        }

        private void frmRPTKhuyenMaiCuaKH_Load(object sender, EventArgs e)
        {

        }

        private void frmRPTKhuyenMaiCuaKH_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmRPTKhuyenMaiCuaKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            crystalReportViewer1.Dispose();
            this.Dispose();
        }
    }
}
