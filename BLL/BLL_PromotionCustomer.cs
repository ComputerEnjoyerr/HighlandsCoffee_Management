using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PromotionCustomer
    {
        DAL_PromotionCustomer promotionCustomer = new DAL_PromotionCustomer();

        public List<PromotionCustomer> GetAll()
        {
            return promotionCustomer.GetAll();
        }
        public void Add(PromotionCustomer pc)
        {
            promotionCustomer.Add(pc);
        }
        public void Update(PromotionCustomer pc)
        {
            promotionCustomer.Update(pc);
        }
        public void Delete(int promotionId, int customerId)
        {
            promotionCustomer.Delete(promotionId, customerId);
        }
    }
}
