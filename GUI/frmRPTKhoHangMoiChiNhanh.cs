using BLL;
using CrystalDecisions.Shared;
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
    public partial class frmRPTKhoHangMoiChiNhanh : Form
    {
        public frmRPTKhoHangMoiChiNhanh()
        {
            InitializeComponent();
        }

        private BLL_Report bllReport = new BLL_Report();
        private BLL_Branch bllBranch = new BLL_Branch();
        private bool isFirst = true;

        private void LoadData(int branchId)
        {
            if (branchId < 1)
                branchId = 1;
            rptKhoHangMoiChiNhanh rpt = new rptKhoHangMoiChiNhanh();
            try
            {
                // Lấy và gán dữ liệu từ BLL
                DataTable dt = bllReport.GetInventoryDetails(branchId);
                rpt.SetDataSource(dt);

                // Thêm tham số
                ParameterValues paraBranchId = new ParameterValues();
                ParameterDiscreteValue paraValBranchId = new ParameterDiscreteValue();
                paraValBranchId.Value = branchId;
                paraBranchId.Add(paraValBranchId);
                rpt.DataDefinition.ParameterFields["@BranchId"].ApplyCurrentValues(paraBranchId);
                // Hiển thị báo cáo
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng và giải phóng tài nguyên báo cáo
                if (isFirst)
                {
                    isFirst = false;

                }
                else
                {
                    rpt.Close();
                    rpt.Dispose();
                }
            }
        }

        private void LoadChiNhanh()
        {
            cboChiNhanh.DataSource = bllBranch.GetDataBranch();
            cboChiNhanh.DisplayMember = "BranchName";
            cboChiNhanh.ValueMember = "BranchId";
        }

        private void frmRPTKhoHangMoiChiNhanh_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadData(1);
            LoadChiNhanh();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboChiNhanh.SelectedValue != null)
            {
                int branchId = Convert.ToInt32(cboChiNhanh.SelectedValue);
                LoadData(branchId);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi nhánh.");
            }
        }
    }
}
