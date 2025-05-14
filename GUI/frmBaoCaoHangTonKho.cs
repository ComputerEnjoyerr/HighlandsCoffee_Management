using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CrystalDecisions.Shared;

namespace GUI
{
    public partial class frmBaoCaoHangTonKho : Form
    {
        private BLL_Branch bllBranch = new BLL_Branch();
        public frmBaoCaoHangTonKho()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(cboTen.Text))
            {
                MessageBox.Show("Vui lòng chọn tên chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();
            cboTen.SelectedIndex = -1;
        }

        private void LoadData()
        {
            try
            {
                //Khai báo biến
                BaoCaoHangTonKho report = new BaoCaoHangTonKho();
                //khai báo tham số
                ParameterValues pa = new ParameterValues();
                //Biến lấy giá trị
                ParameterDiscreteValue paBranchId = new ParameterDiscreteValue();

                paBranchId.Value = Convert.ToInt32(cboTen.SelectedValue);

                ParameterValues paValues = new ParameterValues();
                paValues.Add(paBranchId);
                report.DataDefinition.ParameterFields["@BranchId"].ApplyCurrentValues(paValues);


                //Gán report vào viewer
                crvHangTon.ReportSource = report;
                crvHangTon.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo " + ex.Message, "Thông báo");
            }
        }

        private void frmBaoCaoHangTonKho_Load(object sender, EventArgs e)
        {
            var branches = bllBranch.GetDataBranch();
            cboTen.DataSource = branches;
            cboTen.DisplayMember = "BranchName";
            cboTen.ValueMember = "BranchId";
            cboTen.SelectedIndex = -1;
        }
    }
}
