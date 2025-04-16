using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.frmDatMon; // Dữ liệu tạm

namespace GUI
{
    public partial class frmAdBanAn : Form
    {
        public frmAdBanAn()
        {
            InitializeComponent();
        }
        // Dữ liệu tạm
        private List<Table> listtTables = new List<Table>
        {
            new Table { TableId = 1, TableName = "Bàn 1", BranchId = 1, Capacity = 4, Status = 0 },
            new Table { TableId = 2, TableName = "Bàn 2", BranchId = 1, Capacity = 4, Status = 1 },
            new Table { TableId = 3, TableName = "Bàn 3", BranchId = 1, Capacity = 4, Status = 0 },
            new Table { TableId = 4, TableName = "Bàn 4", BranchId = 1, Capacity = 4, Status = 0 }
        };
        private void frmAdBanAn_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpBanAn.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbChiNhanh.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            var table = listtTables.ToList();
            foreach (var item in table)
            {
                Button btn = new Button();
                btn.Text = item.TableName;
                btn.Tag = item;
                btn.BackColor = ColorTranslator.FromHtml("#B12830");
                btn.ForeColor = ColorTranslator.FromHtml("#DED4CA");
                btn.FlatStyle = FlatStyle.Flat;
                btn.Width = 150;
                btn.Height = 100;
                flpBanAn.Controls.Add(btn);
            }
        }
    }
}
