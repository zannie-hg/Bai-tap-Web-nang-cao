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
            // tạo một đối tượng BookList
            BookList bl = new BookList();

            bl.InputList();

            bl.ShowList();

            Console.ReadLine();
        }
    }
}
