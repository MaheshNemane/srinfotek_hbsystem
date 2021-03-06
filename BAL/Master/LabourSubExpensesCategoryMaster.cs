﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
   public class LabourSubExpensesCategoryMaster
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string cmd { get; set; }


        public string insertLabourSubExpenseCategory(LabourSubExpensesCategoryMaster labourSubExpenseCategoryMaster)
        {
            return Common.putData(labourSubExpenseCategoryMaster, "sp_LabourSubExpenseCategory");
        }
        public string deleteLabourSubExpenseCategory(LabourSubExpensesCategoryMaster labourSubExpenseCategoryMaster)
        {
            return Common.putData(labourSubExpenseCategoryMaster, "sp_LabourSubExpenseCategory");
        }
        public string updateLaboursubExpenseCategory(LabourSubExpensesCategoryMaster labourSubExpenseCategoryMaster)
        {
            return Common.putData(labourSubExpenseCategoryMaster, "sp_LabourSubExpenseCategory");
        }
        public DataSet getLabourSubExpenseCategory(Int32 SubCategoryId)
        {
            this.SubCategoryId = SubCategoryId;
            this.cmd = "getLaboursubExpenseCategory";
            return Common.getData(this, "sp_LabourSubExpenseCategory");
            fillLabourSubExpenseCategoryInfo(Common.getData(this, "sp_LabourExpenseCategory"));
            return this;
        }
        public DataSet getAllLabourSubExpenseCategory()
        {
            this.cmd = "getAllLabourSubExpenseCategory";
            return Common.getData(this, "sp_LabourSubExpenseCategory");
        }
        public DataSet getAllLabourSubExpenseCategoryCmb()
        {
            this.cmd = "getAllLabourSubExpenseCategoryCmb";
            return Common.getData(this, "sp_LabourSubExpenseCategory");
        }
        public DataSet getAllLabourSubExpenseCategoryCmb(Int32 CategoryId)
        {
            this.CategoryId = CategoryId;
            this.cmd = "getAllLabourSubExpenseCategoryCmb";
            return Common.getData(this, "sp_LabourSubExpenseCategory");
        }
        private LabourSubExpensesCategoryMaster fillLabourSubExpensesCategoryInfo(DataSet ds)
        {
            if (!Common.isDataSetEmpty(ds))
            {
                this.SubCategoryId = Convert.ToInt32(ds.Tables[0].Rows[0]["SubCategoryId"]);
                this.CategoryId = Convert.ToInt32(ds.Tables[0].Rows[0]["CategoryId"]);
                this.SubCategoryName = ds.Tables[0].Rows[0]["SubCategoryName"].ToString();

            }
            return this;
        }

    }
}
