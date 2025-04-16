using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ingredient
    {
        private int ingredientId, supplierId;
        private string ingredientName, unit;
        private DateTime mFGDate, eXPDate;

        public Ingredient() { }
        public Ingredient(int ingredientId, string ingredientName, int supplierId, string unit, DateTime mFGDate, DateTime eXPDate)
        {
            this.IngredientId = ingredientId;
            this.IngredientName = ingredientName;
            this.SupplierId = supplierId;
            this.Unit = unit;
            this.MFGDate = mFGDate;
            this.EXPDate = eXPDate;
        }

        public int IngredientId { get => ingredientId; set => ingredientId = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public string IngredientName { get => ingredientName; set => ingredientName = value; }
        public string Unit { get => unit; set => unit = value; }
        public DateTime MFGDate { get => mFGDate; set => mFGDate = value; }
        public DateTime EXPDate { get => eXPDate; set => eXPDate = value; }
    }
}
