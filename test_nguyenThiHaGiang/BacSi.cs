using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_nguyenThiHaGiang
{
    internal abstract class BacSi
    {
        public int Ma {  get; set; }
        public string HoTen { get; set; }
        public  double MucLuong { get; set; }

        protected BacSi(int ma, string hoTen, double mucLuong)
        {
            Ma = ma;
            HoTen = hoTen;
            MucLuong = mucLuong;
        }

        protected BacSi()
        {
        }
        public abstract double TinhLuong();
        //public abstract void Nhap();
        public override string ToString()
        {
            return $"Mã: {Ma}, Ho ten: {HoTen}";
        }

    }
}
