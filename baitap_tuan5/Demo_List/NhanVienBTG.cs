using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List
{
    internal class NhanVienBTG : NhanVien
    {
        public double LuongGio { get; set; }

        public NhanVienBTG(string maSV, string hoTen, double luongGio)
            : base(maSV, hoTen)
        {
            LuongGio = luongGio;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lương giờ: {LuongGio}");
        }
    }
}
