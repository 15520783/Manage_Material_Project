using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DTO;

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

        public int Themchitietgiaodich(Nguyenlieu chitietgiaodich)
        {
            string query = "INSERT INTO NGUYENLIEU VALUES ('" + chitietgiaodich.pso + "'," + chitietgiaodich.manl + "," + chitietgiaodich.soluong + "," + chitietgiaodich.dongia + ","+chitietgiaodich.thanhtien+",'" + chitietgiaodich.taikhoandu + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int Xoachitietgiaodich(string pso)
        {
            string query = "DELETE FROM NGUYENLIEU WHERE pso = " + pso;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
