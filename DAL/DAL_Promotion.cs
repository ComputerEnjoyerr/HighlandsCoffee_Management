using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Promotion
    {
        public List<Promotion> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.PROMOTIONs.Select(p => new Promotion
                {
                    PromotionId = p.PromotionId,
                    PromotionName = p.PromotionName,
                    Description = p.Description,
                    RequirePoint = (int)p.RequirePoint,
                    Discount = (double)p.Discount,
                    StartDate = (DateTime)p.StartDate,
                    EndDate = (DateTime)p.EndDate
                });
                return data.ToList();
            }
        }
        public DAL.PROMOTION GetById(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.PROMOTIONs.FirstOrDefault(p => p.PromotionId == id);
                return data;
            }
        }
        public void Add(DTO.Promotion promotion)
        {
            if (promotion == null)
            {
                throw new ArgumentNullException(nameof(promotion));
            }
            using (var db = new HLCMDataContext())
            {

                var newPromotion = new DAL.PROMOTION
                {
                    
                    PromotionName = promotion.PromotionName,
                    Description = promotion.Description,
                    RequirePoint = promotion.RequirePoint,
                    Discount = (decimal)promotion.Discount,
                    StartDate = promotion.StartDate,
                    EndDate = promotion.EndDate

                };
                db.PROMOTIONs.InsertOnSubmit(newPromotion);
                db.SubmitChanges();
                //Lấy ID ms từ db
                promotion.PromotionId = newPromotion.PromotionId;
            }
        }
        public void Update(DTO.Promotion pro)
        {
            if (pro == null)
            {
                throw new ArgumentNullException(nameof(pro));
            }
            using (var db = new HLCMDataContext())
            {
                var up = db.PROMOTIONs.FirstOrDefault(x => x.PromotionId == pro.PromotionId);
                if (up != null)
                {
                    
                    up.PromotionName = pro.PromotionName;
                    up.Description = pro.Description;
                    up.RequirePoint = pro.RequirePoint;
                    up.Discount = (decimal)pro.Discount;
                    up.StartDate = pro.StartDate;
                    up.EndDate = pro.EndDate;

                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Khuyen mai khong ton tai");
                }
            }
        }
        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var del = db.PROMOTIONs.FirstOrDefault(x => x.PromotionId == id);
                if (del != null)
                {
                    db.PROMOTIONs.DeleteOnSubmit(del);
                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Khuyen mai không tồn tại để xóa!");
                }
            }
        }


        //public List<string> GetTiers()
        //{
        //    using (var db = new HLCMDataContext())
        //    {
        //        return db.CUSTOMERs.Select(c => c.Tier).Distinct().ToList();
        //    }
        //}
    }
}
