using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class HotelExpenseCategoryMaster
    {
        public Int32 CategoryId{ get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertHotelExpenseCategory(HotelExpenseCategoryMaster expenseMaster)
        {
            return Common.putData(expenseMaster, "sp_HotelExpenseCategory");
        }


        public string updateHotelExpenseCategory(HotelExpenseCategoryMaster expenseMaster)
        {
            return Common.putData(expenseMaster, "sp_HotelExpenseCategory");
        }

        public string deleteHotelExpenseCategory(HotelExpenseCategoryMaster expenseMaster)
        {
            return Common.putData(expenseMaster, "sp_HotelExpenseCategory");
        }

        public DataSet getHotelExpenseCategory(Int32 CategoryId)
        {
            this.CategoryId = CategoryId;
            this.cmd = "getHotelExpenseCategory";
            return Common.getData(this, "sp_HotelExpenseCategory");
        }


        public DataSet getAllHotelExpenseCategory()
        {
            this.cmd = "getAllHotelExpenseCategory";
            return Common.getData(this, "sp_HotelExpenseCategory");
        }

        public DataSet getAllHotelExpenseCategoryCmb()
        {
            this.cmd = "getAllHotelExpenseCategoryCmb";
            return Common.getData(this, spname: "sp_HotelExpenseCategory");
        }
    }
}
