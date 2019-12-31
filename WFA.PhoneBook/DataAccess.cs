using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WFA.PhoneBook
{
    class DataAccess
    {
        public static int ID = 0;
        private static SqlConnection sqlcon;
        public static SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private static SqlCommand sqlcom;
        public static SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static SqlDataAdapter sda;
        public static SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;
        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            Sqlcon = new SqlConnection(@"Data Source=DESKTOP-MA2HO1K\SQLEXPRESS;Initial Catalog=PhoneBookDB;Persist Security Info=True;User ID=sa;Password=P@$$w0rd");
            Sqlcon.Open();
            ID = SearchMaxID();
            
        }

        public static int SearchMaxID()
        {
            string sql = @"select MAX(id) as id from contacts;";
            DataSet ds = ExecuteQuery(sql);
            try
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            }
            catch
            {

            }
            return 0;

        }

        private static void QueryText(string query)
        {
            Sqlcom = new SqlCommand(query, Sqlcon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }

        public static int ExecuteUpdateQuery(string sql)
        {
            QueryText(sql);
            int u = Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
