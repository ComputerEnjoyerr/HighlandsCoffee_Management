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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private BLL_Financial bllFinancial = new BLL_Financial();
        private Employee currentEmployee = new Employee();

        private void LoadDoanhTHu()
        {
            var doanhthus = bllFinancial.GetAll().Where(f => f.BranchId == currentEmployee.BranchId);
            if (doanhthus.Any())
            {
                dgvDoanhThu.DataSource = doanhthus.ToList();
                dgvDoanhThu.Columns["FinancialId"].Visible = false;
            }
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }

            LoadDoanhTHu();
        }

        // Khi nhấn vào một doanh thu, tìm kiếm các tất cả các hóa đơn theo tháng trong CreateDate, Hiển thị: mã hóa đơn, tên và giá các sản phẩm (lấy từ bảng Product), số lượng sp (BillInfo), thời gian lập bill
        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin doanh thu đã chọn
                Financial selectedDoanhThu = dgvDoanhThu.SelectedRows[0].DataBoundItem as Financial;
                // Hiển thị thông tin chi tiết doanh thu
                if (selectedDoanhThu == null) return;
                using (frmChiTietDoanhThu fr = new frmChiTietDoanhThu(selectedDoanhThu))
                {
                    fr.ShowDialog();
                }

            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cboThang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng để lọc doanh thu.");
                return;
            }
            int selectedMonth = int.Parse(cboThang.SelectedIndex.ToString());
            if (selectedMonth == 0)
            {
                var doanhthus = bllFinancial.GetAll().Where(f => f.BranchId == currentEmployee.BranchId);
                if (doanhthus.Any())
                {
                    dgvDoanhThu.DataSource = doanhthus.ToList();
                    dgvDoanhThu.Columns["FinancialId"].Visible = false;
                }
            }
            else
            {   
                // Lọc doanh thu theo tháng đã chọn
                var filteredDoanhThu = bllFinancial.GetAll().Where(f => f.BranchId == currentEmployee.BranchId && f.ReportDate.Month == selectedMonth).ToList();
                if (filteredDoanhThu.Any())
                    dgvDoanhThu.DataSource = filteredDoanhThu.ToList();
                else
                    MessageBox.Show("Không có doanh thu nào trong tháng " + selectedMonth);
            }
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // Xem chi tiết doanh thu 
            if (dgvDoanhThu.SelectedRows.Count > 0)
            {
                // Lấy thông tin doanh thu đã chọn
                Financial selectedDoanhThu = dgvDoanhThu.SelectedRows[0].DataBoundItem as Financial;
                // Hiển thị thông tin chi tiết doanh thu
                if (selectedDoanhThu == null) return;
                using (frmChiTietDoanhThu fr = new frmChiTietDoanhThu(selectedDoanhThu))
                {
                    fr.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một doanh thu để xem chi tiết.");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.SelectedRows.Count > 0)
            {
                Financial selectedDoanhThu = dgvDoanhThu.SelectedRows[0].DataBoundItem as Financial;
                using (frmRPTChiTietDoanhThu frm = new frmRPTChiTietDoanhThu(selectedDoanhThu))
                    frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một doanh thu để in báo cáo.");
            }
        }
    }
}
