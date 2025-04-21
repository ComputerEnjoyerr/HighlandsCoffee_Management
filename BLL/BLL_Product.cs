using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Product
    {
        private DAL_Product product = new DAL_Product();

        public List<Product> GetAll()
        {
            return product.GetAll();
        }
        public void Add(Product p)
        {
            product.Add(p);
        }
        public void Update(Product p)
        {
            product.Update(p);
        }
        public void Delete(int id)
        {
            product.Delete(id);
        }
    }
}
