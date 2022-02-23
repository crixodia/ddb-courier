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
        private string DataSource { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        private string InitialCatalog { get; set; }

        public SqlConnection SqlCon;
        public Connection(string datSource, string user, string password, string initialCatalog)
        {
            DataSource = datSource;
            User = user;
            Password = password;
            InitialCatalog = initialCatalog;
            ConnectTo();
        }

        private void ConnectTo()
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

        public DataTable Query(string queryString)
        {
            SqlCommand cmd = new SqlCommand(queryString, SqlCon);
            DataTable dt = new DataTable();

            SqlCon.Open();
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public void Close()
        {
            SqlCon.Close();
        }

    }
}
