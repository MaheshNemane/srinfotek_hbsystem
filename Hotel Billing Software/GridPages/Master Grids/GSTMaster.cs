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
    public partial class GSTMaster : Form
    {
        BAL.Master.GSTMaster gstmaster = new BAL.Master.GSTMaster();
        static Bunifu.Framework.UI.BunifuFlatButton btn;
        public GSTMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad() {
            try
            {
                gridGSTMaster.DataSource = gstmaster.getAllGST().Tables[0];
                gridGSTMaster.Columns[0].HeaderText = "GST Id";
                gridGSTMaster.Columns[1].HeaderText = "GST";
                gridGSTMaster.Columns[2].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewGST_Click(object sender, EventArgs e)
        {
            try
            {
                Master.GSTMaster objForm = new Master.GSTMaster();
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnEditGST_Click(object sender, EventArgs e)
        {
            try
            {
                Master.GSTMaster objForm = getGST();
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

        private void btnRemoveGST_Click(object sender, EventArgs e)
        {

        }

        public Master.GSTMaster getGST()
        {
            try
            {
                Master.GSTMaster obj = new Master.GSTMaster();
                DataGridViewSelectedRowCollection row = gridGSTMaster.SelectedRows;
                if (row.Count > 0)
                {
                    gstmaster = gstmaster.getGST(Convert.ToInt32(row[0].Cells["GSTId"].Value));
                    obj.txtGSTId.Text = gstmaster.GSTId.ToString();
                    obj.txtGSTPercentage.Text = gstmaster.GST.ToString();
                    return obj;
                }
                else
                {
                    return new Master.GSTMaster();
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
