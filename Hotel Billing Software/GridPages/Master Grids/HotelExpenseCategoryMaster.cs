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


namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    public partial class HotelExpenseCategoryMaster : Form
    {
        BAL.Master.HotelExpenseCategoryMaster category = new BAL.Master.HotelExpenseCategoryMaster();
        static Bunifu.Framework.UI.BunifuFlatButton btn;

        public HotelExpenseCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }
        private void onPageLoad()
        {
            try
            {
                gridHotelExpenseCategoryMaster.DataSource = category.getAllHotelExpenseCategory().Tables[0];
                gridHotelExpenseCategoryMaster.Columns[0].HeaderText = "Category Id";
                gridHotelExpenseCategoryMaster.Columns[1].HeaderText = "Category Name";
                gridHotelExpenseCategoryMaster.Columns[2].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewHotelExpensesCategory_Click(object sender, EventArgs e)
        {
            try
            {
                HotelExpenseCategory objForm = new HotelExpenseCategory();
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnEditHotelExpense_Click(object sender, EventArgs e)
        {

            try
            {
                Master.HotelExpenseCategory objForm = getHotelExpenseCategory();
                btn = objForm.btnSave;
                objForm.btnSave = Common.setUpdate(btn);
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        public Master.HotelExpenseCategory getHotelExpenseCategory()
        {
            try
            {
                Master.HotelExpenseCategory obj = new Master.HotelExpenseCategory();
                DataGridViewSelectedRowCollection row = gridHotelExpenseCategoryMaster.SelectedRows;
                if (row.Count > 0)
                {
                    category = category.getHotelExpenseCategory(Convert.ToInt32(row[0].Cells["CategoryId"].Value));
                    obj.txtExpenseCategory.Text = category.CategoryId.ToString();
                    return obj;
                }
                else
                {
                    return new Master.HotelExpenseCategory();
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
                return null;
            }
        }
    }
}
