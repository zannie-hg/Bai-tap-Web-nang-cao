using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List
{
    internal class DanhSachNhanVien
    {
        private List<NhanVien> danhSach = new List<NhanVien>();

        public void ThemNhanVien()
        {
            Console.Write("Nhập mã NV: ");
            string maNV = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Chọn loại (1-Bán thời gian, 2-Toàn thời gian): ");
            int loai = int.Parse(Console.ReadLine());

            if (loai == 1)
            {
                Console.Write("Nhập lương giờ: ");
                double luongGio = double.Parse(Console.ReadLine());
                danhSach.Add(new NhanVienBTG(maNV, hoTen, luongGio));
            }
            else
            {
                Console.Write("Nhập lương tháng: ");
                double luongThang = double.Parse(Console.ReadLine());
                danhSach.Add(new NhanVienTTG(maNV, hoTen, luongThang));
            }
        }

        public void HienThi()
        {
            Console.WriteLine("\nDanh sách nhân viên:");
            foreach (var nv in danhSach) nv.HienThi();
        }

        public void TimKiem()
        {
            Console.Write("Nhập tên cần tìm: ");
            string tuKhoa = Console.ReadLine();
            var ketQua = danhSach.Where(nv => nv.HoTen.Contains(tuKhoa)).ToList();

            if (ketQua.Count > 0)
                ketQua.ForEach(nv => nv.HienThi());
            else
                Console.WriteLine("Không tìm thấy.");
        }

        public void XoaNhanVien()
        {
            Console.Write("Nhập mã NV cần xóa: ");
            string maNV = Console.ReadLine();
            var nv = danhSach.FirstOrDefault(n => n.MaNV == maNV);
            if (nv != null)
            {
                danhSach.Remove(nv);
                Console.WriteLine("Đã xóa nhân viên.");
            }
            else
                Console.WriteLine("Không tìm thấy.");
        }

        public void SapXep()
        {
            danhSach = danhSach.OrderBy(nv => nv.HoTen).ToList();
            Console.WriteLine("Đã sắp xếp danh sách.");
        }
    }
}
