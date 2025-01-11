using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trò chơi đoán số
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int winningNumber = random.Next(1, 101);
            int attempts = 7;

            Console.WriteLine("Trò chơi đoán số! Bạn có 7 lần đoán để tìm số trong khoảng từ 1 đến 100.");

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write($"Lần đoán thứ {i}, nhập số của bạn: ");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == winningNumber)
                {
                    Console.WriteLine("Chúc mừng! Bạn đã đoán đúng.");
                    return;
                }
                else if (userGuess < winningNumber)
                {
                    Console.WriteLine("Số bạn đoán nhỏ hơn số đúng.");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán lớn hơn số đúng.");
                }
            }

            Console.WriteLine($"Bạn đã hết lượt đoán! Số đúng là {winningNumber}.");
        }
    }
}
