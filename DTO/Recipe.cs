using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Recipe
    {
        private int recipeId, productId, ingredientId;
        private string unit;
        private double quantity;
        public Recipe() { }
        public Recipe(int recipeId, int ingredientId, int productId, double quantity, string unit)
        {
            this.RecipeId = recipeId;
            this.ProductId = productId;
            this.IngredientId = ingredientId;
            this.Quantity = quantity;
            this.unit = unit;
        }
        public int RecipeId { get => recipeId; set => recipeId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int IngredientId { get => ingredientId; set => ingredientId = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}
