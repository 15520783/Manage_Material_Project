using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Quyen
    {
        public string quyen { get; set; }
        public string mauso { get; set; }
        public string kyhieu { get; set; }

        public Quyen() { }
        public Quyen(string quyen, string mauso, string kyhieu)
        {
            this.quyen = quyen;
            this.mauso = mauso;
            this.kyhieu = kyhieu;
     
        }
        
    }
}
