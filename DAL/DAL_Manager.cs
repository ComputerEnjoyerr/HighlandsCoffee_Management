using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Manager
    {
        public List<Employee> GetManagers()
        {
            using (var db = new HLCMDataContext())
            {
                return db.EMPLOYEEs
                         .Where(e => e.Role == "Quản lý")
                         .Select(e => new DTO.Employee
                         {
                             EmployeeId = e.EmployeeId,
                             EmployeeName = e.EmployeeName
                         }).ToList();
            }
        }

    }
}
