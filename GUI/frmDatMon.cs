using BLL;
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

        private Product selectedProduct = null;
        private Table selectedTable = null;
        private Customer selectedCustomer = null;
        private Employee currentEmployee = null;

        private BLL_Table bllTable = new BLL_Table();
        private BLL_Bill bllBill = new BLL_Bill();
        private BLL_BillInfo bllBillInfo = new BLL_BillInfo();
        private BLL_Product bllProduct = new BLL_Product();
        private BLL_Customer bllCustomer = new BLL_Customer();

        private List<Table> cachedTables = null;
        private List<Product> cachedProducts = null;

        private void LoadBanAn()
        {
            flpBan.Controls.Clear();
            if (cachedTables == null)
            {
                cachedTables = bllTable.GetAll().Where(t => t.BranchId == currentEmployee.BranchId).ToList();
            }

            foreach (var table in cachedTables)
            {
                Button btnTable = CreateTableButton(table);
                flpBan.Controls.Add(btnTable);
            }
        }

        private void LoadSanPham()
        {
            flpSanPham.Controls.Clear();
            if (cachedProducts == null)
            {
                cachedProducts = bllProduct.GetAll();
            }

            foreach (var product in cachedProducts)
            {
                Panel pnlProduct = CreateProductItems(product);
                flpSanPham.Controls.Add(pnlProduct);
            }
        }

        private void ClearDuLieuNhap(int action = 0)
        {
            if (action == 0)
            {
                nbrSoLuong.Value = 1;
            }
            else if (action == 1)
            {
                selectedProduct = null;
                selectedTable = null;
                selectedCustomer = null;
                txtTenMon.Clear();
                nbrSoLuong.Value = 1;
                txtKH.Clear();
            }
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

            dgvMonAn.Columns.Clear();
            dgvMonAn.Columns.Add("ProductId", "Mã sản phẩm");
            dgvMonAn.Columns.Add("ProductName", "Tên sản phẩm");
            dgvMonAn.Columns.Add("Price", "Giá");
            dgvMonAn.Columns.Add("Quantity", "Số lượng");

            dgvMonAn.Columns["ProductId"].Visible = false;
            dgvMonAn.Columns["Price"].DefaultCellStyle.Format = "#,##0 VNĐ";
            dgvMonAn.Columns["Price"].Width = 70;
            dgvMonAn.Columns["Quantity"].Width = 50;

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
                imagePath = Path.Combine(Application.StartupPath, "Products", "noImage.png");
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
                //Console.WriteLine("Lỗi khi tải ảnh: " + ex.Message);
                //pictureBox.Image = imlSanPham.Images[1];
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
            Control btnTable = sender as Control;
            selectedTable = (Table)btnTable.Tag;
            if (selectedTable != null)
            {
                lbBan.Text = btnTable.Text;
                tabBanAn.SelectedTab = tabBanAn.TabPages[1];
            }
            if (selectedTable.Status == 1)
            {
                dgvMonAn.Rows.Clear();
                txtKH.Clear();


                var bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == selectedTable.TableId && b.Status == 0);
                if (bill != null)
                {
                    var currentCustomer = bllCustomer.GetAll().FirstOrDefault(c => c.CustomerId == bill.CustomerId);
                    if (currentCustomer != null)
                    {

                        txtKH.Text = currentCustomer.CustomerName;
                        txtKH.Tag = currentCustomer;

                        selectedCustomer = currentCustomer;
                    }
                    var billInfo = bllBillInfo.GetAll().Where(bi => bi.BillId == bill.BillId).ToList();
                    foreach (var item in billInfo)
                    {
                        var product = bllProduct.GetAll().FirstOrDefault(p => p.ProductId == item.ProductId);
                        if (product != null)
                        {
                            dgvMonAn.Rows.Add(product.ProductId, product.ProductName, product.Price, item.Quantity);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cho bàn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (selectedTable.Status == 0)
            {
                selectedCustomer = null;
                selectedProduct = null;
                dgvMonAn.Rows.Clear();
                txtKH.Clear();
            }
        }

        private void PanelProduct_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control != null && control.Tag is Product product)
            {
                selectedProduct = product;
                //control.BackColor = ColorTranslator.FromHtml("#52362A");
                txtTenMon.Text = product.ProductName;
            }
        }

        private void btnChonKhach_Click(object sender, EventArgs e)
        {
            frmChonKhachHang fr = new frmChonKhachHang(currentEmployee);

            if (fr.ShowDialog() == DialogResult.OK)
            {
                selectedCustomer = fr.SelectedCustomer;
                if (selectedCustomer != null)
                {
                    txtKH.Text = selectedCustomer.CustomerName;
                    txtKH.Tag = selectedCustomer;
                }
            }
            fr.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (selectedTable == null || selectedTable.TableId <= 0)
            {
                MessageBox.Show("Vui lòng chọn bàn ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedCustomer == null || string.IsNullOrEmpty(txtKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedProduct == null || selectedProduct.ProductId <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nbrSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int billId = 0;
                var bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == selectedTable.TableId && b.Status == 0);

                // Sử dụng giao dịch để đảm bảo toàn vẹn dữ liệu
                if (selectedTable.Status == 0) // Bàn trống
                {
                    Bill newBill = new Bill
                    {
                        BranchId = currentEmployee.BranchId,
                        CreateDate = DateTime.Now,
                        CustomerId = selectedCustomer.CustomerId,
                        EmployeeId = currentEmployee.EmployeeId,
                        TableId = selectedTable.TableId,
                        Status = 0
                    };
                    bllBill.Add(newBill);
                    bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == selectedTable.TableId && b.Status == 0);
                    if (bill == null)
                    {
                        MessageBox.Show("Không thể tạo hóa đơn mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    billId = bill.BillId;

                    // Cập nhật trạng thái bàn
                    selectedTable.Status = 1;
                    bllTable.Update(selectedTable);
                    // Cập nhật cache
                    var tableInCache = cachedTables?.FirstOrDefault(t => t.TableId == selectedTable.TableId);
                    if (tableInCache != null)
                    {
                        tableInCache.Status = 1;
                    }
                    LoadBanAn(); // Tải lại toàn bộ danh sách bàn
                }
                else if (selectedTable.Status == 1) // Bàn đã có khách
                {
                    if (bill == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn hợp lệ cho bàn này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    billId = bill.BillId;
                }

                // Kiểm tra và cập nhật BillInfo
                var existingBillInfo = bllBillInfo.GetAll().FirstOrDefault(bi => bi.BillId == billId && bi.ProductId == selectedProduct.ProductId);
                if (existingBillInfo != null)
                {
                    existingBillInfo.Quantity += (int)nbrSoLuong.Value;
                    bllBillInfo.Update(existingBillInfo);
                }
                else
                {
                    var newBillInfo = new BillInfo
                    {
                        BillId = billId,
                        ProductId = selectedProduct.ProductId,
                        Quantity = (int)nbrSoLuong.Value
                    };
                    bllBillInfo.Add(newBillInfo);
                }

                // Cập nhật DataGridView
                bool productExistsInGrid = false;
                foreach (DataGridViewRow row in dgvMonAn.Rows)
                {
                    if (row.Cells["ProductId"].Value != null && row.Cells["ProductId"].Value.ToString() == selectedProduct.ProductId.ToString())
                    {
                        row.Cells["Quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) + (int)nbrSoLuong.Value;
                        productExistsInGrid = true;
                        break;
                    }
                }

                if (!productExistsInGrid)
                {
                    dgvMonAn.Rows.Add(selectedProduct.ProductId, selectedProduct.ProductName, selectedProduct.Price, (int)nbrSoLuong.Value);
                }

                ClearDuLieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMonAn.SelectedRows)
                {
                    if (row.Cells["ProductId"].Value != null)
                    {
                        int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                        // Tìm hóa đơn tương ứng với bàn ăn hiện tại
                        int billId = bllBill.GetAll().FirstOrDefault(b => b.TableId == selectedTable.TableId && b.Status == 0)?.BillId ?? 0;
                        // Tìm thông tin hóa đơn tương ứng với sản phẩm
                        var billInfo = bllBillInfo.GetAll().FirstOrDefault(bi => bi.BillId == billId && bi.ProductId == productId);
                        if (billInfo != null)
                        {
                            bllBillInfo.Delete(billInfo.BillInfoId);
                            dgvMonAn.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}