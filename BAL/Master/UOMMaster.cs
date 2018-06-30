using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class UOMMaster
    {
        public Int32 UOMId { get; set; }
        public string UOMName { get; set; }
        public string Unit { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertUOM(UOMMaster UOM)
        {
            return Common.putData(UOM, "sp_UOM");
        }

        public string updateUOM(UOMMaster UOM)
        {
            return Common.putData(UOM, "sp_UOM");
        }

        public string deleteUOM(UOMMaster UOM)
        {
            return Common.putData(UOM, "sp_UOM");
        }

        public UOMMaster getUOM(int UOMId)
        {
            this.UOMId = UOMId;
            this.cmd = "getUOM";
            return fillUOMInfo(Common.getData(this, "sp_UOM"));
        }


        public DataSet getAllUOM()
        {
            this.cmd = "getAllUOM";
            return Common.getData(this, "sp_UOM");
        }

        public DataSet getAllUOMCmb()
        {
            this.cmd = "getAllUOMCmb";
            return Common.getData(this, "sp_UOM");
        }

        private UOMMaster fillUOMInfo(DataSet ds)
        {
            if (!Common.isDataSetEmpty(ds))
            {
                this.UOMId = Convert.ToInt32(ds.Tables[0].Rows[0]["UOMId"]);
                this.UOMName = ds.Tables[0].Rows[0]["UOMName"].ToString();
                this.Unit = ds.Tables[0].Rows[0]["Unit"].ToString();
                this.Status = ds.Tables[0].Rows[0]["Status"].ToString();
            }
            return this;
        }
    }
}
