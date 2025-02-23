using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Abstract_QLNV
{
    internal abstract class NhanVien
    {
        public int MaNV {  get; set; }
        public string HoTen { get; set; }

        protected NhanVien(int maNV, string hoTen)
        {
            MaNV = maNV;
            HoTen = hoTen;
        }

        protected NhanVien()
        {
        }
        public abstract double TinhLuong(); //pt trừu tượng, bắt buộc các lớp con phải override
        public override string ToString()
        {
            return $"Mã NV: {MaNV}, Họ tên: {HoTen}, Lương: {TinhLuong()}";
        }
    }
}
