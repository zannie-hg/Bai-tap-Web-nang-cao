using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //tieng viet
            Console.WriteLine("Nhập số mặt của xúc xắc: ");
            int SoMat = int.Parse(Console.ReadLine());
            XucXac xx1 = new XucXac();
            Console.WriteLine($"Kết quả ngẫu nhiên của xúc xắc là: {xx1.doXucXac()}");
        }
    }
}
