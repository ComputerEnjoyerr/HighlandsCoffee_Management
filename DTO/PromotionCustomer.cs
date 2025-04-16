using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PromotionCustomer
    {
        private int promotionId, customerId;
        private DateTime applyDate;

        public PromotionCustomer() { }
        public PromotionCustomer(int promotionId, int customerId, DateTime applyDate)
        {
            this.PromotionId = promotionId;
            this.CustomerId = customerId;
            this.ApplyDate = applyDate;
        }
        public int PromotionId { get => promotionId; set => promotionId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public DateTime ApplyDate { get => applyDate; set => applyDate = value; }
    }
}
