using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BAL.Master;

namespace Hotel_Billing_Software.Transaction
{
    public partial class PurchaseBilling : Form
    {
        SupplierMaster supplier = new SupplierMaster();
        MenuCategoryMaster MenuCategory = new MenuCategoryMaster();
        MenuSubCategoryMaster MenuSubCategory = new MenuSubCategoryMaster();
        ProductMaster productMaster = new ProductMaster();

        public PurchaseBilling()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            fillSupplierCombo();
            fillCategory();
        }

        private void fillSupplierCombo()
        {
            try
            {
                DataSet ds = supplier.getAllSupplierCmb();
                DataRow dr = ds.Tables[0].NewRow();
                dr["ShopName"] = "-Select Supplier-";
                dr["SupplierId"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);

                cmbSupplier.DataSource = ds.Tables[0];
                cmbSupplier.DisplayMember = "ShopName";
                cmbSupplier.ValueMember = "SupplierId";

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
                DataSet ds = MenuSubCategory.getAllMenuSubCategoryCmb(CategoryId);
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

        private void fillMenuItem(Int32 CategoryId, Int32 SubCategoryId)
        {
            try
            {
                DataSet ds = productMaster.getAllProductCmb(CategoryId, SubCategoryId);
                DataRow dr = ds.Tables[0].NewRow();
                dr["ItemName"] = "-Select Menu-";
                dr["ProductId"] = "0";
                ds.Tables[0].Rows.InsertAt(dr, 0);

                cmbItemName.DataSource = ds.Tables[0];
                cmbItemName.DisplayMember = "ItemName";
                cmbItemName.ValueMember = "ProductId";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryid;
            if (cmbCategory.SelectedValue.GetType().Name == "DataRowView")
                categoryid = Convert.ToInt32(((DataRowView)cmbCategory.SelectedValue).Row.ItemArray[0]);
            else
                categoryid = Convert.ToInt32(cmbCategory.SelectedValue);

            int subCategoryId;
            if (cmbSubCategory.SelectedValue.GetType().Name == "DataRowView")
                subCategoryId = Convert.ToInt32(((DataRowView)cmbSubCategory.SelectedValue).Row.ItemArray[0]);
            else
                subCategoryId = Convert.ToInt32(cmbSubCategory.SelectedValue);
            fillMenuItem(categoryid, subCategoryId);
        }
    }
}
