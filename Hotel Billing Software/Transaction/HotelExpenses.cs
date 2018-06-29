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
            onPageLoad();
        }
        private void onPageLoad()
        {
            fillExpenseCategory();
            fillSubExpenseCategory();
            fillPaymentMode();
        }

        private void fillPaymentMode()
        {
            try
            {
                cmbPayMode.DataSource = paymentModeTransaction.getAllPaymentCategoryCmb().Tables[0];
                cmbPayMode.ValueMember = "PaymentId";
                cmbPayMode.DisplayMember = "PaymentCategoryName";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void fillSubExpenseCategory()
        {
            try
            {
                cmbSubExpensesCategory.DataSource = hotelSubExpenseCatergory.getAllHotelSubExpenseCategoryCmb().Tables[0];
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
                cmbExpenseCategory.DataSource = hotelExpenseCategoryMaster.getAllHotelExpenseCategoryCmb().Tables[0];
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
                hotelExpenseMaster.Date = Convert.ToDateTime(dtpDate.Text);
                hotelExpenseMaster.CategoryId = Convert.ToInt32(cmbExpenseCategory.Text);
                hotelExpenseMaster.SubCategoryId = Convert.ToInt32(cmbSubExpensesCategory.Text);
                hotelExpenseMaster.Amount = Convert.ToDouble(txtAmount.Text);
                hotelExpenseMaster.Note = txtNote.Text;
                hotelExpenseMaster.PayModeId = Convert.ToInt32(cmbPayMode.Text);
                hotelExpenseMaster.BankName = TxtBankName.Text;
                hotelExpenseMaster.ChequeNo = txtChaqueNo.Text;
                hotelExpenseMaster.ChequeDate = Convert.ToDateTime(dtpChequeDate.Text);

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
    }
}
