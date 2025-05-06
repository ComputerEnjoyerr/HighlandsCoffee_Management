using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Bill
    {
        DAL_Bill bill = new DAL_Bill();

        public List<Bill> GetAll() { return bill.GetAll(); }
        public void Add(Bill b) { bill.Add(b); }
        public void Delete(int id) { bill.Delete(id); }
        public void Update(Bill b) { bill.Update(b); }
    }
}
