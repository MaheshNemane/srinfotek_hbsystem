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
        MenuSubCategoryMaster menuSubCategory = new MenuSubCategoryMaster();
        BAL.Master.GSTMaster GSTMaster = new BAL.Master.GSTMaster();

        public ProductRegistration()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            fillGSTCmb();
            fillCategory();
        }

        private void fillCategory()
        {
            try
            {
                DataSet ds = menuCategory.getAllMenuCategoryCmb();
                DataRow dr = ds.Tables[0].NewRow();
                dr["CategoryName"] = "-Select Category-";
                dr["CategoryId"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);

                cmbCategory.DataSource = ds.Tables[0];
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillSubCategory(Int32 CategoryId)
        {
            try
            {
                DataSet ds = menuSubCategory.getAllMenuSubCategoryCmb(CategoryId);
                DataRow dr = ds.Tables[0].NewRow();
                dr["SubCategoryName"] = "-Select Sub Category-";
                dr["SubCategoryId"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmbSubCategory.DataSource = ds.Tables[0];
                cmbSubCategory.DisplayMember = "SubCategoryName";
                cmbSubCategory.ValueMember = "SubCategoryId";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
        private void fillGSTCmb()
        {
            DataSet ds = GSTMaster.getAllGSTCmb();
            DataRow dr = ds.Tables[0].NewRow();
            dr["GST"] =0.00;
            dr["GSTId"] = "0";
            //ds.Tables[0].Rows.InsertAt(dr, 0);            
            cmbGSTId.DataSource =ds.Tables[0];
            cmbGSTId.ValueMember = "GSTId";
            cmbGSTId.DisplayMember = "GST";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                productMaster.ItemCode = txtItemCode.Text;
                productMaster.ItemName = txtItemName.Text;
                productMaster.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                productMaster.SubCategoryId = Convert.ToInt32(cmbSubCategory.SelectedValue);
                productMaster.WaiterMargin = txtWaiterMargin.Text==""?0:Convert.ToDouble(txtWaiterMargin.Text);
                productMaster.GSTId = Convert.ToInt32(cmbGSTId.SelectedValue);
                productMaster.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                productMaster.Margin = txtMargin.Text == "" ? 0:Convert.ToDouble(txtMargin.Text);
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryid;
            if (cmbCategory.SelectedValue.GetType().Name == "DataRowView")
                categoryid = Convert.ToInt32(((DataRowView)cmbCategory.SelectedValue).Row.ItemArray[0]);
            else
                categoryid = Convert.ToInt32(cmbCategory.SelectedValue);
            fillSubCategory(categoryid);
        }
    }
}
