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
    }
}
