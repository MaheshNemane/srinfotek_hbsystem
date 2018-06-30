using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL.Master;
using Bunifu.Framework.UI;

namespace Hotel_Billing_Software.Master
{
    public partial class UOMMaster : Form
    {
       BAL.Master.UOMMaster uOMMaster = new BAL.Master.UOMMaster();

        public UOMMaster()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            uOMMaster.UOMId = Convert.ToInt32(txtUOMId.Text);
            uOMMaster.UOMName = txtUOMName.Text;
            uOMMaster.Unit = txtUnit.Text;

            BunifuFlatButton btnsave = (BunifuFlatButton)sender;
            uOMMaster.cmd = btnsave.Text;
            string msgText = uOMMaster.insertUOM(uOMMaster);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
