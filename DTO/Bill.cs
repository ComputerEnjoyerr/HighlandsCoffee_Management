using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int billId, branchId, employeeId, customerId, tableId;
        private double totalPrice;
        private DateTime createDate;

        public Bill() { }
        public Bill(int billId, int branchId, int employeeId, int customerId, int tableId, double totalPrice, DateTime createDate)
        {
            this.BillId = billId;
            this.BranchId = branchId;
            this.EmployeeId = employeeId;
            this.CustomerId = customerId;
            this.TableId = tableId;
            this.TotalPrice = totalPrice;
            this.CreateDate = createDate;
        }

        public int BillId { get => billId; set => billId = value; }
        public int BranchId { get => branchId; set => branchId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
    }
}
