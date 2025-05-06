using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PromotionCustomer
    {
        public List<PromotionCustomer> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.PROMOTION_CUSTOMERs
                    .Select(pc => new PromotionCustomer
                    {
                        PromotionId = pc.PromotionId,
                        CustomerId = pc.CustomerId,
                        ApplyDate = (DateTime)pc.ApplyDate
                    }).ToList();
                if (data.Any())
                {
                    return data;
                }
                else
                {
                    return new List<PromotionCustomer>();
                }
            }
        }

        public void Add(PromotionCustomer pc)
        {
            using (var db = new HLCMDataContext())
            {
                var newPC = new PROMOTION_CUSTOMER
                {
                    PromotionId = pc.PromotionId,
                    CustomerId = pc.CustomerId,
                    ApplyDate = pc.ApplyDate
                };
                db.PROMOTION_CUSTOMERs.InsertOnSubmit(newPC);
                db.SubmitChanges();
            }
        }

        public void Update(PromotionCustomer pc)
        {
            using (var db = new HLCMDataContext())
            {
                var existingPC = db.PROMOTION_CUSTOMERs
                    .FirstOrDefault(p => p.PromotionId == pc.PromotionId && p.CustomerId == pc.CustomerId);
                if (existingPC != null)
                {
                    existingPC.ApplyDate = pc.ApplyDate;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int promotionId, int customerId)
        {
            using (var db = new HLCMDataContext())
            {
                var pcToDelete = db.PROMOTION_CUSTOMERs
                    .FirstOrDefault(p => p.PromotionId == promotionId && p.CustomerId == customerId);
                if (pcToDelete != null)
                {
                    db.PROMOTION_CUSTOMERs.DeleteOnSubmit(pcToDelete);
                    db.SubmitChanges();
                }
            }
        }
    }
}
