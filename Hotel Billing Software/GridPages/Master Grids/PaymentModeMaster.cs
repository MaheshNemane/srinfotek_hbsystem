using System;
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
    public partial class PaymentModeMaster : Form
    {
        BAL.Master.PaymentModeMaster paymentMode = new BAL.Master.PaymentModeMaster();
        public PaymentModeMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            gridPaymentModeMaster.DataSource = paymentMode.getAllPaymentCategory().Tables[0];
            gridPaymentModeMaster.Columns[0].HeaderText = "Payment Id";
            gridPaymentModeMaster.Columns[1].HeaderText = "Payment Category Name";
            gridPaymentModeMaster.Columns[2].HeaderText = "Status";
        }
        private void btnNewPaymentMode_Click(object sender, EventArgs e)
        {
            Master.PaymentMode objForm = new Master.PaymentMode();
            objForm.ShowDialog();
            onPageLoad();
        }
    }
}
