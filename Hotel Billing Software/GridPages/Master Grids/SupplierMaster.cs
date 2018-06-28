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
    public partial class SupplierMaster : Form
    {
        BAL.Master.SupplierMaster supplierMaster = new BAL.Master.SupplierMaster();
        public SupplierMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridSupplierMaster.DataSource = supplierMaster.getAllSupplier().Tables[0];
                gridSupplierMaster.Columns[0].HeaderText = "Supplier Id";
                gridSupplierMaster.Columns[1].HeaderText = "Supplier Name";
                gridSupplierMaster.Columns[2].HeaderText = "Mobile No";
                gridSupplierMaster.Columns[3].HeaderText = "Address";
                gridSupplierMaster.Columns[4].HeaderText = "Shop Name";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Master.SupplierRegistration objForm = new Master.SupplierRegistration();
                objForm.ShowDialog();
                onPageLoad();
                objForm.ShowDialog();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
    }
}
