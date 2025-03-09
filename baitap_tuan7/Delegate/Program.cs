using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void ShowLog(string message); 
    internal class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();

        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();

        }
        //delegate int KIEU1();\
        //static int Tong(int a, int b) => a + b;
        //static int Hieu(int a, int b) => a - b;

        static void Tong(int a, int b, ShowLog log)
        {
            int kq = a + b;
           
            log?.Invoke($"Tong la {kq}");
        }
        static void Main(string[] args)
        {
            //ShowLog log = null;// biến delegate có thể 1 lúc tham chiếu đến nhiều pthuc( tạo ra 1 chuỗi các tham chiếu)

            //log += Info;
            //log += Info;
            //log += Info;
            //log += Warning;
            //log += Warning;
            //log += Info;

            //log?.Invoke("Xin chao cac ban");

            //log = Info;

            //log?.Invoke("Xin chao ABc");
            //log = Warning;
            //log("Hoc ve delegate");


            //action, func : delegate, sudung cac tham so gereric de khai bao
            //neu can khai bao ra bien kieu delegate ma co kieu tra ve la void hay k tra ve kieu du lieu gi thi sdung khai bao action
            //Action action;                  // tuong duong delegate void KIEU();
            //Action<string, int> action1;    // tuong duong delegate void KIEU(string s, int i);
            //Action<string> action2;         // tuong duong delegate void KIEU(string s);

            //action2 = Warning;
            //action2 += Info;
            //action2?.Invoke("thong bao tu action");

            //KIEU1 f1;
            //Func<int> f1;                       //tuong duong delegate int KIEU();
            //Func<string, double, string> f2;    //tuong duong delegate string KIEU(string s, double s);


            //Func<int, int, int> tinhtoan;       //tuong duong delegate int KIEU(int a, int b);
            //int a = 5;
            //int b = 10;

            //tinhtoan = Tong;
            //tinhtoan = Hieu;
            //Console.WriteLine($"Tong la {tinhtoan(a, b)}");
            //Console.WriteLine($"Hieu la {tinhtoan(a, b)}");



            Tong(4, 5, Info);
            Tong(4, 5, Warning);

        }
    }
}
