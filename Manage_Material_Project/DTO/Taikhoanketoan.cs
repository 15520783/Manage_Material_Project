using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Taikhoanketoan
    {
        public string mataikhoan { get; set; }
        public string tentaikhoan { get; set; }

        public Taikhoanketoan() { }
        public Taikhoanketoan(string mataikhoan, string tentaikhoan)
        {
            this.mataikhoan = mataikhoan;
            this.tentaikhoan = tentaikhoan;
        }
    }
}
