using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = GaussTrick(numbers);
            Console.WriteLine(string.Join(" ", result));

        }
        static List<int> GaussTrick(List<int> numbers)
        {
            List<int> result = new List<int>();
            int left = 0, right = numbers.Count - 1;

            while (left <= right)
            {
                if (left == right)
                    result.Add(numbers[left]); // Nếu còn một số, thêm vào danh sách kết quả
                else
                    result.Add(numbers[left] + numbers[right]); // Cộng số đầu với số cuối

                left++;  // Di chuyển con trỏ đầu
                right--; // Di chuyển con trỏ cuối
            }
            return result;
        }
    }
}
