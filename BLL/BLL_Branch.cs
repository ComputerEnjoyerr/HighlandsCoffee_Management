using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Branch
    {
        DAL_Branch dal = new DAL_Branch();

        public List<Branch> GetDataBranch()
        {
            return dal.GetAll();
        }

        public void AddBranch(Branch branch)
        {
            dal.Add(branch);
        }

        public void RemoveBranch(int id) 
        { 
            dal.Delete(id);
        }

        public void UpdateBranch(Branch branch)
        {
            dal.Update(branch);
        }
        public DAL.BRANCH GetDataByID(int id) 
        {
            return dal.GetById(id);
        }
       
        public List<string> GetStatus()
        {
            return dal.GetStatus();
        }
    }
}
