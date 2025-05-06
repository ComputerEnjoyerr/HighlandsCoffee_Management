using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_Supplier
    {
        public List<Supplier> GetAll()
        {
            using (var db = new HLCMDataContext())
            {
                var data = db.SUPPLIERs.Select(s => new Supplier
                {
                    SupplierId = s.SupplierId,
                    SupplierName = s.Name,
                    Address = s.Address,
                    PhoneNumber = s.Phone,
                    Email = s.Email,
                });
                return data.ToList();
            }
        }

        public void Add(Supplier sp)
        {
            using (var db = new HLCMDataContext())
            {
                var newSupplier = new SUPPLIER
                {
                    SupplierId = sp.SupplierId,
                    Name = sp.SupplierName,
                    Address = sp.Address,
                    Phone = sp.PhoneNumber,
                    Email = sp.Email,
                };
                db.SUPPLIERs.InsertOnSubmit(newSupplier);
                db.SubmitChanges();
            }
        }

        public void Update(Supplier sp)
        {
            using (var db = new HLCMDataContext())
            {
                var existingSupplier = db.SUPPLIERs.FirstOrDefault(s => s.SupplierId == sp.SupplierId);
                if (existingSupplier != null)
                {
                    existingSupplier.Name = sp.SupplierName;
                    existingSupplier.Address = sp.Address;
                    existingSupplier.Phone = sp.PhoneNumber;
                    existingSupplier.Email = sp.Email;
                    db.SubmitChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new HLCMDataContext())
            {
                var supplierToDelete = db.SUPPLIERs.FirstOrDefault(s => s.SupplierId == id);
                if (supplierToDelete != null)
                {
                    db.SUPPLIERs.DeleteOnSubmit(supplierToDelete);
                    db.SubmitChanges();
                }
            }
        }
    }
}
