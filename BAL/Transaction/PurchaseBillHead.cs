using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class PurchaseBillHead
    {
        public Int32 PurchaseId { get; set; }
        public Int32 InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Int32 SupplierId { get; set; }
        public Int32 PaymentId { get; set; }
        public decimal TotalCGST { get; set; }
        public decimal TotalSGST { get; set; }
        public decimal TotalIGST { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Other { get; set; }
        public decimal GrandTotal { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }
        List<PurchaseBillDetails> PurchaseList { get; set; }

    }
}
