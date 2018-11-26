using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DTO;

namespace Manage_Material_Project.DAO
{
    class ChitietgiaodichDAO
    {
        private static ChitietgiaodichDAO _instance;
        public static ChitietgiaodichDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChitietgiaodichDAO();
                }
                return _instance;
            }
        }

        public int Themchitietgiaodich(Chitietgiaodich chitietgiaodich)
        {
            string query = "INSERT INTO CHITIETGIAODICH VALUES (" + chitietgiaodich.sohd + "," + chitietgiaodich.manl + "," + chitietgiaodich.soluong + "," + chitietgiaodich.dongia + ","+chitietgiaodich.thanhtien+",'" + chitietgiaodich.taikhoandu + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
