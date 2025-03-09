using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EventHandler
{
    public delegate void SuKienNhapSo(int x);
    /*
        publisher -> class - phat su kien
        subsriber -> class - nhan su kien
        += dang ky su kien
        -= huy bo su kien
     */
    //publisher
    class Dulieunhap : EventArgs
    {
        public int data { get; set; }
        public Dulieunhap(int x) => data = x;
        class UserInput
        {
            // tuongduong delegate void KIEU(object? sender, EventArgs args)
            public event EventHandler sukiennhapso;
            public void Input()
            {
                do
                {
                    Console.Write("Nhap vao so nguyen: ");
                    string s = Console.ReadLine();
                    int i = Int32.Parse(s);
                    //phat su kien
                    sukiennhapso?.Invoke(this, new Dulieunhap(i));
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

            // tuongduong delegate void KIEU(object? sender, EventArgs args)

            public void Can(object sender, EventArgs e)
            {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                int i = dulieunhap.data;
                Console.WriteLine($"Can bac hai cua {i} la {Math.Sqrt(i)}");
            }
        }
        class BinhPhuong
        {
            public void Sub(UserInput input)
            {
                input.sukiennhapso += TinhBinhPhuong;
            }
            public void TinhBinhPhuong(object sender, EventArgs e)
            {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                int i = dulieunhap.data;
                Console.WriteLine($"Binh phuong cua {i} la {i * i}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.CancelKeyPress += (sender, e) =>
                {
                    Console.WriteLine();
                    Console.WriteLine("Thoat ung dung");
                };
                //publisher
                UserInput userInput = new UserInput();
                userInput.sukiennhapso += (sender, e) =>
                {
                    Dulieunhap dulieunhap = (Dulieunhap)e;
                    Console.WriteLine("Ban vua nhap so: " + dulieunhap.data);
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
}
