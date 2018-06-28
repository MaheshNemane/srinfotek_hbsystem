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
namespace Hotel_Billing_Software.Billing
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void btnHallTable1_Click(object sender, EventArgs e)
        {           
            Transaction.Bill objForm = new Transaction.Bill();
            BunifuThinButton2 btn = (BunifuThinButton2)sender;
            objForm.lblTableNo.Text = btn.ButtonText;
            objForm.TopLevel = false;
            this.pnlBillDescription.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.AutoScaleMode = AutoScaleMode.None;
            objForm.Show();
        }

        private void pnlACRoom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
