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
<<<<<<< HEAD
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

=======
        public List<Account> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.ACCOUNTs.Select(a => new Account
                {
                    AccountId = a.AccountId,
                    AccountName = a.AccountName,
                    EmployeeId = a.EmployeeId,
                    Password = a.Password,
                    CreateDate = (DateTime)a.CreateDate,
                });

                if (data.Any()) return data.ToList();
                else return new List<Account>();
            }
        }

        public void Add(Account account)
        {
            using (var db = new HLCMDataContext())
            {
                var newAccount = new ACCOUNT
                {
                    AccountId = account.AccountId,
                    AccountName = account.AccountName,
                    EmployeeId = account.EmployeeId,
                    Password = account.Password,
                    CreateDate = account.CreateDate,
                };
                db.ACCOUNTs.InsertOnSubmit(newAccount);
                db.SubmitChanges();
            }
        }

        public void Update(Account account)
        {
            using (var db = new HLCMDataContext())
            {
                var existingAccount = db.ACCOUNTs.FirstOrDefault(a => a.AccountId == account.AccountId);
                if (existingAccount != null)
                {
                    existingAccount.AccountName = account.AccountName;
                    existingAccount.EmployeeId = account.EmployeeId;
                    existingAccount.Password = account.Password;
                    existingAccount.CreateDate = account.CreateDate;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var accountToDel = db.ACCOUNTs.FirstOrDefault(a => a.AccountId == id);
                if (accountToDel != null)
                {
                    db.ACCOUNTs.DeleteOnSubmit(accountToDel);
                    db.SubmitChanges(); 
                }
            }
        }
>>>>>>> Thanh-Phú
    }
}
