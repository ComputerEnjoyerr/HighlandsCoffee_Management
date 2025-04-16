using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Financial
    {
        private int financialId, branchId;
        private DateTime reportDate;
        private double revenue, operationCost, ingredientCost, profit;

        public Financial() { }
        public Financial(int financialId, int branchId, DateTime reportDate, double revenue, double operateCost, double ingredientCost, double profit)
        {
            this.FinancialId = financialId;
            this.BranchId = branchId;
            this.ReportDate = reportDate;
            this.Revenue = revenue;
            this.OperationCost = operateCost;
            this.IngredientCost = ingredientCost;
            this.Profit = profit;
        }

        public int FinancialId { get => financialId; set => financialId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public DateTime ReportDate { get => reportDate; set => reportDate = value; }
        public double Revenue { get => revenue; set => revenue = value; }
        public double OperationCost { get => operationCost; set => operationCost = value; }
        public double IngredientCost { get => ingredientCost; set => ingredientCost = value; }
        public double Profit { get => profit; set => profit = value; }
    }
}
