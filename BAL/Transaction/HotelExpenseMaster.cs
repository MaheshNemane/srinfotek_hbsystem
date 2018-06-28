using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
     public class HotelExpenseMaster
    {
        public int HotelExpenseId { get; set; }
        public DateTime Date { get; set; }
        public Int32 CategoryId { get; set; }
        public Int32 SubCategoryId { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
        public Int32 PayModeId { get; set; }
        public string BankName { get; set; }
        public string ChequeNo { get; set; }
        public DateTime ChequeDate { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertHotelExpense(HotelExpenseMaster hotelExpenseMaster)
        {
            return Common.putData(hotelExpenseMaster, "sp_HotelExpense");
        }

        public string updateHotelExpense(HotelExpenseMaster hotelExpenseMaster)
        {
            return Common.putData(hotelExpenseMaster, "sp_HotelExpense");
        }

        public string deleteHotelExpense(HotelExpenseMaster hotelExpenseMaster)
        {
            return Common.putData(hotelExpenseMaster, "sp_HotelExpense");
        }

        public DataSet getHotelExpense(int HotelExpenseId)
        {
            this.HotelExpenseId = HotelExpenseId;
            this.cmd = "getHotelExpense";
            return Common.getData(this, "sp_HotelExpense");
        }


        public DataSet getAllHotelExpense()
        {
            this.cmd = "getAllHotelExpense";
            return Common.getData(this, "sp_HotelExpense");
        }

        public DataSet getAllHotelExpenseCmb()
        {
            this.cmd = "getAllHotelExpenseCmb";
            return Common.getData(this, spname: "sp_HotelExpense");
        }
    }
}
