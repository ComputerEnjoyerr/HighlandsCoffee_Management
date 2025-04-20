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
    public partial class frmAdNhaCungCap : Form
    {
        public frmAdNhaCungCap()
        {
            InitializeComponent();
        }

        private BLL_Supplier supplierBLL = new BLL_Supplier();
        
        private void ClearDuLieu()
        {
            txtMa.Clear();
            rtbDiaChi.Clear();
            rtbTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();

            rtbTen.Focus();
        }

        private void LoadNhaCC()
        {
            flpNhaCC.Controls.Clear();
            var suppliers = supplierBLL.GetAll();
            if (suppliers.Count > 0)
            {
                // Hiển thị thông tin nhà cc bằng các panel
                foreach (var supplier in suppliers)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(475, 150);
                    panel.BackColor = ColorTranslator.FromHtml("#BD965F");
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    //panel.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;

                    Label lbName = new Label();
                    lbName.Font = new Font("Arial", 12, FontStyle.Bold);
                    lbName.Text = supplier.SupplierName;
                    lbName.Size = new Size(panel.Width - 20, 25);
                    lbName.Location = new Point(10, 10);
                    lbName.ForeColor = ColorTranslator.FromHtml("#52362A");
                    

                    Label lbAddress = new Label();
                    lbAddress.Text = supplier.Address;
                    lbAddress.AllowDrop = true;
                    lbAddress.Size = new Size(panel.Width - 20, 45);
                    lbAddress.Location = new Point(10, 35);
                    lbAddress.ForeColor = ColorTranslator.FromHtml("#52362A");

                    Label lbPhone = new Label();
                    lbPhone.Size = new Size(panel.Width - 20, 20);
                    lbPhone.Text = supplier.PhoneNumber;
                    lbPhone.Location = new Point(10, 80);
                    lbPhone.ForeColor = ColorTranslator.FromHtml("#52362A");

                    Label lbEmail = new Label();
                    lbEmail.Size = new Size(panel.Width - 20, 20);
                    lbEmail.Text = supplier.Email;
                    lbEmail.Location = new Point(10, 100);
                    lbEmail.ForeColor = ColorTranslator.FromHtml("#52362A");

                    panel.Tag = supplier;
                    lbName.Tag = supplier;
                    lbAddress.Tag = supplier;
                    lbPhone.Tag = supplier;
                    lbEmail.Tag = supplier;

                    panel.Controls.Add(lbName);
                    panel.Controls.Add(lbPhone);
                    panel.Controls.Add(lbAddress);
                    panel.Controls.Add(lbEmail);

                    // Hiển thị dữ liệu sang các ô nhập liệu khi nhấn vào các panel
                    panel.Click += panelNhaCC_Click;
                    lbName.Click += panelNhaCC_Click;
                    lbEmail.Click += panelNhaCC_Click;
                    lbAddress.Click += panelNhaCC_Click;
                    lbPhone.Click += panelNhaCC_Click;

                    flpNhaCC.Controls.Add(panel);
                }
            }
        }

        private void frmAdNhaCungCap_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpNhaCC.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            LoadNhaCC();
        }

        private void panelNhaCC_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            var supplier = (Supplier)control.Tag;
            if (supplier != null)
            {
                txtMa.Text = supplier.SupplierId.ToString();
                rtbTen.Text = supplier.SupplierName;
                rtbDiaChi.Text = supplier.Address;
                txtDienThoai.Text = supplier.PhoneNumber;
                txtEmail.Text = supplier.Email;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbTen.Text) || string.IsNullOrEmpty(rtbDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtDienThoai.Text) || !txtDienThoai.Text.Trim().All(char.IsDigit) || txtDienThoai.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Supplier supplier = new Supplier
                {
                    SupplierName = rtbTen.Text,
                    Address = rtbDiaChi.Text,
                    PhoneNumber = txtDienThoai.Text,
                    Email = txtEmail.Text,
                };
                // Thêm nhà cung cấp
                supplierBLL.Add(supplier);
                MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhaCC();
                ClearDuLieu();
              
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDuLieu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtMa.Text) || !int.TryParse(txtMa.Text, out int id))
                    {
                        MessageBox.Show("Vui lòng chọn nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Xóa nhà cung cấp
                    supplierBLL.Delete(id);
                    LoadNhaCC();
                    ClearDuLieu();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật thông tin nhà cung cấp này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtMa.Text) || !int.TryParse(txtMa.Text, out int id))
                    {
                        MessageBox.Show("Vui lòng chọn nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(rtbTen.Text) || string.IsNullOrEmpty(rtbDiaChi.Text) || string.IsNullOrEmpty(txtEmail.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(txtDienThoai.Text) || !txtDienThoai.Text.Trim().All(char.IsDigit) || txtDienThoai.Text.Trim().Length < 10)
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Supplier supplier = new Supplier
                    {
                        SupplierId = id,
                        SupplierName = rtbTen.Text,
                        Address = rtbDiaChi.Text,
                        PhoneNumber = txtDienThoai.Text,
                        Email = txtEmail.Text,
                    };
                    // Sửa nhà cung cấp
                    supplierBLL.Update(supplier);
                    LoadNhaCC();
                    ClearDuLieu();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
