using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Service.Service;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace Service.Data
{
    public class Global : System.Web.HttpApplication
    {
        public static DataSet dtSet = new DataSet();
        public static DataTable dtTable = new DataTable();
        public static DataRow dtRow;
        public static DataRow[] dtRows;
        public static String sql;
        public static SqlCommand cmd;
        public static SqlDataAdapter dtAdapter;
        public static XmlDocument xdoc = new XmlDocument();
        public static String con = ConfigurationManager.ConnectionStrings["koneksi"].ConnectionString;
        public static SqlConnection konek = new SqlConnection(con);

        public static DataSet Get_dtSet(string sql)
        {
            try
            {
                konek = new SqlConnection(con);
                konek.Open();
                cmd = new SqlCommand(sql, konek);
                dtAdapter = new SqlDataAdapter(cmd);
                DataSet dtSet = new DataSet();
                dtAdapter.Fill(dtSet);
                return dtSet;
            }
            catch
            {
                throw;
            }
            finally
            {
                konek.Close();
            }
        }

        public static DataTable get_dtTable(string sql)
        {
            try
            {
                konek = new SqlConnection(con);
                konek.Open();
                cmd = new SqlCommand(sql, konek);
                dtAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtAdapter.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                konek.Close();
            }
        }

        public static Boolean ExecQuery(string sql)
        {
            try
            {
                konek.Open();
                cmd = new SqlCommand(sql, konek);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                konek.Close();
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            //Jadwal.Start();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}