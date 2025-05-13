using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Account
    {
<<<<<<< HEAD
        private DAL_Account dal = new DAL_Account();
        //public (DTO.Account, DTO.Employee) Login(string username, string password)
        //{
        //    var result = dal.Login(username, password);
        //    if (result.Item1 == null || result.Item2 == null)
        //        return (null, null);
        //    DTO.Account account = new DTO.Account
        //    {
        //        AccountId = result.Item1.AccountId,
        //        AccountName = result.Item1.AccountName,
        //        Password = result.Item1.Password,
        //        EmployeeId = result.Item1.EmployeeId,
        //        CreateDate = result.Item1.CreateDate
        //    };
        //    DTO.Employee employee = new DTO.Employee
        //    {
        //        EmployeeId = result.Item2.EmployeeId,
        //        EmployeeName = result.Item2.EmployeeName,
        //        BranchId = result.Item2.BranchId,
        //        Role = result.Item2.Role,
        //        Address = result.Item2.Address,
        //        PhoneNumber = result.Item2.PhoneNumber,
        //        HireDate = result.Item2.HireDate,
        //        BaseSalary = result.Item2.BaseSalary,
        //        OverTimeHour = result.Item2.OverTimeHour,
        //        TotalSalary = result.Item2.TotalSalary
        //    };
        //    return (account, employee);
        //}

        public (Account, Employee) Login(string username, string password)
        {
            return dal.Login(username, password);
        }
=======
        DAL_Account account = new DAL_Account();

        public List<Account> GetAll() { return account.GetAll(); }
        public void Add (Account ac) { account.Add(ac); }
        public void Update (Account ac) { account.Update(ac); }
        public void Delete (int id) { account.Delete(id); }
>>>>>>> Thanh-Phú
    }
}
