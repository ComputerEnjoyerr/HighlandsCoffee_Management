using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Table
    {
        private DAL_Table table = new DAL_Table();

        public List<Table> GetAll() { return table.GetAll(); }
        public void Add(Table t) { table.Add(t); }
        public void Update(Table t) { table.Update(t); }
        public void Delete(int id) { table.Delete(id); }

        public List<Table> GetTableForManager(int branchId)
        {
            return table.GetTablesByBranchId(branchId);
        }
    }
}
