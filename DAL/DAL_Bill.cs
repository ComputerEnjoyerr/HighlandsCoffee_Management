using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Bill
    {
        public List<Bill> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.BILLs.Select(b => new Bill
                {
                    BillId = b.BillId,
                    BranchId = b.BranchId,
                    CreateDate = (DateTime)b.CreateDate,
                    CustomerId = b.CustomerId,
                    EmployeeId = b.EmployeeId,
                    TableId = b.TableId,
                    TotalPrice = (double)b.TotalPrice,
                    Status = (int)b.Status,
                });
                if (data.Any()) return data.ToList();
                return new List<Bill>();
            }
        }

        public void Add(Bill bl)
        {
            using (var db = new HLCMDataContext())
            {
                var newBill = new BILL
                {
                    BillId = bl.BillId,
                    BranchId = bl.BranchId,
                    CreateDate = bl.CreateDate,
                    CustomerId = bl.CustomerId,
                    EmployeeId = bl.EmployeeId,
                    TableId = bl.TableId,
                    TotalPrice = (decimal)bl.TotalPrice,
                    Status = bl.Status,
                };
                db.BILLs.InsertOnSubmit(newBill);
                db.SubmitChanges();
            }
        }

        public void Update(Bill bl)
        {
            using (var db = new HLCMDataContext())
            {
                var existingBill = db.BILLs.FirstOrDefault(b => b.BillId == bl.BillId);
                if (existingBill != null)
                {
                    existingBill.BranchId = bl.BranchId;
                    existingBill.CreateDate = bl.CreateDate;
                    existingBill.CustomerId = bl.CustomerId;
                    existingBill.EmployeeId = bl.EmployeeId;
                    existingBill.TableId = bl.TableId;
                    existingBill.TotalPrice =  (decimal)bl.TotalPrice;
                    existingBill.Status = bl.Status;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var billToDel = db.BILLs.FirstOrDefault(b => b.BillId == id);
                if (billToDel != null)
                {
                    db.BILLs.DeleteOnSubmit(billToDel);
                    db.SubmitChanges();
                }
            }
        }
    }
}
