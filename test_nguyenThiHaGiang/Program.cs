using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_nguyenThiHaGiang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachBacSi danhSach = new DanhSachBacSi();

            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhập bác sĩ");
                Console.WriteLine("2. Hiển thị danh sách bác sĩ");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        danhSach.Nhap();

                        break;
                    case 2:
                        danhSach.HienThi();
                        break;
                    case 3:
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }
    }
}
