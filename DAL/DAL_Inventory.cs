using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Inventory
    {
        private HLCMDataContext db = new HLCMDataContext();
        //Lấy danh sách hàng hóa theo chi nhánh
        public List<Inventory> GetInventoryByBranchId(int branchId)
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.INVENTORies.Where(t => t.BranchId == branchId).Select(t => new Inventory
                {
                    InventoryId = t.InventoryId,
                    BranchId = t.BranchId,
                    IngredientId = t.IngredientId,
                    Quantity = (double)t.Quantity,
                    //LastRestock = (DateTime)t.LastRestock,
                    Unit = t.Unit,
                });
                return data.ToList();
            }
        }
    }
}
