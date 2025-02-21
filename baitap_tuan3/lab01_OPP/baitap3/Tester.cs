using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class Tester
    {
        public static List<Student> NhapDS()
        {
            List<Student> DSSV = new List<Student>(); // Sử dụng List

            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho sinh viên {i + 1}:");

                Console.Write("Nhập MSSV: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nhập tên sinh viên: ");
                string name = Console.ReadLine();

                Console.Write("Nhập khoa: ");
                string faculty = Console.ReadLine();

                Console.Write("Nhập điểm TB: ");
                float gpa = float.Parse(Console.ReadLine());

                DSSV.Add(new Student(id, name, faculty, gpa)); // Thêm sinh viên vào List
            }

            return DSSV;
        }

        public static void XuatDS(List<Student> DSSV)
        {
            Console.WriteLine("\n==== DANH SÁCH SINH VIÊN ====");
            foreach (Student sv in DSSV)
            {
                sv.Show();
                Console.WriteLine("-------------------");
            }
        }

       
    }
}
