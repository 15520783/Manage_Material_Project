using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Danhmucphanxuong
    {
        public int maphanxuong { get; set; }
        public string tenphanxuong { get; set; }
        public string diachi { get; set; }

        public Danhmucphanxuong() { }
        public Danhmucphanxuong(int maphanxuong, string tenphanxuong, string diachi)
        {
            this.tenphanxuong = tenphanxuong;
            this.maphanxuong = maphanxuong;
            this.diachi = diachi;
        }
    }
}
