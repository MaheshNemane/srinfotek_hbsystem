using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class PurchaseBillDetails
    {

        public Int32 Id { get; set; }
        public Int32 PurchaseId { get; set; }
        public Int32 CategoryId { get; set; }
        public Int32 SubCategoryId { get; set; }
        public Int32 ItemId { get; set; }
        public Double Qty{ get; set; }
        public Double Price { get; set; }
        public String Unit { get; set; }
        public decimal TotalCGST { get; set; }
        public decimal TotalSGST { get; set; }
        public decimal TotalIGST { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        
    }
}
