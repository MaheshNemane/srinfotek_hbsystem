using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL.Transaction;
using Bunifu.Framework.UI;
using BAL.Master;
namespace Hotel_Billing_Software
{
    public partial class Expenses : Form
    {
      LabourExpenseMaster LabourExpenseMaster = new LabourExpenseMaster();
      PaymentModeMaster paymentModeMaster = new PaymentModeMaster();
      LabourExpenseCategoryMaster labourExpenseCategory = new LabourExpenseCategoryMaster();
      LabourSubExpensesCategoryMaster labourSubExpensesCategory = new LabourSubExpensesCategoryMaster();

        public Expenses()
        {
            InitializeComponent();
        }
        private void fillPaymentMode()
        {
            try
            {
                DataSet ds = paymentModeMaster.getAllPaymentCategoryCmb();
                cmbPayMode.DataSource = ds.Tables[0];
                cmbPayMode.ValueMember = "PaymentId";
                cmbPayMode.DisplayMember = "PaymentCategoryName";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillSubExpenseCategory(Int32 Categoryid)
        {
            try
            {
                DataSet ds = labourSubExpensesCategory.getAllLabourSubExpenseCategoryCmb(Categoryid);
                cmbSubExpenseCategory.DataSource = ds.Tables[0];
                cmbSubExpenseCategory.ValueMember = "SubCategoryId";
                cmbSubExpenseCategory.DisplayMember = "SubCategoryName";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillExpenseCategory()
        {
            try
            {
                DataSet ds = labourExpenseCategory.getAllLabourExpenseCategoryCmb();
                cmbExpenseCategory.DataSource = ds.Tables[0];
                cmbExpenseCategory.ValueMember = "CategoryId";
                cmbExpenseCategory.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                LabourExpenseMaster.Date = Convert.ToDateTime(dtpDate.Value);
                LabourExpenseMaster.EmployeeId = Convert.ToInt32(cmbEmployeeName.SelectedValue);
                LabourExpenseMaster.CategoryId = Convert.ToInt32(cmbExpenseCategory.SelectedValue);
                LabourExpenseMaster.SubCategoryId = Convert.ToInt32(cmbSubExpenseCategory.SelectedValue);
                LabourExpenseMaster.Amount = Convert.ToDouble(txtAmount.Text);
                LabourExpenseMaster.Note = txtNote.Text;
                LabourExpenseMaster.PaymentId = Convert.ToInt32(cmbPayMode.SelectedValue);
                LabourExpenseMaster.BankName = TxtBankName.Text;
                LabourExpenseMaster.ChequeNo = txtChaqueNo.Text;
                LabourExpenseMaster.ChequeDate = Convert.ToDateTime(dtpChaqueDate.Value);
                BunifuFlatButton btnsave = (BunifuFlatButton)sender;
                LabourExpenseMaster.cmd = btnsave.Text;
                string msgText = LabourExpenseMaster.insertLabourExpense(LabourExpenseMaster);
                Common.showSuccess(msgText);
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            fillExpenseCategory();
            fillPaymentMode();
        }

        private void cmbExpenseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Categoryid;
            if (cmbExpenseCategory.SelectedValue.GetType().Name == "DataRowView")
                Categoryid = Convert.ToInt32(((DataRowView)cmbExpenseCategory.SelectedValue).Row.ItemArray[0]);
            else
                Categoryid = Convert.ToInt32(cmbExpenseCategory.SelectedValue);
            fillSubExpenseCategory(Categoryid);
        }
    }
}
