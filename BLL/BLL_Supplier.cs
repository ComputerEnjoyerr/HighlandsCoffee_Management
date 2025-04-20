using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Supplier
    {
        private DAL_Supplier supplier = new DAL_Supplier();

        public List<Supplier> GetAll()
        {
            return supplier.GetAll();
        }
        public void Add(Supplier s)
        {
            supplier.Add(s);
        }
        public void Update(Supplier s)
        {
            supplier.Update(s);
        }
        public void Delete(int id)
        {
            supplier.Delete(id);
        }
    }
}
