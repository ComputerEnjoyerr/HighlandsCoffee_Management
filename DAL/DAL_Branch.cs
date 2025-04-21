using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Branch
    {
        public List<Branch> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.BRANCHes.Select(b => new Branch
                {
                    BranchId = (int)b.BranchId,
                    BranchName = b.BranchName,
                    ManagerId = (int)b.ManagerId,
                    Address = b.Address,
                    PhoneNumber = b.Phone,
                    //Chuyển TimeSpan thành DateTime
                    OpenTime = (TimeSpan)b.OpenTime,
                    CloseTime = (TimeSpan)b.CloseTime,

                    MonthlyRent = (double)b.MonthlyRent,
                    Status = b.Status
                });
                return data.ToList();
            }
        }
        public DAL.BRANCH GetById(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.BRANCHes.FirstOrDefault(b => b.BranchId == id);
                return data;
            }
        }
        public void Add(DTO.Branch branch)
        {
            if (branch == null)
            {
                throw new ArgumentNullException(nameof(branch));
            }
            using (var db = new HLCMDataContext())
            {
                
                var newBranch = new DAL.BRANCH
                {
                    BranchId = branch.BranchId,
                    BranchName = branch.BranchName,
                    ManagerId = branch.ManagerId,
                    Address = branch.Address,
                    Phone = branch.PhoneNumber,
                    OpenTime = branch.OpenTime,
                    CloseTime = branch.CloseTime,
                    MonthlyRent = (decimal)branch.MonthlyRent,
                    Status = branch.Status
                };
                db.BRANCHes.InsertOnSubmit(newBranch);
                db.SubmitChanges();

                branch.BranchId = newBranch.BranchId;
            }
        }
        public void Update(DTO.Branch branch)
        {
            if (branch == null)
            {
                throw new ArgumentNullException(nameof(branch));
            }
            using (var db = new HLCMDataContext())
            {
                var up = db.BRANCHes.FirstOrDefault(x => x.BranchId == branch.BranchId);
                if (up != null)
                {
                    
                    up.BranchName = branch.BranchName;
                    up.ManagerId = branch.ManagerId;
                    up.Address = branch.Address;
                    up.Phone = branch.PhoneNumber;
                    up.OpenTime = branch.OpenTime;
                    up.CloseTime = branch.CloseTime;
                    up.MonthlyRent = (decimal)branch.MonthlyRent;
                    up.Status = branch.Status;

                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Chi nhanh khong ton tai");
                }
            }
        }
        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var del = db.BRANCHes.FirstOrDefault(x => x.BranchId == id);
                if (del != null)
                {
                    db.BRANCHes.DeleteOnSubmit(del);
                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Item không tồn tại để xóa!");
                }
            }
        }
        public List<string> GetStatus()
        {
            using (var db = new HLCMDataContext())
            {
                return db.BRANCHes.Select(c => c.Status).Distinct().ToList();
            }
        }
    }
}
