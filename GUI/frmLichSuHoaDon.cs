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
        private Employee currentEmployee;
        private int currentBranchId;
        private BLL_Bill bill = new BLL_Bill();
        public frmLichSuHoaDon(Employee em, int branchId)
        {
            InitializeComponent();
            currentEmployee = em;
            currentBranchId = branchId;
        }

        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            List<Employee> employees = bill.GetEmployeesByBranchId(currentBranchId);
            cboEmployee.DataSource = employees;
            cboEmployee.DisplayMember = "EmployeeName";
            cboEmployee.ValueMember = "EmployeeId";
            cboEmployee.SelectedIndex = -1;

            LoadData();
        }

        // Khi nhấn vào hóa đơn, tìm các chi tiết hóa đơn có mã hóa đơn khớp với mã hóa đơn của hóa đơn rồi truyền dl vào frmChiTietHoaDon
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // Bỏ qua khi click header hoặc dòng không hợp lệ

            // Lấy BillID từ dòng được chọn
            int billId = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["BillId"].Value);

            // Gọi form chi tiết hóa đơn, truyền vào billId
            frmChiTietHoaDon fr = new frmChiTietHoaDon(billId);
            fr.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int? employeeId = null;

            if (cboEmployee.SelectedIndex != -1)
                employeeId = Convert.ToInt32(cboEmployee.SelectedValue);

            DateTime selectedDate = dtpDate.Value.Date;

            List<Bill> bills = bill.FilterBills(currentBranchId, employeeId, selectedDate);
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = bills;

            // Đặt tên cột
            dgvHoaDon.Columns["BillId"].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns["EmployeeId"].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns["CustomerId"].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns["TableId"].HeaderText = "Mã bàn";
            dgvHoaDon.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns["CreateDate"].HeaderText = "Ngày tạo";
            dgvHoaDon.Columns["Status"].HeaderText = "Trạng thái";
        }

        private void LoadData()
        {
            List<Bill> bills = bill.GetBillsByBranch(currentBranchId);
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = bills;
            // Đặt tên cột
            dgvHoaDon.Columns["BillId"].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns["EmployeeId"].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns["CustomerId"].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns["TableId"].HeaderText = "Mã bàn";
            dgvHoaDon.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns["CreateDate"].HeaderText = "Ngày tạo";
            dgvHoaDon.Columns["Status"].HeaderText = "Trạng thái";
        }
    }
}
