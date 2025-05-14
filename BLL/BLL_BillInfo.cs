using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_BillInfo
    {
        DAL_BillInfo billInfo = new DAL_BillInfo();

        public List<BillInfo> GetAll() { return billInfo.GetAll(); }
        public void Add(BillInfo bf) { billInfo.Add(bf); }
        public void Update(BillInfo bf) { billInfo.Update(bf); }
        public void Delete(int id) { billInfo.Delete(id); }
        public List<BillInfo> GetDetailsByBillId(int billId)
        {
            return billInfo.GetBillByBillId(billId);
        }
    }
}
