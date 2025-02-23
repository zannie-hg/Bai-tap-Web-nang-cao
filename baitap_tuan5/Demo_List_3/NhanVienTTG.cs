using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_List_3;

namespace Demo_List_3
{
    internal class NhanVienTTG : NhanVien
    {
        public double LuongThang { get; set; }

        public NhanVienTTG(double luongThang)
        {
            LuongThang = luongThang;
        }

        public NhanVienTTG()
        {
        }

        public NhanVienTTG(int maNV, string hoTen) : base(maNV, hoTen)
        {
        }
        public NhanVienTTG(int maNV, string hoTen, double luongThang) : base(maNV, hoTen)
        {
            LuongThang = luongThang;

        }
        public override string ToString()
        {
            return $"Nhân Viên TTG: " + base.ToString() + $", Lương tháng: {LuongThang}";
        }
    }
}
