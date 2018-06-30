using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class Stock
    {
        public int StockId { get; set; }
        public DateTime Date { get; set; }
        public int Qty { get; set; }
        public int UOMId { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public string Status { get; set; }


    }
}
