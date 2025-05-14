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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL;

namespace GUI
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
            
        }

        private Employee currentEmployee = new Employee();
       
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlChonBan.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpKhuyenMai.BackColor = ColorTranslator.FromHtml("#DED4CA");

            List<Promotion> promotionList = promotion.GetDataPromotion();
           // Dữ liệu khuyến mãi ở đây
            foreach (var promotion in promotionList)
            {
                Panel panel = new Panel();
                panel.Size = new Size(flpKhuyenMai.Width - 25, 60);
                panel.BackColor = ColorTranslator.FromHtml("#BD965F");

                CheckBox checkBox = new CheckBox();
                checkBox.Size = new Size(panel.Width - 20, panel.Height - 10);
                checkBox.Font = new Font("Arial", 12, FontStyle.Bold);
                checkBox.Location = new Point(10, 10);
                checkBox.Text = promotion.PromotionName;
                checkBox.Tag = promotion.Discount;
                checkBox.AllowDrop = true;
                panel.Controls.Add(checkBox);
                flpKhuyenMai.Controls.Add(panel);

                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
            LoadBan();
        }
        BLL_Table table = new BLL_Table();
        BLL_BillInfo billInfo = new BLL_BillInfo();
        BLL_Bill bllBill = new BLL_Bill();
        BLL_PromotionCustomer promotionCustomer = new BLL_PromotionCustomer();
        BLL_Product product = new BLL_Product();
        BLL_Promotion promotion = new BLL_Promotion();
        BLL_Financial fin = new BLL_Financial();
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int tableId = Convert.ToInt32(comboBox1.SelectedValue);

           
                var bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == tableId && b.Status == 0);
                
                if (bill == null)
                {
                    dataGridView1.DataSource = null;
                    textBox2.Clear();
                    textBox1.Clear();
                    return;
                }

                var chiTiet = billInfo.GetAll()
                                .Where(bi => bi.BillId == bill.BillId)
                                .Join(product.GetAll(), bi => bi.ProductId, p => p.ProductId, (bi, p) => new
                                
                                {
                                    p.ProductName,
                                    bi.Quantity,
                                    DonGia = p.Price,
                                    ThanhTien = bi.Quantity * p.Price
                                })
                                .ToList();

                dataGridView1.DataSource = chiTiet;
            //Tính số món
            int tongMon = chiTiet.Sum(ct => ct.Quantity);
            textBox1.Text = tongMon.ToString("N0");

                //Tinh tổng tiền
                double tongTien = chiTiet.Sum(ct => ct.ThanhTien);
                textBox2.Text = tongTien.ToString("N0");

            double discount = promotionCustomer.GetAll()
                                .Join(promotion.GetDataPromotion(),
                                pc => pc.PromotionId,
                                p => p.PromotionId,
                                (pc, p) => new { pc.CustomerId, Promotion = p })
                                .Where(x => x.CustomerId == bill.CustomerId &&
                                x.Promotion.StartDate <= DateTime.Now &&
                                x.Promotion.EndDate >= DateTime.Now)
                                .Select(x => (double?)x.Promotion.Discount)
                                .FirstOrDefault() ?? 0;
            //Tính khuyến mãi
            
            //tính thành tiền
            double thanhTien = tongTien;
            textBox3.Text = thanhTien.ToString("N0");
            
        }
        private List<Bill> lichSuThanhToan = new List<Bill>();
        private frmLichSuHoaDon frmLichSu = null; // giữ tham chiếu

        //hiện khuyến mãi lên textbox
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = sender as CheckBox;

            //Kiểm tra checkbox đã chọn ròi thì không chọn textbox khác
            if (clickedCheckbox.Checked)
            {
                // Deselect tất cả checkbox khác trong FlowLayoutPanel
                foreach (Control control in flpKhuyenMai.Controls)
                {
                    if (control is CheckBox checkbox && checkbox != clickedCheckbox)
                    {
                        checkbox.Checked = false; // Bỏ chọn checkbox khác
                    }
                }


                if (clickedCheckbox.Checked)
                {
                    // Lấy giá trị giảm giá từ Tag của CheckBox
                    double discount = (double)clickedCheckbox.Tag;

                    // Lấy tổng tiền từ textBox2 (tổng tiền trước khi giảm giá)
                    double tongTien = Convert.ToDouble(textBox2.Text.Replace(",", "")); // Xử lý dấu phẩy nếu có

                    // Tính số tiền sau giảm giá
                    double thanhTien = tongTien * (1 - discount);

                    // Hiển thị kết quả giảm giá vào textBox3 (hoặc textBox4 nếu muốn)
                    textBox3.Text = thanhTien.ToString("N0");

                    // Hiển thị phần trăm khuyến mãi vào textBox4
                    textBox4.Text = $"{discount:P0}"; // Hiển thị phần trăm, ví dụ: 10%
                }
                else
                {
                    // Nếu bỏ chọn, xóa phần trăm khuyến mãi và tính lại số tiền
                    textBox4.Clear();

                    // Lấy lại tổng tiền chưa giảm
                    textBox3.Clear();
                    double tongTien = Convert.ToDouble(textBox2.Text.Replace(",", ""));

                    textBox3.Text = tongTien.ToString("N0");
                }
            }
        }
        //Lấy dữ liệu bàn đã chọn
        private void LoadBan()
        {
               var dsBan = table.GetAll()
                              .Where(t => t.Status == 1)
                              .Select(t => new { t.TableId, t.TableName })
                              .ToList();

                
                comboBox1.DisplayMember = "TableName";
                comboBox1.ValueMember = "TableId";
                comboBox1.DataSource = dsBan;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            int tableId = (int)comboBox1.SelectedValue;


            var bill = bllBill.GetAll().FirstOrDefault(b => b.TableId == tableId && b.Status == 0);
            if (bill == null) return;

            double thanhTien = double.Parse(textBox2.Text);

            // Cập nhật hóa đơn
            bill.TotalPrice = thanhTien;
            bill.Status = 1;

            // Cập nhật trạng thái bàn
            var ban = table.GetAll().FirstOrDefault(tb => tb.TableId == tableId);
            // if (ban != null) ban.Status = 0;
            if (ban != null)
            {
                ban.Status = 0;
                table.Update(ban); // 🛠️ THÊM DÒNG NÀY để ghi lại thay đổi
            }
            // Cập nhật doanh thu tháng
            DateTime today = DateTime.Today;
            var financial = fin.GetAll().FirstOrDefault(f =>
                f.BranchId == bill.BranchId &&
                f.ReportDate.Month == today.Month &&
                f.ReportDate.Year == today.Year);

            if (financial == null)
            {
                fin.Add(new Financial
                {
                    BranchId = bill.BranchId,
                    ReportDate = today,
                    Revenue = thanhTien,
                    OperationCost = 0,
                    IngredientCost = 0
                });
            }
            else
            {
                financial.Revenue += thanhTien;
                fin.Update(financial);//cập nhập lại hóa đơn
            }
            //Xóa món sau khi thanh toán
            var danhSachMon = billInfo.GetAll().Where(bi => bi.BillId == bill.BillId).ToList();
            foreach (var item in danhSachMon)
            {
                billInfo.Delete(item.BillInfoId); // Hàm này cần tồn tại trong BLL_BillInfo
            }

            //fin.SaveChanges();
            MessageBox.Show("Thanh toán thành công!");


            // In hóa đơn
            if (checkBox1.Checked)
            {
                rptViewInHoaDon rpt = new rptViewInHoaDon();
                rpt.ShowDialog();
            }

            LoadBan();
            dataGridView1.DataSource = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}
