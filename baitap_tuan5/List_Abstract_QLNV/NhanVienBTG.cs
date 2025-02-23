using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Abstract_QLNV
{
    internal class NhanVienBTG : NhanVien
    {
        public double LuongGio {  get; set; }
        public int SoGioLam { get; set; }

        public NhanVienBTG()
        {
        }

        public NhanVienBTG(int maNV, string hoTen, double luongGio, int soGioLam) : base(maNV, hoTen)
        {
            LuongGio = luongGio;
            SoGioLam = soGioLam;
        }
        public override double TinhLuong()
        {
            return LuongGio * SoGioLam;
        }
        public override string ToString()
        {
            return $"Nhân viên BTG: "+base.ToString()+$", Lương giờ: {LuongGio}, Số giờ làm: {SoGioLam}";
        }
    }
}
