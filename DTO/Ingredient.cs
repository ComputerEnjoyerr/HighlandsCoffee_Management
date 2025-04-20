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
        private double price;
        private string ingredientName, unit;
        private int eXPDate;

        public Ingredient() { }
        public Ingredient(int ingredientId, string ingredientName, int supplierId, double price, string unit, int eXPDate)
        {
            this.IngredientId = ingredientId;
            this.IngredientName = ingredientName;
            this.Price = price;
            this.SupplierId = supplierId;
            this.Unit = unit;
            this.EXPDay = eXPDate;
        }

        public int IngredientId { get => ingredientId; set => ingredientId = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public double Price { get => price; set => price = value; }
        public string IngredientName { get => ingredientName; set => ingredientName = value; }
        public string Unit { get => unit; set => unit = value; }
        public int EXPDay { get => eXPDate; set => eXPDate = value; }
    }
}
