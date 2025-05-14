using BLL;
using CrystalDecisions.CrystalReports.Engine;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class rptViewInHoaDon : Form
    {
        
        public rptViewInHoaDon()
        {
            InitializeComponent();
            
        }
        BLL_Bill bill = new BLL_Bill();
        BLL_BillInfo billInfo = new BLL_BillInfo();
        BLL_Branch branch = new BLL_Branch();
        BLL_Customer customer = new BLL_Customer();
        BLL_Product product = new BLL_Product();
        BLL_Promotion promotion = new BLL_Promotion();
        BLL_Table table = new BLL_Table();


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           

        }
    
    }
}
