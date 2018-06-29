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

namespace Hotel_Billing_Software.Transaction
{
    public partial class HotelExpenses : Form
    {
        HotelExpenseMaster hotelExpenseMaster = new HotelExpenseMaster();
        HotelExpenseCategoryMaster hotelExpenseCategoryMaster = new HotelExpenseCategoryMaster();
        HotelSubExpenseCatergoryMaster hotelSubExpenseCatergory = new HotelSubExpenseCatergoryMaster();
        PaymentModeMaster paymentModeTransaction = new PaymentModeMaster();

        public HotelExpenses()
        {
            InitializeComponent();
        }
        private void fillPaymentMode()
        {
            try
            {
                DataSet ds = paymentModeTransaction.getAllPaymentCategoryCmb();
                cmbPayMode.DataSource = ds.Tables[0];
                cmbPayMode.ValueMember = "PaymentId";
                cmbPayMode.DisplayMember = "PaymentCategoryName";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillSubExpenseCategory(Int32 categoryid)
        {
            try
            {
                DataSet ds = hotelSubExpenseCatergory.getAllHotelSubExpenseCategoryCmb(categoryid);
                cmbSubExpensesCategory.DataSource = ds.Tables[0];
                cmbSubExpensesCategory.ValueMember = "SubCategoryId";
                cmbSubExpensesCategory.DisplayMember = "SubCategoryName";
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
                DataSet ds = hotelExpenseCategoryMaster.getAllHotelExpenseCategoryCmb();
                cmbExpenseCategory.DataSource = ds.Tables[0];
                cmbExpenseCategory.ValueMember = "CategoryId";
                cmbExpenseCategory.DisplayMember = "CategoryName";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                hotelExpenseMaster.Date = Convert.ToDateTime(dtpDate.Value);
                hotelExpenseMaster.CategoryId = Convert.ToInt32(cmbExpenseCategory.SelectedValue);
                hotelExpenseMaster.SubCategoryId = Convert.ToInt32(cmbSubExpensesCategory.SelectedValue);
                hotelExpenseMaster.Amount = Convert.ToDouble(txtAmount.Text);
                hotelExpenseMaster.Note = txtNote.Text;
                hotelExpenseMaster.PaymentId = Convert.ToInt32(cmbPayMode.SelectedValue);
                hotelExpenseMaster.BankName = TxtBankName.Text;
                hotelExpenseMaster.ChequeNo = txtChaqueNo.Text;
                hotelExpenseMaster.ChequeDate = Convert.ToDateTime(dtpChequeDate.Value);
                BunifuFlatButton btnsave = (BunifuFlatButton)sender;
                hotelExpenseMaster.cmd = btnsave.Text;
                string msgText = hotelExpenseMaster.insertHotelExpense(hotelExpenseMaster);
                Common.showSuccess(msgText);
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void HotelExpenses_Load(object sender, EventArgs e)
        {
            fillExpenseCategory();
            fillPaymentMode();
        }

        private void cmbExpenseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryid;
            if (cmbExpenseCategory.SelectedValue.GetType().Name == "DataRowView")
                categoryid = Convert.ToInt32(((DataRowView)cmbExpenseCategory.SelectedValue).Row.ItemArray[0]);
            else
                categoryid = Convert.ToInt32(cmbExpenseCategory.SelectedValue);
            fillSubExpenseCategory(categoryid);
        }
    }
}
