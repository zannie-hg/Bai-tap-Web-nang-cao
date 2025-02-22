using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 3, 6, 1 };
            SumAdjacentEqualNumbers(numbers);
        }

        static void SumAdjacentEqualNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] *= 2; // Cộng hai số bằng nhau
                    numbers.RemoveAt(i + 1); // Xóa số thứ hai
                    i = -1; // Reset vòng lặp để kiểm tra lại danh sách từ đầu
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
