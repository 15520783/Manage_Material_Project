using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DAO
{
    class HoadongiaodichDAO
    {
        private static HoadongiaodichDAO _instance;
        public static HoadongiaodichDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HoadongiaodichDAO();
                }
                return _instance;
            }
        }

        public int Getsohoadonmoinhat()
        {
            string query = "SELECT COUNT(*) FROM HOADONGIAODICH";
            return (int)DataProvider.Instance.ExecuteScalar(query) + 10001;
        }
    }
}
