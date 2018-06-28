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
using Bunifu.Framework.UI;

namespace Hotel_Billing_Software.Master
{
    public partial class HotelSubExpenses : Form
    {
       BAL.Master.HotelSubExpenseCatergoryMaster hotelSubExpense = new BAL.Master.HotelSubExpenseCatergoryMaster();
        HotelExpenseCategoryMaster HotelExpense = new HotelExpenseCategoryMaster();

        public HotelSubExpenses()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            cmbExpenseCategory.DataSource = HotelExpense.getAllHotelExpenseCategoryCmb().Tables[0];
            cmbExpenseCategory.ValueMember = "CategoryId";
            cmbExpenseCategory.DisplayMember = "CategoryName";
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
                hotelSubExpense.SubCategoryName = txtSubExpenseCategroy.Text;
                hotelSubExpense.CategoryId = Convert.ToInt32(cmbExpenseCategory.SelectedValue);
                BunifuFlatButton btn = (BunifuFlatButton)sender;
                hotelSubExpense.cmd = btn.Text;
                string msgText = hotelSubExpense.insertHotelSubExpenseCategory(hotelSubExpense);
                MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
