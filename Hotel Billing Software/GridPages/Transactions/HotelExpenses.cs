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
                gridHotelExpenseMaster.DataSource = expenseMaster.getAllHotelExpense().Tables[0];
                gridHotelExpenseMaster.Columns[0].HeaderText = "Hotel Expense Id";
                gridHotelExpenseMaster.Columns[1].HeaderText = "Date";
                gridHotelExpenseMaster.Columns[2].HeaderText = "Category Name";
                gridHotelExpenseMaster.Columns[3].HeaderText = "Sub Category Name";
                gridHotelExpenseMaster.Columns[4].HeaderText = "Amount";
                gridHotelExpenseMaster.Columns[5].HeaderText = "Note";
                gridHotelExpenseMaster.Columns[6].HeaderText = "Pay Mode";
                gridHotelExpenseMaster.Columns[7].HeaderText = "Bank Name";
                gridHotelExpenseMaster.Columns[8].HeaderText = "Cheque No";
                gridHotelExpenseMaster.Columns[9].HeaderText = "Cheque Date";
                gridHotelExpenseMaster.Columns[10].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewHotelExpenses_Click(object sender, EventArgs e)
        {
           
                try
                {
                    Transaction.HotelExpenses objForm = new Transaction.HotelExpenses();
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
