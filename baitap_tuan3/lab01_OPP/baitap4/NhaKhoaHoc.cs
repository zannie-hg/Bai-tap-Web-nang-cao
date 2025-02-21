using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class NhaKhoaHoc: NhanVien
    {
        public int SoBaiBao { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, int soBaiBao, int soNgayCong, double bacLuong)
            : base(hoTen, namSinh, bangCap)
        {
            SoBaiBao = soBaiBao;
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
            Console.WriteLine($"Số bài báo: {SoBaiBao}, Số ngày công: {SoNgayCong}, Bậc lương: {BacLuong}");
        }
    }
}
