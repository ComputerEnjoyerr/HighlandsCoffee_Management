using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account
    {
        DAL_Account account = new DAL_Account();

        public List<Account> GetAll() { return account.GetAll(); }
        public void Add (Account ac) { account.Add(ac); }
        public void Update (Account ac) { account.Update(ac); }
        public void Delete (int id) { account.Delete(id); }
    }
}
