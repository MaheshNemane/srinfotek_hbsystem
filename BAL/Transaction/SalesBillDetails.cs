using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    class SalesBillDetails
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public Double Qty { get; set; }
        public Double Price { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public double IGST { get; set; }
        public double Total { get; set; }
        public string cmd { get; set; }

        public string insertSalesBillDetails(SalesBillDetails salesBill)
        {
            return Common.putData(salesBill, "sp_SalesBillDetails");
        }
        public string UpdateSalesBillDetails(SalesBillDetails salesBill)
        {
            return Common.putData(salesBill, "sp_SalesBillDetails");
        }
        public string DeleteSalesBillDetails(SalesBillDetails salesBill)
        {
            return Common.putData(salesBill, "sp_SalesBillDetails");
        }
        public string getSalesBillDetails(SalesBillDetails salesBill)
        {
            return Common.putData(salesBill, "sp_SalesBillDetails");
        }
        public string getAllSalesBillDetails(SalesBillDetails salesBill)
        {
            return Common.putData(salesBill, "sp_SalesBillDetails");
        }
        public string getAllSalesBillDetailsCmb(SalesBillDetails salesBill)
        {
            return Common.putData(salesBill, "sp_SalesBillDetails");
        }


    }
}
