using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DaHinh_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TinhToan.Cong(2,3));
            Console.WriteLine(TinhToan.Cong(2.5, 3.5));
            Console.WriteLine(TinhToan.Cong("Nguyen Thi Ha", "GIang"));
        }
    }
}
