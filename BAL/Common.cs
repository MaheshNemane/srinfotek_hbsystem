using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BAL
{
    public static class Common
    {
        public static string toXML(object obj)
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(stringwriter, obj);
            return stringwriter.ToString();
        }

        public static string putData(object obj, string spname)
        {
            try
            {
                string xml = toXML(obj);
                DBConnection con = new DBConnection();
                DataSet ds = con.ExecuteProcedure(spname, xml);
                return notificationMsg(ds);
            }
            catch (Exception ex)
            {
                DataSet ds = null;
                return notificationMsg(ds);
            }
        }

        public static DataSet getData(object obj, string spname)
        {
            try
            {
                string xml = toXML(obj);
                DBConnection con = new DBConnection();
                DataSet ds = con.ExecuteProcedure(spname, xml);
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static bool isDataSetEmpty(DataSet ds)
        {
            bool rval = true;
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    rval = false;
                }
                else
                {
                    rval = true ;
                }
            }
            return rval;
        }

        public static string notificationMsg(DataSet ds)
        {
            if (isDataSetEmpty(ds))
            {
                return "Error";
            }
            else {
                return ds.Tables[0].Rows[0][1].ToString();
            }            
        }

    }
}
