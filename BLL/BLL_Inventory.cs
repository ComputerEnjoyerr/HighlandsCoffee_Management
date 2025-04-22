using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Inventory
    {
        private DAL_Inventory dal = new DAL_Inventory();
        //Lấy danh sách hàng hóa theo chi nhánh
        public List<Inventory> GetInventoryByBranchId(int branchId)
        {
            return dal.GetInventoryByBranchId(branchId);
        }
    }
}
