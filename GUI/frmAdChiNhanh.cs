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

        public class Branch
        {
            public string BranchName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
        }
        List<Branch> braches = new List<Branch>
        { 
            new Branch { BranchName = "Highlands Coffee 85 No.3 Binh Tan", Address = "85 Đường Số 3, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee 565 Tinh Lo 10", Address = "85 Đường Số 4, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee 85 No.5 Binh Tan", Address = "85 Đường Số 5, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee Số 7 Bình Tân", Address = "85 Đường Số 6, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee 377 Tân Kỳ Tân Quý", Address = "85 Đường Số 7, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee Hồng Lạc", Address = "85 Đường Số 8, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee 85 No.9 Binh Tan", Address = "85 Đường Số 9, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },
            new Branch { BranchName = "Highlands Coffee 85 No.10 Binh Tan", Address = "85 Đường Số 10, Phường Bình Hưng Hòa B, Quận Bình Tân, Tp. Hồ Chí Minh", PhoneNumber = "0901234567" },

        };
        private void frmAdChiNhanh_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            flpChiNhanh.BackColor = ColorTranslator.FromHtml("#DED4CA");

            foreach (var branch in braches)
            {
                Panel panel = new Panel();
                panel.Size = new Size(445, 150);
                panel.BackColor = ColorTranslator.FromHtml("#BD965F");
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(10);

                Label lblBranchName = new Label();
                lblBranchName.Size = new Size(panel.Width - 20, 20);
                lblBranchName.Text = "Tên: " + branch.BranchName;
                lblBranchName.Font = new Font("Arial", 12, FontStyle.Bold);
                lblBranchName.Location = new Point(10, 10);
                lblBranchName.ForeColor = ColorTranslator.FromHtml("#52362A");
                panel.Controls.Add(lblBranchName);

                Label lblAddress = new Label();
                lblAddress.Size = new Size(panel.Width - 20, 40);
                lblAddress.Text = "Địa chỉ: " + branch.Address;
                lblAddress.ForeColor = Color.White;
                lblAddress.Location = new Point(10, 35);
                lblAddress.AllowDrop = true;
                panel.Controls.Add(lblAddress);

                Label lblPhoneNumber = new Label();
                lblPhoneNumber.Size = new Size(panel.Width - 100, 20);
                lblPhoneNumber.Text = "SĐT: " + branch.PhoneNumber;
                lblPhoneNumber.ForeColor = Color.White;
                lblPhoneNumber.Location = new Point(10, 90);
                panel.Controls.Add(lblPhoneNumber);
                flpChiNhanh.Controls.Add(panel);
            }
        }
    }
}
