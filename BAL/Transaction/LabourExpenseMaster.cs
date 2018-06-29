using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
     public class LabourExpenseMaster
    {
        public int LabourExpenseId { get; set; }
        public DateTime Date { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 CategoryId { get; set; }
        public Int32 SubCategoryId { get; set; }
        public Double Amount { get; set; }
        public string Note { get; set; }
        public Int32 PaymentId { get; set; }
        public string BankName { get; set; }
        public string ChequeNo { get; set; }
        public DateTime ChequeDate { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertLabourExpense(LabourExpenseMaster labourExpenseMaster)
        {
            return Common.putData(labourExpenseMaster, "sp_LabourExpense");
        }

        public string updateLabourExpense(LabourExpenseMaster labourExpenseMaster)
        {
            return Common.putData(labourExpenseMaster, "sp_LabourExpense");
        }

        public string deleteLabourExpense(LabourExpenseMaster labourExpenseMaster)
        {
            return Common.putData(labourExpenseMaster, "sp_LabourExpense");
        }

        public DataSet getLabourExpense(int LabourExpenseId)
        {
            this.Date = this.ChequeDate = DateTime.Now;
            this.LabourExpenseId = LabourExpenseId;
            this.cmd = "getLabourExpense";
            return Common.getData(this, "sp_LabourExpense");
        }


        public DataSet getAllLabourExpense()
        {
            this.Date = this.ChequeDate = DateTime.Now;
            this.cmd = "getAllLabourExpense";
            return Common.getData(this, "sp_LabourExpense");
        }

    }
}
