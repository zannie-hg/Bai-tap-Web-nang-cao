using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    /*
     Lambda -  anonymous function, biểu thức có thể nhận tham số đầu vào giống như pthuc 
     1)
      (tham_so) => bieu_thuc;

     2)
    (tham_so) => {
            cac_bieu_thuc;
            return bieu_thuc_tra_ve;
     */ 
    //1 bieu thuc lambda co the duoc gan cho  1 bien kieu delegate,
    //nhung phai phu hop ve khai bao tham so va kieu tra ve
    internal class Program
    {
        static void Main(string[] args)
        {
            //*Sử dụng delegate trong tham số phương thức
            //Action<string> thongbao;

            //thongbao = (string s) => Console.WriteLine(s); // tuong duong delegate void KIEU(string s) = action<string>
            //for (int i = 0; i < 10; i++)
            //{
            //thongbao?.Invoke("Xin chao");

            //}
            ////(int a, int b) =>
            ////{
            ////    int kq = a + b;
            ////    return kq;
            ////}

            //dau vao k co tham so va k co kieu tra ve
            //Action thongbao;
            //thongbao = () => Console.WriteLine("Xin chhao cac ban");
            //thongbao?.Invoke();

            //Action<string, string> welcome;
            //welcome = ( s,  name) => Console.WriteLine(s + " "+ name);
            //welcome?.Invoke("Xin chao", "Nguyen Van A");


            //Action<string, string> welcome;
            //welcome = (s, name) => {
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(s + " " + name);
            //    Console.ResetColor();

            //};
            //welcome?.Invoke("Xin chao", "Nguyen Van A");

            //Func<int, int, int> tinhtoan;
            //tinhtoan = (int a, int b) =>
            //{
            //    int kq = a + b;
            //    return kq;
            //};
            //Console.WriteLine(tinhtoan.Invoke(5,6));

            //* Sử dụng lambda trong 1 số thư viện của .NET

            int[] mang = { 2, 2, 43, 34, 3, 5, 7, 8, 2, 6, 9, 10 };
            //var kq = mang.Select(
            //    (int x) =>
            //    {
            //    return Math.Sqrt(x);
            //    } //bieuthuc lambda
            //);
            //foreach (var result in kq)
            //{
            //    Console.WriteLine(result);
            //}


            //mang.ToList().ForEach(
            //    (int x) =>
            //    {
            //        if (x % 2 != 0) 
            //            Console.WriteLine(x);
            //    }
            //    );

            var kq = mang.Where(
                (x) =>
                {
                    return x % 4 == 0;
                }
            );
            foreach (var n in kq)
            {
                Console.WriteLine(n);
            }
        }
    }
}
