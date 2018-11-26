using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class NguyenlieuBUS
    {
        private static NguyenlieuBUS _instance;
        public static NguyenlieuBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NguyenlieuBUS();
                }
                return _instance;
            }
        }

        public DataTable _Hienthitatcanguyenlieu()
        {
            return NguyenlieuDAO.Instance.Hienthitatcanguyenlieu();
        }

        public int _Getmanguyenlieumoinhat()
        {
            return NguyenlieuDAO.Instance.Getmanguyenlieumoinhat();
        }

        public int _Themnguyenlieu(int manguyenlieu,string tennguyenlieu, string donvitinh)
        {
            return NguyenlieuDAO.Instance.Themnguyenlieu(manguyenlieu,tennguyenlieu, donvitinh);
        }

        public DataTable _Timkiemnguyenlieu(string tennguyenlieu)
        {
            return NguyenlieuDAO.Instance.Timkiemnguyenlieu(tennguyenlieu);
        }
    }
}
