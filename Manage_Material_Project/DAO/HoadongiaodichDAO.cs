using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DTO;

namespace Manage_Material_Project.DAO
{
    class HoadongiaodichDAO
    {
        private static HoadongiaodichDAO _instance;
        public static HoadongiaodichDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HoadongiaodichDAO();
                }
                return _instance;
            }
        }

        public int Getsohoadonmoinhat()
        {
            string query = "SELECT COUNT(*) FROM HOADONGIAODICH";
            return (int)DataProvider.Instance.ExecuteScalar(query) + 1;
        }

        public int Themhoadongiaodich(Hoadongiaodich hoadon)
        {
            string query = "INSERT INTO HOADONGIAODICH VALUES (" + hoadon.sohd + ",'" + hoadon.ngayphathanh + "','"
                + hoadon.ngaythanhtoan + "',N'" + hoadon.hinhthucthanhtoan + "',N'" + hoadon.lydo + "'," + hoadon.thuesuat + "," + hoadon.tongtien + ",'"
                + hoadon.taikhoanchinh + "'," + hoadon.makho + ",'" + hoadon.quyen + "'," + hoadon.makh + ",'" + hoadon.ngayban + "'," + hoadon.tongthueGTGT +","+hoadon.loaiHD+ ")";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
