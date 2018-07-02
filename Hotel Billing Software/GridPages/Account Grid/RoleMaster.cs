using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL.Account;

namespace Hotel_Billing_Software.GridPages.Account_Grid
{

    public partial class RoleMaster : Form
    {
        Role role = new Role();
        static Bunifu.Framework.UI.BunifuFlatButton btn;
        public RoleMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            gridRoleMaster.DataSource = role.getAllRole().Tables[0];
            gridRoleMaster.Columns[0].HeaderText = "Role Id";
            gridRoleMaster.Columns[1].HeaderText = "Role Name";
            gridRoleMaster.Columns[2].HeaderText = "Status";
        }

        private void btnNewRole_Click(object sender, EventArgs e)
        {
            Account.RoleMaster objForm = new Account.RoleMaster();
            objForm.ShowDialog();
            onPageLoad();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            try
            {
                Account.RoleMaster objForm = getRole();
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


        public Account.RoleMaster getRole()
        {
            try
            {
                Account.RoleMaster obj = new Account.RoleMaster();
                DataGridViewSelectedRowCollection row = gridRoleMaster.SelectedRows;
                if (row.Count > 0)
                {
                    role = role.getRole(Convert.ToInt32(row[0].Cells["RoleId"].Value));
                    obj.txtRolename.Text = role.RoleName;
                    return obj;
                }
                else
                {
                    return new Account.RoleMaster();
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
