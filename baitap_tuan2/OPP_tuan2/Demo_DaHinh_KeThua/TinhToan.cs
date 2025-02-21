using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DaHinh_KeThua
{
    internal class TinhToan
    {
        //overloading
        public static int Cong(int x, int y) { return x + y; }
        public static string Cong(string x, string y) { return x+" " + y; }
        public static double Cong(double x, double y) { return x + y; }
        public static double Cong(double x, double y, double z) { return x + y + z; }

    }
}
