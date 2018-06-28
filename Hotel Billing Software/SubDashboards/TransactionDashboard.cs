using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.SubDashboards
{
    public partial class TransactionDashboard : Form
    {
        public TransactionDashboard()
        {
            InitializeComponent();
            onFormLoad();
        }
        private void onFormLoad()
        {
            refreshPage();
            GridPages.Transactions.PurchaseMaster objForm = new GridPages.Transactions.PurchaseMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void refreshPage()
        {
            this.pnlPage.Controls.Clear();
        }

        private void btnPurchaseMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Transactions.PurchaseMaster objForm = new GridPages.Transactions.PurchaseMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }
    }
}
