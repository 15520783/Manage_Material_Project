using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class TonkhoDAO
    {
        private static TonkhoDAO _instance;
        public static TonkhoDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TonkhoDAO();
                }
                return _instance;
            }
        }

        public int Themmoitonkho (int makho, int manl, int thang, int nam, int soluongton, double sotien)
        {
            string query = "INSERT INTO TONKHO VALUES (" + thang + "," + nam + "," + manl + "," + makho + "," + soluongton + ","+ sotien+")";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int Updatetonkho (int thang, int nam, int manl, int makho, int soluongton, double sotien)
        {
            string query = "UPDATE TONKHO SET soluongton = " + soluongton + ",sotien ="+ sotien + "WHERE thang = " + thang + "and nam = " + nam + "and manl = " + manl + "and makho = " + makho;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable Kiemtratonkhotontai(int thang, int nam, int makho, int manl)
        {
            string query = "SELECT * FROM TONKHO WHERE thang = " + thang + "and nam = " + nam + "and manl = " + manl + "and makho = " + makho;
            return DataProvider.Instance.ExecuteQuery(query);
            
        }

        public int Laysoluongtonnguyenlieu(int manl,int makho)
        {
            string query = "select sum(soluongton) from TONKHO where manl = " + manl +" and makho = "+makho+ " group by manl,makho";
            if (DataProvider.Instance.ExecuteScalar(query) == null)
                return 0;
            else
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable Gettonkho(int manl, int makho)
        {
            string query = "Select * from TONKHO where manl = " + manl + " and makho = " + makho+ " order by thang,nam asc";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
