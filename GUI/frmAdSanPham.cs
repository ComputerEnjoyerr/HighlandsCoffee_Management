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
using BLL;
using DTO;

namespace GUI
{
    public partial class frmAdSanPham : Form
    {
        public frmAdSanPham()
        {
            InitializeComponent();
        }

        private string imageName = "";
        private string imagePath = "";
        private BLL_Product productBLL = new BLL_Product();
        private BLL_Ingredient ingredientBLL = new BLL_Ingredient();
        private BLL_Recipe recipeBLL = new BLL_Recipe();   

        private void ClearDuLieu()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            picHinhAnh.Image = null;

            cboNguyenLieu.SelectedItem = null;
            cboSanPham.SelectedItem = null;
            txtMaCT.Clear();
            txtSoLuong.Clear();
        }

        private void LoadSanPham()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            picHinhAnh.Image = null;
            imageName = "";
            imagePath = "";

            dgvSanPham1.DataSource = productBLL.GetAll();
            dgvSanPham2.DataSource = productBLL.GetAll();

            cboSanPham.DataSource = productBLL.GetAll();
            cboSanPham.DisplayMember = "ProductName";
            cboSanPham.ValueMember = "ProductId";
            cboSanPham.SelectedIndex = 0;

            cboNguyenLieu.DataSource = ingredientBLL.GetAll();
            cboNguyenLieu.DisplayMember = "IngredientName";
            cboNguyenLieu.ValueMember = "IngredientId";
            cboNguyenLieu.SelectedIndex = 0;

        }
        private void LoadCotCongThuc()
        {
            dgvNguyenLieu1.Columns.Add("IngredientId", "Mã NL");
            dgvNguyenLieu1.Columns.Add("IngredientName", "Tên NL");
            dgvNguyenLieu1.Columns.Add("Quantity", "SL");
            dgvNguyenLieu1.Columns.Add("Unit", "ĐVT");
        }
        private void LoadCongThuc()
        {
            dgvNguyenLieu2.DataSource = ingredientBLL.GetAll();
        }

        private bool ThemAnhVaoThuMuc(Product product)
        {
            // Tạo đường dẫn đến file ảnh trong thư mục "Products"
            string productsFolder = Path.Combine(Application.StartupPath, "Products");
            string destinationPath = Path.Combine(productsFolder, imageName);
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Kiểm tra xem file ảnh đã tồn tại chưa nếu rồi thì báo lỗi
                if (File.Exists(destinationPath))
                {
                    MessageBox.Show("File ảnh này không hợp. Vui lòng chọn một ảnh khác bên ngoài", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                File.Copy(imagePath, destinationPath, true);
            }
            else
            {
                product.Image = "";
            }
            return true;
        }

        private void frmAdSanPham_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlMain2.BackColor = ColorTranslator.FromHtml("#52362A");
            pnl1.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnl2.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnl3.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadSanPham();
            LoadCongThuc();
            LoadCotCongThuc();
        }

        private void dgvSanPham1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSanPham1.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    txtId.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtPrice.Text = row.Cells[3].Value.ToString();
                }
            }

            var selectedProduct = productBLL.GetAll().FirstOrDefault(p => p.ProductId == int.Parse(txtId.Text));
            var recipes = recipeBLL.GetAll().Where(r => r.ProductId == selectedProduct.ProductId).ToList();
            dgvNguyenLieu1.Rows.Clear(); // Clear existing rows
            foreach (var rp in recipes)
            {
                var ig = ingredientBLL.GetAll().FirstOrDefault(i => i.IngredientId == rp.IngredientId);
                if (ig != null)
                {

                    dgvNguyenLieu1.Rows.Add(ig.IngredientId, ig.IngredientName, rp.Quantity, rp.Unit);
                }
            }
        }

        private void dgvSanPham2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSanPham2.Rows[e.RowIndex];
                // Lấy ProductId từ cột đầu tiên 
                if (row.Cells[0].Value != null)
                {
                    int productId = (int)row.Cells[0].Value;
                    // Đặt SelectedValue của cboSanPham thành ProductId
                    cboSanPham.SelectedValue = productId;
                }
            }
        }

        private void dgvNguyenLieu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNguyenLieu2.Rows[e.RowIndex];
                // Lấy ProductId từ cột đầu tiên 
                if (row.Cells[0].Value != null)
                {
                    int ingredientId = (int)row.Cells[0].Value;
                    // Đặt SelectedValue của cboSanPham thành ProductId
                    cboNguyenLieu.SelectedValue = ingredientId;
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn hình ảnh
                    imagePath = openFileDialog.FileName;
                    imageName = Path.GetFileName(imagePath);
                    // Hiển thị hình ảnh trong PictureBox
                    picHinhAnh.Image = Image.FromFile(imagePath);
                }
                //MessageBox.Show($"{imageName}\n{imagePath}");
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text) || !txtPrice.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Vui lòng nhập giá sản phẩm hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Product product = new Product
                {
                    ProductName = txtName.Text,
                    Price = double.Parse(txtPrice.Text),
                    Image = imageName,
                };

                if(!ThemAnhVaoThuMuc(product))
                {
                    return;
                }
                // Thêm sản phẩm
                productBLL.Add(product);
                LoadSanPham();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtId.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(txtPrice.Text) || !txtPrice.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Vui lòng nhập giá sản phẩm hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Product product = new Product
                    {
                        ProductId = int.Parse(txtId.Text),
                        ProductName = txtName.Text,
                        Price = double.Parse(txtPrice.Text),
                        Image = imageName,
                    };

                    // Nếu có thay đổi hình ảnh, xóa hình ảnh cũ
                    string oldImagePath = Path.Combine(Application.StartupPath, "Products", product.Image);
                    if (File.Exists(oldImagePath) && oldImagePath != imagePath)
                    {
                        File.Delete(oldImagePath);
                        MessageBox.Show("Xóa hình ảnh cũ thành công", "Thành cô", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Cập nhật sản phẩm
                    productBLL.Update(product);
                    LoadSanPham();
                    ClearDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {txtName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        MessageBox.Show("Vui lòng chọn sản phẩm để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    // Xóa sản phẩm
                    int productId = int.Parse(txtId.Text);
                    productBLL.Delete(productId);
                    LoadSanPham();
                    ClearDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtSoLuong.Text, out double quantity) || quantity < 0)
                {
                    MessageBox.Show("Số lượng phải là một số không âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đồng bộ hóa đơn vị tính của nguyên liệu và sản phẩm
                Ingredient ingredient = ingredientBLL.GetAll().FirstOrDefault(i => i.IngredientId == (int)cboNguyenLieu.SelectedValue);
                if (ingredient == null)
                {
                    MessageBox.Show("Nguyên liệu không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Recipe recipe = new Recipe
                {
                    IngredientId = (int)cboNguyenLieu.SelectedValue,
                    ProductId = (int)cboSanPham.SelectedValue,
                    Quantity = quantity, 
                    Unit = ingredient.Unit,
                };

                // Thêm công thức và làm mới
                recipeBLL.Add(recipe);
                LoadCongThuc();
                MessageBox.Show("Thêm công thức thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                // Đẩy dữ liệu product vào frmAdXoaSuaCongThuc
                var product = productBLL.GetAll().FirstOrDefault(p => p.ProductId == (int)cboSanPham.SelectedValue);
                var recipe = recipeBLL.GetAll().Any(r => r.ProductId == product.ProductId);
                if (product != null && recipe) // Ktra nguyên liệu đã có công thức chưa
                {
                    frmAdXoaSuaCongThuc fr = new frmAdXoaSuaCongThuc(product);
                    fr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hãy thêm công thức trước khi xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Vui lòng chọn sản phẩm trước khi xem", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvSanPham2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đẩy dữ liệu product vào frmAdXoaSuaCongThuc
            var product = productBLL.GetAll().FirstOrDefault(p => p.ProductId == (int)cboSanPham.SelectedValue);
            var recipe = recipeBLL.GetAll().Any(r => r.ProductId == product.ProductId);
            if (product != null && recipe) // Ktra nguyên liệu đã có công thức chưa
            {
                frmAdXoaSuaCongThuc fr = new frmAdXoaSuaCongThuc(product);
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy thêm công thức trước khi xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
