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

namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    public partial class UOMMaster : Form
    {
        BAL.Master.UOMMaster uommaster = new BAL.Master.UOMMaster();
        static Bunifu.Framework.UI.BunifuFlatButton btn;
        public UOMMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridUOMMaster.DataSource = uommaster.getAllUOM().Tables[0];
                gridUOMMaster.Columns[0].HeaderText = "UOM Id";
                gridUOMMaster.Columns[1].HeaderText = "UOMName";
                gridUOMMaster.Columns[2].HeaderText = "Unit";
                gridUOMMaster.Columns[3].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewUOM_Click(object sender, EventArgs e)
        {
            try
            {
                Master.UOMMaster objForm = new Master.UOMMaster();
                objForm.ShowDialog();
                onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnEditUOM_Click(object sender, EventArgs e)
        {
            try
            {
                Master.UOMMaster objForm = getUOM();
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

        public Master.UOMMaster getUOM()
        {
            try
            {
                Master.UOMMaster obj = new Master.UOMMaster();
                DataGridViewSelectedRowCollection row = gridUOMMaster.SelectedRows;
                if (row.Count > 0)
                {
                    uommaster = uommaster.getUOM(Convert.ToInt32(row[0].Cells["UOMId"].Value));
                    obj.txtUOMId.Text = uommaster.UOMId.ToString();
                    obj.txtUOMName.Text = uommaster.UOMName.ToString();
                    obj.txtUnit.Text = uommaster.Unit.ToString();
                    return obj;
                }
                else
                {
                    return new Master.UOMMaster();
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
                return null;
            }
        }

        private void btnRemoveUOM_Click(object sender, EventArgs e)
        {

        }
    }
}
