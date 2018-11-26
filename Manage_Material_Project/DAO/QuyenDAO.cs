using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class QuyenDAO
    {
        private static QuyenDAO _instance;
        public static QuyenDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuyenDAO();
                }
                return _instance;
            }
        }

        public DataTable GetThongTinByMaquyen(string maquyen)
        {
            string query = "SELECT * FROM QUYEN WHERE quyen = @maquyen";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maquyen });
        }
    }
}
