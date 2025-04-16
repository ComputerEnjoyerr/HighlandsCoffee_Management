using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private int accountId, employeeId;
        private string accountName, password;
        private DateTime createDate;

        public Account() { }
        public Account(int accountId, string accountName, string password, int employeeId, DateTime createDate)
        {
            this.AccountId = accountId;
            this.AccountName = accountName;
            this.Password = password;
            this.EmployeeId = employeeId;
            this.CreateDate = createDate;
        }

        public int AccountId { get => accountId; set => accountId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
    }
}
