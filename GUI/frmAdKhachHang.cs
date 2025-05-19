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
    public partial class frmAdKhachHang : Form
    {
        BLL_Customer bllCustomer = new BLL_Customer();
        public frmAdKhachHang()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void frmAdKhachHang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvKhachHang.DataSource = bllCustomer.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

           
            if (!int.TryParse(txtDiem.Text, out int point))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            var customer = new Customer
            {
                
                CustomerName = txtHoTen.Text,
                PhoneNumber = txtPhone.Text,
                Email = txtEmail.Text,
                Point = point,
                Tier = cbHang.SelectedItem.ToString()
            };
                bllCustomer.AddCustomer(customer);
                MessageBox.Show("Thêm thành công!");
                dgvKhachHang.DataSource = bllCustomer.GetAll();
                
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            try
            {
                int id = int.Parse(txtMaKH.Text);
                bllCustomer.DeleteCustomer(id);
                MessageBox.Show("Xóa thành công!");
                dgvKhachHang.DataSource = bllCustomer.GetAll(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtDiem.Text = row.Cells[1].Value.ToString();
                cbHang.Text = row.Cells[5].Value.ToString();
            }
        }
        
        private void LoadComboBox()
        {
            cbHang.DataSource = bllCustomer.GetTears();
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDiem.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDiem.Text, out int point))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }
            if (!int.TryParse(txtMaKH.Text, out int customerId))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            var customer = new Customer
            {
                CustomerId = customerId,
                CustomerName = txtHoTen.Text,
                PhoneNumber = txtPhone.Text,
                Email = txtEmail.Text,
                Point = point,
                Tier = cbHang.SelectedItem.ToString()
            };
            bllCustomer.UpdateCustomer(customer);
            MessageBox.Show("Sửa thành công!");
            dgvKhachHang.DataSource = bllCustomer.GetAll();

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var tenKH = bllCustomer.GetAll().Where(c => c.CustomerName.ToLower().Contains(txtTim.Text.ToLower())).ToList();
            var phoneKH = bllCustomer.GetAll().Where(c => c.PhoneNumber.ToLower().Contains(txtTim.Text.ToLower())).ToList();
            if (tenKH.Count != 0)
            {
                dgvKhachHang.DataSource = tenKH;
            }
            else if (phoneKH.Count != 0)
            {
                dgvKhachHang.DataSource = phoneKH;
            }
        }
    }
}
