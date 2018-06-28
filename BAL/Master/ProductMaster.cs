using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class ProductMaster
    {
        public int ProductId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public double Price { get; set; }
        public double WaiterMargin { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertProduct(ProductMaster productMaster)
        {
            return Common.putData(productMaster, "sp_Product");
        }

        public ProductMaster getProduct(Int32 ProductId)
        {
            this.ProductId = ProductId;
            this.cmd = "getProduct";           
            DataSet ds= Common.getData(this, "sp_Product");
            fillProduct(ds);
            return this;
        }

        public ProductMaster getProduct(string ItemCode)
        {
            this.ItemCode = ItemCode;
            this.cmd = "getProductByItemCode";
            DataSet ds = Common.getData(this, "sp_Product");
            fillProduct(ds);
            return this;
        }

        public DataSet getAllProduct()
        {
            this.cmd = "getAllProduct";
            return Common.getData(this, "sp_Product");
        }       

        public DataSet getAllProductCmb(Int32 CategoryId,Int32 SubCategoryId)
        {
            this.cmd = "getAllProductCmb";
            this.CategoryId = CategoryId;
            this.SubCategoryId = SubCategoryId;
            return Common.getData(this, "sp_Product");
        }


        private void fillProduct(DataSet ds)
        {
            if (Common.isDataSetEmpty(ds))
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        this.CategoryId = Convert.ToInt32(ds.Tables[0].Rows[0]["CategoryId"]);
                        this.SubCategoryId = Convert.ToInt32(ds.Tables[0].Rows[0]["SubCategoryId"]);
                        this.ProductId = Convert.ToInt32(ds.Tables[0].Rows[0]["ProductId"]);
                        this.ItemCode = ds.Tables[0].Rows[0]["ItemCode"].ToString();
                        this.ItemName = ds.Tables[0].Rows[0]["ItemName"].ToString();
                        this.Price = Convert.ToDouble(ds.Tables[0].Rows[0]["Price"].ToString());
                        this.WaiterMargin = Convert.ToDouble(ds.Tables[0].Rows[0]["WaiterMargin"].ToString());
                        this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                        this.cmd = "";
                    }
                }
            }            
        }
    }
}
