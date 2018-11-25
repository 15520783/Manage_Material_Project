﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Manage_Material_Project.DAO;

namespace Manage_Material_Project.BLL
{
    class KhachhangBUS
    {
        private static KhachhangBUS _instance;
        public static KhachhangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachhangBUS();
                }
                return _instance;
            }
        }

        public DataTable _Hienthitatcakhachhang()
        {
            return KhachhangDAO.Instance.Hienthitatcakhachhang();
        }
        public DataTable _GetthongtinKHbyMaKH(int makh)
        {
            return KhachhangDAO.Instance.GetthongtinKHbyMaKH(makh);
        }

    }
}
