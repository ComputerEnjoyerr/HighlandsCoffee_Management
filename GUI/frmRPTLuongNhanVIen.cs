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
    public partial class frmRPTLuongNhanVIen : Form
    {
        public frmRPTLuongNhanVIen()
        {
            InitializeComponent();
        }

        private BLL_Report bllReports = new BLL_Report();
        private BLL_Branch bllBranch = new BLL_Branch();
        private bool isFirst = true;

        private void LoadData(int branch)
        {
            if (branch < 1)
                branch = 1;
            rptLuongNhanVien rpt = new rptLuongNhanVien();
            try
            {

                // Lấy dữ liệu từ BLL
                DataTable dt = bllReports.GetEmployeeSalaryDetails(branch);
                // Gán dữ liệu vào báo cáo

                rpt.SetDataSource(dt);
                // Thêm tham số
                ParameterValues paraBranchId = new ParameterValues();
                ParameterDiscreteValue paraValBranchId = new ParameterDiscreteValue();
                paraValBranchId.Value = branch;
                paraBranchId.Add(paraValBranchId);
                rpt.DataDefinition.ParameterFields["@BranchId"].ApplyCurrentValues(paraBranchId);

                // Hiển thị báo cáo
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
            finally
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    // Giải phóng tài nguyên
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

        private void frmRPTLuongNhanVIen_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");

            LoadChiNhanh();
            LoadData(1);
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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
