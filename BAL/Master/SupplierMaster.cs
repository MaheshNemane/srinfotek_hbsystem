using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class SupplierMaster
    {
        public Int32 SupplierId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string ShopName { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertSupplier(SupplierMaster supplierMaster)
        {
            return Common.putData(supplierMaster, "sp_Supplier");
        }
        public string updateSupplier(SupplierMaster supplierMaster)
        {
            return Common.putData(supplierMaster, "sp_Supplier");
        }

        public string deleteSupplier(SupplierMaster supplierMaster)
        {
            return Common.putData(supplierMaster, "sp_Supplier");
        }

        public DataSet getSupplier(Int32 SupplierId)
        {
            this.SupplierId = SupplierId;
            this.cmd = "getSupplier";
            return Common.getData(this, "sp_Supplier");
        }


        public DataSet getAllSupplier()
        {
            this.cmd = "getAllSupplier";
            return Common.getData(this, "sp_Supplier");
        }

        public DataSet getAllSupplierCmb()
        {
            this.cmd = "getAllSupplierCmb";
            return Common.getData(this, spname: "sp_Supplier");
        }
    }
}
