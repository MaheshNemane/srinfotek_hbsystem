using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class Expenses
    {
        public DateTime Date { get; set; }
        public string ExpensesType { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        public string Paymode { get; set; }
        public string BankName { get; set; }
        public int ChaqueNo { get; set; }
        public DateTime ChaqueDate { get; set; }
        public string Status { get; set; }
    }
}
