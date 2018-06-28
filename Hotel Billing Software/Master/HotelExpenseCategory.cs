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
using BAL.Master;

namespace Hotel_Billing_Software.Master
{
    public partial class HotelExpenseCategory : Form
    {
        HotelExpenseCategoryMaster HotelExpense = new HotelExpenseCategoryMaster();

        public HotelExpenseCategory()
        {
            InitializeComponent();
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
                HotelExpense.CategoryName = txtExpenseCategory.Text;
                BunifuFlatButton btnsave = (BunifuFlatButton)sender;
                HotelExpense.cmd = btnsave.Text;
                string msgText = HotelExpense.insertHotelExpenseCategory(HotelExpense);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
