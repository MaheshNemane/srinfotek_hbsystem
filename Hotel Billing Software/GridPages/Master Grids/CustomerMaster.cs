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

        static Bunifu.Framework.UI.BunifuFlatButton btn;
        public CustomerMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {

                gridCustomerMaster.DataSource = CustomerMst.getAllCustomer().Tables[0];
                gridCustomerMaster.Columns[0].HeaderText = "Customer Id";
                gridCustomerMaster.Columns[1].HeaderText = "Customer Name";
                gridCustomerMaster.Columns[2].HeaderText = "Address";
                gridCustomerMaster.Columns[3].HeaderText = "Mobile No";
                gridCustomerMaster.Columns[4].HeaderText = "Credit Limit";
                gridCustomerMaster.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Master.CustomerRegistation objForm = new Master.CustomerRegistation();
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Master.CustomerRegistation objForm = getCustomer();
                btn = objForm.btnSave;
                objForm.btnSave = Common.setUpdate(btn);
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {


        }

        public Master.CustomerRegistation getCustomer()
        {
            try
            {
                Master.CustomerRegistation obj = new Master.CustomerRegistation();
                DataGridViewSelectedRowCollection row = gridCustomerMaster.SelectedRows;
                if (row.Count > 0)
                {
                    CustomerMst = CustomerMst.getCustomer(Convert.ToInt32(row[0].Cells["CustomerId"].Value));
                    obj.txtCustomerId.Text = CustomerMst.CustomerId.ToString();
                    obj.txtname.Text = CustomerMst.CustomerName;
                    obj.txtMobile.Text = CustomerMst.MobileNo;
                    obj.txtaddress.Text = CustomerMst.Address;
                    obj.txtCreditLimit.Text = CustomerMst.CreditLimit.ToString();
                    return obj;
                }
                else
                {
                    return new Master.CustomerRegistation();
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
                return null;
            }
        }

        private void gridCustomerMaster_MouseClick(object sender, MouseEventArgs e)
        {
            gridCustomerMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
