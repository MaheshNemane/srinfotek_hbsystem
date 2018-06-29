using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    class SalesBillHead
    {
        public int BillId { get; set; }
        public DateTime Date { get; set; }
        public String TableNo{get;set;}
        public int CustomerIdId { get; set; }
        public int EmployeeIdId { get; set; }
        public String PaymentMode { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public double IGST { get; set; }
        public double Discount { get; set; }
        public double SubTotal { get; set; }
        public double GrandTotal { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertSalesBillHead(SalesBillHead salesBillHead)
        {
            return Common.putData(salesBillHead, "sp_SalesBillHead");
        }
        public string UpdateSalesBillHead(SalesBillHead salesBillHead)
        {
            return Common.putData(salesBillHead, "sp_SalesBillDetails");
        }
        public string DeleteSalesBillHead(SalesBillHead salesBillHead)
        {
            return Common.putData(salesBillHead, "sp_SalesBillDetails");
        }
        public string getSalesBillHead(SalesBillHead salesBillHead)
        {
            return Common.putData(salesBillHead, "sp_SalesBillDetails");
        }
        public string getAllSalesBillHead(SalesBillHead salesBillHead)
        {
            return Common.putData(salesBillHead, "sp_SalesBillDetails");
        }
        public string getAllSalesBillHeadCmb(SalesBillHead salesBillHead)
        {
            return Common.putData(salesBillHead, "sp_SalesBillDetails");
        }





    }
}
