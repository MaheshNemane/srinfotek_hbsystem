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
            gridExpenseMaster.DataSource = expenseMaster.getAllHotelExpense().Tables[0];
        }


        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            Transaction.HotelExpenses objForm = new Transaction.HotelExpenses();
            objForm.Show();
            onPageLoad();
        }
    }
}
