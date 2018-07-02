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
    public partial class EmployeeMaster : Form
    {

        BAL.Master.EmployeeMaster EmpMst = new BAL.Master.EmployeeMaster();
        public EmployeeMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            gridEmployeeMaster.DataSource = EmpMst.getAllEmployee().Tables[0];
            gridEmployeeMaster.Columns[0].HeaderText = "Employee Id";
            gridEmployeeMaster.Columns[1].HeaderText = "Employee Name";
            gridEmployeeMaster.Columns[2].HeaderText = "Address";
            gridEmployeeMaster.Columns[3].HeaderText = "Mobile No";
            gridEmployeeMaster.Columns[4].HeaderText = "Salary";
        }


        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            Master.EmployeeRegistration objForm = new Master.EmployeeRegistration();
            objForm.ShowDialog();
            onPageLoad();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Master.EmployeeRegistration objForm =getEmployee();
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

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {

        }
        public Master.EmployeeRegistration getEmployee()
        {
            try
            {
                Master.EmployeeRegistration obj = new Master.EmployeeRegistration();
                DataGridViewSelectedRowCollection row = gridEmployeeMaster.SelectedRows;
                if (row.Count > 0)
                {
                    EmpMst = EmpMst.getEmployee(Convert.ToInt32(row[0].Cells["EmployeeId"].Value));
                    obj.txtEmployeeId.Text = EmpMst.EmployeeId.ToString();
                    obj.txtname.Text = EmpMst.EmployeeName;
                    obj.txtMobile.Text = EmpMst.MobileNo;
                    obj.txtaddress.Text = EmpMst.Address;
                    obj.txtSalary.Text = EmpMst.Salary.ToString();
                    return obj;
                }
                else
                {
                    return new Master.EmployeeRegistration();
                }
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
                return null;
            }
        }

        private void gridEmployeeMaster_MouseClick(object sender, MouseEventArgs e)
        {
            gridEmployeeMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
