using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Recipe
    {
        private DAL_Recipe recipe = new DAL_Recipe();

        public List<Recipe> GetAll()
        {
            return recipe.GetAll();
        }
        public void Add(Recipe rp)
        {
            recipe.Add(rp);
        }
        public void Remove(int id)
        {
            recipe.Delete(id);
        }
        public void Update(Recipe rp)
        {
            recipe.Update(rp);
        }
    }
}
