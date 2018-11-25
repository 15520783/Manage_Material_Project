﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Material_Project.DTO
{
    class Hoadongiaodich
    {
        public int sohd { get; set; }
        public DateTime ngayphathanh { get; set; }
        public DateTime ngaythanhtoan { get; set; }
        public string hinhthucthanhtoan { get; set; }
        public string lydo { get; set; }
        public float thuesuat { get; set; }
        public float tongtien { get; set; }
        public string taikhoanchinh { get; set; }
        public string taikhoandu { get; set; }
        public int makho { get; set; }
        public string quyen { get; set; }
        public int makh { get; set; }

        public Hoadongiaodich() { }
        public Hoadongiaodich(int sohd, DateTime ngayphathanh, DateTime ngaythanhtoan, string hinhthucthanhtoan, string lydo, float thuesuat, float tongtien, string taikhoanchinh, string taikhoandu,int makho, string quyen, int makh)
        {
            this.sohd = sohd;
            this.ngayphathanh = ngayphathanh;
            this.ngaythanhtoan = ngaythanhtoan;
            this.hinhthucthanhtoan = hinhthucthanhtoan;
            this.lydo = lydo;
            this.thuesuat = thuesuat;
            this.tongtien = tongtien;
            this.taikhoanchinh = taikhoanchinh;
            this.taikhoandu = taikhoandu;
            this.makho = makho;
            this.quyen = quyen;
            this.makh = makh;
        }
    }
}