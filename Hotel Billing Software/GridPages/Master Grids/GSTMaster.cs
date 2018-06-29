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
    public partial class GSTMaster : Form
    {
        BAL.Master.GSTMaster CustomerMst = new BAL.Master.GSTMaster();
        public GSTMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void btnNewGST_Click(object sender, EventArgs e)
        {
            try
            {
                Master.GSTMaster objForm = new Master.GSTMaster();
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
