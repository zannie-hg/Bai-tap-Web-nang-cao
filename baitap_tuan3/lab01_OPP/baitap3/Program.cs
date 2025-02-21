using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> DSSV = Tester.NhapDS();
            Tester.XuatDS(DSSV);
            Console.ReadLine();
        }
    }
}
