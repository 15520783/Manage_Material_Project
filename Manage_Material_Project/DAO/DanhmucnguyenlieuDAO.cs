using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class DanhmucnguyenlieuDAO
    {
        private static DanhmucnguyenlieuDAO _instance;
        public static DanhmucnguyenlieuDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DanhmucnguyenlieuDAO();
                }
                return _instance;
            }
        }

        public DataTable Hienthitatcanguyenlieu()
        {
            string query = "SELECT * FROM DANHMUCNGUYENLIEU";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int Getmanguyenlieumoinhat()
        {
            string query = "SELECT COUNT(*) FROM DANHMUCNGUYENLIEU";
            return (int)DataProvider.Instance.ExecuteScalar(query) + 100000001;
        }

        public int Themnguyenlieu(int manguyenlieu,string tennguyenlieu, string donvitinh)
        {
            string query = "INSERT INTO DANHMUCNGUYENLIEU VALUES (" + "'" + manguyenlieu + "',N'" + tennguyenlieu + "','" + donvitinh + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable Timkiemnguyenlieu (string tennguyenlieu)
        {
            string query = "SELECT * FROM DANHMUCNGUYENLIEU WHERE tennguyenlieu like N'%" + tennguyenlieu + "%'";
            return DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
