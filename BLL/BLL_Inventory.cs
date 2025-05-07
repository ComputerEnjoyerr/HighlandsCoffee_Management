using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Inventory
    {
        DAL_Inventory inventory = new DAL_Inventory();

        public List<Inventory> GetAll()
        {
            return inventory.GetAll();
        }
        public void Add(Inventory t)
        {
            inventory.Add(t);
        }
        public void Update(Inventory t)
        {
            inventory.Update(t);
        }
        public void Delete(int id)
        {
            inventory.Delete(id);
        }
    }
}
