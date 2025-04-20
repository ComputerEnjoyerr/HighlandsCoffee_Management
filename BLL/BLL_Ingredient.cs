using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Ingredient
    {
        DAL_Ingredient ingredient = new DAL_Ingredient();

        public List<Ingredient> GetAll()
        {
            return ingredient.GetAll();
        }
        public void Add(Ingredient ig)
        {
            ingredient.Add(ig);
        }
        public void Update(Ingredient ig)
        {
            ingredient.Update(ig);
        }
        public void Delete(int id)
        {
            ingredient.Delete(id);
        }
    }
}
