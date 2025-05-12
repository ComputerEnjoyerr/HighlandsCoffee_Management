using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BillInfo
    {
        public List<BillInfo> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.BILLINFOs.Select(bf => new BillInfo
                {
                    BillId = bf.BillId,
                    BillInfoId = bf.BillInfoId,
                    ProductId = bf.ProductId,
                    Quantity = bf.Quantity, 
                });
                if (data != null) return data.ToList();
                return new List<BillInfo>();
            }
        }

        public void Add(BillInfo bf)
        {
            using (var db = new HLCMDataContext())
            {
                var newBillInfo = new BILLINFO
                {
                    BillId = bf.BillId,
                    BillInfoId = bf.BillInfoId,
                    ProductId = bf.ProductId,
                    Quantity = bf.Quantity,
                };
                db.BILLINFOs.InsertOnSubmit(newBillInfo);
                db.SubmitChanges();
            }
        }

        public void Update(BillInfo bf)
        {
            using (var db = new HLCMDataContext())
            {
                var existingBillInfo = db.BILLINFOs.FirstOrDefault(b => b .BillInfoId == bf.BillInfoId);
                if (existingBillInfo != null)
                {
                    existingBillInfo.BillId = bf.BillId;
                    existingBillInfo.ProductId = bf.ProductId;
                    existingBillInfo.Quantity = bf.Quantity;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var BillInfoToDel = db.BILLINFOs.FirstOrDefault(b => b.BillInfoId == id);
                if (BillInfoToDel != null)
                {
                    db.BILLINFOs.DeleteOnSubmit(BillInfoToDel);
                    db.SubmitChanges();
                }
            };
        }
    }
}
