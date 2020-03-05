using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DbConnection
    {
        //string sqlcon = ConfigurationManager.ConnectionStrings["assignmentDB"].ConnectionString;
        //SqlConnection conn = new SqlConnection();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["assignmentDB"].ConnectionString);
        public SqlConnection getCon()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getCon();
            int rowsAffected = -1;
            rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;
        }

        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getCon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            conn.Close();
            return obj;
        }
        
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getCon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            return dt;
        }
        public SqlConnection closeCon()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
        
    }
}
