using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Inventory
    {
        private int branchId, ingredientId, expDay;
        private double quantity, unitPrice, totalPrice;
        private DateTime expDate, restockDate;
        private string unit, inventoryId;

        public Inventory() { }
        public Inventory(string inventoryId, int branchId, int ingredientId, DateTime restockDate, int expDay, DateTime expDate, double quantity, string unit, double unitPrice, double totalP)
        {
            this.InventoryId = inventoryId;
            this.BranchId = branchId;
            this.IngredientId = ingredientId;
            this.ExpDay = expDay;
            this.Quantity = quantity;
            this.ExpDate = expDate;
            this.Unit = unit;
            this.RestockDate = restockDate; 
            this.UnitPrice = unitPrice;
            this.TotalPrice = totalP;
        }

        public string InventoryId { get => inventoryId; set => inventoryId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public int IngredientId { get => ingredientId; set => ingredientId = value; }
        public int ExpDay { get => expDay; set => expDay = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime ExpDate { get => expDate; set => expDate = value; }
        public DateTime RestockDate { get => restockDate; set => restockDate = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}
