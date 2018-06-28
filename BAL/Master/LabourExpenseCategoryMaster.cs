using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
     public class LabourExpenseCategoryMaster
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string cmd { get; set; }

        public string insertLabourExpenseCategory(LabourExpenseCategoryMaster labourExpenseCategoryMaster)
        {
            return Common.putData(labourExpenseCategoryMaster, "sp_LabourExpenseCategory");
        }
        public string deleteLabourExpenseCategory(LabourExpenseCategoryMaster labourExpenseCategoryMaster)
        {
            return Common.putData(labourExpenseCategoryMaster, "sp_LabourExpenseCategory");
        }
        public string updateLabourExpenseCategory(LabourExpenseCategoryMaster labourExpenseCategoryMaster)
        {
            return Common.putData(labourExpenseCategoryMaster, "sp_LabourExpenseCategory");
        }
        public DataSet getLabourExpenseCategory(Int32 CategoryId)
        {
            this.CategoryId = CategoryId;
            this.cmd = "getLabourExpenseCategory";
            return Common.getData(this, "sp_LabourExpenseCategory");
        }
        public DataSet getAllLabourExpenseCategory()
        {
            this.cmd = "getAllLabourExpenseCategory";
            return Common.getData(this, "sp_LabourExpenseCategory");
        }
        public DataSet getAllLabourExpenseCategoryCmb()
        {
            this.cmd = "getAllLabourExpenseCategoryCmb";
            return Common.getData(this, "sp_LabourExpenseCategory");
        }
    }
}
