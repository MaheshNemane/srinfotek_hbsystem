using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.SubDashboards
{
    public partial class MasterDashboard : Form
    {
        public MasterDashboard()
        {
            InitializeComponent();
            onFormLoad();
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onFormLoad() {
            refreshPage();
            GridPages.CustomerMaster objForm = new GridPages.CustomerMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }


        private void refreshPage() {
            this.pnlPage.Controls.Clear();
        }

        private void btnCustomerMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.CustomerMaster objForm = new GridPages.CustomerMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }
      

        private void btnEmployeeMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.EmployeeMaster objForm = new GridPages.EmployeeMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnSupplierMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.SupplierMaster objForm = new GridPages.SupplierMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnProductMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.ProductMaster objForm = new GridPages.ProductMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnMenuCategoryMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.MenuCategoryMaster objForm = new GridPages.MenuCategoryMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnMenuSubCategoryMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.SubMenuCategoryMaster objForm = new GridPages.SubMenuCategoryMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnHotelExpenseCategoryMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Master_Grids.HotelExpenseCategoryMaster objForm = new GridPages.Master_Grids.HotelExpenseCategoryMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnHotelExpenseSubCategory_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.HotelSubExpenseCategoryMaster objForm = new GridPages.HotelSubExpenseCategoryMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnLabourExpenseCategory_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Master_Grids.LabourExpenseCategoryMaster objForm = new GridPages.Master_Grids.LabourExpenseCategoryMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnLabourExpensesubCategory_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Master_Grids.LabourSubExpenseCategoryMaster objForm = new GridPages.Master_Grids.LabourSubExpenseCategoryMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnPaymentMode_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Master_Grids.PaymentModeMaster objForm = new GridPages.Master_Grids.PaymentModeMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnGSTMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Master_Grids.GSTMaster objForm = new GridPages.Master_Grids.GSTMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;
        }

        private void btnUOMMaster_Click(object sender, EventArgs e)
        {
            refreshPage();
            GridPages.Master_Grids.UOMMaster objForm = new GridPages.Master_Grids.UOMMaster();
            Common.showPage(objForm);
            this.pnlPage.Controls.Add(objForm);
            this.lblMasterName.Text = objForm.Text;

        }
    }
}
