using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Kho
    {
        public int makho { get; set; }
        public string tenkho { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }

        public Kho() { }
        public Kho(int makho, string tenkho, string diachi, string sdt)
        {
            this.makho = makho;
            this.tenkho = tenkho;
            this.diachi = diachi;
            this.sdt = sdt;

        }

    }
}
