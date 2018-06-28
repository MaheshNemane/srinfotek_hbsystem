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
    public partial class ProductMaster : Form
    {
        BAL.Master.ProductMaster productMaster = new BAL.Master.ProductMaster();
        public ProductMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridProductMaster.DataSource = productMaster.getAllProduct().Tables[0];
                gridProductMaster.Columns[0].HeaderText = "Product Id";
                gridProductMaster.Columns[1].HeaderText = "Item Code";
                gridProductMaster.Columns[2].HeaderText = "Item Name";
                gridProductMaster.Columns[3].HeaderText = "Category Name";
                gridProductMaster.Columns[4].HeaderText = "Sub Category Name";
                gridProductMaster.Columns[5].HeaderText = "Price";
                gridProductMaster.Columns[6].HeaderText = "Waiter Margin";
                gridProductMaster.Columns[7].HeaderText = "Status";

            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Master.ProductRegistration objForm = new Master.ProductRegistration();
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
