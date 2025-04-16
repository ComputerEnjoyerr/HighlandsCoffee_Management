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

        public class Promotion
        {
            public string Name { get; set; }
            public string Discount { get; set; }
        }

        List<Promotion> promotionList = new List<Promotion> 
        { 
            new Promotion { Name = "Giảm 10% cho hóa đơn từ 100k có ít nhất 1 sản phẩm là cà phê", Discount = "10%" },
            new Promotion { Name = "Giảm 20%", Discount = "20%" },
            new Promotion { Name = "Giảm 30%", Discount = "30%" },
            new Promotion { Name = "Giảm 50%", Discount = "50%" },
            new Promotion { Name = "Giảm 10%", Discount = "100%" },
            new Promotion { Name = "Giảm 2%", Discount = "200%" },
            new Promotion { Name = "Giảm 3%", Discount = "300%" },
            new Promotion { Name = "Giảm 4%", Discount = "400%" },
            new Promotion { Name = "Giảm 5%", Discount = "500%" },
            new Promotion { Name = "Giảm 6%", Discount = "600%" },
            new Promotion { Name = "Giảm 70%", Discount = "700%" },
            new Promotion { Name = "Giảm 80%", Discount = "800%" },
            new Promotion { Name = "Giảm 90%", Discount = "900%" },
            new Promotion { Name = "Giảm 100%", Discount = "1000%" },
        };

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlChonBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpKhuyenMai.BackColor = ColorTranslator.FromHtml("#DED4CA");

            foreach (var promotion in promotionList)
            {
                Panel panel = new Panel();
                panel.Size = new Size(flpKhuyenMai.Width - 25, 60);
                panel.BackColor = ColorTranslator.FromHtml("#BD965F");

                CheckBox checkBox = new CheckBox();
                checkBox.Size = new Size(panel.Width - 20, panel.Height - 10);
                checkBox.Font = new Font("Arial", 12, FontStyle.Bold);
                checkBox.Location = new Point(10, 10);
                checkBox.Text = promotion.Name;
                checkBox.Tag = promotion.Discount;
                checkBox.AllowDrop = true;
                panel.Controls.Add(checkBox);
                flpKhuyenMai.Controls.Add(panel);
            }
        }
    }
}
