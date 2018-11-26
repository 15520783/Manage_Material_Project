using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class QuyenBUS
    {
        private static QuyenBUS _instance;
        public static QuyenBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuyenBUS();
                }
                return _instance;
            }
        }

        public DataTable _GetThongTinByMaquyen(string maquyen)
        {
            return QuyenDAO.Instance.GetThongTinByMaquyen(maquyen);
        }

        public DataTable _Laytatcamaquyen()
        {
            return QuyenDAO.Instance.Laytatcamaquyen();
        }


    }
}
