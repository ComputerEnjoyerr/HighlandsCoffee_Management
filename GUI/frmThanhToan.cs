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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlChonBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpKhuyenMai.BackColor = ColorTranslator.FromHtml("#DED4CA");

            // Dữ liệu khuyến mãi ở đây
            //foreach (var promotion in promotionList)
            //{
            //    Panel panel = new Panel();
            //    panel.Size = new Size(flpKhuyenMai.Width - 25, 60);
            //    panel.BackColor = ColorTranslator.FromHtml("#BD965F");

            //    CheckBox checkBox = new CheckBox();
            //    checkBox.Size = new Size(panel.Width - 20, panel.Height - 10);
            //    checkBox.Font = new Font("Arial", 12, FontStyle.Bold);
            //    checkBox.Location = new Point(10, 10);
            //    checkBox.Text = promotion.Name;
            //    checkBox.Tag = promotion.Discount;
            //    checkBox.AllowDrop = true;
            //    panel.Controls.Add(checkBox);
            //    flpKhuyenMai.Controls.Add(panel);
            //}
        }
    }
}
