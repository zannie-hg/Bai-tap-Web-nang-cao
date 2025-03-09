using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void SuKienNhapSo(int x);
    /*
        publisher -> class - phat su kien
        subsriber -> class - nhan su kien
        += dang ky su kien
        -= huy bo su kien
     */
    class UserInput
    {
        public event SuKienNhapSo sukiennhapso;
        public void Input()
        {
            do
            {
                Console.Write("Nhap vao so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                //phat su kien
                sukiennhapso?.Invoke(i);
            }
            while (true);
        }
    }
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += Can;
        }
        public void Can(int i)
        {
            Console.WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
        }
    }
    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += TinhBinhPhuong;
        }
        public void TinhBinhPhuong(int i)
        {
            Console.WriteLine($"Binh phuong cua {i} la {i * i}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //publisher
            UserInput userInput = new UserInput();
            userInput.sukiennhapso += x =>
            {
                Console.WriteLine("Ban vua nhap so: " + x);
            };
            //subcriber 
            TinhCan tinhcan = new TinhCan();
            tinhcan.Sub(userInput);

            BinhPhuong binhPhuong = new BinhPhuong();
            binhPhuong.Sub(userInput);


            userInput.Input();
        }
    }
}
