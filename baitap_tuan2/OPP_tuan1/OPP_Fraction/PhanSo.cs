using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Fraction
{
    class PhanSo
    {
        public int TuSo {  get; set; }
        public int MauSo { get; set; }
        public PhanSo(int tuSo, int mauSo) 
        {
            if (mauSo==0)
            {
                throw new ArgumentException("Mẫu số không được bằng 0.");
            }
            TuSo = tuSo;
            MauSo = mauSo;
            ChuanHoaPhanSo();
        }
        //hàm chuẩn hóa phân số 
        private void ChuanHoaPhanSo()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo<0)
            {
                TuSo = -TuSo;
                MauSo=-MauSo;
            }
        }
        //ham tinh UCLN
        private int UCLN(int a, int b)
        {
            while (b!=0)
            {
                int temp = b;
                b= a%b;
                a = temp;
            }
            return a;
        }
        //nhap phan so
        public static PhanSo NhapPhanSo()
        {
            Console.WriteLine("Nhập tử số: ");
            int tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số: ");
            int mauSo = int.Parse(Console.ReadLine());
            if (mauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0, vui lòng nhập lại.");
                return NhapPhanSo();
            }
            return new PhanSo(tuSo, mauSo);
        }
        //hien thi phan so
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
        //hien thi duoi dang so thap phan
        public double SoThapPhan()
        {
            return (double)TuSo / MauSo;
        }
        public PhanSo PhepCong(PhanSo other)
        {
            int tuSo = this.TuSo * other.MauSo + other.TuSo*this.MauSo;
            int mauSo = this.MauSo * other.MauSo;
            return new PhanSo(tuSo,mauSo);
        }
        public PhanSo PhepTru(PhanSo other)
        {
            int tuSo = this.TuSo * other.MauSo - other.TuSo * this.MauSo;
            int mauSo = this.MauSo * other.MauSo;
            return new PhanSo(tuSo, mauSo);

        }
        public PhanSo PhepNhan(PhanSo other)
        {
            int tuSo = this.TuSo *  other.TuSo ;
            int mauSo = this.MauSo * other.MauSo;
            return new PhanSo(tuSo, mauSo);

        }
        public PhanSo PhepChia(PhanSo other)
        {
            int tuSo = this.TuSo * other.MauSo;
            int mauSo = this.MauSo * other.TuSo;
            return new PhanSo(tuSo, mauSo);

        }
    }
}
