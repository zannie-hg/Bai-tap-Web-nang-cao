using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class SinhVien : Nguoi
    {
        protected double gpa;
        public double Gpa { get { return gpa; } 
                                    set {if (value >= 0 && value <= 4) gpa = value;
                        else Console.WriteLine("Diem GPA bi sai");
                    } 
        }
        public SinhVien(double gpa)
        {
            this.gpa = gpa;
        }
        
        //base=super
        public SinhVien(string ten, int namSinh, double gpa) : base(ten, namSinh)
        {
            this.gpa = gpa;
        }

        public SinhVien()
        {
        }

        //public new void Nhap() //new: bo thua ke pthuc Nhap, tu dinh nghia moi 
        //{
        //    base.Nhap();
        //    Console.Write("GPA: ");
        //    bool ketQua;
        //    do
        //    {
        //        ketQua = double.TryParse(Console.ReadLine(), out gpa);

        //    }
        //    while (!ketQua);
        //    while (!double.TryParse(Console.ReadLine(), out gpa))
        //    {
        //        Console.WriteLine("gpa sai, nhap lai");
        //    }

        //}
        public override void Nhap()
        {
            base.Nhap();
            while ((!double.TryParse(Console.ReadLine(), out gpa)) || (gpa < 0) || (gpa > 4))
            {
                Console.WriteLine("gpa sai, nhap lai");
            }
        }
        public override string ToString()
        {
            return base.ToString()+$", GPA={gpa}";
        }





    }
}
