using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class Student : People
    {
        private string Faculty;
        private float GPA;

        public Student() : base() // Gọi constructor mặc định của People
        {
            Faculty = "Unknown";
            GPA = 0;
        }

        public Student(int id, string name, string faculty, float gpa) : base(id, name)
        {
            Faculty = faculty;
            GPA = gpa;
        }

        public void SetFaculty(string faculty) { Faculty = faculty; }
        public string GetFaculty() { return Faculty; }

        public void SetGPA(float gpa) { GPA = gpa; }
        public float GetGPA() { return GPA; }

        public void Show()
        {
            Console.WriteLine($"MSSV: {ID}");
            Console.WriteLine($"Tên SV: {Name}");
            Console.WriteLine($"Khoa: {Faculty}");
            Console.WriteLine($"Điểm TB: {GPA}");
        }
    }
}
