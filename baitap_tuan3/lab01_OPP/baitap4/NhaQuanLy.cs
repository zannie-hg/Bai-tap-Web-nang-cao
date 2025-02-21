using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class NhaQuanLy:NhanVien
    {
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public NhaQuanLy(string hoTen, int namSinh, string bangCap, int soNgayCong, double bacLuong)
            : base(hoTen, namSinh, bangCap)
        {
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }

        public override void TinhLuong()
        {
            Luong = SoNgayCong * BacLuong;
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Số ngày công: {SoNgayCong}, Bậc lương: {BacLuong}");
        }
    }
}
