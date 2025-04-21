using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Promotion
    {
        DAL_Promotion dal = new DAL_Promotion();
        public List<Promotion> GetDataPromotion()
        {
            return dal.GetAll();
        }

        public void AddPromotion(Promotion promotion)
        {
            dal.Add(promotion);
        }

        public void RemovePromotion(int id)
        {
            dal.Delete(id);
        }

        public void UpdatePromotion(Promotion promotion)
        {
            dal.Update(promotion);
        }
    }
}
