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

        //Lấy nhân viên theo chi nhánh
        public List<Employee> GetEmployeesForManager(int branchId, int currentManagerId)
        {
            return dal.GetEmployeesByBranch(branchId, currentManagerId);
        }
        public List<string> GetRoles()
        {
            return dal.GetsRoles();
        }
        public bool Add(Employee emp) => dal.Adds(emp);
        public bool Update(Employee emp) => dal.Updates(emp);
        public bool Delete(int id) => dal.Deletes(id);
        public bool AddAccount(Account ac)
        {
            return dal.AddAccount(ac);
        }
        public bool TestEmployee(string name, string phone)
        {
            return dal.TestEmployee(name, phone);
        }

    }
}
