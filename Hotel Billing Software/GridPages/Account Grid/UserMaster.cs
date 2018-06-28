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
    public partial class UserMaster : Form
    {
        User user = new User();

        public UserMaster()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            gridUserMaster.DataSource = user.getAllUser().Tables[0];
            gridUserMaster.Columns[0].HeaderText = "User Id";
            gridUserMaster.Columns[1].HeaderText = "User Name";
            gridUserMaster.Columns[2].HeaderText = "Role Name";
            gridUserMaster.Columns[3].HeaderText = "First Name";
            gridUserMaster.Columns[4].HeaderText = "Last Name";
            gridUserMaster.Columns[5].HeaderText = "Email Id";
            gridUserMaster.Columns[6].HeaderText = "Mobile No";
            gridUserMaster.Columns[7].HeaderText = "Status";
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Account.UserRegistration objForm = new Account.UserRegistration();
            objForm.ShowDialog();
            onPageLoad();
        }       
    }
}
