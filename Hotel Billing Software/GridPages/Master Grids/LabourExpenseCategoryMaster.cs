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
    public partial class LabourExpenseCategoryMaster : Form
    {
        BAL.Master.LabourExpenseCategoryMaster labourExpenseCategoryMaster = new BAL.Master.LabourExpenseCategoryMaster();

        public LabourExpenseCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridLabourExpenseCategoryMaster.DataSource = labourExpenseCategoryMaster.getAllLabourExpenseCategory().Tables[0];
                gridLabourExpenseCategoryMaster.Columns[0].HeaderText = "Category Id";
                gridLabourExpenseCategoryMaster.Columns[1].HeaderText = "Category Name";
                gridLabourExpenseCategoryMaster.Columns[2].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewLabourExpenseCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Master.LabourExpenseCategory objForm = new Master.LabourExpenseCategory();
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnEditLabourExpenses_Click(object sender, EventArgs e)
        {

        }
    }
}
