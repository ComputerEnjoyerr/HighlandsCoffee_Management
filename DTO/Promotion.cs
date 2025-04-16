using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Promotion
    {
        private int promotionId, requirePoint;
        private string promotionName, description;
        private double discount;
        private DateTime startDate, endDate;

        public Promotion() { }
        public Promotion(int promotionId, string promotionName, string description, int requirePoint, double discount, DateTime startDate, DateTime endDate)
        {
            this.PromotionId = promotionId;
            this.RequirePoint = requirePoint;
            this.PromotionName = promotionName;
            this.Description = description;
            this.Discount = discount;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public int PromotionId { get => promotionId; set => promotionId = value; }
        public int RequirePoint { get => requirePoint; set => requirePoint = value; }
        public string PromotionName { get => promotionName; set => promotionName = value; }
        public string Description { get => description; set => description = value; }
        public double Discount { get => discount; set => discount = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
