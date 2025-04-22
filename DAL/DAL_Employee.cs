using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Employee
    {
        private HLCMDataContext db = new HLCMDataContext();
        public List<Employee> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.EMPLOYEEs.Select(e => new Employee
                {
                    EmployeeId = e.EmployeeId,
                    EmployeeName = e.EmployeeName,
                    BranchId = (int)e.BranchId,
                    Address = e.Address,
                    PhoneNumber = e.Phone,
                    HireDate = (DateTime)e.HireDate,
                    BaseSalary = (double)e.BaseSalary,
                    OverTimeHour = (int)e.OverTimeHours,
                    TotalSalary = (double)e.TotalSalary,
                    Role = e.Role
                });
                return data.ToList();
            }
        }
        public DAL.EMPLOYEE GetById(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.EMPLOYEEs.FirstOrDefault(s => s.EmployeeId == id);
                return data;
            }
        }
        public void Add(DTO.Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            using (var db = new HLCMDataContext())
            {

                var newEmp = new DAL.EMPLOYEE
                {

                    EmployeeName = employee.EmployeeName,
                    BranchId = employee.BranchId,
                    Address = employee.Address,
                    Phone = employee.PhoneNumber,
                    Role = employee.Role,
                    HireDate = employee.HireDate,
                    OverTimeHours = employee.OverTimeHour,
                    BaseSalary = (decimal)employee.BaseSalary,
                    TotalSalary = (decimal)employee.TotalSalary

                };
                db.EMPLOYEEs.InsertOnSubmit(newEmp);
                db.SubmitChanges();

                employee.EmployeeId = newEmp.EmployeeId;
            }
        }

        public void Update(DTO.Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            using (var db = new HLCMDataContext())
            {
                var up = db.EMPLOYEEs.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
                if (up != null)
                {

                    up.EmployeeName = employee.EmployeeName;
                    up.Address = employee.Address;
                    up.Phone = employee.PhoneNumber;
                    up.Role = employee.Role;
                    up.HireDate = employee.HireDate;
                    up.OverTimeHours = employee.OverTimeHour;
                    up.BaseSalary = (decimal)employee.BaseSalary;
                    up.TotalSalary = (decimal)employee.TotalSalary;
                    up.BranchId = employee.BranchId;

                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Nhan vien khong ton tai");
                }
            }
        }
        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var del = db.EMPLOYEEs.FirstOrDefault(x => x.EmployeeId == id);
                if (del != null)
                {
                    db.EMPLOYEEs.DeleteOnSubmit(del);
                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Item không tồn tại để xóa!");
                }
            }
        }

        public List<string> GetRoles()
        {
            using (var db = new HLCMDataContext())
            {
                return db.EMPLOYEEs.Select(c => c.Role).Distinct().ToList(); //???
            }
        }

        //public List<Branch> GetBranchList()
        //{
        //    using (var db = new HLCMDataContext())
        //    {
        //        // t
        //        var data = db.BRANCHes.Select(b => new Branch
        //        {
        //            BranchId = b.BranchId,
        //            BranchName = b.BranchName,
        //            Address = b.Address,
        //            CloseTime = (TimeSpan)b.CloseTime,
        //            OpenTime = (TimeSpan)b.OpenTime,
        //        });
        //    }
        //}

        //Lấy nhân viên theo chi nhánh
        public List<Employee> GetEmployeesByBranch(int branchId, int currentManagerId)
        {
            using (var db = new HLCMDataContext())
            {
                var query = from em in db.EMPLOYEEs
                            where em.BranchId == branchId && em.EmployeeId != currentManagerId
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

        //Lấy Role
        public List<string> GetsRoles()
        {
            return db.EMPLOYEEs
                     .Select(e => e.Role)
                     .Distinct()
                     .ToList();
        }

        //Add nhân viên theo chi nhánh
        public bool Adds(Employee emp)
        {
            try
            {
                EMPLOYEE em = new EMPLOYEE
                {
                    EmployeeName = emp.EmployeeName,
                    Phone = emp.PhoneNumber,
                    Address = emp.Address,
                    Role = emp.Role,
                    HireDate = emp.HireDate,
                    BranchId = emp.BranchId,
                    OverTimeHours = emp.OverTimeHour,
                    BaseSalary = (decimal)emp.BaseSalary,
                    TotalSalary = (decimal)emp.TotalSalary
                };
                db.EMPLOYEEs.InsertOnSubmit(em);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        //Update nhân viên theo chi nhánh
        public bool Updates(Employee emp)
        {
            try
            {
                EMPLOYEE e = db.EMPLOYEEs.FirstOrDefault(x => x.EmployeeId == emp.EmployeeId);
                if (e == null) return false;

                e.EmployeeName = emp.EmployeeName;
                e.Phone = emp.PhoneNumber;
                e.Address = emp.Address;
                e.Role = emp.Role;
                e.HireDate = emp.HireDate;
                e.BranchId = emp.BranchId;
                e.OverTimeHours = emp.OverTimeHour;
                e.BaseSalary = (decimal)emp.BaseSalary;
                e.TotalSalary = (decimal)emp.TotalSalary;

                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        //Delete nhân viên theo chi nhánh
        public bool Deletes(int employeeId)
        {
            try
            {
                var emp = db.EMPLOYEEs.FirstOrDefault(e => e.EmployeeId == employeeId);
                if (emp == null) return false;

                db.EMPLOYEEs.DeleteOnSubmit(emp);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        //Create account nhân viên theo chi nhánh
        public bool AddAccount(Account ac)
        {
            try
            {
                ACCOUNT entity = new ACCOUNT
                {
                    AccountName = ac.AccountName,
                    Password = ac.Password,
                    EmployeeId = ac.EmployeeId,
                    CreateDate = ac.CreateDate
                };

                db.ACCOUNTs.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Tìm Nhân 
    }
}
