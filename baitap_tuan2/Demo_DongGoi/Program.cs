using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DongGoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.hoTen = "Nguyen Thi Ha Giang";
            sv1.namSinh = 2004;
            sv1.HienThi();
        }
    }
}
