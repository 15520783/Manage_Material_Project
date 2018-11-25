using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DAO;
using System.Data;

namespace Manage_Material_Project.BLL
{
    class TaikhoanketoanBUS
    {
        private static TaikhoanketoanBUS _instance;
        public static TaikhoanketoanBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaikhoanketoanBUS();
                }
                return _instance;
            }
        }

        public DataTable _Laythongtintaikhoan(string mataikhoan)
        {
            return TaikhoanketoanDAO.Instance.Laythongtintaikhoan(mataikhoan);
        }
    }
}
