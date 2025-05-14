using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CrystalDecisions.Shared;

namespace GUI
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        private BLL_Report bllReport = new BLL_Report();
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
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
            try
            {
                //Khai báo biến
                DoanhThuChiNhanh report = new DoanhThuChiNhanh();
                //khai báo tham số
                ParameterValues pa = new ParameterValues();
                //Biến lấy giá trị
                ParameterDiscreteValue paMonth = new ParameterDiscreteValue();
                ParameterDiscreteValue paYear = new ParameterDiscreteValue();

                paMonth.Value = int.Parse(txtThang.Text);
                paYear.Value = int.Parse(txtNam.Text);

                ParameterValues paMonthValues = new ParameterValues();
                paMonthValues.Add(paMonth);
                report.DataDefinition.ParameterFields["@Month"].ApplyCurrentValues(paMonthValues);

                ParameterValues paYearValues = new ParameterValues();
                paYearValues.Add(paYear);
                report.DataDefinition.ParameterFields["@Year"].ApplyCurrentValues(paYearValues);

                //Gán report vào viewer
                crvDoanhThu.ReportSource = report;
                crvDoanhThu.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo " + ex.Message, "Thông báo");
            }
        }
    }
}
