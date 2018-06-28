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
    public partial class LabourSubExpenseCategoryMaster : Form
    {
        BAL.Master.LabourSubExpensesCategoryMaster labourSubExpenseCategoryMaster = new BAL.Master.LabourSubExpensesCategoryMaster();
        public LabourSubExpenseCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridLabourSubExpenseCategoryMaster.DataSource = labourSubExpenseCategoryMaster.getAllLabourSubExpenseCategory().Tables[0];
                gridLabourSubExpenseCategoryMaster.Columns[0].HeaderText = "Sub Category Id";
                gridLabourSubExpenseCategoryMaster.Columns[1].HeaderText = "Category Id";
                gridLabourSubExpenseCategoryMaster.Columns[2].HeaderText = "Sub-Category Id";
                gridLabourSubExpenseCategoryMaster.Columns[3].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewLabourSubExpenseCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Master.LabourSubExpenseCategory objForm = new Master.LabourSubExpenseCategory();
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
