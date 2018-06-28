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

        public PurchaseBilling()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            cmbSupplier.DataSource= supplier.getAllSupplierCmb().Tables[0];
        }

        private void fillSupplierCombo()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
