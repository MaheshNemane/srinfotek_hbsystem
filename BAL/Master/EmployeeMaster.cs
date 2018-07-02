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
            fillEmployeeInfo(Common.getData(this, "sp_Employee"));
            return this;
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
        private EmployeeMaster fillEmployeeInfo(DataSet ds)
        {
            if (!Common.isDataSetEmpty(ds))
            {
                this.EmployeeId = Convert.ToInt32(ds.Tables[0].Rows[0]["EmployeeId"]);
                this.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                this.MobileNo = ds.Tables[0].Rows[0]["MobileNo"].ToString();
                this.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                this.Salary = Convert.ToDouble(ds.Tables[0].Rows[0]["Salary"]);
                this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
            }
            return this;
        }
    }
}
