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
using DTO;
namespace GUI
{
    public partial class frmRPTKhoHang : Form
    {
        public frmRPTKhoHang(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private BLL_Report bllReports = new BLL_Report();
        private bool isFirst = true;

        private void LoadData()
        {
            rptKhoHang rpt = new rptKhoHang();
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dt = bllReports.GetInventoryDetails(currentEmployee.BranchId);
                // Gán dữ liệu vào báo cáo

                rpt.SetDataSource(dt);

                ParameterValues paraBranchId = new ParameterValues();
                ParameterDiscreteValue paraValBranchId = new ParameterDiscreteValue();
                paraValBranchId.Value = currentEmployee.BranchId;
                paraBranchId.Add(paraValBranchId);
                rpt.DataDefinition.ParameterFields["@BranchId"].ApplyCurrentValues(paraBranchId);
                // Hiển thị báo cáo
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    rpt.Clone();
                    rpt.Dispose();
                }
            }
        }

        private void frmRPTKhoHang_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");

            LoadData();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
