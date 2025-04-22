using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        private int employeeId, branchId, overTimeHour;
        private string employeeName, phoneNumber, address, role;
        private DateTime hireDate;
        private double baseSalary, totalSalary;

        public Employee() { }
        public Employee(int employeeId, string employeeName, int branchId, string address, string phoneNumber, DateTime hireDate, double baseSalary, int overTimeHour, double totalSalary, string role)
        {
            this.EmployeeId = employeeId;
            this.BranchId = branchId;
            this.OverTimeHour = overTimeHour;
            this.EmployeeName = employeeName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Role = role;
            this.HireDate = hireDate;
            this.BaseSalary = baseSalary;
            this.TotalSalary = totalSalary;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public int OverTimeHour { get => overTimeHour; set => overTimeHour = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Role { get => role; set => role = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        public double TotalSalary { get => totalSalary; set => totalSalary = value; }
        public string Phone { get; set; }
    }
}
