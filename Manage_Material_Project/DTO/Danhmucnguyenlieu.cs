using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Danhmucnguyenlieu
    {
        public int manl { get; set; }
        public string tennguyenlieu { get; set; }
        public string donvitinh { get; set; }
        public string loainl { get; set; }

        public Danhmucnguyenlieu() { }
        public Danhmucnguyenlieu(int manl, string tennguyenlieu, string donvitinh, string loainl)
        {
            this.manl = manl;
            this.tennguyenlieu = tennguyenlieu;
            this.donvitinh = donvitinh;
            this.loainl = loainl;
        }
    }
}
