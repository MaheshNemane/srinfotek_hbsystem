using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class EmployeeMaster
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertEmployee(EmployeeMaster employeeMaster)
        {
            return Common.putData(employeeMaster,"sp_Employee");
        }

        public string updateEmployee(EmployeeMaster employeeMaster)
        {
            return Common.putData(employeeMaster, "sp_Employee");
        }

        public string deleteEmployee(EmployeeMaster employeeMaster)
        {
            return Common.putData(employeeMaster, "sp_Employee");
        }

        public DataSet getEmployee(int EmployeeId)
        {
            this.EmployeeId = EmployeeId;
            this.cmd = "getEmployee";
            return Common.getData(this, "sp_Employee");
        }


        public DataSet getAllEmployee()
        {
            this.cmd = "getAllEmployee";
            return Common.getData(this, "sp_Employee");
        }

        public DataSet getAllEmployeeCmb()
        {
            this.cmd = "getAllEmployeeCmb";
            return Common.getData(this, spname: "sp_Employee");
        }
    }
}
