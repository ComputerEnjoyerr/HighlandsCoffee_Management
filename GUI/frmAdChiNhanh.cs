using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmAdChiNhanh : Form
    {
        public frmAdChiNhanh()
        {
            InitializeComponent();
        }
        BLL_Branch bll = new BLL_Branch();
        BLL_Employee bllEmployee = new BLL_Employee();
        private void frmAdChiNhanh_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            flpChiNhanh.BackColor = ColorTranslator.FromHtml("#DED4CA");
            LoadComboBoxManager();
            LoadComboBoxStatus();
            LoadDataBranch();
            
            



            // Hiển thị thông tin chi nhánh bằng panel
            //foreach (var branch in braches)
            //{
            //    Panel panel = new Panel();
            //    panel.Size = new Size(445, 150);
            //    panel.BackColor = ColorTranslator.FromHtml("#BD965F");
            //    panel.BorderStyle = BorderStyle.FixedSingle;
            //    panel.Margin = new Padding(10);

            //    Label lblBranchName = new Label();
            //    lblBranchName.Size = new Size(panel.Width - 20, 20);
            //    lblBranchName.Text = "Tên: " + branch.BranchName;
            //    lblBranchName.Font = new Font("Arial", 12, FontStyle.Bold);
            //    lblBranchName.Location = new Point(10, 10);
            //    lblBranchName.ForeColor = ColorTranslator.FromHtml("#52362A");
            //    panel.Controls.Add(lblBranchName);

            //    Label lblAddress = new Label();
            //    lblAddress.Size = new Size(panel.Width - 20, 40);
            //    lblAddress.Text = "Địa chỉ: " + branch.Address;
            //    lblAddress.ForeColor = Color.White;
            //    lblAddress.Location = new Point(10, 35);
            //    lblAddress.AllowDrop = true;
            //    panel.Controls.Add(lblAddress);

            //    Label lblPhoneNumber = new Label();
            //    lblPhoneNumber.Size = new Size(panel.Width - 100, 20);
            //    lblPhoneNumber.Text = "SĐT: " + branch.PhoneNumber;
            //    lblPhoneNumber.ForeColor = Color.White;
            //    lblPhoneNumber.Location = new Point(10, 90);
            //    panel.Controls.Add(lblPhoneNumber);
            //    flpChiNhanh.Controls.Add(panel);
            //}
        }

       

        private void LoadDataBranch()
        {
            flpChiNhanh.Controls.Clear();
            var chiNhanh = bll.GetDataBranch();

            foreach (var ch in chiNhanh)
            {
                Panel panel = new Panel();
                panel.Size = new Size(445, 150);
                panel.BackColor = ColorTranslator.FromHtml("#BD965F");
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(10);

                Label lblBranchName = new Label();
                lblBranchName.Size = new Size(panel.Width - 20, 20);
                lblBranchName.Text = "Tên: " + ch.BranchName;
                lblBranchName.Font = new Font("Arial", 12, FontStyle.Bold);
                lblBranchName.Location = new Point(10, 10);
                lblBranchName.ForeColor = ColorTranslator.FromHtml("#52362A");
                panel.Controls.Add(lblBranchName);

                Label lblAddress = new Label();
                lblAddress.Size = new Size(panel.Width - 20, 40);
                lblAddress.Text = "Địa chỉ: " + ch.Address;
                lblAddress.ForeColor = Color.White;
                lblAddress.Location = new Point(10, 35);
                lblAddress.AllowDrop = true;
                panel.Controls.Add(lblAddress);

                Label lblPhoneNumber = new Label();
                lblPhoneNumber.Size = new Size(panel.Width - 100, 20);
                lblPhoneNumber.Text = "SĐT: " + ch.PhoneNumber;
                lblPhoneNumber.ForeColor = Color.White;
                lblPhoneNumber.Location = new Point(10, 90);
                panel.Controls.Add(lblPhoneNumber);

                //Add Tag để giữ lại dữ liệu
                flpChiNhanh.Tag = ch;

                flpChiNhanh.Click += flpChiNhanh_Click; // Gắn sự kiện
                foreach (Control c in new Control[] { lblBranchName, lblAddress, lblPhoneNumber })
                {
                    panel.Controls.Add(c);
                    c.Click += flpChiNhanh_Click; // Đảm bảo label click cũng gọi event
                    c.Tag = ch;
                }
               

                flpChiNhanh.Controls.Add(panel);
            }
        }

        private void flpChiNhanh_Click(object sender, EventArgs e)
        {
            var control = sender as Control;
            var branch = control.Tag as Branch; 

            if (branch != null)
            {
                txtMaCN.Text = branch.BranchId.ToString();
                txtTenCN.Text = branch.BranchName;
                cbQuanLy.SelectedValue = branch.ManagerId;
               
                txtDiaChi.Text = branch.Address;
                txtPhone.Text = branch.PhoneNumber;
                dtMoCua.Text = branch.OpenTime.ToString();
                dtDongCua.Text = branch.CloseTime.ToString();
                txtTienThue.Text = branch.MonthlyRent.ToString();
                cbStatus.SelectedItem = branch.Status;
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaCN.Clear();
            txtTenCN.Clear();
            txtDiaChi.Clear();
            txtPhone.Clear();
            txtTienThue.Clear();
            
        }

        private void LoadComboBoxManager()
        {
            //var managerList = ma.GetManagers();
            //cbQuanLy.DataSource = managerList;
            //cbQuanLy.DisplayMember = "EmployeeName";
            //cbQuanLy.ValueMember = "EmployeeId";
            //cbQuanLy.DropDownStyle = ComboBoxStyle.DropDownList;

            var emp = bllEmployee.GetDataEmployee().ToList();
            cbQuanLy.DataSource = emp;
            cbQuanLy.DisplayMember = "EmployeeName";
            cbQuanLy.ValueMember = "EmployeeId";
        }

        private void LoadComboBoxStatus()
        {
            List<string> statusList = new List<string>
            {
                "Đang hoạt động",
                "Đã đóng",
                "Đóng vĩnh viễn"
            };

            cbStatus.DataSource = statusList;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaCN.Text);
                bll.RemoveBranch(id);
                MessageBox.Show("Xóa thành công!");
                LoadDataBranch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTienThue.Text, out double monthlyRent))
            {
                MessageBox.Show("Tien thue không hợp lệ!");
                return;
            }
            var br = new Branch
            {


                BranchName = txtTenCN.Text,
                ManagerId = (int)cbQuanLy.SelectedValue,
                Address = txtDiaChi.Text,
                PhoneNumber = txtPhone.Text,
                OpenTime = dtMoCua.Value.TimeOfDay,
                CloseTime = dtDongCua.Value.TimeOfDay,
                MonthlyRent = monthlyRent,
                Status = cbStatus.SelectedItem.ToString(),
                


            };

            bll.AddBranch(br);
            MessageBox.Show("Thêm thành công!");
            LoadDataBranch();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaCN.Text, out int branchId))
            {
                MessageBox.Show("BranchID không hợp lệ!");
                return;
            }
            if (!double.TryParse(txtTienThue.Text, out double monthlyRent))
            {
                MessageBox.Show("Tien thue không hợp lệ!");
                return;
            }
            
            var br = new Branch
            {

                BranchId = branchId,
                BranchName = txtTenCN.Text,
                ManagerId = (int)cbQuanLy.SelectedValue,
                Address = txtDiaChi.Text,
                PhoneNumber = txtPhone.Text,
                OpenTime = dtMoCua.Value.TimeOfDay,
                CloseTime = dtDongCua.Value.TimeOfDay,
                MonthlyRent = monthlyRent,
                Status = cbStatus.SelectedItem.ToString(),

            };

            bll.UpdateBranch(br);
            MessageBox.Show("Sửa thành công!");
            LoadDataBranch();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
