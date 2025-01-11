using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_PersonAndStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;//tieng viet
            Student student = new Student();
            student.InputStudent();
            student.DisplayStudent();
        }
    }
}
