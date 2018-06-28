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

namespace Hotel_Billing_Software.Account
{
    public partial class Login : Form
    {

        User user = new User();
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                DataSet ds = user.getLogin(txtUserName.Text);
                if (!BAL.Common.isDataSetEmpty(ds))
                {
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        if (BAL.Encryption.Decrypt(ds.Tables[0].Rows[0]["Password"].ToString()).ToString() == txtPassword.Text)
                        {
                            this.Hide();
                            Dashboard obj = new Dashboard();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Incorrect User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Enter User Name And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}
