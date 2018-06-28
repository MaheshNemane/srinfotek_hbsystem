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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }
        private void refreshPage()
        {
            this.pnlPage.Controls.Clear();
        }

        private void onPageLoad()
        {
            refreshPage();
            GridPages.Account_Grid.RoleMaster objForm = new GridPages.Account_Grid.RoleMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnRoleMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Account_Grid.RoleMaster objForm = new GridPages.Account_Grid.RoleMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnUserMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Account_Grid.UserMaster objForm = new GridPages.Account_Grid.UserMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            refreshPage();
            Account.ChangePassword objForm = new Account.ChangePassword();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }
    }
}
