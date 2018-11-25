using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class NguyenlieuDAO
    {
        private static NguyenlieuDAO _instance;
        public static NguyenlieuDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NguyenlieuDAO();
                }
                return _instance;
            }
        }

        public DataTable Hienthitatcanguyenlieu()
        {
            string query = "SELECT * FROM NGUYENLIEU";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int Getmanguyenlieumoinhat()
        {
            string query = "SELECT COUNT(*) FROM NGUYENLIEU";
            return (int)DataProvider.Instance.ExecuteScalar(query) + 100000001;
        }

        public int Themnguyenlieu(int manguyenlieu,string tennguyenlieu, string donvitinh)
        {
            string query = "INSERT INTO NGUYENLIEU VALUES (" + "'" + manguyenlieu + "',N'" + tennguyenlieu + "','" + donvitinh + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
