using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Employee
    {
        DAL_Employee dal = new DAL_Employee();

        public List<Employee> GetDataEmployee()
        {
            return dal.GetAll();
        }
        public void AddEmployee(Employee emp)
        {
             dal.Add(emp);
        }
        public void DeleteEmployee(int id)
        {
            dal.Delete(id);
        }
        public void UpdateEmployee(Employee emp)
        {
            dal.Update(emp);
        }

        public List<string> GetRole()
        {
            return dal.GetRoles();
        }
        //public List<KeyValuePair<int, string>> GetBranchList()
        //{
        //    return dal.GetBranchList();
        //}
       

    }
}
