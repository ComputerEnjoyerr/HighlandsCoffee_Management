using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmAdXoaSuaCongThuc : Form
    {
        public frmAdXoaSuaCongThuc(Product p)
        {
            InitializeComponent();
            product = p;
        }

        private BLL_Recipe recipeBLL = new BLL_Recipe();
        private BLL_Ingredient ingredientBLL = new BLL_Ingredient();
        private Product product = new Product();

        private void ClearDuLieu()
        {
            cboNguyenLieu.SelectedItem = null;
            txtSoLuong.Clear();
            txtDVT.Clear();
            txtMaCT.Clear();
        }

        private void LoadCotCongThuc()
        {
            dgvCongThuc.Columns.Add("RecipeId", "Mã CT");
            dgvCongThuc.Columns.Add("IngredientId", "Mã NL");
            dgvCongThuc.Columns.Add("IngredientName", "Tên NL");
            dgvCongThuc.Columns.Add("Quantity", "SL");
            dgvCongThuc.Columns.Add("Unit", "ĐVT");
        }
        private void LoadCongThuc()
        {
            dgvCongThuc.Rows.Clear();
            var recipes = recipeBLL.GetAll().Where(r => r.ProductId == product.ProductId);
            if (recipes.Any())
            {
                foreach (var r in recipes)
                {
                    var ig = ingredientBLL.GetAll().FirstOrDefault(i => i.IngredientId == r.IngredientId);
                    dgvCongThuc.Rows.Add(r.RecipeId ,ig.IngredientId, ig.IngredientName, r.Quantity, r.Unit);
                }
            }
        }

        private void LoadNguyenLieu()
        {
            cboNguyenLieu.Items.Clear();
            cboNguyenLieu.DataSource = ingredientBLL.GetAll();
            cboNguyenLieu.DisplayMember = "IngredientName";
            cboNguyenLieu.ValueMember = "IngredientId";
        }

        private void frmAdXoaSuaCongThuc_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadCotCongThuc();
            LoadCongThuc();
            LoadNguyenLieu();
        }

        private void dgvCongThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCongThuc.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    txtMaCT.Text = row.Cells[0].Value.ToString();
                    cboNguyenLieu.SelectedValue = row.Cells[1].Value;
                    txtSoLuong.Text = row.Cells[3].Value.ToString();
                    txtDVT.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc chắn muốn xóa công thức này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    if (!int.TryParse(txtMaCT.Text, out int id) || id < 0)
                    {
                        MessageBox.Show("Vui lòng chọn công thức", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Xóa công thức
                    recipeBLL.Remove(id);
                    LoadCongThuc();
                    ClearDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show($"Bạn có chắc chắn muốn sửa công thức này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    if (!double.TryParse(txtSoLuong.Text, out double qty) || qty < 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(txtDVT.Text))
                    {
                        MessageBox.Show("Vui lòng nhập hoặc chọn đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!int.TryParse(txtMaCT.Text, out int id) || id < 0)
                    {
                        MessageBox.Show("Vui lòng chọn công thức", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Recipe recipe = new Recipe
                    {
                        RecipeId = id,
                        ProductId = product.ProductId,
                        IngredientId = (int)cboNguyenLieu.SelectedValue,
                        Quantity = qty,
                        Unit = txtDVT.Text,
                    };

                    // Cập nhật công thức
                    recipeBLL.Update(recipe);
                    LoadCongThuc();
                    ClearDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
