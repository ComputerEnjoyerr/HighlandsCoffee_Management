using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Financial
    {
        DAL_Financial financial = new DAL_Financial();

        public List<Financial> GetAll() { return financial.GetAll(); }
        public void Add(Financial fin) { financial.Add(fin); }
        public void Delete(int id) { financial.Delete(id); }
        public void Update(Financial fin) { financial.Update(fin); }
    }
}
