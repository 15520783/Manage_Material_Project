using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Tonkho
    {
        public int thang { get; set; }
        public int nam { get; set; }
        public int manl { get; set; }
        public int makho { get; set; }
        public int soluongton { get; set; }
        
        public Tonkho() { }
        public Tonkho(int thang, int nam, int manl, int soluongton, int makho) {
            this.manl = manl;
            this.thang = thang;
            this.nam = nam;
            this.soluongton = soluongton;
            this.makho = makho;
       
        }
        
    }
}
