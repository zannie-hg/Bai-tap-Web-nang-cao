using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_List_3;

namespace Demo_List_3
{
    internal class NhanVienBTG : NhanVien
    {
        public double LuongGio { get; set; }

        public NhanVienBTG(double luongGio)
        {
            LuongGio = luongGio;
        }

        public NhanVienBTG()
        {
        }

        public NhanVienBTG(int maNV, string hoTen, double luongGio) : base(maNV, hoTen)
        {
            LuongGio = luongGio;

        }

        public NhanVienBTG(int maNV, string hoTen) : base(maNV, hoTen)
        {
        }
        public override string ToString()
        {
            return $"Nhân viên BTG: " + base.ToString() + $", Lương giờ: {LuongGio}";
        }
    }
}
