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
           
        }

        private void fillSupplierCombo()
        {
            cmbSupplier.DataSource = supplier.getAllSupplierCmb().Tables[0];
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
