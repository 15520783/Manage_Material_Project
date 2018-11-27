using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Manage_Material_Project.DAO
{
    class DataProvider
    {
        private const string connectionString = "Server=tcp:dbwp.database.windows.net,1433;Initial Catalog=db;Persist Security Info=False;User ID=dbwp@dbwp;Password=Dev11111111;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataProvider();
                }
                return _instance;
            }
        }

        public DataProvider() { }
        //SqlConnection conn;


        /* public void Connect()
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
         }*/

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    var parameterList = query.Split();
                    var index = 0;

                    foreach (var param in parameterList)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameters[index]);
                            index++;
                        }
                    }
                }

                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

            return dataTable;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            var result = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    var parameterList = query.Split();
                    var index = 0;

                    foreach (var param in parameterList)
                    {
                        if (!param.Contains("@")) continue;
                        cmd.Parameters.AddWithValue(param, parameters[index]);
                        index++;
                    }
                }

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch
                {
                    return 0;
                }

                connection.Close();
            }

            return result;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object result = null;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    var parameterList = query.Split();
                    var index = 0;

                    foreach (var param in parameterList)
                    {
                        if (!param.Contains("@")) continue;
                        cmd.Parameters.AddWithValue(param, parameters[index]);
                        index++;
                    }
                }
                result = cmd.ExecuteScalar();
                connection.Close();
            }

            return result;
        }
    }
}
