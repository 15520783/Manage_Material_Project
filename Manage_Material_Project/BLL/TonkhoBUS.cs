using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manage_Material_Project.DAO;
using System.Data;

namespace Manage_Material_Project.BLL
{
    class TonkhoBUS
    {
        private static TonkhoBUS _instance;
        public static TonkhoBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TonkhoBUS();
                }
                return _instance;
            }
        }

        public int _Themmoitonkho(int makho, int manl, int thang, int nam, int soluongton)
        {
            return TonkhoDAO.Instance.Themmoitonkho(makho, manl, thang, nam, soluongton);
        }

        public int _Updatetonkho(int thang, int nam, int manl, int makho, int soluongton)
        {
            return TonkhoDAO.Instance.Updatetonkho(thang, nam, manl, makho, soluongton);
        }

        public DataTable _Kiemtratonkhotontai(int thang, int nam, int makho, int manl)
        {
            return TonkhoDAO.Instance.Kiemtratonkhotontai(thang, nam, makho, manl);
        }
        public int _Laysoluongtonnguyenlieu(int manl, int makho)
        {
            return TonkhoDAO.Instance.Laysoluongtonnguyenlieu(manl,makho);
        }
        public DataTable _Gettonkho(int manl, int makho)
        {
            return TonkhoDAO.Instance.Gettonkho(manl, makho);
        }

    }
}
