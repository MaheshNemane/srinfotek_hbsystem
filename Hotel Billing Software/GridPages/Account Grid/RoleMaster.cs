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

namespace Hotel_Billing_Software.GridPages.Account_Grid
{

    public partial class RoleMaster : Form
    {
        Role role = new Role();

        public RoleMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            gridRoleMaster.DataSource = role.getAllRole().Tables[0];
            gridRoleMaster.Columns[0].HeaderText = "Role Id";
            gridRoleMaster.Columns[1].HeaderText = "Role Name";
            gridRoleMaster.Columns[2].HeaderText = "Status";
        }

        private void btnNewRole_Click(object sender, EventArgs e)
        {
            Account.RoleMaster objForm = new Account.RoleMaster();
            objForm.ShowDialog();
            onPageLoad();
        }
    }
}
