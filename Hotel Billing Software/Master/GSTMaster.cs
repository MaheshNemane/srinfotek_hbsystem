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
    public partial class GSTMaster : Form
    {
        BAL.Master.GSTMaster gst = new BAL.Master.GSTMaster();
        public GSTMaster()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gst.GSTId = Convert.ToInt32(txtGSTId.Text);
            gst.GST =Convert.ToDecimal( txtGSTPercentage.Text);
         
            BunifuFlatButton btnsave = (BunifuFlatButton)sender;
            gst.cmd = btnsave.Text;
            string msgText = gst.insertGST(gst);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGSTPercentage_MouseClick(object sender, MouseEventArgs e)
        {
            lblSign.Visible = true;
        }

        private void txtGSTPercentage_OnValueChanged(object sender, EventArgs e)
        {
            if (txtGSTPercentage.Text == "")
            {
                lblSign.Visible = false;
            }
        }
    }
}
