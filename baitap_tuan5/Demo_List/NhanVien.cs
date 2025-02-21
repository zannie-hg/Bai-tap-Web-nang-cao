using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        public NhanVien(string maSV, string hoTen)
        {
            this.MaNV = maSV;
            this.HoTen = hoTen;
        }
        public virtual void HienThi()
        {
            Console.WriteLine($"Mã NV: {MaNV}, Họ tên: {HoTen}");
        }
    }
}
