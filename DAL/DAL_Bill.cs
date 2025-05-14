using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Bill
    {
        public List<Bill> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.BILLs.Select(b => new Bill
                {
                    BillId = b.BillId,
                    BranchId = b.BranchId,
                    CreateDate = (DateTime)b.CreateDate,
                    CustomerId = b.CustomerId,
                    EmployeeId = b.EmployeeId,
                    TableId = b.TableId,
                    TotalPrice = (double)b.TotalPrice,
                    Status = (int)b.Status,
                });
                if (data.Any()) return data.ToList();
                return new List<Bill>();
            }
        }

        public void Add(Bill bl)
        {
            using (var db = new HLCMDataContext())
            {
                var newBill = new BILL
                {
                    BillId = bl.BillId,
                    BranchId = bl.BranchId,
                    CreateDate = bl.CreateDate,
                    CustomerId = bl.CustomerId,
                    EmployeeId = bl.EmployeeId,
                    TableId = bl.TableId,
                    TotalPrice = (decimal)bl.TotalPrice,
                    Status = bl.Status,
                };
                db.BILLs.InsertOnSubmit(newBill);
                db.SubmitChanges();
            }
        }

        public void Update(Bill bl)
        {
            using (var db = new HLCMDataContext())
            {
                var existingBill = db.BILLs.FirstOrDefault(b => b.BillId == bl.BillId);
                if (existingBill != null)
                {
                    existingBill.BranchId = bl.BranchId;
                    existingBill.CreateDate = bl.CreateDate;
                    existingBill.CustomerId = bl.CustomerId;
                    existingBill.EmployeeId = bl.EmployeeId;
                    existingBill.TableId = bl.TableId;
                    existingBill.TotalPrice =  (decimal)bl.TotalPrice;
                    existingBill.Status = bl.Status;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var billToDel = db.BILLs.FirstOrDefault(b => b.BillId == id);
                if (billToDel != null)
                {
                    db.BILLs.DeleteOnSubmit(billToDel);
                    db.SubmitChanges();
                }
            }
        }

        // Lấy Bill theo chi nhánh và ngày
        HLCMDataContext db = new HLCMDataContext();
        public List<DTO.Bill> GetBillsByFilter(int branchId, int? employeeId, DateTime date)
        {
            var query = db.BILLs.Where(b =>
                b.BranchId == branchId &&
                b.CreateDate == date.Date
            );

            if (employeeId.HasValue)
                query = query.Where(b => b.EmployeeId == employeeId.Value);

            var result = query.Select(b => new DTO.Bill
            {
                BillId = b.BillId,
                BranchId = b.BranchId,
                EmployeeId = b.EmployeeId,
                EmployeeName = b.EMPLOYEE.EmployeeName,
                CustomerId = b.CustomerId,
                TableId = b.TableId,
                TotalPrice = (double)(b.TotalPrice ?? 0),
                CreateDate = (DateTime)b.CreateDate,
                Status = b.Status ?? 0
            });

            return result.ToList();
        }


        //Lấy nhân viên theo chi nhánh
        public List<Employee> GetEmployeesByBranch(int branchId)
        {
            using (var db = new HLCMDataContext())
            {
                var query = from em in db.EMPLOYEEs
                            where em.BranchId == branchId
                            select new Employee
                            {
                                EmployeeId = em.EmployeeId,
                                EmployeeName = em.EmployeeName,
                                PhoneNumber = em.Phone,
                                Address = em.Address,
                                Role = em.Role,
                                BranchId = em.BranchId,
                                HireDate = (DateTime)em.HireDate,
                                OverTimeHour = em.OverTimeHours ?? 0,
                                BaseSalary = (double)em.BaseSalary,
                                TotalSalary = (double)(em.TotalSalary ?? 0)
                            };

                return query.ToList();
            }
        }

        //Lấy bill theo chi nhánh
        public List<Bill> GetBillsByBranch(int branchId)
        {
            using (var db = new HLCMDataContext())
            {
                var query = from b in db.BILLs
                            join e in db.EMPLOYEEs on b.EmployeeId equals e.EmployeeId
                            where b.BranchId == branchId
                            select new Bill
                            {
                                BillId = b.BillId,
                                BranchId = b.BranchId,
                                EmployeeId = b.EmployeeId,
                                CustomerId = b.CustomerId,
                                TableId = b.TableId,
                                EmployeeName = e.EmployeeName,
                                CreateDate = (DateTime)b.CreateDate,
                                Status = b.Status ?? 0,
                                TotalPrice = (double)(b.TotalPrice ?? 0)
                            };

                return query.ToList();
            }
        }

    }
}
