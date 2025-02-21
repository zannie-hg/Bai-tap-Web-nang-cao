using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class Nguoi
    {
        public string Ten { get; set; }
        protected int namSinh; //field: trường
        public int NamSinh
        {
            get { return namSinh; }
            set
            {
                if (value >= 1950)
                    namSinh = value;
                else Console.WriteLine("Năm sinh bị sai");
            }
        }

        public Nguoi(string ten, int namSinh)
        {
            Ten = ten;
            if (namSinh >= 1950)
                this.namSinh = namSinh;
            else Console.WriteLine("Năm sinh bị sai");

        }
        public Nguoi()
        {

        }
        //Nhập thông tin cho lớp từ bàn phím
        public virtual void Nhap()
        {
            Console.Write("Ten: ");
            Ten = Console.ReadLine();
            Console.Write("Năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
        }
        //sửa lại phương thưc ToString() được kế thừa từ lớp object.
        public override string ToString()
        {
            return $"ten: {Ten}, năm sinh: {namSinh}";
        }
    }
}