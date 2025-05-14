using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_Report
    {
        private DAL_Report dalReport = new DAL_Report();

        //Report doanh thu
        public DataTable GetFinancialsDetails(int month, int year)
        {
            try
            {
                return dalReport.GetFinancials(month, year);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu từ BLL: " + ex.Message);
            }
        }

        //Report hàng tồn
        public DataTable GetInventorysDetails(int branchId)
        {
            try
            {
                return dalReport.GetInventorys(branchId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu từ BLL: " + ex.Message);
            }
        }
    }
}
