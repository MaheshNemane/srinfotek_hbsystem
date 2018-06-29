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
using BAL.Master;
namespace Hotel_Billing_Software.Master
{
    public partial class ProductRegistration : Form
    {
        ProductMaster productMaster = new ProductMaster();
        MenuCategoryMaster menuCategory = new MenuCategoryMaster();
        MenuSubCategoryMaster categoryMaster = new MenuSubCategoryMaster();
        BAL.Master.GSTMaster GSTMaster = new BAL.Master.GSTMaster();

        public ProductRegistration()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            cmbCategory.DataSource = menuCategory.getMenuCategory().Tables[0];
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DisplayMember = "CategoryName";
            cmbSubCategory.DataSource = categoryMaster.getMenuSubCategory().Tables[0];
            cmbSubCategory.ValueMember = "SubCategoryId";
            cmbSubCategory.DisplayMember = "SubCategoryName";

        }
        private void fillGSTCmb()
        {
            cmbSubCategory.DataSource = GSTMaster.getAllGSTCmb().Tables[0];
            cmbSubCategory.ValueMember = "GSTId";
            cmbSubCategory.DisplayMember = "GST";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                productMaster.ItemCode = txtItemCode.Text;
                productMaster.ItemName = txtItemName.Text;
                productMaster.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                productMaster.SubCategoryId = Convert.ToInt32(cmbSubCategory.SelectedValue);
                productMaster.WaiterMargin = Convert.ToDouble(txtWaiterMargin.Text);
                productMaster.GSTId = Convert.ToInt32(cmbGSTId.SelectedValue);
                productMaster.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                productMaster.Margin = Convert.ToDouble(txtMargin.Text);
                productMaster.MRP = Convert.ToDouble(txtMRP.Text);

                BunifuFlatButton btn = (BunifuFlatButton)sender;
                productMaster.cmd = btn.Text;
                string msgText = productMaster.insertProduct(productMaster);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { Common.showDenger(ex.Message); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
