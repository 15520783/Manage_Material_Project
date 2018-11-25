using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class TaikhoanketoanDAO
    {
        private static TaikhoanketoanDAO _instance;
        public static TaikhoanketoanDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaikhoanketoanDAO();
                }
                return _instance;
            }
        }

        public DataTable Laythongtintaikhoan(string mataikhoan)
        {
            string query = "SELECT * FROM TAIKHOANKETOAN WHERE mataikhoan = @mataikhoan";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { mataikhoan });
        }
    }
}
