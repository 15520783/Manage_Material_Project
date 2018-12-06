using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DAO;
using Manage_Material_Project.DTO;

namespace Manage_Material_Project.BLL
{
    class PhieuBUS
    {
        private static PhieuBUS _instance;
        public static PhieuBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhieuBUS();
                }
                return _instance;
            }
        }

        public string _Getsohoadonmoinhat(int loaiphieu)
        {
            return PhieuDAO.Instance.Getsohoadonmoinhat(loaiphieu);
        }
        public int _Themhoadongiaodich(Phieu hoadon)
        {
            return PhieuDAO.Instance.Themhoadongiaodich(hoadon);
        }
        public int _Xoaphieubypso(string pso)
        {
            return PhieuDAO.Instance.Xoaphieubypso(pso);
        }
    }
}
