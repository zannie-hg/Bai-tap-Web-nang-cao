using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_PersonAndStudent
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Input()
        {
            Console.WriteLine("Nhập tên: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void DisplayPerson()
        {
            Console.Write($"Tên: {Name}, Tuổi: {Age}");
        }
        public override string ToString() // ghi đè phương thức đẻ hiển thị thông tin ở dạng chuổi
        {
            return $"Tên: {Name}, Tuổi: {Age}";
        }
    }
}
