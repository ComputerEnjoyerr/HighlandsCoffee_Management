using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Report
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Highlands_Database;Integrated Security=True;Encrypt=False";

        public DataTable GetRevenueDetails(DateTime reportDate, int status, int branch)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ChiTietDoanhThu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReportDate", reportDate.Date);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@BranchId", branch);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu từ Stored Procedure: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable GetInventoryDetails(int branch)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ChiTietKhoHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BranchId", branch);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu từ Stored Procedure: " + ex.Message);
                }
            }
            return dt;
        }
    }
}
