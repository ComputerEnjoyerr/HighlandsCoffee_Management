using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Ingredient
    {
        public List<Ingredient> GetAll()
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var data = db.INGREDIENTs.Select(i => new Ingredient
                    {
                        IngredientId = i.IngredientId,
                        IngredientName = i.IngredientName,
                        SupplierId = i.SupplierId,
                        Price = (double)i.Price,
                        Unit = i.Unit,
                        EXPDay = (int)i.EXPDay,
                    });

                    return data.ToList();
                }
            }
            catch { return new List<Ingredient>(); }
        }

        public void Add(Ingredient ingredient)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var newIngredient = new INGREDIENT
                    {
                        IngredientId = ingredient.IngredientId,
                        IngredientName = ingredient.IngredientName,
                        SupplierId = ingredient.SupplierId,
                        Price = (decimal)ingredient.Price,
                        Unit = ingredient.Unit,
                        EXPDay = (int)ingredient.EXPDay,
                    };
                    db.INGREDIENTs.InsertOnSubmit(newIngredient);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex) { Console.WriteLine("Loi: " + ex.Message); }
        }
        public void Update(Ingredient ingredient)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var existingIngredient = db.INGREDIENTs.FirstOrDefault(i => i.IngredientId == ingredient.IngredientId);
                    if (existingIngredient != null)
                    {
                        existingIngredient.IngredientName = ingredient.IngredientName;
                        existingIngredient.SupplierId = ingredient.SupplierId;
                        existingIngredient.Price = (decimal)ingredient.Price;
                        existingIngredient.Unit = ingredient.Unit;
                        existingIngredient.EXPDay = (int)ingredient.EXPDay;
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Loi: " + ex.Message); }
        }
        public void Delete(int id)
        {
            try
            {
                using (var db = new HLCMDataContext())
                {
                    var ingredientToDelete = db.INGREDIENTs.FirstOrDefault(i => i.IngredientId == id);
                    if (ingredientToDelete != null)
                    {
                        db.INGREDIENTs.DeleteOnSubmit(ingredientToDelete);
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Loi: " + ex.Message); }
        }
    }
}
