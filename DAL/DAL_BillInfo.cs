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

        //Lấy chi tiết hóa đơn theo BillId
        public List<BillInfo> GetBillByBillId(int billId)
        {
            using (var db = new HLCMDataContext())
            {
                var result = from bi in db.BILLINFOs
                             join p in db.PRODUCTs on bi.ProductId equals p.ProductId
                             where bi.BillId == billId
                             select new BillInfo
                             {
                                 BillInfoId = bi.BillInfoId,
                                 BillId = bi.BillId,
                                 ProductId = bi.ProductId,
                                 ProductName = p.ProductName,
                                 Quantity = bi.Quantity,
                                 Price = p.Price,
                                 Total = bi.Quantity * p.Price
                             };

                return result.ToList();
            }
        }

    }
}
