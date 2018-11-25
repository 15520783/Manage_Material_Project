using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Taikhoannganhang
    {
        public int sotaikhoan { get; set; }
        public int makh { get; set; }
        public string tennganhang { get; set; }

        public Taikhoannganhang() { }
        public Taikhoannganhang(int sotaikhoan, int makh, string tennganhang)
        {
            this.makh = makh;
            this.sotaikhoan = sotaikhoan;
            this.tennganhang = tennganhang;
           
        }
    }
}
