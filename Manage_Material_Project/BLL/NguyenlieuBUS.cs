using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DTO;
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

        public int _Themchitietgiaodich(Nguyenlieu chitiet)
        {
            return NguyenlieuDAO.Instance.Themchitietgiaodich(chitiet);
        }

        public int _Xoachitietgiaodich(string pso)
        {
            return NguyenlieuDAO.Instance.Xoachitietgiaodich(pso);
        }
    }
}
