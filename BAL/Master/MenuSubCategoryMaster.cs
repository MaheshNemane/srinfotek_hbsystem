using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class MenuSubCategoryMaster
    {
        public Int32 SubCategoryId { get; set; }
        public Int32 CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string Status { get; set; }

        public string cmd { get; set; }

        public string insertMenuSubCategory(MenuSubCategoryMaster menuSubCategoryMaster)
        {
            return Common.putData(menuSubCategoryMaster, "sp_SubMenuCategory");
        }

        public DataSet getMenuSubCategory()
        {
            try
            {
                this.cmd = "getMenuSubCategory";
                return Common.getData(this, "sp_SubMenuCategory");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet getAllMenuSubCategory()
        {
            try
            {
                this.cmd = "getAllMenuSubCategory";
                return Common.getData(this, "sp_SubMenuCategory");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet getAllMenuSubCategoryCmb()
        {
            try
            {
                this.cmd = "getAllMenuSubCategoryCmb";
                return Common.getData(this, "sp_SubMenuCategory");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet getAllMenuSubCategoryCmb(Int32 CategoryId)
        {
            try
            {
                this.CategoryId = CategoryId;
                this.cmd = "getAllMenuSubCategoryCmb";
                return Common.getData(this, "sp_SubMenuCategory");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
