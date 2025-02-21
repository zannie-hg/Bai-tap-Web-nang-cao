using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Nguoi nguoi1 = new Nguoi();
            //nguoi1.Ten = "An";
            //nguoi1.NamSinh = 1;
            ////nguoi1.Nhap();
            //Console.WriteLine(nguoi1);
            //Nguoi nguoi2 = new Nguoi("Tuấn", 2002);
            //Console.WriteLine(nguoi2);
            SinhVien sv1 = new SinhVien();
            sv1.Nhap();
            Console.WriteLine(sv1);
        }
    }
}
