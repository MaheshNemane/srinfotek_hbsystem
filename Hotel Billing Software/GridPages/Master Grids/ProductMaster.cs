﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages.Master_Grids
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
                gridProductMaster.Columns[3].HeaderText = "Category";
                gridProductMaster.Columns[4].HeaderText = "Sub Category";
                gridProductMaster.Columns[5].HeaderText = "Waiter Margin";
                gridProductMaster.Columns[6].HeaderText = "Purchase Price";
                gridProductMaster.Columns[7].HeaderText = "Margin";
                gridProductMaster.Columns[8].HeaderText = "GST";
                gridProductMaster.Columns[9].HeaderText = "MRP";
                gridProductMaster.Columns[10].HeaderText = "Status";
                gridProductMaster.Columns[0].Visible = false;
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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Master.ProductRegistration objForm = getProduct();
                btn = objForm.btnSave;
                objForm.btnSave = Common.setUpdate(btn);
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
