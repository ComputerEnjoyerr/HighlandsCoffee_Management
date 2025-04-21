using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Manager
    {
        public List<Employee> GetManagers()
        {
            DAL_Manager dal = new DAL_Manager();
            return dal.GetManagers();
        }

    }
}
