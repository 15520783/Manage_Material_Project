using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class DanhmucnguyenlieuBUS
    {
        private static DanhmucnguyenlieuBUS _instance;
        public static DanhmucnguyenlieuBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DanhmucnguyenlieuBUS();
                }
                return _instance;
            }
        }

        public DataTable _Hienthitatcanguyenlieu()
        {
            return DanhmucnguyenlieuDAO.Instance.Hienthitatcanguyenlieu();
        }

        public int _Getmanguyenlieumoinhat()
        {
            return DanhmucnguyenlieuDAO.Instance.Getmanguyenlieumoinhat();
        }

        public int _Themnguyenlieu(int manguyenlieu,string tennguyenlieu, string donvitinh)
        {
            return DanhmucnguyenlieuDAO.Instance.Themnguyenlieu(manguyenlieu,tennguyenlieu, donvitinh);
        }

        public DataTable _Timkiemnguyenlieu(string tennguyenlieu)
        {
            return DanhmucnguyenlieuDAO.Instance.Timkiemnguyenlieu(tennguyenlieu);
        }
    }
}
