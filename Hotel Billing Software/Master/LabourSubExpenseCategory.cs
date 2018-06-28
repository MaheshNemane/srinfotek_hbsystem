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
    public partial class LabourSubExpenseCategory : Form
    {
        LabourSubExpensesCategoryMaster labourSubExpensesCategory = new LabourSubExpensesCategoryMaster();
        LabourExpenseCategoryMaster labourExpenseCategory = new LabourExpenseCategoryMaster();
        public LabourSubExpenseCategory()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            cmbExpenseCategory.DataSource = labourExpenseCategory.getAllLabourExpenseCategoryCmb().Tables[0];
            cmbExpenseCategory.ValueMember = "CategoryId";
            cmbExpenseCategory.DisplayMember = "CategoryName";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                labourSubExpensesCategory.SubCategoryName = txtSubExpenseCategroy.Text;
                labourSubExpensesCategory.CategoryId = Convert.ToInt32(cmbExpenseCategory.SelectedValue);
                BunifuFlatButton btn = (BunifuFlatButton)sender;
                labourSubExpensesCategory.cmd = btn.Text;
                string msgText = labourSubExpensesCategory.insertLabourSubExpenseCategory(labourSubExpensesCategory);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
            catch (Exception) { }
        }
        public void clearForm()
        {
            txtSubExpenseCategroy.Text = "";
            cmbExpenseCategory.Text = "";
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