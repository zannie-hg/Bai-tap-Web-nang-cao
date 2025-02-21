using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }
        public double Luong { get; set; }
        public NhanVien(string hoTen, int namSinh, string bangCap)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
        }

        public virtual void TinhLuong() { }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Bằng cấp: {BangCap}, Lương: {Luong}");
        }
    }
}
