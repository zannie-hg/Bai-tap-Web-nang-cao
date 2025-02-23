using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List_2
{
    internal class NhanVien
    {
        

        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public NhanVien()
        {
        }

        public NhanVien(int maNV, string hoTen)
        {
            MaNV = maNV;
            HoTen = hoTen;
        }
        public override string ToString()
        {
            return $"Mã NV: {MaNV}, Họ tên: {HoTen}";
        }
    }
}
