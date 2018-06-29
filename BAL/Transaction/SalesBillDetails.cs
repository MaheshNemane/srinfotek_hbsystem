using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class SalesBillDetails
    {
        public Int32 BillId { get; set; }
        public DateTime Date { get; set; }
        public string TableNo { get; set; }
        public Int32 CustomerId { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 PaymentId { get; set; }
        public decimal TotalCGST { get; set; }
        public decimal TotalSGST { get; set; }
        public decimal TotalIGST { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public string Status { get; set; }
    }
}
