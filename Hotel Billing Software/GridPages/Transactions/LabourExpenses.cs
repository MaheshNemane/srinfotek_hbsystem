using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Billing_Software.Transaction;

namespace Hotel_Billing_Software.GridPages.Transactions
{
    public partial class LabourExpenses : Form
    {
        BAL.Transaction.LabourExpenseMaster labourExpense = new BAL.Transaction.LabourExpenseMaster();
        public LabourExpenses()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            try
            {
                gridLabourExpense.DataSource = labourExpense.getAllLabourExpense().Tables[0];
                gridLabourExpense.Columns[0].HeaderText = "Labour Expense Id";
                gridLabourExpense.Columns[1].HeaderText = "Date";
                gridLabourExpense.Columns[2].HeaderText = "Employee Name";
                gridLabourExpense.Columns[3].HeaderText = "Category Name";
                gridLabourExpense.Columns[4].HeaderText = "Sub Category Name";
                gridLabourExpense.Columns[5].HeaderText = "Amount";
                gridLabourExpense.Columns[6].HeaderText = "Note";
                gridLabourExpense.Columns[7].HeaderText = "Pay Mode";
                //gridLabourExpense.Columns[8].HeaderText = "Bank Name";
                //gridLabourExpense.Columns[9].HeaderText = "Cheque No";
                //gridLabourExpense.Columns[10].HeaderText = "Cheque Date";
                //gridLabourExpense.Columns[11].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewLabourExpense_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction.Expenses objForm = new Transaction.Expenses();
                objForm.ShowDialog();
                onPageLoad();
               
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
    }
}
