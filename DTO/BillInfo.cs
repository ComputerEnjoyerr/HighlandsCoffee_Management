using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfo
    {
        private int billInfoId, productId, billId, quantity;

        public BillInfo() { }
        public BillInfo(int billInfoId, int productId, int billId, int quantity)
        {
            this.BillInfoId = billInfoId;
            this.ProductId = productId;
            this.BillId = billId;
            this.Quantity = quantity;
        }

        public int BillInfoId { get => billInfoId; set => billInfoId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int BillId { get => billId; set => billId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
