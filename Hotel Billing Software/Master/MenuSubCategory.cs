using BAL.Master;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.Master
{
    public partial class MenuSubCategory : Form
    {
        MenuSubCategoryMaster menuSubCategory= new MenuSubCategoryMaster();
        MenuCategoryMaster menuCategory = new MenuCategoryMaster();
        public MenuSubCategory()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad() {
            cmbCategory.DataSource = menuCategory.getMenuCategory().Tables[0];
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DisplayMember = "CategoryName";
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            menuSubCategory.SubCategoryName = txtSubCategory.Text;
            menuSubCategory.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            menuSubCategory.cmd = btn.Text;
            string msgText = menuSubCategory.insertMenuSubCategory(menuSubCategory);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
