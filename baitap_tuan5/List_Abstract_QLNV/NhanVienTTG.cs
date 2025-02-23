using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Abstract_QLNV
{
    internal class NhanVienTTG : NhanVien
    {   
        public double LuongThang { get; set;}

       

        public NhanVienTTG()
        {
        }

        public NhanVienTTG(int maNV, string hoTen, double luongThang) : base(maNV, hoTen)
        {
            LuongThang = luongThang;

        }
        public override double TinhLuong()
        {
            return LuongThang;
        }
        public override string ToString()
        {
            return $"Nhân viên TTG: "+ base.ToString()+$", Lương tháng: {LuongThang}";
        }
    }
}
