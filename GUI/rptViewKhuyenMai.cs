using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class rptViewKhuyenMai : Form
    {
        public rptViewKhuyenMai()
        {
            InitializeComponent();
        }
       
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            var cus = new BLL_Customer().GetAll();
            var pro = new BLL_Promotion().GetDataPromotion();
            var proCus = new BLL_PromotionCustomer().GetAll();

            //xử lý khi bị trùng
            var distinctProCus = proCus
                                .GroupBy(x => new { x.CustomerId, x.PromotionId }) //nhóm id của ng dùng với khuyến mãi
                                .Select(g => g.First());


            var data = from pc in proCus
                       join c in cus on pc.CustomerId equals c.CustomerId
                       join p in pro on pc.PromotionId equals p.PromotionId
                       group p by new
                       {
                           
                           p.PromotionName,
                           p.Discount,
                           p.StartDate,
                           p.EndDate
                       }
                       into grp
                       select new
                       {
                           PromotionName = grp.Key.PromotionName,
                           Discount = grp.Key.Discount,
                           StartDate = grp.Key.StartDate,
                           EndDate = grp.Key.EndDate,
                           SLKH = grp.Count() // số lượng khách hàng áp dụng
                       };

            //rptKhuyenMaiKH rptKM = new rptKhuyenMaiKH();
            //rptKM.SetDataSource(data.ToList());
            //crystalReportViewer1.ReportSource = rptKM;

            rptKhuyenMaiKH rpt = new rptKhuyenMaiKH(); // file .rpt bạn đã tạo
            rpt.SetDataSource(data.ToList()); // gán dữ liệu cho report

            crystalReportViewer1.ReportSource = rpt;  // hiển thị trên viewer
            crystalReportViewer1.Refresh();

        }
    }
}
