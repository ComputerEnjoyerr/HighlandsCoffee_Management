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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DTO;

namespace GUI
{
    public partial class frmRPTHoaDonThanhToan : Form
    {
        public frmRPTHoaDonThanhToan(Bill b)
        {
            InitializeComponent();
            bill = b;
        }

        private Bill bill = new Bill();
        private BLL_Report bllReports = new BLL_Report();
        private bool isFirst = true;

        private void LoadData()
        {
            if (bill == null)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị báo cáo.");
                return;
            }
            MessageBox.Show(bill.BillId.ToString());
            rptHoaDonThanhToan rpt = new rptHoaDonThanhToan();
            try
            {
                rpt.Database.Tables["sp_InHoaDon;1"].SetDataSource(bllReports.GetBill(bill.BillId));
                rpt.Subreports["rptChiTietHoaDon"].Database.Tables["sp_InChiTietHoaDon;1"].SetDataSource(bllReports.GetBillInfo(bill.BillId));

                ParameterValues paraBillId = new ParameterValues();
                ParameterDiscreteValue paraValBillId = new ParameterDiscreteValue();
                paraValBillId.Value = bill.BillId;
                paraBillId.Add(paraValBillId);
                rpt.DataDefinition.ParameterFields["@BillId"].ApplyCurrentValues(paraBillId);

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
        private void frmRPTHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon-1.ico");
            this.BackColor = ColorTranslator.FromHtml("#52362A");

            LoadData();
        }
    }
}
