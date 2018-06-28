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

    }
}
