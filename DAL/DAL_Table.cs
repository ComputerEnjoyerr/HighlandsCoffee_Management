using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Table
    {
        public List<Table> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.TABLEs.Select(t => new Table
                {
                    TableId = t.TableId,
                    BranchId = t.BranchId,
                    TableName = t.TableName,
                    Capacity = (int)t.Capacity,
                    Status = (int)t.Status,
                });

                return data.ToList();
            }
        }
        
        public void Add(Table table)
        {
            using (var db = new HLCMDataContext())
            {
                var newTable = new TABLE
                {
                    BranchId = table.BranchId,
                    TableName = table.TableName,
                    Capacity = (int)table.Capacity,
                    Status = (int)table.Status,
                };
                db.TABLEs.InsertOnSubmit(newTable);
                db.SubmitChanges();
            }
        }

        public void Update(Table table)
        {
            using (var db = new HLCMDataContext())
            {
                var existingTable = db.TABLEs.FirstOrDefault(t => t.TableId == table.TableId);
                if (existingTable != null)
                {
                    existingTable.TableName = table.TableName;
                    existingTable.Capacity = (int)table.Capacity;
                    existingTable.Status = (int)table.Status;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var tableToDelete = db.TABLEs.FirstOrDefault(t => t.TableId == id);
                if (tableToDelete != null)
                {
                    db.TABLEs.DeleteOnSubmit(tableToDelete);
                    db.SubmitChanges();
                }
            }
        }

        //Lấy bàn theo chi nhánh
        public List<Table> GetTablesByBranchId(int branchId)
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.TABLEs.Where(t => t.BranchId == branchId).Select(t => new Table
                {
                    TableId = t.TableId,
                    BranchId = t.BranchId,
                    TableName = t.TableName,
                    Capacity = (int)t.Capacity,
                    Status = (int)t.Status,
                });
                return data.ToList();
            }
        }
    }
}
