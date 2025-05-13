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
        public DataTable GetRevenueDetails(DateTime reportDate, int status, int branch)
        {
            return dalReport.GetRevenueDetails(reportDate, status, branch);
        }

        public DataTable GetInventoryDetails(int branch)
        {
            return dalReport.GetInventoryDetails(branch);
        }   
    }
}
