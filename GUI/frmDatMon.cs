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
        // Dữ liệu tạm
        public class Table
        {
            public int TableId { get; set; }
            public string TableName { get; set; }
            public int BranchId { get; set; }
            public int Capacity { get; set; }
            public int Status { get; set; } // 0: Trống, 1: Đã đặt
        }
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
        }
        private List<Product> listProducts = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Cà phê", Price = 20000 },
            new Product { ProductId = 2, ProductName = "Trà sữa", Price = 25000 },
            new Product { ProductId = 3, ProductName = "Nước ngọt", Price = 15000 },
            new Product { ProductId = 4, ProductName = "Bánh mì", Price = 30000 },
            new Product { ProductId = 5, ProductName = "Pizza", Price = 50000 },
            new Product { ProductId = 6, ProductName = "Mì Ý", Price = 60000 },
            new Product { ProductId = 7, ProductName = "Salad", Price = 40000 },
            new Product { ProductId = 8, ProductName = "Bánh ngọt", Price = 35000 },
            new Product { ProductId = 9, ProductName = "Kem", Price = 30000 },
            new Product { ProductId = 10, ProductName = "Soda", Price = 20000 },
            new Product { ProductId = 11, ProductName = "Nước ép", Price = 25000 },
            new Product { ProductId = 12, ProductName = "Trà đào", Price = 30000 },
            new Product { ProductId = 13, ProductName = "Trà xanh", Price = 20000 },
            new Product { ProductId = 14, ProductName = "Trà chanh", Price = 15000 }
        };
        private List<Table> listtTables = new List<Table>
        {
            new Table { TableId = 1, TableName = "Bàn 1", BranchId = 1, Capacity = 4, Status = 0 },
            new Table { TableId = 2, TableName = "Bàn 2", BranchId = 1, Capacity = 4, Status = 1 },
            new Table { TableId = 3, TableName = "Bàn 3", BranchId = 1, Capacity = 4, Status = 0 },
            new Table { TableId = 4, TableName = "Bàn 4", BranchId = 1, Capacity = 4, Status = 0 }
        };

        private void frmDatMon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#B12830");
            flpBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlDatMon.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlMain2.BackColor = ColorTranslator.FromHtml("#52362A");
            flpSanPham.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            tabDatMon.BackColor = ColorTranslator.FromHtml("#DED4CA");

            var tables = listtTables.Where(t => t.BranchId == 1).ToList();
            foreach (var table in tables)
            {
                Table tb = new Table
                {
                    TableId = table.TableId,
                    TableName = table.TableName,
                    BranchId = table.BranchId,
                    Capacity = table.Capacity,
                    Status = table.Status
                };
                Button btnTable = CreateTableButton(tb);
                flpBan.Controls.Add(btnTable);
            }

            var products = listProducts.ToList();
            foreach (var product in products)
            {
                Product p = new Product
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price
                };
                Button btnProduct = CreateProductButton(p);
                flpSanPham.Controls.Add(btnProduct);
            }
        }
        private Button CreateProductButton(Product product)
        {
            Button btnProduct = new Button
            {
                Text = product.ProductName,
                Size = new Size(116, 150),
                Padding = new Padding(5, 5, 5, 0),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                ForeColor = ColorTranslator.FromHtml("#52362A"),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag
            };
            btnProduct.Click += BtnProduct_Click; // Gán sự kiện Click cho nút
            return btnProduct;
        }
        private Button CreateTableButton(Table table)
        {
            Button btnTable = new Button
            {
                Text = table.TableName,
                Size = new Size(100, 100),
                // Đổi màu bàn theo trạng thái
                BackColor = table.Status == 0 ? ColorTranslator.FromHtml("#BD965F") : ColorTranslator.FromHtml("#B12830"),
                ForeColor = ColorTranslator.FromHtml("#DED4CA"),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Tag = table // Lưu thông tin bàn vào thuộc tính Tag
            };
            btnTable.Click += BtnTable_Click; // Gán sự kiện Click cho nút
            return btnTable;
        }
        private void BtnTable_Click(object sender, EventArgs e)
        {
            Button btnTable = sender as Button;
            lbBan.Text = btnTable.Text;
            tabBanAn.SelectedTab = tabBanAn.TabPages[1];
        }
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            Button btnProduct = sender as Button;
            if (btnProduct != null)
            {
                Product selectedProduct = (Product)btnProduct.Tag;
                // Xử lý khi sản phẩm được chọn
                MessageBox.Show($"Sản phẩm: {selectedProduct.ProductName}, Giá: {selectedProduct.Price}");
            }
        }
    }
}
