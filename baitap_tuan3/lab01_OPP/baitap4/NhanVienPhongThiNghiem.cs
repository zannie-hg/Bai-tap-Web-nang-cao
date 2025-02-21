using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class NhanVienPhongThiNghiem : NhanVien
    {
        public double LuongThang { get; set; }

        public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, double luongThang)
            : base(hoTen, namSinh, bangCap)
        {
            LuongThang = luongThang;
            Luong = LuongThang;
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Lương tháng: {LuongThang}");
        }
    }
}
