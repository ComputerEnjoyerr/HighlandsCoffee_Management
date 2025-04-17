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
    public partial class frmAdBanAn : Form
    {
        public frmAdBanAn()
        {
            InitializeComponent();
        }

        private void frmAdBanAn_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpBanAn.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbChiNhanh.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            // Hiển thị các button Bàn ăn
            //var table = //Nhập dữ liệu để tạo bản;
            //foreach (var item in table)
            //{
            //    Button btn = new Button();
            //    btn.Text = item.TableName;
            //    btn.Tag = item;
            //    btn.BackColor = ColorTranslator.FromHtml("#B12830");
            //    btn.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            //    btn.FlatStyle = FlatStyle.Flat;
            //    btn.Width = 150;
            //    btn.Height = 100;
            //    flpBanAn.Controls.Add(btn);
            //}
        }
    }
}
