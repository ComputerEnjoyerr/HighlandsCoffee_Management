using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Inventory
    {
        private int inventoryId, branchId, ingredientId;
        private double quantity;
        private DateTime lastRestock;
        private string unit;

        public Inventory() { }
        public Inventory(int inventoryId, int branchId, int ingredientId, DateTime lastRestock, double quantity, string unit)
        {
            this.InventoryId = inventoryId;
            this.BranchId = branchId;
            this.IngredientId = ingredientId;
            this.Quantity = quantity;
            this.LastRestock = lastRestock;
            this.Unit = unit;
        }

        public int InventoryId { get => inventoryId; set => inventoryId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public int IngredientId { get => ingredientId; set => ingredientId = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public DateTime LastRestock { get => lastRestock; set => lastRestock = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}
