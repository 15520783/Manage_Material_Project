using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Manage_Material_Project.DAO
{
    class KhachhangDAO
    {
        private static KhachhangDAO _instance;
        public static KhachhangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachhangDAO();
                }
                return _instance;
            }
        }

        public DataTable Hienthitatcakhachhang()
        {
            string query = "SELECT KH.*, TK.sotaikhoan FROM KHACHHANG KH ,TAIKHOANNGANHANG TK WHERE KH.makh = TK.makh and loaikh = 1 ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Hienthitatcaphanxuong()
        {
            string query = "SELECT KH.*, TK.sotaikhoan FROM KHACHHANG KH ,TAIKHOANNGANHANG TK WHERE KH.makh = TK.makh and loaikh = 2 ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetthongtinKHbyMaKH(int makh)
        {
            string query = "SELECT KH.*,TK.sotaikhoan FROM KHACHHANG KH ,TAIKHOANNGANHANG TK WHERE KH.makh = @makh AND KH.makh = TK.makh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { makh });
        }

        public DataTable GetKhachHangByTen (string tenkhachhang)
        {
            string query = "SELECT KH.*, TK.sotaikhoan FROM KHACHHANG KH ,TAIKHOANNGANHANG TK WHERE KH.loaikh = 1 and KH.makh = TK.makh AND KH.ten like N'%" + tenkhachhang + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetPhanXuongByTen(string ten)
        {
            string query = "SELECT KH.*, TK.sotaikhoan FROM KHACHHANG KH ,TAIKHOANNGANHANG TK WHERE KH.loaikh = 2 and KH.makh = TK.makh AND KH.ten like N'%" + ten + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
