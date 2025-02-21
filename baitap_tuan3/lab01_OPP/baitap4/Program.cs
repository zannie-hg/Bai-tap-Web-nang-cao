using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            Console.WriteLine("Nhập số lượng nhân viên:");
            int soLuongNhanVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuongNhanVien; i++)
            {
                Console.WriteLine($"\nNhập thông tin nhân viên thứ {i + 1}:");
                Console.WriteLine("Chọn loại nhân viên (1: Nhà khoa học, 2: Nhà quản lý, 3: Nhân viên thí nghiệm):");
                int loaiNhanVien = int.Parse(Console.ReadLine());

                switch (loaiNhanVien)
                {
                    case 1: // Nhà khoa học
                        Console.WriteLine("Nhập họ tên:");
                        string hoTenNKH = Console.ReadLine();
                        Console.WriteLine("Nhập năm sinh:");
                        int namSinhNKH = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập bằng cấp:");
                        string bangCapNKH = Console.ReadLine();
                        Console.WriteLine("Nhập số bài báo:");
                        int soBaiBao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập số ngày công:");
                        int soNgayCongNKH = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập bậc lương:");
                        double bacLuongNKH = double.Parse(Console.ReadLine());

                        var nhaKhoaHoc = new NhaKhoaHoc(hoTenNKH, namSinhNKH, bangCapNKH, soBaiBao, soNgayCongNKH, bacLuongNKH);
                        nhaKhoaHoc.TinhLuong();
                        danhSachNhanVien.Add(nhaKhoaHoc);
                        break;

                    case 2: // Nhà quản lý
                        Console.WriteLine("Nhập họ tên:");
                        string hoTenNQL = Console.ReadLine();
                        Console.WriteLine("Nhập năm sinh:");
                        int namSinhNQL = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập bằng cấp:");
                        string bangCapNQL = Console.ReadLine();
                        Console.WriteLine("Nhập số ngày công:");
                        int soNgayCongNQL = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập bậc lương:");
                        double bacLuongNQL = double.Parse(Console.ReadLine());

                        var nhaQuanLy = new NhaQuanLy(hoTenNQL, namSinhNQL, bangCapNQL, soNgayCongNQL, bacLuongNQL);
                        nhaQuanLy.TinhLuong();
                        danhSachNhanVien.Add(nhaQuanLy);
                        break;

                    case 3: // Nhân viên thí nghiệm
                        Console.WriteLine("Nhập họ tên:");
                        string hoTenNV = Console.ReadLine();
                        Console.WriteLine("Nhập năm sinh:");
                        int namSinhNV = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập bằng cấp:");
                        string bangCapNV = Console.ReadLine();
                        Console.WriteLine("Nhập lương tháng:");
                        double luongThang = double.Parse(Console.ReadLine());

                        var nhanVienThiNghiem = new NhanVienPhongThiNghiem(hoTenNV, namSinhNV, bangCapNV, luongThang);
                        danhSachNhanVien.Add(nhanVienThiNghiem);
                        break;

                    default:
                        Console.WriteLine("Loại nhân viên không hợp lệ.");
                        break;
                }
            }

            Console.WriteLine("\nDanh sách nhân viên:");
            foreach (var nv in danhSachNhanVien)
            {
                nv.XuatThongTin();
                Console.WriteLine();
            }

            // Tính tổng lương đã trả
            double tongLuong = 0;
            foreach (var nv in danhSachNhanVien)
            {
                tongLuong += nv.Luong;
            }
            Console.WriteLine($"Tổng lương đã trả: {tongLuong}");
        }
    }
    
}
