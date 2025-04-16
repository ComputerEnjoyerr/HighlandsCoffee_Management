using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private int productId;
        private string productName, image;
        private double price;

        public Product() { }
        public Product(int productId, string productName, double price, string image)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Price = price;
            this.Image = image;
        }

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Image { get => image; set => image = value; }
        public double Price { get => price; set => price = value; }
    }
}
