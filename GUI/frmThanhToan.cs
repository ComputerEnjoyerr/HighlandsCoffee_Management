using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmThanhToan : Form
    {


        public frmThanhToan(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private readonly Employee currentEmployee;

        private readonly BLL_Table bllTable = new BLL_Table();
        private readonly BLL_BillInfo bllBillInfo = new BLL_BillInfo();
        private readonly BLL_Bill bllBill = new BLL_Bill();
        private readonly BLL_PromotionCustomer bllPromotionCustomer = new BLL_PromotionCustomer();
        private readonly BLL_Product bllProduct = new BLL_Product();
        private readonly BLL_Promotion bllPromotion = new BLL_Promotion();
        private readonly BLL_Financial bllFinancial = new BLL_Financial();

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            // Cài đặt màu sắc
            BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlChonBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpKhuyenMai.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadBan();
        }

        private void LoadBan()
        {
            var dsBan = bllTable.GetAll()
                .Where(t => t.Status == 1)
                .Select(t => new { t.TableId, t.TableName })
                .ToList();

            cboBanAn.DisplayMember = "TableName";
            cboBanAn.ValueMember = "TableId";
            cboBanAn.DataSource = dsBan;
        }

        private void LoadKhuyenMai(int customerId)
        {
            flpKhuyenMai.Controls.Clear(); // Xóa danh sách khuyến mãi cũ

            var promotions = bllPromotionCustomer.GetAll()
                .Join(bllPromotion.GetDataPromotion(),
                    pc => pc.PromotionId,
                    p => p.PromotionId,
                    (pc, p) => new { pc.CustomerId, Promotion = p })
                .Where(x => x.CustomerId == customerId &&
                            x.Promotion.StartDate <= DateTime.Now &&
                            x.Promotion.EndDate >= DateTime.Now)
                .Select(x => x.Promotion)
                .ToList();

            // Tạo một GroupBox hoặc sử dụng chính FlowLayoutPanel để nhóm các RadioButton
            foreach (var promotion in promotions)
            {
                var radioButton = new RadioButton
                {
                    Size = new Size(flpKhuyenMai.Width - 10, 70),
                    Padding = new Padding(10),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Text = promotion.PromotionName,
                    Tag = promotion.Discount,
                    Name = $"radio_{promotion.PromotionId}",
                    BackColor = ColorTranslator.FromHtml("#BD965F")
                };

                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                flpKhuyenMai.Controls.Add(radioButton);
            }
        }

        private void cboBanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBanAn.SelectedValue == null) return;

            int tableId = Convert.ToInt32(cboBanAn.SelectedValue);
            var bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == tableId && b.Status == 0);

            if (bill == null)
            {
                ResetForm();
                return;
            }

            // Load chi tiết hóa đơn
            var chiTiet = bllBillInfo.GetAll()
                .Where(bi => bi.BillId == bill.BillId)
                .Join(bllProduct.GetAll(),
                    bi => bi.ProductId,
                    p => p.ProductId,
                    (bi, p) => new
                    {
                        p.ProductName,
                        bi.Quantity,
                        DonGia = p.Price,
                        ThanhTien = bi.Quantity * p.Price
                    })
                .ToList();

            dgvChiTietHoaDon.DataSource = chiTiet;

            // Tính tổng món và tổng tiền
            int tongMon = chiTiet.Sum(ct => ct.Quantity);
            double tongTien = chiTiet.Sum(ct => ct.ThanhTien);

            txtTongMon.Text = tongMon.ToString("N0");
            txtThanhTien.Text = tongTien.ToString("N0");
            textBox3.Text = tongTien.ToString("N0");

            // Load danh sách khuyến mãi của khách hàng
            LoadKhuyenMai(bill.CustomerId);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadio = sender as RadioButton;
            if (!selectedRadio.Checked) return;

            double discount = (double)selectedRadio.Tag;
            double tongTien = double.Parse(txtThanhTien.Text.Replace(",", ""));
            double thanhTien = tongTien * (1 - discount);

            textBox3.Text = thanhTien.ToString("N0");
            txtKhuyenMai.Text = $"{discount:P0}";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboBanAn.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bàn ăn trước khi thanh toán.");
                return;
            }

            int tableId = (int)cboBanAn.SelectedValue;
            var bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == tableId && b.Status == 0);

            if (bill == null) return;
            if (cboBanAn.SelectedValue == null) return;

            DialogResult rs = MessageBox.Show($"Bạn có chắc chắn thanh toán cho {cboBanAn.SelectedText}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs) return;

            // Cập nhật hóa đơn
            bill.TotalPrice = double.Parse(textBox3.Text.Replace(",", ""));
            bill.Status = 1; // Đã thanh toán
            bllBill.Update(bill);

            // Cập nhật trạng thái bàn
            var ban = bllTable.GetAll().FirstOrDefault(tb => tb.TableId == tableId);
            if (ban != null)
            {
                ban.Status = 0; // Trống
                bllTable.Update(ban);
            }

            // Cập nhật doanh thu
            DateTime today = DateTime.Today;
            var financial = bllFinancial.GetAll().FirstOrDefault(f =>
                f.BranchId == bill.BranchId &&
                f.ReportDate.Date == today.Date);

            if (financial == null)
            {
                bllFinancial.Add(new Financial
                {
                    BranchId = bill.BranchId,
                    ReportDate = today,
                    Revenue = bill.TotalPrice,
                    OperationCost = 500000,
                    IngredientCost = 500000
                });
            }
            else
            {
                financial.Revenue += bill.TotalPrice;
                bllFinancial.Update(financial);
            }

            if (cbxInHoaDon.Checked)
            {
                using (frmRPTHoaDonThanhToan rpt = new frmRPTHoaDonThanhToan(bill))
                    rpt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thanh toán thành công!");
            }
            ResetForm();
            LoadBan();
        }

        private void ResetForm()
        {
            dgvChiTietHoaDon.DataSource = null;
            txtTongMon.Clear();
            txtThanhTien.Clear();
            textBox3.Clear();
            txtKhuyenMai.Clear();
            flpKhuyenMai.Controls.Clear();
            cboBanAn.SelectedIndex = -1;
        }
    }
}