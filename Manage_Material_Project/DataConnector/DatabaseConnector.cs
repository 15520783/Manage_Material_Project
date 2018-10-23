using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DataSource
{
    class DatabaseConnector
    {
        private const string connectionString = "someone";

        SqlConnection conn;


        public void Connect()
        {
            this.conn = new SqlConnection(connectionString);
            this.conn.Open();
        }

        public void Disconnect()
        {
            this.conn.Close();
        }
    }

}
