using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages
{
    public partial class SubMenuCategoryMaster : Form
    {
        BAL.Master.MenuSubCategoryMaster category = new BAL.Master.MenuSubCategoryMaster();
        public SubMenuCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridSubMenuCategoryMaster.DataSource = category.getAllMenuSubCategory().Tables[0];
                gridSubMenuCategoryMaster.Columns[0].HeaderText = "Sub Category Id";
                gridSubMenuCategoryMaster.Columns[1].HeaderText = "Category Id";
                gridSubMenuCategoryMaster.Columns[2].HeaderText = "Sub Category Name";
                gridSubMenuCategoryMaster.Columns[3].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewSubMenuCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Master.MenuSubCategory objForm = new Master.MenuSubCategory();
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
    }
}
