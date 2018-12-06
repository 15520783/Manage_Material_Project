using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class KhoDAO
    {
        private static KhoDAO _instance;
        public static KhoDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhoDAO();
                }
                return _instance;
            }
        }

        public DataTable Hienthitatcakho()
        {
            string query = "SELECT * FROM KHO";
            return DataProvider.Instance.ExecuteQuery(query);
        }

       
    }
}
