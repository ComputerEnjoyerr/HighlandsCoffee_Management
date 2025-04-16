using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        private int supplierId;
        private string supplierName, phoneNumber, address, email;

        public Supplier() { }
        public Supplier(int supplierId, string supplierName, string phoneNumber, string address, string email)
        {
            this.SupplierId = supplierId;
            this.SupplierName = supplierName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Email = email;
        }

        public int SupplierId { get => supplierId; set => supplierId = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
    }
}
