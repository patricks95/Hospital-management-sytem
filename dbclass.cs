using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Early_Intervention_of_childhood
{
    public class dbclass
    {
        public static string MainConStr = ConfigurationManager.ConnectionStrings["DBCS"].ToString();

        public SqlConnection con = new SqlConnection();

        string returnValue = "";

        public void DBConnect()
        {
            try
            {
                con = new SqlConnection(MainConStr);
                con.Open();
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
        }



        public bool ExecNonQuerry(string sqlstr)
        {
            DBConnect();
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public DataSet getDS(string strqry)
        {
            DBConnect();
            SqlTransaction trans = con.BeginTransaction(IsolationLevel.ReadUncommitted);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(strqry, con, trans);
            da.Fill(ds);
            da.Dispose();
            DBClose();
            return ds;
        }


        public DataSet getDS(DataSet ds, string strqry, string tblName)
        {
            DBConnect();
            SqlTransaction trans = con.BeginTransaction(IsolationLevel.ReadUncommitted);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(strqry, con, trans);
            da.Fill(ds, tblName);
            da.Dispose();
            trans.Dispose();
            DBClose();
            return ds;
        }


        public SqlCommand GetCommand(string sqlstr)
        {
            SqlCommand com;
            com = new SqlCommand(sqlstr, con);
            return com;
        }

        public void DBClose()
        {
            con.Dispose();
            con.Close();
        }


       

        public string ExecuteScalar(string strSql)
        {
            DBConnect();
            SqlCommand cmd = new SqlCommand(strSql, con);
            try
            {
                returnValue = cmd.ExecuteScalar().ToString();
                cmd.Dispose();
                DBClose();
            }
            catch (Exception)
            {
                cmd.Dispose();
                DBClose();
            }
            return returnValue;
        }













    }
}
