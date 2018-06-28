using BAL.Master;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.Master
{
    public partial class LabourExpenseCategory : Form
    {

        LabourExpenseCategoryMaster labourExpenseCategory = new LabourExpenseCategoryMaster();
        public LabourExpenseCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                labourExpenseCategory.CategoryName = txtExpenseCategory.Text;
                BunifuFlatButton btnsave = (BunifuFlatButton)sender;
                labourExpenseCategory.cmd = btnsave.Text;
                string msgText = labourExpenseCategory.insertLabourExpenseCategory(labourExpenseCategory);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
            catch (Exception)
            {

            }
        }
        public void clearForm()
        {
            txtExpenseCategory.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}