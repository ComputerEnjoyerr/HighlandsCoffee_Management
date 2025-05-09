﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDatMon : Form
    {
        public frmDatMon(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private BLL_Table tableBLL = new BLL_Table();
        private BLL_Bill billBLL = new BLL_Bill();
        private BLL_BillInfo billInfoBLL = new BLL_BillInfo();
        private BLL_Product productBLL = new BLL_Product();

        private void LoadBanAn()
        {
            flpBan.Controls.Clear();
            // Hiển thị các btn Bàn ăn
            var tables = tableBLL.GetAll().Where(t => t.BranchId == currentEmployee.BranchId).ToList();
            foreach (var table in tables)
            {
                Button btnTable = CreateTableButton(table);
                flpBan.Controls.Add(btnTable);
            }
        }

        private void LoadSanPham()
        {
            flpSanPham.Controls.Clear();
            // Hiển thị các button sản phẩm
            var products = productBLL.GetAll();
            foreach (var product in products)
            {
                Panel pnlProduct = CreateProductItems(product);
                flpSanPham.Controls.Add(pnlProduct);
            }

        }

        private void frmDatMon_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(employeeThatUse.EmployeeName + " " + employeeThatUse.BranchId);

            this.BackColor = ColorTranslator.FromHtml("#B12830");
            flpBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlDatMon.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlMain2.BackColor = ColorTranslator.FromHtml("#52362A");
            flpSanPham.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            tabDatMon.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadBanAn();
            LoadSanPham();
        }
        
        private Panel CreateProductItems(Product product)
        {
            Panel panel = new Panel
            {
                Size = new Size(133, 200),
                Padding = new Padding(5, 5, 5, 0),
                BackColor = ColorTranslator.FromHtml("#FFFFFF"),
                Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag
            };
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(panel.Width, panel.Width),
                Tag = product,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            // Xác định đường dẫn ảnh
            string imagePath;
            if (string.IsNullOrEmpty(product.Image))
            {
                // Sử dụng ảnh mặc định nếu product.Image rỗng hoặc không tồn tại
                imagePath = Path.Combine(Application.StartupPath, "Products", "americano.jpg");
            }
            else
            {
                imagePath = Path.Combine(Application.StartupPath, "Products", product.Image);
            }

            // Tải ảnh vào PictureBox
            try
            {
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu cả ảnh mặc định cũng không tồn tại, sử dụng ảnh tạm từ imlSanPham
                    pictureBox.Image = imlSanPham.Images[1];
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu không tải được ảnh
                Console.WriteLine("Lỗi khi tải ảnh: " + ex.Message);
                pictureBox.Image = imlSanPham.Images[1];
            }
            Label ten = new Label
            {
                Text = product.ProductName,
                Location = new Point(panel.Left + 5, pictureBox.Bottom + 10),
                Size = new Size(panel.Width - 10, panel.Height - pictureBox.Height - 45),
                ForeColor = ColorTranslator.FromHtml("#52362A"),
                Tag = product
            };
            Label gia = new Label
            {
                Text = product.Price.ToString("###,###,###") + " VNĐ",
                Size = new Size(panel.Width - 10, panel.Height - pictureBox.Height),
                Location = new Point(panel.Left + 5, ten.Bottom + 10),
                Font = new Font("Arial", 13, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#52362A"),
                Tag = product
            };

            panel.Controls.Add(ten);
            panel.Controls.Add(gia);
            panel.Controls.Add(pictureBox);

            panel.Click += PanelProduct_Click; // Gán sự kiện Click cho nút
            pictureBox.Click += PanelProduct_Click;
            ten.Click += PanelProduct_Click;
            gia.Click += PanelProduct_Click;

            return panel;
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

        private void PanelProduct_Click(object sender, EventArgs e)
        {
            Button btnProduct = sender as Button;
            if (btnProduct != null)
            {
                Product selectedProduct = (Product)btnProduct.Tag;
                // Xử lý khi sản phẩm được chọn

            }
        }
    }
}
