using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class CustomerBill
    {
        public int TableNo { get; set; }
        public string CustomerName { get; set; }
        public int ItmeCode { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public string Waiter { get; set; }
        public string Paymode { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public double IGST { get; set; }
        public double SubTotal { get; set; }
        public double GrandTotal { get; set; }
        public string Status { get; set; }
    }
}
