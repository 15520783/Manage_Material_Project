using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class HoadongiaodichBUS
    {
        private static HoadongiaodichBUS _instance;
        public static HoadongiaodichBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HoadongiaodichBUS();
                }
                return _instance;
            }
        }

        public int _Getsohoadonmoinhat()
        {
            return HoadongiaodichDAO.Instance.Getsohoadonmoinhat();
        }
    }
}
