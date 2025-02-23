using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Abstract_QLNV
{
    internal class DanhSachNhanVien
    {
        private List<NhanVien> DSNhanVien {  get; set; } = new List<NhanVien>();
        public void ThemNhanVien()
        {
            Console.WriteLine("Nhập mã nhân viên: ");
            int maNV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Chọn loại nhân viên (1 - Bán thời gian, 2 - Toàn thời gian): ");
            int loaiNV = int.Parse(Console.ReadLine());
            if (loaiNV == 1)
            {
                Console.WriteLine("Nhập lương giờ: ");
                int luongGio = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số giờ làm: ");
                int soGioLam = int.Parse(Console.ReadLine());
                DSNhanVien.Add(new NhanVienBTG(maNV, hoTen, luongGio, soGioLam));
            }
            else if (loaiNV == 2)
            {
                Console.WriteLine("Nhập lương tháng: ");
                int luongThang = int.Parse(Console.ReadLine());
                DSNhanVien.Add(new NhanVienTTG(maNV, hoTen, luongThang));
            } else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }
        public void HienThi()
        {
            foreach (var nv in DSNhanVien)
            {
                Console.WriteLine(nv);
            }
        }
        public void XoaNhanVien()
        {
            Console.WriteLine("Nhập mã NV cần xóa: ");
            int maNV = int.Parse(Console.ReadLine());
            DSNhanVien.RemoveAll(nv=>nv.MaNV == maNV);
        }
        public NhanVien TimTheoMa()
        {
            Console.WriteLine("Nhập mã NV cần tìm: ");
            int maNv = int.Parse(Console.ReadLine());
            NhanVien kq = null;
            foreach (var nv in DSNhanVien)
            {
                if (nv.MaNV == maNv)
                {
                    kq = nv;
                    return kq;
                }
            }
            return kq;
        }
        public void SapXepGiamDanTheoMa()
        {
            DSNhanVien=DSNhanVien.OrderByDescending(nv=>nv.MaNV).ToList();
        }
    }
}
