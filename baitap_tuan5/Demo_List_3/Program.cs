using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_List_3;

namespace Demo_List_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            //Console.WriteLine("Danh sach nhân viên: ");
            //dsnv.ThemNhanVien(new NhanVienBTG(1, "Nguyễn Văn C", 14000));
            //dsnv.ThemNhanVien(new NhanVienTTG(2, "Nguyễn Văn E", 15000));
            //dsnv.ThemNhanVien(new NhanVienBTG(3, "Nguyễn Văn A", 13000));
            //dsnv.HienThi();
            //Console.WriteLine("Kết quả tìm kiếm theo mã NV = 3");
            //Console.WriteLine(dsnv.TimTheoMa(3));
            //Console.WriteLine("Sắp xếp giảm dần theo mã: ");
            //dsnv.SapXepGiamDanTheoMa();
            //dsnv.HienThi();
            //Console.WriteLine("Xoá nhân viên có mã = 1: ");
            //dsnv.XoaNhanVien(1);
            //dsnv.HienThi();
            while (true)
            {
                Console.WriteLine("\n1. Nhập nhân viên mới");
                Console.WriteLine("2. Hiển thị danh sách nhân viên");
                Console.WriteLine("3. Tìm nhân viên theo mã");
                Console.WriteLine("4. Sắp xếp danh sách giảm dần theo mã");
                Console.WriteLine("5. Xóa nhân viên theo mã");
                Console.WriteLine("6. Thoát");
                Console.Write("Chọn một tùy chọn: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        dsnv.ThemNhanVien();
                        break;
                    case 2: 
                        dsnv.HienThi();
                        break;
                    case 3:
                        Console.WriteLine(dsnv.TimTheoMa());
                        break;
                    case 4:
                        dsnv.SapXepGiamDanTheoMa();
                        break;
                    case 5:
                        dsnv.XoaNhanVien();
                        break;
                    case 6:
                        Console.WriteLine("Thoát chương trình");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                        break;
                }
            }

        }
    }
}
