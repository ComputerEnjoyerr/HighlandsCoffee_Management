using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmLichSuHoaDon : Form
    {
        public frmLichSuHoaDon(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee;

        private BLL_Bill bllBill = new BLL_Bill();
        private BLL_Employee bllEmployee = new BLL_Employee();
        private BLL_Branch bllBranch = new BLL_Branch();
        private BLL_Customer bllCustomer = new BLL_Customer();
        private BLL_BillInfo bllBillInfo = new BLL_BillInfo();
        private BLL_Table bllTable = new BLL_Table();

        private void LoadNhanVien()
        {
            var nv = bllEmployee.GetDataEmployee()
                .Where(e => e.BranchId == currentEmployee.BranchId)
                .Select(e => new
                {
                    e.EmployeeId,
                    e.EmployeeName,
                })
                .ToList();

            cboEmployee.DataSource = nv;
            cboEmployee.DisplayMember = "EmployeeName";
            cboEmployee.ValueMember = "EmployeeId";
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            cboEmployee.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadNhanVien();
            LoadHoaDon();
        }

        // Khi nhấn vào hóa đơn, tìm các chi tiết hóa đơn có mã hóa đơn khớp với mã hóa đơn của hóa đơn rồi truyền dl vào frmChiTietHoaDon
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã hóa đơn từ dòng được chọn
                int billId = (int)dgvHoaDon.Rows[e.RowIndex].Cells["BillId"].Value;
                var billInfos = bllBillInfo.GetAll()
                    .Where(bi => bi.BillId == billId)
                    .ToList();
                if (billInfos != null)
                {
                    using (frmChiTietHoaDon fr = new frmChiTietHoaDon(billInfos))
                    {
                        fr.ShowDialog();
                    }
                }
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Lọc hóa đơn theo nhân viên được chọn 
            int selectedEmployeeId = (int)cboEmployee.SelectedValue;
            var filteredBills = from b in bllBill.GetAll()
                                join em in bllEmployee.GetDataEmployee() on b.EmployeeId equals em.EmployeeId
                                join c in bllCustomer.GetAll() on b.CustomerId equals c.CustomerId
                                join t in bllTable.GetAll() on b.TableId equals t.TableId
                                where b.EmployeeId == selectedEmployeeId && b.Status == 1
                                && b.BranchId == currentEmployee.BranchId
                                && b.CreateDate.Date == dtpDate.Value.Date
                                orderby b.BillId descending
                                select new
                                {
                                    b.BillId,
                                    t.TableName,
                                    em.EmployeeName,
                                    c.CustomerName,
                                    b.CreateDate,
                                    b.TotalPrice,
                                };
            dgvHoaDon.DataSource = filteredBills.ToList();
            dgvHoaDon.Columns["BillId"].Visible = false;
        }

        private void LoadHoaDon()
        {
            var filteredBills = from b in bllBill.GetAll()
                                join em in bllEmployee.GetDataEmployee() on b.EmployeeId equals em.EmployeeId
                                join c in bllCustomer.GetAll() on b.CustomerId equals c.CustomerId
                                join t in bllTable.GetAll() on b.TableId equals t.TableId
                                where b.BranchId == currentEmployee.BranchId && b.Status == 1
                                orderby b.BillId descending
                                select new
                                {
                                    b.BillId,
                                    t.TableName,
                                    em.EmployeeName,
                                    c.CustomerName,
                                    b.CreateDate,
                                    b.TotalPrice,
                                };
            dgvHoaDon.DataSource = filteredBills.ToList();
            dgvHoaDon.Columns["BillId"].Visible = false;
        }
    }
}
