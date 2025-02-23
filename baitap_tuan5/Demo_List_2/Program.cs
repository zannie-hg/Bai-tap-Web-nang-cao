using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            Console.WriteLine("Danh sach nhân viên: ");
            dsnv.ThemNhanVien(new NhanVienBTG(1, "Nguyễn Văn C", 14000));
            dsnv.ThemNhanVien(new NhanVienTTG(2, "Nguyễn Văn E", 15000));
            dsnv.ThemNhanVien(new NhanVienBTG(3, "Nguyễn Văn A", 13000));
            dsnv.HienThi();
            Console.WriteLine("Kết quả tìm kiếm theo mã NV = 3");
            Console.WriteLine(dsnv.TimTheoMa(3));
            Console.WriteLine("Sắp xếp giảm dần theo mã: ");
            dsnv.SapXepGiamDanTheoMa();
            dsnv.HienThi();
            Console.WriteLine("Xoá nhân viên có mã = 1: ");
            dsnv.XoaNhanVien(1);
            dsnv.HienThi();


        }
    }
}
