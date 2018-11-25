using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Khachhang
    {
        public int makh { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string masothue { get; set; }
        
        public Khachhang() { }
        public Khachhang(int makh, string ten, string diachi, string masothue)
        {
            this.makh = makh;
            this.ten = ten;
            this.diachi = diachi;
            this.masothue = masothue;
        }

    }
}
