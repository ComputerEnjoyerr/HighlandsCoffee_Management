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
    public partial class frmAdKhachHang : Form
    {
        BLL_Customer bll = new BLL_Customer();
        public frmAdKhachHang()
        {
            InitializeComponent();
        }

        private void frmAdKhachHang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvKhachHang.DataSource = bll.GetAll();
        }
    }
}
