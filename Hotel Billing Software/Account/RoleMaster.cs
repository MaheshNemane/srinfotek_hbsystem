using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL.Account;
using Bunifu.Framework.UI;
namespace Hotel_Billing_Software.Account
{
    public partial class RoleMaster : Form
    {
        Role role = new Role();

        public RoleMaster()
        {
            InitializeComponent();
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            role.RoleName = txtRole.Text;

            BunifuFlatButton btn = (BunifuFlatButton)sender;
            role.cmd = btn.Text;
            string msgText = role.insertRole(role);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
