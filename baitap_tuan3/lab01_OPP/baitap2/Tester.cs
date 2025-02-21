using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    internal class Tester
    {
        // Nhập thông tin một sinh viên
        public static Student Nhap1SV()
        {
            Student sv = new Student();

            Console.Write("Nhập MaSV: ");
            sv.SetSID(int.Parse(Console.ReadLine()));

            Console.Write("Họ tên SV: ");
            sv.SetTenSV(Console.ReadLine());

            Console.Write("Nhập khoa: ");
            sv.SetKhoa(Console.ReadLine());

            Console.Write("Nhập Điểm TB: ");
            sv.SetDiemTB(float.Parse(Console.ReadLine()));

            return sv;
        }

        public static Student[] NhapDS()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            Student[] DSSV = new Student[n];
            Console.WriteLine("\n==== NHẬP DANH SÁCH SINH VIÊN ====");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin sinh viên {i + 1}:");
                DSSV[i] = Nhap1SV();
            }
            return DSSV;
        }

        public static void XuatDS(Student[] DSSV)
        {
            Console.WriteLine("\n==== DANH SÁCH SINH VIÊN ====");
            foreach (Student sv in DSSV)
            {
                sv.Show();
            }
        }

        
      
    }
}
