using BLL;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
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
    public partial class frmBanAn : Form
    {
        public frmBanAn(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private BLL_Table bllTable = new BLL_Table();

        private void ClearDuLieuNhap()
        {
            txtMa.Clear();
            txtTen.Clear();
            nbrSucNgoi.Value = 2;
            cboTrangThai.SelectedIndex = -1;
        }

        private void LoadTable()
        {
            flpBanAn.Controls.Clear();
            // Hiển thị các button Bàn ăn
            var table = bllTable.GetAll().Where(t => t.BranchId == currentEmployee.BranchId);
            if (table.Any())
            {
                foreach (var item in table)
                {
                    Button btn = new Button();
                    btn.Text = item.TableName;
                    btn.Tag = item;
                    if (item.Status == 0)
                    {
                        btn.BackColor = ColorTranslator.FromHtml("#B12830");
                        btn.ForeColor = ColorTranslator.FromHtml("#DED4CA");
                    } else
                    {
                        btn.BackColor = ColorTranslator.FromHtml("#52362A");
                        btn.ForeColor = ColorTranslator.FromHtml("#DED4CA");
                    }
                        btn.FlatStyle = FlatStyle.Flat;
                    btn.Width = 145;
                    btn.Height = 100;
                    btn.Click += Btn_Click;
                    flpBanAn.Controls.Add(btn);
                }
            }
        }
        private void frmAdBanAn_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            flpBanAn.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadTable();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            if (ctrl != null)
            {
                Table selectedTable = ctrl.Tag as Table;
                if (selectedTable != null)
                {
                    txtMa.Text = selectedTable.TableId.ToString();
                    txtTen.Text = selectedTable.TableName;
                    nbrSucNgoi.Value = selectedTable.Capacity;
                    string trangThai = "";
                    if (selectedTable.Status == 0)
                        trangThai = "Trống";
                    else
                        trangThai = "Đã đặt";
                    cboTrangThai.Text = trangThai;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text) || nbrSucNgoi.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ và hợp lệ");
                    return;
                }
                Table table = new Table
                {
                    TableName = txtTen.Text,
                    Capacity = (int)nbrSucNgoi.Value,
                    BranchId = currentEmployee.BranchId,
                    Status = 0
                };

                bllTable.Add(table);
                LoadTable();
                ClearDuLieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn một bàng để xóa!", "Thông báo");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa bàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                int id = int.Parse(txtMa.Text);
                bllTable.Delete(id);
                LoadTable();
                ClearDuLieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn một bàng để cập nhật!", "Thông báo");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật bàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text) || nbrSucNgoi.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ và hợp lệ");
                    return;
                }
                Table table = new Table
                {
                    TableId = int.Parse(txtMa.Text),
                    TableName = txtTen.Text,
                    Capacity = (int)nbrSucNgoi.Value,
                    BranchId = currentEmployee.BranchId,
                    Status = cboTrangThai.SelectedIndex,
                };
                bllTable.Update(table);
                LoadTable();
                ClearDuLieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            ClearDuLieuNhap();
        }
    }
}
