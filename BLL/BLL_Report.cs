using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Report
    {
        private DAL_Report dalReport = new DAL_Report();
        public DataTable GetRevenueDetails(int status, int branch)
        {
            return dalReport.GetRevenueDetails(status, branch);
        }

        public DataTable GetInventoryDetails(int branch)
        {
            return dalReport.GetInventoryDetails(branch);
        }

        public DataTable GetEmployeeSalaryDetails(int branch)
        {
            return dalReport.GetEmployeeSalaryDetails(branch);
        }

        public DataTable GetBill(int billId)
        {
            return dalReport.GetBill(billId);
        }

        public DataTable GetBillInfo(int billId)
        {
            return dalReport.GetBillInfo(billId);
        }
    }
}
