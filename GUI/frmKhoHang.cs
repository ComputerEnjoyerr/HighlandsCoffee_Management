using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmKhoHang : Form
    {
        public frmKhoHang(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private BLL_Inventory bllInventory = new BLL_Inventory();
        private BLL_Ingredient bllIngredient = new BLL_Ingredient();
        private BLL_Branch bllBranch = new BLL_Branch();

        private void LoadKhoHang()
        {
            var data = from i in bllInventory.GetAll()
                       where i.BranchId == currentEmployee.BranchId
                       select new
                       {
                           i.InventoryId,
                           bllIngredient.GetAll().FirstOrDefault(ig => ig.IngredientId == i.IngredientId).IngredientName,
                           i.RestockDate,
                           i.ExpDay,
                           i.ExpDate,
                           i.Quantity,
                           i.Unit,
                           i.UnitPrice,
                           i.TotalPrice
                       };
            if (data != null) dgvKhoHang.DataSource = data.ToList();
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void LoadNguyenLieu()
        {
            var data = from i in bllIngredient.GetAll()
                       select new
                       {
                           i.IngredientName,
                           i.Unit,
                           i.Price,
                           i.EXPDay
                       };
            if (data != null)
            {
                dgvNguyenLieu.DataSource = data.ToList();
            }
        }

        private void ClearDuLieuNhap()
        {
            txtMa.Clear();
            txtNguyenLieu.Clear();
            txtSoLuong.Clear();
            txtSoNgayHH.Clear();
            txtDonGia.Clear();
            txtTongTien.Clear();
            dtpNgayHH.Value = DateTime.Now;
            dtpNgayNhap.Value = DateTime.Now;
            cboDVT.SelectedIndex = -1;
            txtSoLuong.Focus();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            LoadKhoHang();
            LoadNguyenLieu();
        }

        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhoHang.Rows[e.RowIndex];
                txtMa.Text = row.Cells["InventoryId"].Value.ToString();
                txtNguyenLieu.Text = row.Cells["IngredientName"].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["RestockDate"].Value);
                txtSoNgayHH.Text = row.Cells["ExpDay"].Value.ToString();
                dtpNgayHH.Value = Convert.ToDateTime(row.Cells["ExpDate"].Value);
                txtSoLuong.Text = row.Cells["Quantity"].Value.ToString();
                cboDVT.Text = row.Cells["Unit"].Value.ToString();
                txtDonGia.Text = row.Cells["UnitPrice"].Value.ToString();
                txtTongTien.Text = row.Cells["TotalPrice"].Value.ToString();
            }
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNguyenLieu.Rows[e.RowIndex];
                txtNguyenLieu.Text = row.Cells["IngredientName"].Value.ToString();
                cboDVT.Text = row.Cells["Unit"].Value.ToString();
                txtDonGia.Text = row.Cells["Price"].Value.ToString();

                if (double.TryParse(txtSoLuong.Text, out double soLuong) && double.TryParse(txtDonGia.Text, out double donGia))
                {
                    double tongTien = soLuong * donGia;
                    txtTongTien.Text = tongTien.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNguyenLieu.Text) || string.IsNullOrEmpty(txtSoNgayHH.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else if (!double.TryParse(txtSoLuong.Text, out double soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                }
                else if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia <= 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 0");
                }
                else if (!double.TryParse(txtTongTien.Text, out double tongTien) || tongTien <= 0)
                {
                    MessageBox.Show("Tổng tiền phải lớn hơn 0");
                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    string id = dateTime.Day.ToString("00") + dateTime.Month.ToString("00") + dateTime.Year.ToString().Substring(2, 2) + dateTime.Second.ToString("00") + dateTime.Minute.ToString("00") + dateTime.Hour.ToString("00");
                    Inventory inventory = new Inventory
                    {
                        InventoryId = "KH" + id,
                        BranchId = currentEmployee.BranchId,
                        IngredientId = bllIngredient.GetAll().FirstOrDefault(ig => ig.IngredientName == txtNguyenLieu.Text).IngredientId,
                        ExpDay = int.Parse(txtSoNgayHH.Text),
                        ExpDate = dtpNgayHH.Value,
                        Quantity = double.Parse(txtSoLuong.Text),
                        Unit = cboDVT.Text,
                        RestockDate = dtpNgayNhap.Value,
                        UnitPrice = double.Parse(txtDonGia.Text),
                        TotalPrice = double.Parse(txtTongTien.Text)
                    };
                    bllInventory.Add(inventory);
                    ClearDuLieuNhap();
                    LoadKhoHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoLuong.Text, out double soLuong) && double.TryParse(txtDonGia.Text, out double donGia))
            {
                double tongTien = soLuong * donGia;
                txtTongTien.Text = tongTien.ToString();
            }
        }

        private void txtSoNgayHH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtSoNgayHH.Text, out int soNgay))
                {
                    DateTime ngayNhap = dtpNgayNhap.Value;
                    DateTime ngayHH = ngayNhap.AddDays(soNgay);
                    dtpNgayHH.Value = ngayHH;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn một loại hàng để xóa!", "Thông báo");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                bllInventory.Delete(txtMa.Text);
                ClearDuLieuNhap();
                LoadKhoHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn một loại hàng để sửa!", "Thông báo");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn sửa hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                if (string.IsNullOrEmpty(txtNguyenLieu.Text) || string.IsNullOrEmpty(txtSoNgayHH.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else if (!double.TryParse(txtSoLuong.Text, out double soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                }
                else if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia <= 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 0");
                }
                else if (!double.TryParse(txtTongTien.Text, out double tongTien) || tongTien <= 0)
                {
                    MessageBox.Show("Tổng tiền phải lớn hơn 0");
                }
                else
                {
                    DateTime dateTime = DateTime.Now;;
                    Inventory inventory = new Inventory
                    {
                        InventoryId = txtMa.Text,
                        BranchId = currentEmployee.BranchId,
                        IngredientId = bllIngredient.GetAll().FirstOrDefault(ig => ig.IngredientName == txtNguyenLieu.Text).IngredientId,
                        ExpDay = int.Parse(txtSoNgayHH.Text),
                        ExpDate = dtpNgayHH.Value,
                        Quantity = double.Parse(txtSoLuong.Text),
                        Unit = cboDVT.Text,
                        RestockDate = dateTime,
                        UnitPrice = double.Parse(txtDonGia.Text),
                        TotalPrice = double.Parse(txtTongTien.Text)
                    };

                    bllInventory.Update(inventory);
                    ClearDuLieuNhap();
                    LoadKhoHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var data = from i in bllInventory.GetAll()
                       join ig in bllIngredient.GetAll() on i.IngredientId equals ig.IngredientId
                       where i.BranchId == currentEmployee.BranchId && ig.IngredientName.ToLower().Contains(txtTim.Text.ToLower())
                       select new
                       {
                           i.InventoryId,
                           bllIngredient.GetAll().FirstOrDefault(ig => ig.IngredientId == i.IngredientId).IngredientName,
                           i.RestockDate,
                           i.ExpDay,
                           i.ExpDate,
                           i.Quantity,
                           i.Unit,
                           i.UnitPrice,
                           i.TotalPrice
                       };
            dgvKhoHang.DataSource = data.ToList();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            ClearDuLieuNhap();
        }
    }
}
