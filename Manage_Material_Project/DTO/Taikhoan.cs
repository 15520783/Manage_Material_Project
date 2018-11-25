using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Taikhoan
    {
        public int matk { get; set; }
        public string matkhau { get; set; }
        public string tennhanvien { get; set; }

        public Taikhoan() { }
        public Taikhoan(int matk, string matkhau, string tennhanvien)
        {
            this.matk = matk;
            this.matkhau = matkhau;
            this.tennhanvien = tennhanvien;
        }
    }

    
}
