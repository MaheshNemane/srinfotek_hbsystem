using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages
{
    public partial class CustomerMaster : Form
    {
        BAL.Master.CustomerMaster CustomerMst = new BAL.Master.CustomerMaster();
        public CustomerMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            gridCustomerMaster.DataSource = CustomerMst.getAllCustomer().Tables[0];
            gridCustomerMaster.Columns[0].HeaderText = "Customer Id";
            gridCustomerMaster.Columns[1].HeaderText = "Customer Name";
            gridCustomerMaster.Columns[2].HeaderText = "Address";
            gridCustomerMaster.Columns[3].HeaderText = "Mobile No";
            gridCustomerMaster.Columns[4].HeaderText = "Credit Limit";           
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Master.CustomerRegistation objForm = new Master.CustomerRegistation();
            objForm.ShowDialog();
            onPageLoad();
        }

        private void gridCustomerMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
