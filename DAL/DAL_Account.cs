using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        private HLCMDataContext db = new HLCMDataContext();

        public (Account, Employee) Login(string username, string password)
        {
            var ac = db.ACCOUNTs.FirstOrDefault(a => a.AccountName == username && a.Password == password);

            if (ac == null)
                return (null, null);

            var em = db.EMPLOYEEs.FirstOrDefault(e => e.EmployeeId == ac.EmployeeId);

            if (em == null)
                return (null, null);

            Account account = new Account
            {
                AccountId = ac.AccountId,
                AccountName = ac.AccountName,
                Password = ac.Password,
                EmployeeId = ac.EmployeeId,
                CreateDate = (DateTime)ac.CreateDate
            };

            Employee employee = new Employee
            {
                EmployeeId = em.EmployeeId,
                EmployeeName = em.EmployeeName,
                BranchId = em.BranchId,
                Role = em.Role,
                Address = em.Address,
                PhoneNumber = em.Phone,
                HireDate = (DateTime)em.HireDate,
                BaseSalary = (double)em.BaseSalary,
                OverTimeHour = em.OverTimeHours ?? 0,
                TotalSalary = (double)(em.TotalSalary ?? 0)
            };

            return (account, employee);
        }

    }
}
