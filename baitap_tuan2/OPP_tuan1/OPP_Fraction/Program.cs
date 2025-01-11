using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập phân số thứ nhất: ");
            PhanSo ps1 = PhanSo.NhapPhanSo();

            Console.WriteLine("Nhập phân số thứ hai: ");
            PhanSo ps2  = PhanSo.NhapPhanSo();

            Console.WriteLine("\nPhân số 1: " + ps1);
            Console.WriteLine("Phân số 2: " + ps2);
            Console.WriteLine("\nPhân số 1 dưới dạng thập phân: " + ps1.SoThapPhan());
            Console.WriteLine("Phân số 2 dưới dạng thập phân: " + ps2.SoThapPhan());

            PhanSo tong = ps1.PhepCong(ps2);
            Console.WriteLine("\nTổng: " + tong);
            PhanSo hieu = ps1.PhepTru(ps2);
            Console.WriteLine("Hiệu: " + hieu);
            PhanSo tich = ps1.PhepNhan(ps2);
            Console.WriteLine("Tích: " + tich);
            PhanSo thuong = ps1.PhepChia(ps2);
            Console.WriteLine("Thương: " + thuong);
        }
    }
}
