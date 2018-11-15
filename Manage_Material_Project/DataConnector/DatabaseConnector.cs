using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DataSource
{
    class DatabaseConnector
    {
        private const string connectionString = "Server=tcp:dbwp.database.windows.net,1433;Initial Catalog=db;Persist Security Info=False;User ID=dbwp@dbwp;Password=Dev11111111;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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

        private DataTable Getdata(string QuerrySQL)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = QuerrySQL;
            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Disconnect();
            return dt;
        }
    }

}
