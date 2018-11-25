using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class KhoBUS
    {
        private static KhoBUS _instance;
        public static KhoBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhoBUS();
                }
                return _instance;
            }
        }
        public DataTable _Hienthitatcakho()
        {
            return KhoDAO.Instance.Hienthitatcakho();
        }
    }
}
