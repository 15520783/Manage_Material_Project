using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Nguyenlieu
    {
        public string pso { get; set; }
        public int manl { get; set; }
        public int soluong { get; set; }
        public double dongia { get; set; }
        public double thanhtien { get; set; }
        public string taikhoandu { get; set; }

        public Nguyenlieu() { }
        public Nguyenlieu(string pso, int manl, int soluong, double dongia, double thanhtien, string taikhoandu)
        {
            this.pso = pso;
            this.manl = manl;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
            this.taikhoandu = taikhoandu;
        }
    }
}
