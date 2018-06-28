using Hotel_Billing_Software.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages
{
    public partial class HotelSubExpenseCategoryMaster : Form
    {
        BAL.Master.HotelSubExpenseCatergoryMaster hotelSub = new BAL.Master.HotelSubExpenseCatergoryMaster();
        public HotelSubExpenseCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            try
            {
                gridHotelSubExpenseCategoryMaster.DataSource = hotelSub.getAllHotelSubExpenseCategory().Tables[0];
                gridHotelSubExpenseCategoryMaster.Columns[0].HeaderText = "Sub Category Id";
                gridHotelSubExpenseCategoryMaster.Columns[0].HeaderText = "Category Id";
                gridHotelSubExpenseCategoryMaster.Columns[1].HeaderText = "Sub Category Name";
                gridHotelSubExpenseCategoryMaster.Columns[2].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewHotelSubExpenseCategory_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSubExpenses objForm = new HotelSubExpenses();
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
