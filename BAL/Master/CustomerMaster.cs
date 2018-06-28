using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class CustomerMaster
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public double CreditLimit { get; set; }
        public string cmd { get; set; }

        public string insertCustomer(CustomerMaster customerMaster)
        {
            return Common.putData(customerMaster, "sp_Customer");
        }
        public string deleteCustomer(CustomerMaster customerMaster)
        {
            return Common.putData(customerMaster, "sp_Customer");
        }
        public string updateCustomer(CustomerMaster customerMaster)
        {
            return Common.putData(customerMaster, "sp_Customer");
        }
        public DataSet getCustomer(Int32 CustomerId)
        {
            this.CustomerId = CustomerId;
            this.cmd = "getCustomer";
            return Common.getData(this, "sp_Customer");
        }
        public DataSet getAllCustomer()
        {
            this.cmd = "getAllCustomer";
            return Common.getData(this, "sp_Customer");
        }
        public DataSet getAllCustomerCmb()
        {
            this.cmd = "getAllCustomerCmb";
            return Common.getData(this, "sp_Customer");
        }
    }
}
