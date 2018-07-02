using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class MaterialCategoryMaster
    {
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertMaterialCategory(MaterialCategoryMaster materialCategoryMaster)
        {
            return Common.putData(materialCategoryMaster, "sp_MenuCategory");
        }

        public DataSet getMaterialCategory()
        {
            this.cmd = "getMenuCategory";
            return Common.getData(this, "sp_MaterialCategory");
            fillMaterialCategoryInfo(Common.getData(this, "sp_MaterialCategory"));
        }

        public DataSet getAllMaterialCategory()
        {
            this.cmd = "getAllMenuCategory";
            return Common.getData(this, "sp_MaterialCategory");
        }

        public DataSet getAllMaterialCategoryCmb()
        {
            this.cmd = "getAllMaterialCategoryCmb";
            return Common.getData(this, "sp_MaterialCategory");
        }
    }
    private MaterialCategoryMaster fillMaterialCategoryInfo(DataSet ds)
    {
        if (!Common.isDataSetEmpty(ds))
        {
            
            this.CategoryName = ds.Tables[0].Rows[0]["CategoryName"].ToString();

        }
        return this;
    }
}
