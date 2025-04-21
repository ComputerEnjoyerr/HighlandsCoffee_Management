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
using DTO;

namespace GUI
{
    public partial class frmAdKhuyenMai : Form
    {
        public frmAdKhuyenMai()
        {
            InitializeComponent();
        }
        BLL_Promotion bll = new BLL_Promotion();
        private void frmAdKhuyenMai_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dataGridView1.DataSource = bll.GetDataPromotion();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaKM.Text = row.Cells[0].Value.ToString();
                txtTenKM.Text = row.Cells[2].Value.ToString();
                txtNoiDung.Text = row.Cells[3].Value.ToString();
                dtNgayBatDau.Text = row.Cells[5].Value.ToString();
                dtNgayKetThuc.Text = row.Cells[6].Value.ToString();
                txtDiem.Text = row.Cells[1].Value.ToString();
                txtGiamGia.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaKM.Clear();
            txtTenKM.Clear();
            txtNoiDung.Clear();
            txtDiem.Clear();
            txtGiamGia.Clear();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDiem.Text, out int point))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            if(!double.TryParse(txtGiamGia.Text, out double giamGia))
            {
                MessageBox.Show("Giam gia khong hop le");
            }
            var promotion = new Promotion
            {
                PromotionName = txtTenKM.Text,
                Description = txtNoiDung.Text,
                RequirePoint = point,
                Discount = giamGia,
                StartDate = dtNgayBatDau.Value,
                EndDate = dtNgayKetThuc.Value
            };
            bll.AddPromotion(promotion);
            MessageBox.Show("Them thanh cong");
            dataGridView1.DataSource = bll.GetDataPromotion();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaKM.Text);
                bll.RemovePromotion(id);
                MessageBox.Show("Xóa thành công!");
                dataGridView1.DataSource = bll.GetDataPromotion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDiem.Text, out int point))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            if (!int.TryParse(txtMaKM.Text, out int id))
            {
                MessageBox.Show("Mã khuyến mãi không hợp lệ!");
                return;
            }

            if (!double.TryParse(txtGiamGia.Text, out double giamGia))
            {
                MessageBox.Show("Giam gia khong hop le");
            }
            var promotion = new Promotion
            {
                PromotionId = id,
                PromotionName = txtTenKM.Text,
                Description = txtNoiDung.Text,
                RequirePoint = point,
                Discount = giamGia,
                StartDate = dtNgayBatDau.Value,
                EndDate = dtNgayKetThuc.Value
            };
            bll.UpdatePromotion(promotion);
            MessageBox.Show("Sua thanh cong");
            dataGridView1.DataSource = bll.GetDataPromotion();
        }
    }
}
