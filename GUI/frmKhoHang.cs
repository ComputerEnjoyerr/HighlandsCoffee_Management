using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhoHang : Form
    {
        public frmKhoHang(Employee em)
        {
            InitializeComponent();
            currentEmployee = em;
        }

        private Employee currentEmployee = new Employee();
        private BLL_Inventory bllInventory = new BLL_Inventory();
        private BLL_Ingredient bllIngredient = new BLL_Ingredient();
        private BLL_Branch bllBranch = new BLL_Branch();

        private void LoadKhoHang()
        {
            //dgvKhoHang.DataSource = bllInventory.GetAll().Where(i => i.BranchId == currentEmployee.BranchId).ToList();
            var data = from i in bllInventory.GetAll()
                       where i.BranchId == currentEmployee.BranchId
                       select new
                       {
                           i.InventoryId,
                           bllBranch.GetDataBranch().FirstOrDefault(b => b.BranchId == i.BranchId).BranchName,
                           bllIngredient.GetAll().FirstOrDefault(ig => ig.IngredientId == i.IngredientId).IngredientName,
                           i.RestockDate,
                           i.ExpDay,
                           i.ExpDate,
                           i.Quantity,
                           i.Unit,
                           i.UnitPrice,
                           i.TotalPrice
                       };
            if (data != null ) dgvKhoHang.DataSource = data.ToList();
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#52362A");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            LoadKhoHang();
        }

    }
}
