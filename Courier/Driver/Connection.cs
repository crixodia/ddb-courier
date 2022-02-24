using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Courier.Driver
{
    class Connection
    {
        private static string DataSource { get; set; }
        private static string User { get; set; }
        private static string Password { get; set; }
        private static string InitialCatalog { get; set; }

        public static SqlConnection SqlCon;
        public static void ConnectionConfig(string datSource, string user, string password, string initialCatalog)
        {
            DataSource = datSource;
            User = user;
            Password = password;
            InitialCatalog = initialCatalog;
            ConnectTo();
        }

        private static void ConnectTo()
        {
            string ConString = String.Format(
                "Data Source ={0};Initial Catalog={1};user id={2};password={3};Persist Security Info=true",
                DataSource,
                InitialCatalog,
                User,
                Password
            );

            SqlCon = new SqlConnection(ConString);
        }

        public static DataTable Query(string queryString)
        {
            SqlCommand cmd = new SqlCommand(queryString, SqlCon);
            DataTable dt = new DataTable();

            SqlCon.Open();
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public static int CrudNonReader(string queryString)
        {
            SqlCommand cmd = new SqlCommand(queryString, SqlCon);
            SqlCon.Open();

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        public static void Close()
        {
            SqlCon.Close();
        }

    }
}
