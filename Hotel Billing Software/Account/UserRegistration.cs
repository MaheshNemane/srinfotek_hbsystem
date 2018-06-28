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
    public partial class UserRegistration : Form
    {
        User user = new User();

        Role role = new Role();

        public UserRegistration()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            cmbRole.DataSource = role.getAllRoleCmb().Tables[0];
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "RoleId";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                BunifuFlatButton bunifuFlat = (BunifuFlatButton)sender;
                user.cmd = bunifuFlat.Text;
                user.UserName = txtUserName.Text;
                user.RoleId = Convert.ToInt32(cmbRole.SelectedValue);
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.EmailId = txtEmailId.Text;
                user.MobileNo = txtMobileNo.Text;
                user.Password = BAL.Encryption.Encrypt(txtPassword.Text);
                user.PasswordHint = txtPasswordHint.Text;
                string msg = user.insertUser(user);
                MessageBox.Show(msg, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password & Confirm Password Must be Same.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            txtUserName.Text = "";
            cmbRole.SelectedIndex = 0;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmailId.Text = "";
            txtMobileNo.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtPasswordHint.Text = "";
            txtUserName.Focus();
        }
    }
}
