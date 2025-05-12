using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Inventory
    {
        public List<Inventory> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.INVENTORies.Select(i => new Inventory
                {
                    IngredientId = i.IngredientId,
                    BranchId = i.BranchId,
                    InventoryId = i.InventoryId,
                    ExpDay = i.EXPDay,
                    ExpDate = (DateTime)i.EXPDate,
                    Quantity = (double)i.Quantity,
                    Unit = i.Unit,
                    RestockDate = (DateTime)i.RestockDate,
                    UnitPrice = (double)i.UnitPrice,
                    TotalPrice = (double)i.TotalPrice
                });
                if (data != null) return data.ToList();
                return new List<Inventory>();
            }
        }

        public void Add(Inventory item)
        {
            using (var db = new HLCMDataContext())
            {
                var newItem = new INVENTORY
                {
                    InventoryId = item.InventoryId,
                    BranchId = item.BranchId,
                    IngredientId = item.IngredientId,
                    EXPDay = item.ExpDay,
                    //EXPDate = item.ExpDate,
                    Quantity = (decimal)item.Quantity,
                    Unit = item.Unit,
                    RestockDate = (DateTime)item.RestockDate,
                    UnitPrice = (decimal)item.UnitPrice,
                    //TotalPrice = (decimal)item.TotalPrice
                };
                if (newItem != null)
                {
                    //Console.WriteLine("Ma KH da duoc anh xa: " + newItem.InventoryId + $", chieu dai: {newItem.InventoryId.ToString().Length}");
                    db.INVENTORies.InsertOnSubmit(newItem);
                    db.SubmitChanges();
                }
            }
        }

        public void Update(Inventory item)
        {
            using (var db = new HLCMDataContext())
            {
                var existingItem = db.INVENTORies.FirstOrDefault(i => i.InventoryId == item.InventoryId);
                if (existingItem != null)
                {
                    existingItem.BranchId = item.BranchId;
                    existingItem.IngredientId = item.IngredientId;
                    existingItem.EXPDay = item.ExpDay;
                    //existingItem.EXPDate = item.ExpDate;
                    existingItem.Quantity = (decimal)item.Quantity;
                    existingItem.Unit = item.Unit;
                    existingItem.RestockDate = (DateTime)item.RestockDate;
                    existingItem.UnitPrice = (decimal)item.UnitPrice;
                    //existingItem.TotalPrice = (decimal)item.TotalPrice;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(string id)
        {
            using (var db = new HLCMDataContext())
            {
                var itemToDelete = db.INVENTORies.FirstOrDefault(i => i.InventoryId == id);
                if (itemToDelete != null)
                {
                    db.INVENTORies.DeleteOnSubmit(itemToDelete);
                    db.SubmitChanges();
                }
            }
        }
    }
}
