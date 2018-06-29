using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
    public class GSTMaster
    {
        public Int32 GSTId { get; set; }
        public Decimal GST { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertGST(GSTMaster GST)
        {
            return Common.putData(GST, "sp_GST");
        }

        public string updateGST(GSTMaster GST)
        {
            return Common.putData(GST, "sp_GST");
        }

        public string deleteGST(GSTMaster GST)
        {
            return Common.putData(GST, "sp_GST");
        }

        public GSTMaster getGST(int GSTId)
        {
            this.GSTId = GSTId;
            this.cmd = "getGST";
            return fillGSTInfo(Common.getData(this, "sp_GST"));
        }


        public DataSet getAllGST()
        {
            this.cmd = "getAllGST";
            return Common.getData(this, "sp_GST");
        }

        public DataSet getAllGSTCmb()
        {
            this.cmd = "getAllGSTCmb";
            return Common.getData(this,"sp_GST");
        }

        private GSTMaster fillGSTInfo(DataSet ds)
        {
            if (!Common.isDataSetEmpty(ds))
            {
                this.GSTId = Convert.ToInt32(ds.Tables[0].Rows[0]["GSTId"]);
                this.GST = Convert.ToDecimal(ds.Tables[0].Rows[0]["GST"]);
                this.Status = ds.Tables[0].Rows[0]["Status"].ToString();               
            }
            return this;
        }

    }
}
