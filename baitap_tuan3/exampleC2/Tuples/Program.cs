using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static (int sum, int count) MyMethod(int[] values)
        {
            // Khai báo một tuple
            var result = (sum: 0, count: 0);

            foreach (var value in values)
            {
                if (IsEvenNumber(value))
                {
                    result.sum += value;
                    result.count++;
                }
            }

            return result;
        }

        static bool IsEvenNumber(int n)
        {
            return n % 2 == 0;
        }

        static void Main()
        {
            int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
            var (sum, count) = MyMethod(numbers);

            Console.WriteLine($"Sum: {sum}, Count: {count}");
            Console.ReadLine();
        }
    }
}
