using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>();
            students.Add(new Student(1,"Nguyẽn Văn Z", 20));
            students.Add(new Student(2, "Nguyẽn Văn F", 21));
            students.Add(new Student(3, "Nguyẽn Văn E", 19));
            Console.WriteLine("Danh sách trước khi  sắp xếp theo tên:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Danh sách sau khi sắp xếp theo tên:");
            students = students.OrderBy(s => s.Name).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            

        }
    }
}
