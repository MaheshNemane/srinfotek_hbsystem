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

namespace Hotel_Billing_Software.Transaction
{
    public partial class Bill : Form
    {
        MenuCategoryMaster MenuCategory = new MenuCategoryMaster();
        MenuSubCategoryMaster MenuSubCategory = new MenuSubCategoryMaster();
        ProductMaster productMaster = new ProductMaster();
        public Bill()
        {
            InitializeComponent();
            onPageLoad();
        }

        public void onPageLoad()
        {
            try
            {
                fillCategory();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillCategory()
        {
            try
            {
                DataSet ds = MenuCategory.getAllMenuCategoryCmb();
                if (ds.Tables.Count > 0)
                {
                    cmbCategory.DataSource = ds.Tables[0];
                    cmbCategory.DisplayMember = "CategoryName";
                    cmbCategory.ValueMember = "CategoryId";
                }
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
                cmbSubCategory.Items.Clear();
                DataSet ds = MenuSubCategory.getAllMenuSubCategoryCmb(CategoryId);
                if (ds.Tables.Count > 0)
                {
                    cmbSubCategory.DataSource = ds.Tables[0];
                    cmbSubCategory.DisplayMember = "SubCategoryName";
                    cmbSubCategory.ValueMember = "SubCategoryId";
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillMenuItem(Int32 CategoryId, Int32 SubCategoryId)
        {
            try
            {
                cmbItemName.Items.Clear();
                DataSet ds = productMaster.getAllProductCmb(CategoryId, SubCategoryId);
                if (ds.Tables.Count > 0)
                {
                    cmbItemName.DataSource = ds.Tables[0];
                    cmbItemName.DisplayMember = "ItemName";
                    cmbItemName.ValueMember = "ProductId";
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        //private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbCategory.Items.Count>0 && cmbSubCategory.Items.Count > 0)
        //        {
        //            fillMenuItem(Convert.ToInt32(cmbSubCategory.SelectedValue), Convert.ToInt32(cmbSubCategory.SelectedValue));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Common.showDenger(ex.Message);
        //    }
        //}

        //private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbItemName.Items.Count > 0)
        //        {
        //            ProductMaster product = productMaster.getProduct(Convert.ToInt32(cmbItemName.SelectedValue));
        //            txtPrice.Text = product.Price.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Common.showDenger(ex.Message);
        //    }
        //}

        private void txtItemCode_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProductMaster product = productMaster.getProduct(txtItemCode.Text);
                txtPrice.Text = product.MRP.ToString();
                cmbCategory.SelectedValue = product.CategoryId;
                fillSubCategory(product.CategoryId);
                cmbSubCategory.SelectedValue = product.SubCategoryId;
                fillMenuItem(product.CategoryId, product.SubCategoryId);
                cmbItemName.SelectedValue = product.ProductId;
                txtQty.Focus();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.Items.Count > 0)
                {
                    fillSubCategory(Convert.ToInt32(((DataRowView)cmbCategory.SelectedValue)["CategoryId"]));
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.Items.Count > 0 && cmbSubCategory.Items.Count > 0)
                {
                    fillMenuItem(Convert.ToInt32(((DataRowView)cmbCategory.SelectedValue)), Convert.ToInt32(((DataRowView)cmbSubCategory.SelectedValue)));
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int categoryid;
                if (cmbCategory.SelectedValue.GetType().Name == "DataRowView")
                    categoryid = Convert.ToInt32(((DataRowView)cmbCategory.SelectedValue).Row.ItemArray[0]);
                else
                    categoryid = Convert.ToInt32(cmbCategory.SelectedValue);
                fillSubCategory(categoryid);                
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void cmbSubCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int categoryid,subCategoryId;
                if (cmbCategory.SelectedValue.GetType().Name == "DataRowView")
                    categoryid = Convert.ToInt32(((DataRowView)cmbCategory.SelectedValue).Row.ItemArray[0]);
                else
                    categoryid = Convert.ToInt32(cmbCategory.SelectedValue);

                if (cmbSubCategory.SelectedValue.GetType().Name == "DataRowView")
                    subCategoryId = Convert.ToInt32(((DataRowView)cmbSubCategory.SelectedValue).Row.ItemArray[0]);
                else
                    subCategoryId = Convert.ToInt32(cmbSubCategory.SelectedValue);
                fillMenuItem(categoryid, subCategoryId);                
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbItemName.Items.Count > 0)
                {
                    ProductMaster product = productMaster.getProduct(Convert.ToInt32(cmbItemName.SelectedValue));
                    txtPrice.Text = product.MRP.ToString();
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
    }
}
