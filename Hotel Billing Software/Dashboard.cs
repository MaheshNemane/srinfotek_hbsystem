using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Hotel_Billing_Software
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            loadDashboard();
        }

        public void loadDashboard()
        {            
            this.lblPageHeader.Text ="Dashboard";
            SubDashboards.Dashboard objForm = new SubDashboards.Dashboard();
            objForm.TopLevel = false;
            this.pnlMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.AutoScaleMode = AutoScaleMode.None;     
            objForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            this.lblPageHeader.Text = btn.Text;
            refreshPanel();
            loadDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            this.lblPageHeader.Text = btn.Text;
            refreshPanel();
            SubDashboards.MasterDashboard objForm = new SubDashboards.MasterDashboard();
            objForm.TopLevel = false;
            this.pnlMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
        public void refreshPanel()
        {
            this.pnlMain.Controls.Clear();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            this.lblPageHeader.Text = btn.Text;
            refreshPanel();
            SubDashboards.UserDashboard objForm = new SubDashboards.UserDashboard();
            objForm.TopLevel = false;
            this.pnlMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            this.lblPageHeader.Text = btn.Text;
            refreshPanel();
            Billing.Billing objForm = new Billing.Billing();
            objForm.TopLevel = false;
            this.pnlMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account.Login objForm = new Account.Login();
            objForm.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            this.lblPageHeader.Text = btn.Text;
            refreshPanel();
            SubDashboards.TransactionDashboard objForm = new SubDashboards.TransactionDashboard();
            objForm.TopLevel = false;
            this.pnlMain.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}
