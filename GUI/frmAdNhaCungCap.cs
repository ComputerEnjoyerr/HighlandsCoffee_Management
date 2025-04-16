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
    public partial class frmAdNhaCungCap : Form
    {
        public frmAdNhaCungCap()
        {
            InitializeComponent();
        }
        public class Suplier
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
        List<Suplier> supliers = new List<Suplier>
        {
            new Suplier { Name = "Công ty TNHH MTV Thái Kiên", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty TNHH ABC", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty DECAW", Address = "Số 180/15 Đường Nguyễn Hữu Cảnh, P. 22, Q. Bình Thạnh, TP. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty 3123123", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty ZZXAXZZ", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty ZZXAXZZ", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty ZZXAXZZ", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
            new Suplier { Name = "Công ty ZZXAXZZ", Address = "127 Nguyễn Cơ Thạch, An Lợi Đông, Q.2, Tp. Hồ Chí Minh", Phone = "0917561212", Email = "cpg.customerservice@vtijs.com" },
        };
        private void frmAdNhaCungCap_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            fpnNhaCC.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            foreach (var suplier in supliers)
            {
                Panel panel = new Panel();
                panel.Size = new Size(475, 150);
                panel.BackColor = ColorTranslator.FromHtml("#BD965F");
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label lbName = new Label();
                lbName.Font = new Font("Arial", 12, FontStyle.Bold);
                lbName.Text = suplier.Name;
                lbName.Size = new Size(panel.Width - 20, 25);
                lbName.Location = new Point(10, 10);
                lbName.ForeColor = ColorTranslator.FromHtml("#52362A");
                panel.Controls.Add(lbName);

                Label lbAddress = new Label();
                lbAddress.Text = suplier.Address;
                lbAddress.AllowDrop = true;
                lbAddress.Size = new Size(panel.Width - 20, 45);
                lbAddress.Location = new Point(10, 35);
                lbAddress.ForeColor = ColorTranslator.FromHtml("#52362A");
                panel.Controls.Add(lbAddress);

                Label lbPhone = new Label();
                lbPhone.Size = new Size(panel.Width - 20, 20);
                lbPhone.Text = suplier.Phone;
                lbPhone.Location = new Point(10, 80);
                lbPhone.ForeColor = ColorTranslator.FromHtml("#52362A");
                panel.Controls.Add(lbPhone);

                Label lbEmail = new Label();
                lbEmail.Size = new Size(panel.Width - 20, 20);
                lbEmail.Text = suplier.Email;
                lbEmail.Location = new Point(10, 100);
                lbEmail.ForeColor = ColorTranslator.FromHtml("#52362A");
                panel.Controls.Add(lbEmail);

                fpnNhaCC.Controls.Add(panel);
            }
        }
    }
}
