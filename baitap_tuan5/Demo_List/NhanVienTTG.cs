using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List
{
    internal class NhanVienTTG : NhanVien
    {
        public double LuongThang { get; set; }

        public NhanVienTTG(string maSV, string hoTen, double luongThang)
            : base(maSV, hoTen)
        {
            LuongThang = luongThang;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lương tháng: {LuongThang}");
        }
    }
}
