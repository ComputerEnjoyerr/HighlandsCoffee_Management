using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private int customerId, point;
        private string customerName, phoneNumber, email, tier;

        public Customer() { }
        public Customer(int customerId, string customerName, string email, string phoneNumber, int point, string tier)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Point = point;
            this.Tier = tier;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public int Point { get => point; set => point = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Tier { get => tier; set => tier = value; }
    }
}
