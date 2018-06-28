using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages.Transactions
{
    public partial class HotelExpenses : Form
    {
        BAL.Transaction.HotelExpenseMaster expenseMaster = new BAL.Transaction.HotelExpenseMaster();
        public HotelExpenses()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            try
            {
                gridExpenseMaster.DataSource = expenseMaster.getAllHotelExpense().Tables[0];
                gridExpenseMaster.Columns[0].HeaderText = "Hotel Expense Id";
                gridExpenseMaster.Columns[1].HeaderText = "Date";
                gridExpenseMaster.Columns[2].HeaderText = "Category Name";
                gridExpenseMaster.Columns[3].HeaderText = "Sub Category Name";
                gridExpenseMaster.Columns[4].HeaderText = "Amount";
                gridExpenseMaster.Columns[5].HeaderText = "Note";
                gridExpenseMaster.Columns[6].HeaderText = "Pay Mode";
                gridExpenseMaster.Columns[7].HeaderText = "Bank Name";
                gridExpenseMaster.Columns[8].HeaderText = "Cheque No";
                gridExpenseMaster.Columns[9].HeaderText = "Cheque Date";
                gridExpenseMaster.Columns[10].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction.HotelExpenses objForm =new Transaction.HotelExpenses();
                objForm.ShowDialog();
                onPageLoad();
                objForm.ShowDialog();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
    }
}
