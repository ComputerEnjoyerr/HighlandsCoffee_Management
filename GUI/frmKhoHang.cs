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
                    //Inventory inventory = new Inventory
                    //{
                    //    BranchId = currentEmployee.BranchId,
                    //    IngredientId = bllIngredient.GetAll().FirstOrDefault(ig => ig.IngredientName == txtNguyenLieu.Text).IngredientId,
                    //    ExpDay = int.Parse(txtSoNgayHH.Text),
                    //    ExpDate = dtpNgayHH.Value,
                    //    Quantity = double.Parse(txtSoLuong.Text),
                    //    Unit = cboDVT.Text,
                    //    RestockDate = dtpNgayNhap.Value,
                    //    UnitPrice = double.Parse(txtDonGia.Text),
                    //    TotalPrice = double.Parse(txtTongTien.Text)
                    //};

                    var inventory = new Inventory
                    {
                        InventoryId = 200, // Thay bằng InventoryId hợp lệ
                        BranchId = 1, // Thay bằng BranchId hợp lệ
                        IngredientId = 1, // Thay bằng IngredientId hợp lệ
                        ExpDay = 30,
                        //ExpDate = DateTime.Now.AddDays(30),
                        Quantity = 10.0,
                        Unit = "kg",
                        RestockDate = DateTime.Now,
                        UnitPrice = 100.0,
                        //TotalPrice = 1000.0
                    };

                    bllInventory.Add(inventory);
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
    }
}
