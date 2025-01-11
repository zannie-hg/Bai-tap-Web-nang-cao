using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DongGoi
{
    internal class SinhVien
    {
        private string hoTen; //field truong
        // property thuoc tinh
        public string HoTen { get { return hoTen; } 
                                set { hoTen = value; } }
        private int namSinh;
        public int NamSinh
        {
            get { return namSinh; }
            //value la gia tri dung de gan
            set {
                if (value>0)
                    namSinh = value;
                else  Console.WriteLine("Nam sinh khong dung");
            }
        }
       
        public void HienThi()
        {
            Console.WriteLine($"Sinh vien co ten: {hoTen}, nam sinh: {namSinh}");
        }
    }
}
