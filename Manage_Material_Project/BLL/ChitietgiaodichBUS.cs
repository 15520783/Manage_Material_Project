using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DTO;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class ChitietgiaodichBUS
    {
        private static ChitietgiaodichBUS _instance;
        public static ChitietgiaodichBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChitietgiaodichBUS();
                }
                return _instance;
            }
        }

        public int _Themchitietgiaodich(Chitietgiaodich chitiet)
        {
            return ChitietgiaodichDAO.Instance.Themchitietgiaodich(chitiet);
        }
    }
}
