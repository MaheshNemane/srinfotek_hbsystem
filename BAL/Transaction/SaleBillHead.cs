using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class SaleBillHead
    {
        public Int32 Id { get; set; }
        public Int32 BillId { get; set; }
        public Int32 ItemId { get; set; }
        public Int32 CategoryId { get; set; }
        public Int32 SubCategoryId { get; set; }
        public Int32 Qty { get; set; }
        public Int32 UOMId { get; set; }
        public decimal Price { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        public decimal IGST { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}
