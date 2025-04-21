using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer
    {
        public List<Customer> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.CUSTOMERs.Select(c => new Customer
                {
                    CustomerId = c.CustomerId,
                    CustomerName = c.CustomerName,
                    PhoneNumber = c.Phone,
                    Email = c.Email,
                    Point = (int)c.Point,
                    Tier = c.Tier
                });
                return data.ToList();
            }
        }
        public  DAL.CUSTOMER GetById(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.CUSTOMERs.FirstOrDefault(c => c.CustomerId == id);
                return data;
            }
        }
        public  void Add(DTO.Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            using (var db = new HLCMDataContext())
            {
                
                var newCus = new DAL.CUSTOMER
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = customer.CustomerName,
                    Phone = customer.PhoneNumber,
                    Email = customer.Email,
                    Point = (int)customer.Point,
                    Tier = customer.Tier

                };
                db.CUSTOMERs.InsertOnSubmit(newCus);
                db.SubmitChanges();
                //Lấy ID ms từ db
                customer.CustomerId = newCus.CustomerId;
            }
        }
        public  void Update(DTO.Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            using (var db = new HLCMDataContext())
            {
                var up = db.CUSTOMERs.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
                if (up != null)
                {
                    
                    up.CustomerName = customer.CustomerName;
                    up.Phone = customer.PhoneNumber;
                    up.Email = customer.Email;
                    up.Point = (int)customer.Point;
                    up.Tier = customer.Tier;

                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Khach hang khong ton tai");
                }
            }
        }
        public  void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var del = db.CUSTOMERs.FirstOrDefault(x => x.CustomerId == id);
                if (del != null)
                {
                    db.CUSTOMERs.DeleteOnSubmit(del);
                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Item không tồn tại để xóa!");
                }
            }
        }

        
        public List<string> GetTiers()
        {
            using (var db = new HLCMDataContext())
            {
                return db.CUSTOMERs.Select(c => c.Tier).Distinct().ToList();
            }
         }
        


    }
}
