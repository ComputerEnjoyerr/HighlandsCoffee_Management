using BLL;
using CrystalDecisions.Shared;
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
    public partial class frmRPTChiTietDoanhThu : Form
    {
        public frmRPTChiTietDoanhThu(Financial fin)
        {
            InitializeComponent();
            doanhThu = fin;
        }

        private Financial doanhThu = new Financial();
        private BLL_Report bllReports = new BLL_Report();

        // Lọc dữ liệu theo yêu cầu để hiển thị vào dgv
        private void LoadData()
        {
            try
            {

                // Lấy dữ liệu từ BLL
                DataTable dt = bllReports.GetRevenueDetails(doanhThu.ReportDate, 1, doanhThu.BranchId); // Status = 1 (đã thanh toán)

                // Gán dữ liệu vào báo cáo
                rptChiTietDoanhThu rpt = new rptChiTietDoanhThu();
                rpt.SetDataSource(dt);

                // Thêm tham số 
                ParameterValues paraReportDate = new ParameterValues();
                ParameterDiscreteValue paraValReportDate = new ParameterDiscreteValue();
                paraValReportDate.Value = doanhThu.ReportDate; 
                paraReportDate.Add(paraValReportDate);
                rpt.DataDefinition.ParameterFields["@ReportDate"].ApplyCurrentValues(paraReportDate);

                ParameterValues paraStatus = new ParameterValues();
                ParameterDiscreteValue paraValStatus = new ParameterDiscreteValue();
                paraValStatus.Value = 1; 
                paraStatus.Add(paraValStatus);
                rpt.DataDefinition.ParameterFields["@Status"].ApplyCurrentValues(paraStatus);

                ParameterValues paraBranchId = new ParameterValues();
                ParameterDiscreteValue paraValBranchId = new ParameterDiscreteValue();
                paraValBranchId.Value = doanhThu.BranchId;
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

        }

        private void frmRPTChiTietDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
