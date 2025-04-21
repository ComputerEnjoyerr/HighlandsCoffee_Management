using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Branch
    {
        private int branchId, managerId;
        private string branchName, address, phoneNumber, status;
        private double monthlyRent;
        private TimeSpan openTime, closeTime;

        public Branch() { }
        public Branch(int branchId, string branchName, int managerId, string address, string phoneNumber, TimeSpan openTime, TimeSpan closeTime, double monthlyRent, string status)
        {
            this.BranchId = branchId;
            this.ManagerId = managerId;
            this.BranchName = branchName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Status = status;
            this.MonthlyRent = monthlyRent;
            this.OpenTime = openTime;
            this.CloseTime = closeTime;
        }

        public int BranchId { get => branchId; set => branchId = value; }
        public int ManagerId { get => managerId; set => managerId = value; }
        public string BranchName { get => branchName; set => branchName = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Status { get => status; set => status = value; }
        public double MonthlyRent { get => monthlyRent; set => monthlyRent = value; }
        public TimeSpan OpenTime { get => openTime; set => openTime = value; }
        public TimeSpan CloseTime { get => closeTime; set => closeTime = value; }
    }
}
