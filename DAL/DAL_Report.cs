using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_Report
    {
        private string connectionString = "Data Source=DESKTOP-9VSNCL6\\VALKYRIE;Initial Catalog=Highlands_Database;Integrated Security=True;Encrypt=False";

        //Report doanh thu
        public DataTable GetFinancials(int month, int year)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_LoiNhuan_TatCaChiNhanhTheoThang", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Thang", month);
                    cmd.Parameters.AddWithValue("@Nam", year);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu từ Stored Procedure: " + ex.Message);
                }
            }
            return dt;
        }

        //Report hàng tồn
        public DataTable GetInventorys(int branchId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_HangTonKho_TheoChiNhanh", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BranchId", branchId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
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
