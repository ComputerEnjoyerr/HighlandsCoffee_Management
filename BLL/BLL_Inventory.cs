using DAL;
using DTO;
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
<<<<<<< HEAD
        private DAL_Inventory dal = new DAL_Inventory();
        //Lấy danh sách hàng hóa theo chi nhánh
        public List<Inventory> GetInventoryByBranchId(int branchId)
        {
            return dal.GetInventoryByBranchId(branchId);
=======
        DAL_Inventory inventory = new DAL_Inventory();

        public List<Inventory> GetAll()
        {
            return inventory.GetAll();
        }
        public void Add(Inventory t)
        {
            inventory.Add(t);
        }
        public void Update(Inventory t)
        {
            inventory.Update(t);
        }
        public void Delete(string id)
        {
            inventory.Delete(id);
>>>>>>> Thanh-Phú
        }
    }
}
