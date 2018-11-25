using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class TaikhoanBUS
    {
        private static TaikhoanBUS _instance;
        public static TaikhoanBUS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaikhoanBUS();
                return _instance;
            }
        }

        public bool _Kiemtrataikhoan(string mataikhoan, string matkhau)
        {
            return TaikhoanDAO.Instance.Kiemtrataikhoan(mataikhoan, matkhau);
        }
    }
}
