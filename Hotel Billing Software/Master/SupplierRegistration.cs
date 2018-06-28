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
    public partial class SupplierRegistration : Form
    {
        SupplierMaster supplierMaster = new SupplierMaster();
        public SupplierRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                supplierMaster.Name = txtName.Text;
                supplierMaster.MobileNo = txtMobile.Text;
                supplierMaster.Address = txtAddress.Text;
                supplierMaster.ShopName = txtShopName.Text;

                BunifuFlatButton btn = (BunifuFlatButton)sender;
                supplierMaster.cmd = btn.Text;
                string msgText = supplierMaster.insertSupplier(supplierMaster);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
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
