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
    public partial class frmAdChiNhanh : Form
    {
        public frmAdChiNhanh()
        {
            InitializeComponent();
        }

        private void frmAdChiNhanh_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            flpChiNhanh.BackColor = ColorTranslator.FromHtml("#DED4CA");

            // Hiển thị thông tin chi nhánh bằng panel
            //foreach (var branch in braches)
            //{
            //    Panel panel = new Panel();
            //    panel.Size = new Size(445, 150);
            //    panel.BackColor = ColorTranslator.FromHtml("#BD965F");
            //    panel.BorderStyle = BorderStyle.FixedSingle;
            //    panel.Margin = new Padding(10);

            //    Label lblBranchName = new Label();
            //    lblBranchName.Size = new Size(panel.Width - 20, 20);
            //    lblBranchName.Text = "Tên: " + branch.BranchName;
            //    lblBranchName.Font = new Font("Arial", 12, FontStyle.Bold);
            //    lblBranchName.Location = new Point(10, 10);
            //    lblBranchName.ForeColor = ColorTranslator.FromHtml("#52362A");
            //    panel.Controls.Add(lblBranchName);

            //    Label lblAddress = new Label();
            //    lblAddress.Size = new Size(panel.Width - 20, 40);
            //    lblAddress.Text = "Địa chỉ: " + branch.Address;
            //    lblAddress.ForeColor = Color.White;
            //    lblAddress.Location = new Point(10, 35);
            //    lblAddress.AllowDrop = true;
            //    panel.Controls.Add(lblAddress);

            //    Label lblPhoneNumber = new Label();
            //    lblPhoneNumber.Size = new Size(panel.Width - 100, 20);
            //    lblPhoneNumber.Text = "SĐT: " + branch.PhoneNumber;
            //    lblPhoneNumber.ForeColor = Color.White;
            //    lblPhoneNumber.Location = new Point(10, 90);
            //    panel.Controls.Add(lblPhoneNumber);
            //    flpChiNhanh.Controls.Add(panel);
            //}
        }
    }
}
