using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DBConnection
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ConnectionString);

        public DataSet ExecuteQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataSet ExecuteProcedure(string SpName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SpName;
                cmd.Connection = con;
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public DataSet ExecuteProcedure(string SpName, string xml)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SpName;
                cmd.Parameters.AddWithValue("@xmltext", xml);
                cmd.Connection = con;
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
