using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
            using (var db = new HLCMDataContext())
            {

            }
        }
        public  void Update(DTO.Customer customer)
        {
            using (var db = new HLCMDataContext())
            {

            }
        }
        public  void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {

            }
        }
    }
}
