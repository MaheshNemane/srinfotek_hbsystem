using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL.Transaction;
using Bunifu.Framework.UI;
using BAL.Master;

namespace Hotel_Billing_Software.Master
{
    public partial class PaymentMode : Form
    {
        PaymentModeMaster paymentMode = new PaymentModeMaster();
        public PaymentMode()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                paymentMode.PaymentCategoryName = txtPaymentCategory.Text;
                BunifuFlatButton btnsave = (BunifuFlatButton)sender;
                paymentMode.cmd = btnsave.Text;
                string msgText = paymentMode.insertPaymentCategory(paymentMode);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
