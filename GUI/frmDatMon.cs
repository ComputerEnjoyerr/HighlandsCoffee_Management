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
    public partial class frmDatMon : Form
    {
        public frmDatMon()
        {
            InitializeComponent();
        }

        private void frmDatMon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#B12830");
            flpBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlDatMon.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlMain2.BackColor = ColorTranslator.FromHtml("#52362A");
            flpSanPham.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            tabDatMon.BackColor = ColorTranslator.FromHtml("#DED4CA");

            // Hiển thị các btn Bàn ăn
            //var tables = listtTables.Where(t => t.BranchId == 1).ToList();
            //foreach (var table in tables)
            //{
            //    Table tb = new Table
            //    {
            //        TableId = table.TableId,
            //        TableName = table.TableName,
            //        BranchId = table.BranchId,
            //        Capacity = table.Capacity,
            //        Status = table.Status
            //    };
            //    Button btnTable = CreateTableButton(tb);
            //    flpBan.Controls.Add(btnTable);
            //}

            // Hiển thị các button sản phẩm
            //var products = listProducts.ToList();
            //foreach (var product in products)
            //{
            //    Product p = new Product
            //    {
            //        ProductId = product.ProductId,
            //        ProductName = product.ProductName,
            //        Price = product.Price
            //    };
            //    Button btnProduct = CreateProductButton(p);
            //    flpSanPham.Controls.Add(btnProduct);
            //}
        }
        //private Button CreateProductButton(Product product)
        //{
        //    Button btnProduct = new Button
        //    {
        //        Text = product.ProductName,
        //        Size = new Size(116, 150),
        //        Padding = new Padding(5, 5, 5, 0),
        //        BackColor = ColorTranslator.FromHtml("#FFFFFF"),
        //        ForeColor = ColorTranslator.FromHtml("#52362A"),
        //        FlatStyle = FlatStyle.Flat,
        //        FlatAppearance = { BorderSize = 0 },
        //        Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag
        //    };
        //    btnProduct.Click += BtnProduct_Click; // Gán sự kiện Click cho nút
        //    return btnProduct;
        //}
        //private Button CreateTableButton(Table table)
        //{
        //    Button btnTable = new Button
        //    {
        //        Text = table.TableName,
        //        Size = new Size(100, 100),
        //        // Đổi màu bàn theo trạng thái
        //        BackColor = table.Status == 0 ? ColorTranslator.FromHtml("#BD965F") : ColorTranslator.FromHtml("#B12830"),
        //        ForeColor = ColorTranslator.FromHtml("#DED4CA"),
        //        FlatStyle = FlatStyle.Flat,
        //        FlatAppearance = { BorderSize = 0 },
        //        Tag = table // Lưu thông tin bàn vào thuộc tính Tag
        //    };
        //    btnTable.Click += BtnTable_Click; // Gán sự kiện Click cho nút
        //    return btnTable;
        //}
        private void BtnTable_Click(object sender, EventArgs e)
        {
            Button btnTable = sender as Button;
            lbBan.Text = btnTable.Text;
            tabBanAn.SelectedTab = tabBanAn.TabPages[1];
        }
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            //Button btnProduct = sender as Button;
            //if (btnProduct != null)
            //{
            //    Product selectedProduct = (Product)btnProduct.Tag;
            //    // Xử lý khi sản phẩm được chọn
            //    
            //}
        }
    }
}
