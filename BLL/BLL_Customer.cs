using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Customer
    {
        DAL_Customer dal = new DAL_Customer();

        public List<Customer> GetAll()
        {
            return dal.GetAll();
        }
    }
}
