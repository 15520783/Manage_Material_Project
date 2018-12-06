using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DTO;

namespace Manage_Material_Project.DAO
{
    class PhieuDAO
    {
        private static PhieuDAO _instance;
        public static PhieuDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhieuDAO();
                }
                return _instance;
            }
        }

        public string Getsohoadonmoinhat(int loaiphieu)
        {
            string query = "SELECT COUNT(*) FROM PHIEU WHERE loaiphieu = " + loaiphieu;
            int stt = (int)DataProvider.Instance.ExecuteScalar(query) + 1;
            string s = stt.ToString().PadLeft(5, '0');
            if (loaiphieu == 1)
                return "NNLC" + s;
            else
            if (loaiphieu == 2)

                return "BNLC" + s;
            else return "XNLC" + s;
        }

        public int Themhoadongiaodich(Phieu hoadon)
        {
            string query = "INSERT INTO PHIEU VALUES ('" + hoadon.pso + "','" + hoadon.ngayphathanh + "','"
                + hoadon.ngaythanhtoan + "',N'" + hoadon.hinhthucthanhtoan + "',N'" + hoadon.lydo + "'," + hoadon.thuesuat + "," + hoadon.tongtien + ",'"
                + hoadon.taikhoanchinh + "'," + hoadon.makho + ",'" + hoadon.quyen + "'," + hoadon.makh + ",'" + hoadon.ngayban + "'," + hoadon.tongthueGTGT +","+hoadon.loaiHD+ ", "+hoadon.sohd+")";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int Xoaphieubypso(string pso)
        {
            string query = "DELETE FROM PHIEU WHERE pso = " + pso;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

      
        
    }
}
