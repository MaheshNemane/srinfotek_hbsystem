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
    public partial class MenuCategoryMaster : Form
    {
        BAL.Master.MenuCategoryMaster menuCategory = new BAL.Master.MenuCategoryMaster();

        public MenuCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            gridMenuCategoryMaster.DataSource = menuCategory.getAllMenuCategory().Tables[0];
            gridMenuCategoryMaster.Columns[0].HeaderText = "Category Id";
            gridMenuCategoryMaster.Columns[1].HeaderText = "Category Name";
            gridMenuCategoryMaster.Columns[2].HeaderText = "Status";
        }


        private void btnNewMenuCategory_Click(object sender, EventArgs e)
        {
            Master.MenuCategory objForm = new Master.MenuCategory();
            objForm.ShowDialog();
            onPageLoad();
        }
    }
}
