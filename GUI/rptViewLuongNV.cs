using BLL;
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
    public partial class rptViewLuongNV : Form
    {
        public rptViewLuongNV()
        {
            InitializeComponent();
        }
        BLL_Branch br = new BLL_Branch();
        BLL_Employee em = new BLL_Employee();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            var data = from emp in em.GetDataEmployee()
                       join b in br.GetDataBranch() on emp.BranchId equals b.BranchId
                       select new
                       {
                           b.BranchName,
                           emp.EmployeeName,
                           emp.Role,
                           emp.TotalSalary
                       };
            rptLuongNV rpt = new rptLuongNV();
            rpt.SetDataSource(data);
        }
    }
}
