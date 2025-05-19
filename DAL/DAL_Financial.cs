using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Financial
    {
        public List<Financial> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.FINANCIALs.Select(f => new Financial
                {
                    FinancialId = f.FinancialId,
                    BranchId = (int)f.BranchId,
                    IngredientCost = (int)f.IngredientCost,
                    OperationCost = (double)f.OperationCost,
                    Revenue = (double)f.Revenue,
                    Profit = (double)f.Profit,
                    ReportDate = (DateTime)f.ReportDate,
                });
                if (data.Any()) return data.ToList();
                return new List<Financial>();
            }
        }

        public void Add(Financial fin)
        {
            using (var db = new HLCMDataContext())
            {
                var newFin = new FINANCIAL
                {
                    FinancialId = fin.FinancialId,
                    BranchId = (int)fin.BranchId,
                    IngredientCost = (decimal)fin.IngredientCost,
                    OperationCost = (decimal)fin.OperationCost,
                    Revenue = (decimal)fin.Revenue,
                    Profit = (decimal)fin.Profit,
                    ReportDate = (DateTime)fin.ReportDate,
                };
                db.FINANCIALs.InsertOnSubmit(newFin);
                db.SubmitChanges();
            }
        }


        public void Update(Financial fin)
        {
            using (var db = new HLCMDataContext())
            {
                var existingFin = db.FINANCIALs.FirstOrDefault(f => f.FinancialId == fin.FinancialId);
                if (existingFin != null)
                {
                    existingFin.FinancialId = fin.FinancialId;
                    existingFin.BranchId = (int)fin.BranchId;
                    existingFin.IngredientCost = (decimal)fin.IngredientCost;
                    existingFin.OperationCost = (decimal)fin.OperationCost;
                    existingFin.Revenue = (decimal)fin.Revenue;
                    existingFin.Profit = (decimal)fin.Profit;
                    existingFin.ReportDate = (DateTime)fin.ReportDate;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var FinToDel = db.FINANCIALs.FirstOrDefault(f => f.FinancialId ==  id);
                if (FinToDel != null)
                {
                    db.FINANCIALs.DeleteOnSubmit(FinToDel);
                    db.SubmitChanges();
                }
            }
        }
    }
}
