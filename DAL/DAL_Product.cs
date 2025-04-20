using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Product
    {
        public List<Product> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                //var data = db.PRODUCTs.Select(p => new Product
                //{
                //    ProductId = p.ProductId,
                //    ProductName = p.ProductName,
                //    Price = (double)p.Price,
                //    Image = p.Image
                //});

                var data = from p in db.PRODUCTs
                           select new Product
                           {
                               ProductId = p.ProductId,
                               ProductName = p.ProductName,
                               Price = (double)p.Price,
                               Image = p.Image
                           };

                return data.ToList();
            }
        }
        public void Add(Product product)
        {
            using (var db = new HLCMDataContext())
            {
                var newProduct = new PRODUCT
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = (decimal)product.Price,
                    Image = product.Image
                };
                db.PRODUCTs.InsertOnSubmit(newProduct);
                db.SubmitChanges();
            }
        }
        public void Update(Product product)
        {
            using (var db = new HLCMDataContext())
            {
                var existingProduct = db.PRODUCTs.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (existingProduct != null)
                {
                    existingProduct.ProductName = product.ProductName;
                    existingProduct.Price = (decimal)product.Price;
                    existingProduct.Image = product.Image;
                    db.SubmitChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var productToDelete = db.PRODUCTs.FirstOrDefault(p => p.ProductId == id);
                if (productToDelete != null)
                {
                    db.PRODUCTs.DeleteOnSubmit(productToDelete);
                    db.SubmitChanges();
                }
            }
        }
    }
}
