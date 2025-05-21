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
using BLL;
using DTO;

namespace GUI
{
    public partial class frmRPTDoanhThuTheoThang : Form
    {
        public frmRPTDoanhThuTheoThang()
        {
            InitializeComponent();
        }

        private BLL_Report bllReports = new BLL_Report();
        private bool isFirst = true;

        private void frmRPTDoanhThuTheoThang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtThang.Text) ||
                string.IsNullOrWhiteSpace(txtNam.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tháng và Năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng số
            if (!int.TryParse(txtThang.Text, out int month) ||
                !int.TryParse(txtNam.Text, out int year))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Tháng và Năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadData();
            txtNam.Clear();
            txtThang.Clear();
        }

        private void LoadData()
        {
            if (string.IsNullOrWhiteSpace(txtThang.Text) ||
                string.IsNullOrWhiteSpace(txtNam.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tháng và Năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtThang.Text, out int month) ||
                !int.TryParse(txtNam.Text, out int year))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Tháng và Năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Khai báo biến
            rptDoanhThuTheoThang report = new rptDoanhThuTheoThang();
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dt = bllReports.GetRevenueByMonth(month, year);
                report.SetDataSource(dt);
                // Biến lấy giá trị
                ParameterDiscreteValue paMonth = new ParameterDiscreteValue();
                ParameterValues paMonthValues = new ParameterValues();
                paMonth.Value = month;
                paMonthValues.Add(paMonth);
                report.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(paMonthValues);

                ParameterDiscreteValue paYear = new ParameterDiscreteValue();
                ParameterValues paYearValues = new ParameterValues();
                paYear.Value = year;
                paYearValues.Add(paYear);
                report.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(paYearValues);

                // Gán report vào viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo " + ex.Message, "Thông báo");
            }
            finally
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    report.Clone();
                    report.Dispose();
                }
            }
        }
    }
}
