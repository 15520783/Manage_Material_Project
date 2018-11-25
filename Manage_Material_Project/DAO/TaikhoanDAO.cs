using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class TaikhoanDAO
    {
        private static TaikhoanDAO _instance;
        public static TaikhoanDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaikhoanDAO();
                }
                return _instance;
            }
        }

        public bool Kiemtrataikhoan(string mataikhoan, string matkhau)
        {
            var dt = new DataTable();
            string query = "SELECT * FROM TAIKHOAN WHERE matk = @mataikhoan AND matkhau = @matkhau";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { mataikhoan, matkhau });
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
