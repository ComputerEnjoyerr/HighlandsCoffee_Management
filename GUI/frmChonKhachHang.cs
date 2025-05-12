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
    public partial class frmChonKhachHang : Form
    {
        public frmChonKhachHang(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;
        }

        public Employee currentEmployee = new Employee();
        public Customer SelectedCustomer = new Customer();
        private BLL_Customer BLL_Customer = new BLL_Customer();

        private void LoadKhachHang()
        {
            // Hiển thị các btn Khách hàng
            var khachhang = BLL_Customer.GetAll().ToList();
            dgvKhachHang.DataSource = khachhang;
        }

        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadKhachHang();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtTimKiem.Text = row.Cells["CustomerName"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
            else if (dgvKhachHang.SelectedRows.Count > 0)
            {
                SelectedCustomer = dgvKhachHang.SelectedRows[0].DataBoundItem as Customer;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
