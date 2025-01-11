using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_PersonAndStudent
{
    class Student : Person
    {
        public double GPA { get; set; }
        public void InputStudent()
        {
            Input();
            Console.WriteLine("Nhập GPA: ");
            GPA = double.Parse(Console.ReadLine());
        }
        public void DisplayStudent()
        {
            DisplayPerson();
            Console.WriteLine($", GPA: {GPA}");
        }
    }
}
