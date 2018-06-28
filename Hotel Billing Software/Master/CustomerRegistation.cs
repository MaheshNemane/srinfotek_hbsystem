using BAL.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Hotel_Billing_Software.Master
{
    public partial class CustomerRegistation : Form
    {
        CustomerMaster customer= new CustomerMaster();

        public CustomerRegistation()
        {
            InitializeComponent();
        }       
        public void clearForm()
        {
            txtname.Text = "";
            txtMobile.Text = "";
            txtcustomer.Text = "";
            txtCreditLimit.Text = "";
            txtaddress.Text = "";
            txtname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customer.CustomerId=Convert.ToInt32(txtCustomerId.Text);
            customer.CustomerName = txtname.Text;
            customer.MobileNo = txtMobile.Text;
            customer.Address = txtaddress.Text;
            customer.CreditLimit = Convert.ToDouble(txtCreditLimit.Text);
            BunifuFlatButton btnsave = (BunifuFlatButton)sender;
            customer.cmd = btnsave.Text;
            string msgText = customer.insertCustomer(customer);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
