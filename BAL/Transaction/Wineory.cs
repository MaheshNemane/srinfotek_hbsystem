using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class Wineory
    {
        public int PurchaseBillNo { get; set; }
        public string SupplierName { get; set; }
        public DateTime Date { get; set; }
        public string WineoryCategory { get; set; }
        public string Name { get; set; }
        public string WineCode { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string UOM { get; set; }
        public double Total { get; set; }
        public string Paymode { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public double IGST { get; set; }
        public double SubTotal { get; set; }
        public double GrandTotal { get; set; }
        public string Status { get; set; }
    }
}
