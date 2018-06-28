using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
     public class HotelSubExpenseCatergoryMaster
    {

        public Int32 SubCategoryId { get; set; }
        public Int32 CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string Status { get; set; }

        public string cmd { get; set; }
               
        public string insertHotelSubExpenseCategory(HotelSubExpenseCatergoryMaster subExpenseMaster)
        {
            return Common.putData(subExpenseMaster, "sp_HotelSubExpense");
        }


        public string updateHotelSubExpenseCategory(HotelSubExpenseCatergoryMaster subExpenseMaster)
        {
            return Common.putData(subExpenseMaster, "sp_HotelSubExpense");
        }

        public string deleteHotelSubExpenseCategory(HotelSubExpenseCatergoryMaster subExpenseMaster)
        {
            return Common.putData(subExpenseMaster, "sp_HotelSubExpense");
        }


        public DataSet getHotelSubExpenseCategory(Int32 SubCategoryId)
        {
            this.SubCategoryId = SubCategoryId;
            this.cmd = "getHotelSubExpenseCategory";
            return Common.getData(this, "sp_HotelSubExpense");
        }


        public DataSet getAllHotelSubExpenseCategory()
        {
            this.cmd = "getAllHotelSubExpenseCategory";
            return Common.getData(this, "sp_HotelSubExpense");
        }

        public DataSet getAllHotelSubExpenseCategoryCmb()
        {
            this.cmd = "getAllHotelSubExpenseCategoryCmb";
            return Common.getData(this, "sp_HotelSubExpense");
        }
    }
}
