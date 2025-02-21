using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    internal class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] DSSV = Tester.NhapDS();
            Tester.XuatDS(DSSV);
            Console.ReadLine();
        }
    }
}
