using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_nguyenThiHaGiang
{
    internal class BSBanTG :BacSi
    {
        public double LuongNgay {  get; set; }
        public int SoNgayLamViec { get; set; }

      

        public BSBanTG()
        {
        }

        public BSBanTG(int ma, string hoTen, double mucLuong, double luongNgay, int soNgayLamViec) : base(ma, hoTen, mucLuong)
        {
            LuongNgay = luongNgay;
            SoNgayLamViec = soNgayLamViec;
        }
        public override string ToString()
        {
            return $"Bác sĩ Bán thời gian: "+ base.ToString()+$", Lương ngày: {LuongNgay}, Số ngày làm việc: {SoNgayLamViec}";
        }
        public override double TinhLuong()
        {
            int phuPhiLuong = SoNgayLamViec < 7 ? 500 : 1000; 
            return MucLuong * 0.3 + LuongNgay * SoNgayLamViec + phuPhiLuong;
        }

   
    }
}
