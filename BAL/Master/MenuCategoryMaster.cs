using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class MenuCategoryMaster
    {
        public string CategoryName { get; set; }
        public string cmd { get; set; }

        public string insertMenuCategory(MenuCategoryMaster menuCategoryMaster)
        {
            return Common.putData(menuCategoryMaster, "sp_MenuCategory");
        }

        public DataSet getMenuCategory()
        {
            this.cmd = "getMenuCategory";
            return Common.getData(this, "sp_MenuCategory");
        }

        public DataSet getAllMenuCategory()
        {
            this.cmd = "getAllMenuCategory";
            return Common.getData(this, "sp_MenuCategory");
        }

        public DataSet getAllMenuCategoryCmb()
        {
            this.cmd = "getAllMenuCategoryCmb";
            return Common.getData(this, "sp_MenuCategory");
        }

    }
}
