using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class KhachhangDAO
    {
        private static KhachhangDAO _instance;
        public static KhachhangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachhangDAO();
                }
                return _instance;
            }
        }

        public DataTable Hienthitatcakhachhang()
        {
            string query = "SELECT * FROM KHACHHANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetthongtinKHbyMaKH(int makh)
        {
            string query = "SELECT KH.*,TK.sotaikhoan FROM KHACHHANG KH ,TAIKHOANNGANHANG TK WHERE KH.makh = @makh AND KH.makh = TK.makh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { makh });
        }
    }
}
