using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Recipe
    {
        public List<Recipe> GetAll()
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var data = db.RECIPEs.Select(r => new Recipe
                    {
                        RecipeId = r.RecipeId,
                        IngredientId = r.IngredientId,
                        ProductId = r.ProductId,
                        Quantity = (double)r.Quantity,
                        Unit = r.Unit,
                    });
                    return data.ToList();
                }
            } catch 
            {
                return new List<Recipe>();
            }
        }

        public Recipe GetById(int id)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var recipe = db.RECIPEs.FirstOrDefault(r => r.RecipeId == id);
                    if (recipe != null)
                    {
                        return new Recipe
                        {
                            RecipeId = recipe.RecipeId,
                            IngredientId = recipe.IngredientId,
                            ProductId = recipe.ProductId,
                            Quantity = (int)recipe.Quantity,
                            Unit = recipe.Unit,
                        };
                    }
                    return null;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return null; }
        }
        public void Add(Recipe recipe)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var newRecipe = new RECIPE
                    {
                        RecipeId = recipe.RecipeId,
                        IngredientId = recipe.IngredientId,
                        ProductId = recipe.ProductId,
                        Quantity = (decimal)recipe.Quantity,
                        Unit = recipe.Unit,
                    };
                    db.RECIPEs.InsertOnSubmit(newRecipe);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.ToString());
            }
        }
        public void Update(Recipe rp)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var existingRecipe = db.RECIPEs.FirstOrDefault(r => r.RecipeId == rp.RecipeId);
                    if (existingRecipe != null)
                    {
                        existingRecipe.IngredientId = rp.IngredientId;
                        existingRecipe.ProductId = rp.ProductId;
                        existingRecipe.Quantity = (decimal)rp.Quantity;
                        existingRecipe.Unit = rp.Unit;
                        db.SubmitChanges();
                    }
                }
            } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        public void Delete(int id)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var existingRecipe = db.RECIPEs.FirstOrDefault(r => r.RecipeId == id);
                    if (existingRecipe != null)
                    {
                        db.RECIPEs.DeleteOnSubmit(existingRecipe);
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
