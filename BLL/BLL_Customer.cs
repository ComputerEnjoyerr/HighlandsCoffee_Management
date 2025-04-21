using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Customer
    {
        DAL_Customer dal = new DAL_Customer();

        public List<Customer> GetAll()
        {
            return dal.GetAll();
        }

        public void AddCustomer(Customer customer)
        {
            dal.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            dal.Update(customer);
        }

        public void DeleteCustomer( int id) 
        { 
            dal.Delete(id);
        }
        public List<string> GetTears()
        {
            return dal.GetTiers();
        }

        public void GetCustomer(int id) {

             dal.GetById(id); 
            
        }

    }
}
